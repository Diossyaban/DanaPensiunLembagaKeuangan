using DPLK.Models;
using DPLK.Models.context;
using DPLK.Models.dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace DPLK.Controllers.Pension
{
    public class PensionController : Controller
    {
        private readonly PensionContext _context;
        private readonly string _connectionString;
        private readonly ILogger<PensionController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public PensionController(ILogger<PensionController> logger, PensionContext context, IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _connectionString = configuration.GetConnectionString("Pension");
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;

        }

        [HttpGet]
        public IActionResult ShowReport(string code)
        {
            var report = _context.SpdReports.FirstOrDefault(r => r.Code == code);

            if (report == null)
            {
                return RedirectToAction("ReportList");
            }

            return View("ShowReport", report);
        }

        [HttpPost]
        public IActionResult ShowReport(SpdReport spdReport)
        {
            if (string.IsNullOrEmpty(spdReport.Code))
            {
                return RedirectToAction("ReportList");
            }

            var selectedReport = _context.SpdReports.FirstOrDefault(report => report.Code == spdReport.Code);

            if (selectedReport == null)
            {
                return RedirectToAction("ReportList");
            }

            return View("ShowReport", selectedReport);
        }

        public IActionResult ReportList()
        {
            ViewBag.ReportList = GetShowReports();
            return View();
        }

        private List<SelectListItem> GetShowReports()
        {
            var reportList = _context.SpdReports
                .OrderBy(r => r.Name)
                .Select(r => new SelectListItem { Value = r.Code, Text = r.Name })
                .ToList();

            return reportList;
        }


        public async Task<IActionResult> NewBussinesCompany(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (!string.IsNullOrEmpty(searchString))
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var companyIndex = await _context.Companies.ToListAsync();
            ViewBag.currentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                companyIndex = companyIndex.Where(address =>
                    address.CompanyNm != null &&
                    address.CompanyNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.CurrentSort = sortOrder;
            ViewBag.SortOrder = sortOrder == "CompanyNm" ? "" : "CompanyNm";

            switch (sortOrder)
            {
                case "CompanyNm":
                    companyIndex = companyIndex.OrderBy(address => address.CompanyNm).ToList();
                    break;
                default:
                    companyIndex = companyIndex.OrderByDescending(address => address.CompanyNm).ToList();
                    break;
            }

            var currentDate = DateTime.Now;
            companyIndex.ForEach(company =>
            {
                var timeDiff = (currentDate - company.LastChangeDt).TotalDays;
                company.LastChangeDt = timeDiff <= 30 ? company.LastChangeDt : DateTime.MinValue;
            });

            return View(companyIndex.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult NewBussinesCompanyIndex()
        {
            ViewBag.HasPaycenterOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Yes" },
                new SelectListItem { Value = "0", Text = "No" }
            };

            ViewBag.PdpFlgOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "true", Text = "Yes" },
                new SelectListItem { Value = "false", Text = "No" }
            };

            DDL();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewBussinesCompanyIndex([Bind("CompanyNm,HasPaycenter,Npwp,BusinessLineNmbr,ContactPerson,Siup,MnySrcType,PayorNm,BankNm,AccountNmbr,AccountNm,Email,AdArt,PdpFlg,OldClientNmbr")] Company company)
        {
            if (ModelState.IsValid)
            {
                company.LastChangeDt = DateTime.Now;
                try
                {
                    TempData["SuccessMessage"] = "Request data sent";
                    await InsertCompany(company);
                    return RedirectToAction("NewBussinesCompany");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", $"Error while inserting company: {ex.Message}");
                }
            }
            DDL();
            return View(company);
        }
        [HttpGet]
        public async Task<IActionResult> NewBussinesCompanyEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.
                 FirstOrDefaultAsync(item => item.ClientNmbr == id);

            if (company == null)
            {
                return NotFound();
            }

            DDL();
            ViewBag.HasPaycenterOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Yes" },
                new SelectListItem { Value = "0", Text = "No" }
            };
            ViewBag.PdpFlgOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "true", Text = "Yes" },
                new SelectListItem { Value = "false", Text = "No" }
            };

            return View(company);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewBussinesCompanyEdit(int id, Company updatedCompany)

        {
            if (id != updatedCompany.ClientNmbr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                updatedCompany.LastChangeDt = DateTime.Now;
                try
                {
                    TempData["SuccessMessage"] = "Request data sent";
                    await UpdateCompany(updatedCompany);
                    return RedirectToAction("NewBussinesCompany");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", $"Error while updating company: {ex.Message}");
                }
            }
            DDL();
            return View(updatedCompany);
        }
        private async Task InsertCompany(Company company)
        {
            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = "sp_company_i";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@company_name", company.CompanyNm),
                    new SqlParameter("@has_paycenter", company.HasPaycenter),
                    new SqlParameter("@NPWP", company.Npwp),
                    new SqlParameter("@business_line_nmbr", company.BusinessLineNmbr),
                    new SqlParameter("@contact_person", company.ContactPerson),
                    new SqlParameter("@SIUP", company.Siup),
                    new SqlParameter("@mny_src_type", company.MnySrcType),
                    new SqlParameter("@payor_nm", company.PayorNm),
                    new SqlParameter("@bank_nm", company.BankNm),
                    new SqlParameter("@account_nmbr", company.AccountNmbr),
                    new SqlParameter("@account_nm", company.AccountNm),
                    new SqlParameter("@email", company.Email),
                    new SqlParameter("@ad_art", company.AdArt),
                    new SqlParameter("@pdp_flg",company.PdpFlg ),
                    new SqlParameter("@old_client_nmbr", company.OldClientNmbr)

                };

                cmd.Parameters.AddRange(parameters.ToArray());

                await _context.Database.OpenConnectionAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var return_value = reader.GetInt32(0);
                        var data_exist = reader.GetInt32(1);
                        var clientnbr = reader.GetInt32(2);
                    }
                }
            }
        }
   
        private List<SelectListItem> GetDDLParams(string ddlParamName)
        {
            var ddlParams = new List<SelectListItem>();

            var sql = $"EXEC [dbo].[DDL_PARAM] @sql_tablename = '{ddlParamName}'";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        private async Task UpdateCompany(Company company)
        {
            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = "sp_company_u";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var parameters = new List<SqlParameter>
            {
                new SqlParameter("@client_nmbr", company.ClientNmbr),
                new SqlParameter("@company_name", company.CompanyNm),
                new SqlParameter("@has_paycenter", company.HasPaycenter),
                new SqlParameter("@NPWP", (object)company.Npwp ?? DBNull.Value),
                new SqlParameter("@business_line_nmbr", company.BusinessLineNmbr),
                new SqlParameter("@contact_person", (object)company.ContactPerson ?? DBNull.Value),
                new SqlParameter("@SIUP", (object)company.Siup ?? DBNull.Value),
                new SqlParameter("@mny_src_type", (object)company.MnySrcType ?? DBNull.Value),
                new SqlParameter("@payor_nm", (object)company.PayorNm ?? DBNull.Value),
                new SqlParameter("@bank_nm", (object)company.BankNm ?? DBNull.Value),
                new SqlParameter("@account_nmbr", (object)company.AccountNmbr ?? DBNull.Value),
                new SqlParameter("@account_nm", (object)company.AccountNm ?? DBNull.Value),
                new SqlParameter("@email", (object)company.Email ?? DBNull.Value),
                new SqlParameter("@ad_art", (object)company.AdArt ?? DBNull.Value),
                new SqlParameter("@pdp_flg", (object)company.PdpFlg ?? DBNull.Value),
                new SqlParameter("@old_client_nmbr", (object)company.OldClientNmbr ?? DBNull.Value)
            };

                cmd.Parameters.AddRange(parameters.ToArray());

                await _context.Database.OpenConnectionAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var return_value = reader.GetInt32(0);
                        var data_exist = reader.GetInt32(1);
                        var clientnbr = reader.GetInt32(2);
                    }
                }
            }
        }
        [HttpGet]
        public IActionResult DeleteConfirmation(int id)
        {
            ViewBag.ClientNmbr = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewBussinesCompanyDelete(int id)
        {
            try
            {
                var company = await _context.Companies.FindAsync(id);

                if (company == null)
                {
                    return NotFound();
                }

                _context.Companies.Remove(company);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Company data deleted successfully";
                return RedirectToAction("NewBussinesCompany");
            }
            catch (System.Exception ex)
            {
                TempData["ErrorMessage"] = $"Error while deleting company: {ex.Message}";
                return RedirectToAction("NewBussinesCompanyIndex");
            }
        }

        public async Task<IActionResult> NewBussinesPayCenter(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var payCenterIndex = await _context.Paycenters.ToListAsync();
            ViewBag.currentfilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                payCenterIndex = payCenterIndex.Where(item =>
                {
                    var properties = typeof(Paycenter).GetProperties();
                    foreach (var property in properties)
                    {
                        var value = property.GetValue(item);
                        if (value != null && value.ToString().ToLower().Contains(searchString.ToLower()))
                        {
                            return true;
                        }
                    }
                    return false;
                }).ToList();
            }

            ViewBag.SortOrder = sortOrder == "PaycenterNm" ? "" : "PaycenterNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PaycenterNm":
                    payCenterIndex = payCenterIndex.OrderBy(payCenter => payCenter.PaycenterNm).ToList();
                    break;
                default:
                    payCenterIndex = payCenterIndex.OrderByDescending(payCenter => payCenter.PaycenterNm).ToList();
                    break;
            }

            return View(payCenterIndex.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult NewBussinesPayLaterIndex(int clientNumber)
        {
            FillDDLMasterPay(clientNumber);
            FillDDLPayCenter();
            return View();
        }

        public async Task<Paycenter> GetPaycenterByCodeAsync(int code)
        {
            Paycenter paycenter = new Paycenter();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand("sp_paycenter_r", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@client_nmbr", code);

                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            paycenter.ClientNmbr = reader.GetInt32(reader.GetOrdinal("client_nmbr"));
                            paycenter.PaycenterNm = reader.GetString(reader.GetOrdinal("paycenter_nm"));
                            paycenter.PaycenterNmbr = reader.GetInt32(reader.GetOrdinal("paycenter_nmbr"));

                            if (!reader.IsDBNull(reader.GetOrdinal("master_paycenter_nmbr")))
                            {
                                paycenter.MasterPaycenterNmbr = reader.GetInt32(reader.GetOrdinal("master_paycenter_nmbr"));
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("contact_person")))
                            {
                                paycenter.ContactPerson = reader.GetString(reader.GetOrdinal("contact_person"));
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return paycenter;
        }

        [HttpGet]
        public IActionResult NewBussinesPayLaterIndex()
        {
            FillDDLPayCenter();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewBussinesPayLaterIndex(Paycenter paycenter)
        {
            int clientNumber = paycenter.ClientNmbr;
            try
            {
                if (ModelState.IsValid)
                {
                    paycenter.LastChangeDt = DateTime.Now;
                    TempData["SuccessMessage"] = "Request data sent";

                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    using (SqlCommand command = new SqlCommand("sp_paycenter_i", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@client_nmbr", clientNumber);
                        command.Parameters.AddWithValue("@paycenter_nm", paycenter.PaycenterNm);
                        command.Parameters.AddWithValue("@master_paycenter_nmbr", paycenter.MasterPaycenterNmbr ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@contact_person", paycenter.ContactPerson ?? (object)DBNull.Value);
                        await connection.OpenAsync();
                        await command.ExecuteNonQueryAsync();
                    }

                    return RedirectToAction("NewBussinesPayCenter");
                }
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    if (ex.Errors[i].Class == 16)
                    {
                        ModelState.AddModelError("", $"Error while inserting company: {ex.Errors[i].Message}");
                    }

                }
            }
            FillDDLMasterPay(clientNumber);
            FillDDLPayCenter();
            return View(paycenter);
        }

        [HttpGet]
        public async Task<IActionResult> NewBussinesPayLaterEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paycenter = await _context.Paycenters.FirstOrDefaultAsync(item => item.ClientNmbr == id);

            if (paycenter == null)
            {
                return NotFound();
            }

            FillDDLPayCenter();

            return View(paycenter);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewBussinesPayLaterEdit(int id, Paycenter updatedPaycenter)
        {
            if (id != updatedPaycenter.ClientNmbr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                updatedPaycenter.LastChangeDt = DateTime.Now;

                try
                {
                    TempData["SuccessMessage"] = "Request data sent";
                    await UpdatePayCenter(updatedPaycenter);
                    return RedirectToAction("NewBussinesPayLaterIndex");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", $"Error while updating PayCenter: {ex.Message}");
                }
            }

            DDL();
            return View(updatedPaycenter);
        }

        [HttpGet]
        public IActionResult DeletePayCenter(int id)
        {
            ViewBag.ClientNmbr = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PayCenterDelete(int id)
        {
            try
            {
                var paycenter = await _context.Paycenters.FindAsync(id);

                if (paycenter == null)
                {
                    return NotFound();
                }

                _context.Paycenters.Remove(paycenter);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Pay Center data deleted successfully";
                return RedirectToAction("NewBussinesPayCenter");
            }
            catch (System.Exception ex)
            {
                TempData["ErrorMessage"] = $"Error while deleting paycenter: {ex.Message}";
                return RedirectToAction("NewBussinesPayCenter");
            }
        }

        private async Task UpdatePayCenter(Paycenter paycenter)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (SqlCommand command = new SqlCommand("sp_paycenter_u", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@client_nmbr", paycenter.ClientNmbr);
                    command.Parameters.AddWithValue("@paycenter_nmbr", paycenter.PaycenterNmbr);
                    command.Parameters.AddWithValue("@paycenter_nm", paycenter.PaycenterNm);
                    command.Parameters.AddWithValue("@master_paycenter_nmbr", paycenter.MasterPaycenterNmbr == 0 ? (object)DBNull.Value : paycenter.MasterPaycenterNmbr);
                    command.Parameters.AddWithValue("@contact_person", paycenter.ContactPerson);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private void FillDDLMasterPay(int clientNumber)
        {
            List<SelectListItem> masterPayList = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand("DDL_MASTER_PAYCENTER_ON_SCR_PAYCENTER", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@client_nmbr", clientNumber);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string paycenterNumber = reader["paycenter_nmbr"].ToString();
                        string paycenterName = reader["paycenter_nm"].ToString();

                        masterPayList.Add(new SelectListItem { Value = paycenterNumber, Text = paycenterName });
                    }
                }
            }

            ViewBag.MasterPayList = masterPayList;
        }
        private void FillDDLPayCenter()
        {
            List<SelectListItem> companyList = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand("DDL_COMPANY_ON_SCR_PAYCENTER", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string clientNumber = reader["client_nmbr"].ToString();
                        string companyName = reader["company_nm"].ToString();

                        companyList.Add(new SelectListItem { Value = clientNumber, Text = companyName });
                    }
                }
            }

            ViewBag.CompanyList = companyList;
        }
        private bool IsValidDate(DateTime date)
        {
            return date >= SqlDateTime.MinValue.Value && date <= SqlDateTime.MaxValue.Value;
        }
        [HttpGet]
        public async Task<JsonResult> GetPaycenter([FromQuery] int clientNmbr, [FromQuery] int paycenterNmbr)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_paycenter_r", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@client_nmbr", clientNmbr);
                        command.Parameters.AddWithValue("@paycenter_nmbr", paycenterNmbr);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var paycenter = new
                                {
                                    Client_Nmbr = reader.GetInt32(0),
                                    CompanyNm = reader.GetString(1),
                                    PaycenterNmbr = reader.GetInt32(2),
                                    PaycenterNm = reader.GetString(3),
                                    MasterPaycenterNmbr = reader.GetInt32(4),
                                    ContactPerson = reader.GetString(5)
                                };

                                return Json(paycenter);
                            }
                            else
                            {
                                return Json(null);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                return Json(new { Error = "Terjadi kesalahan: " + ex.Message });
            }
        }
        [HttpGet]
        public IActionResult NewBussinesGroupIndex()
        {
            DDL();
            return View();
        }
        [HttpPost]
        public IActionResult NewBussinesGroupIndex(GroupInfo group)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    TempData["SuccessMessage"] = "Group information created successfully";
                    InsertGroup(group);
                    return RedirectToAction("NewBussinesGroupIndex");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", $"Error while creating group information: {ex.Message}");
                }
            }

            DDL();
            return View(group);
        }
        [HttpGet]
        public IActionResult GroupChange()
        {
            return View(new GroupCharge());
        }

        [HttpPost]
        public IActionResult GroupChange(GroupCharge group)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Database.ExecuteSqlInterpolated($@"
                    EXEC sp_group_charge_i 
                        @groupnbr = {group.GroupNmbr}, 
                        @chargetype = {group.ChargeTypeNmbr}, 
                        @efctv = {group.ChargeEfctvDt}, 
                        @termination = {group.ChargeTrmntnDt}, 
                        @next = {group.NextChargeDt}, 
                        @freqtype = {group.FreqTypeNmbr}, 
                        @payRspn = {group.PayRspnNmbr}");

                    TempData["SuccessMessage"] = "Group Charge data has been saved successfully.";
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", $"Error while saving Group Charge data: {ex.Message}");
                }
            }

            return View(group);
        }

        [HttpGet]
        public IActionResult InvestmentDirection()
        {
            DDL();
            return View();
        }

        [HttpPost]
        public IActionResult InvestmentDirection(GrpInvDrct model, DateTime nextChargeDate, string changePaymentResponsbility, float billedPercent, string chargeFrequency, float chargeRatePercent, float chargeAmount, float deducatedPatePercent)
        {
            if (ModelState.IsValid)
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var command = new SqlCommand("sp_srp_inv_drct_i", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@group_nmbr", model.GroupNmbr);
                    command.Parameters.AddWithValue("@inv_type_nmbr", model.InvTypeNmbr);
                    command.Parameters.AddWithValue("@max_percent", model.MaxPercent);
                    command.Parameters.AddWithValue("@min_percent", model.MinPercent);
                    command.Parameters.AddWithValue("@next_charge_date", nextChargeDate);
                    command.Parameters.AddWithValue("@billed_percent", billedPercent);
                    command.Parameters.AddWithValue("@charge_frequency", chargeFrequency);
                    command.Parameters.AddWithValue("@changePaymentResponsbility", changePaymentResponsbility);
                    command.Parameters.AddWithValue("@charge_rate_percent", chargeRatePercent);
                    command.Parameters.AddWithValue("@charge_amount", chargeAmount);
                    command.Parameters.AddWithValue("@deducatedPatePercent", deducatedPatePercent);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "Investment Direction data has been saved successfully.";
                return RedirectToAction(nameof(NewBussinesGroupIndex));
            }
            DDL();
            return View(model);
        }


        [HttpGet]
        public IActionResult BillingStatus()
        {
            DDL();
            return View();
        }

        [HttpPost]
        public IActionResult BillingStatus(BillingStatus billing)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand("sp_bill_status_i", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@group_nmbr", billing.GroupNmbr);
                    command.Parameters.AddWithValue("@next_bill_prd", billing.NextBillPrd);
                    command.Parameters.AddWithValue("@next_bill_dt", billing.NextBillDt);
                    command.Parameters.AddWithValue("@bill_freq_nmbr", billing.BillFreqNmbr);
                    command.Parameters.AddWithValue("@next_cntrb_prd", billing.NextCntrbPrd);
                    command.Parameters.AddWithValue("@next_cntrb_dt", billing.NextCntrbDt);
                    command.Parameters.AddWithValue("@cntrb_freq_nmbr", billing.CntrbFreqNmbr);
                    command.Parameters.AddWithValue("@next_psl_prd", billing.NextPslPrd);
                    command.Parameters.AddWithValue("@next_psl_dt", billing.NextPslDt);
                    command.Parameters.AddWithValue("@psl_freq_nmbr", billing.PslFreqNmbr);
                    command.Parameters.AddWithValue("@psl_freqcy", billing.PslFreqcy);

                    if (billing.AutoPrintFlg.HasValue)
                    {
                        command.Parameters.AddWithValue("@auto_print_flg", billing.AutoPrintFlg.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@auto_print_flg", DBNull.Value);
                    }

                    if (billing.MateraiFlg.HasValue)
                    {
                        command.Parameters.AddWithValue("@materai_flg", billing.MateraiFlg.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@materai_flg", DBNull.Value);
                    }

                    if (billing.NextPrintDt.HasValue)
                    {
                        command.Parameters.AddWithValue("@next_print_dt", billing.NextPrintDt.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@next_print_dt", DBNull.Value);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "Billing Status data has been saved successfully.";
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", $"Error while saving Billing Status data: {ex.Message}");
            }

            return RedirectToAction("NewBussinesGroupIndex");
        }

        //[HttpPost]
        //public IActionResult MemberClanPlan(MemberClassPlan mbrClsPlan)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if (mbrClsPlan.CntrbRtER > 100 || mbrClsPlan.CntrbRtEE > 100 || mbrClsPlan.CntrbRtTU > 100 || mbrClsPlan.CntrbRtFT > 100)
        //            {
        //                ViewBag.ErrorMessage = "Percentage should be less than or equal to 100";
        //                return View(mbrClsPlan);
        //            }

        //            using (SqlConnection connection = new SqlConnection(_connectionString))
        //            {
        //                connection.Open();
        //                using (var cmd = new SqlCommand("sp_mbr_cls_plan_i", connection))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;

        //                    cmd.Parameters.AddWithValue("@group_nmbr", mbrClsPlan.GroupNumber);
        //                    cmd.Parameters.AddWithValue("@mcp_nmbr", mbrClsPlan.McpNumber);
        //                    cmd.Parameters.AddWithValue("@cntrb_amt_ER", mbrClsPlan.CntrbAmtER);
        //                    cmd.Parameters.AddWithValue("@cntrb_rt_ER", mbrClsPlan.CntrbRtER);
        //                    cmd.Parameters.AddWithValue("@cntrb_amt_EE", mbrClsPlan.CntrbAmtEE);
        //                    cmd.Parameters.AddWithValue("@cntrb_rt_EE", mbrClsPlan.CntrbRtEE);
        //                    cmd.Parameters.AddWithValue("@cntrb_amt_TU", mbrClsPlan.CntrbAmtTU);
        //                    cmd.Parameters.AddWithValue("@cntrb_rt_TU", mbrClsPlan.CntrbRtTU);
        //                    cmd.Parameters.AddWithValue("@cntrb_amt_FT", mbrClsPlan.CntrbAmtFT);
        //                    cmd.Parameters.AddWithValue("@cntrb_rt_FT", mbrClsPlan.CntrbRtFT);

        //                    cmd.ExecuteNonQuery();
        //                }
        //            }

        //            return RedirectToAction("GroupMemberClassPlan");
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //    }

        //    return View(mbrClsPlan);
        //}
        [HttpGet]
        public IActionResult MemberClassPlan()
        {
            DDL();
            return View();
        }
        [HttpPost]
        public IActionResult MemberClassPlan(int groupNmbr, int mcpNmbr,
                                      double cntrb_amt_ER, double cntrb_rt_ER,
                                      double cntrb_amt_EE, double cntrb_rt_EE,
                                      double cntrb_amt_TU, double cntrb_rt_TU,
                                      double cntrb_amt_FT, double cntrb_rt_FT)
        {
            try
            {
                Console.WriteLine($"groupNmbr: {groupNmbr}");
                Console.WriteLine($"mcpNmbr: {mcpNmbr}");
                Console.WriteLine($"cntrb_amt_ER: {cntrb_amt_ER}");
                Console.WriteLine($"cntrb_rt_ER: {cntrb_rt_ER}");
                Console.WriteLine($"cntrb_amt_EE: {cntrb_amt_EE}");
                Console.WriteLine($"cntrb_rt_EE: {cntrb_rt_EE}");
                Console.WriteLine($"cntrb_amt_TU: {cntrb_amt_TU}");
                Console.WriteLine($"cntrb_rt_TU: {cntrb_rt_TU}");
                Console.WriteLine($"cntrb_amt_FT: {cntrb_amt_FT}");
                Console.WriteLine($"cntrb_rt_FT: {cntrb_rt_FT}");

                using (var context = new PensionContext())
                {
                    context.Database.ExecuteSqlRaw(
                        "EXEC sp_mbr_cls_plan_i " +
                        "@group_nmbr, @mcp_nmbr, " +
                        "@cntrb_amt_ER, @cntrb_rt_ER, " +
                        "@cntrb_amt_EE, @cntrb_rt_EE, " +
                        "@cntrb_amt_TU, @cntrb_rt_TU, " +
                        "@cntrb_amt_FT, @cntrb_rt_FT",
                        new SqlParameter("@group_nmbr", groupNmbr),
                        new SqlParameter("@mcp_nmbr", mcpNmbr),
                        new SqlParameter("@cntrb_amt_ER", cntrb_amt_ER),
                        new SqlParameter("@cntrb_rt_ER", cntrb_rt_ER),
                        new SqlParameter("@cntrb_amt_EE", cntrb_amt_EE),
                        new SqlParameter("@cntrb_rt_EE", cntrb_rt_EE),
                        new SqlParameter("@cntrb_amt_TU", cntrb_amt_TU),
                        new SqlParameter("@cntrb_rt_TU", cntrb_rt_TU),
                        new SqlParameter("@cntrb_amt_FT", cntrb_amt_FT),
                        new SqlParameter("@cntrb_rt_FT", cntrb_rt_FT)
                    );
                }

                return Ok("Success.");
            }
            catch (System.Exception ex)
            {
                DDL();
                return BadRequest("Error while saving Group Member Class Plan data: " + ex.Message);
            }
        }


        [HttpGet]
        public IActionResult BenefitGroup()
        {


            DDL();

            return View();
        }
        [HttpPost]
        public IActionResult BenefitGroup(GroupBeneSetup groupBenefit)
        {
            try
            {
                _context.Database.ExecuteSqlRaw("exec usp_group_benefit_i @group_nmbr, @mcp_type_nmbr, @bene_type_nmbr, " +
                    "@si_calc_type_nmbr, @default_sum_insured, @max_sum_insured, @coi_discont_flg, " +
                    "@coi_discont_value, @coi_loading_flg, @coi_loading_value, @max_Entry_age, " +
                    "@max_cov_age, @coi_type_nmbr, @change_dt, @sub_trns_nmbr",
                    new SqlParameter("@group_nmbr", groupBenefit.GroupNmbr),
                    new SqlParameter("@mcp_type_nmbr", groupBenefit.McpTypeNmbr),
                    new SqlParameter("@bene_type_nmbr", groupBenefit.BeneTypeNmbr),
                    new SqlParameter("@si_calc_type_nmbr", groupBenefit.SiCalcTypeNmbr),
                    new SqlParameter("@default_sum_insured", groupBenefit.DefaultSumInsured),
                    new SqlParameter("@max_sum_insured", groupBenefit.MaxSumInsured),
                    new SqlParameter("@coi_discont_flg", groupBenefit.CoiDiscontFlg),
                    new SqlParameter("@coi_discont_value", groupBenefit.CoiDiscontValue),
                    new SqlParameter("@coi_loading_flg", groupBenefit.CoiLoadingFlg),
                    new SqlParameter("@coi_loading_value", groupBenefit.CoiLoadingValue),
                    new SqlParameter("@max_Entry_age", groupBenefit.MaxEntryAge),
                    new SqlParameter("@max_cov_age", groupBenefit.MaxCovAge),
                    new SqlParameter("@coi_type_nmbr", groupBenefit.CoiTypeNmbr),
                    new SqlParameter("@change_dt", groupBenefit.ChangeDt),
                    new SqlParameter("@sub_trns_nmbr", groupBenefit.SubTrnsNmbr)
                );
                groupBenefit.GroupNmbr = Convert.ToInt32(Request.Form["Company"]);

                TempData["SuccessMessage"] = "Group Benefit data has been saved successfully.";
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", $"Error while saving Group Benefit data: {ex.Message}");
            }

            DDL();
            return RedirectToAction("NewBussinesGroupIndex");
        }

        /* [HttpPost]
         public IActionResult BenefitGroup(GroupBeneSetup groupBenefit)
         {
             try
             {
                 var existingRecord = _context.GroupBeneSetups
                     .FirstOrDefault(gb =>
                         gb.GroupNmbr == groupBenefit.GroupNmbr &&
                         gb.McpTypeNmbr == groupBenefit.McpTypeNmbr &&
                         gb.BeneTypeNmbr == groupBenefit.BeneTypeNmbr &&
                         gb.ChangeDt == groupBenefit.ChangeDt.Value.Date);

                 if (existingRecord != null)
                 {
                     existingRecord.SiCalcTypeNmbr = groupBenefit.SiCalcTypeNmbr;
                     existingRecord.DefaultSumInsured = groupBenefit.DefaultSumInsured;
                     existingRecord.MaxSumInsured = groupBenefit.MaxSumInsured;
                     existingRecord.CoiDiscontFlg = groupBenefit.CoiDiscontFlg;
                     existingRecord.CoiDiscontValue = groupBenefit.CoiDiscontValue;
                     existingRecord.CoiLoadingFlg = groupBenefit.CoiLoadingFlg;
                     existingRecord.CoiLoadingValue = groupBenefit.CoiLoadingValue;
                     existingRecord.MaxEntryAge = groupBenefit.MaxEntryAge;
                     existingRecord.MaxCovAge = groupBenefit.MaxCovAge;
                     existingRecord.CoiTypeNmbr = groupBenefit.CoiTypeNmbr;
                     existingRecord.LastChangeDt = DateTime.Now;
                     existingRecord.SubTrnsNmbr = groupBenefit.SubTrnsNmbr;
                 }
                 else
                 {
                     _context.GroupBeneSetups.Add(groupBenefit);
                 }

                 groupBenefit.GroupNmbr = Convert.ToInt32(Request.Form["Company"]);

                 _context.SaveChanges();
                 TempData["SuccessMessage"] = "Group Benefit data has been saved successfully.";
             }
             catch (System.Exception ex)
             {
                 ModelState.AddModelError("", $"Error while saving Group Benefit data: {ex.Message}");
             }

             DDL();
             return RedirectToAction("NewBussinesGroupIndex");
         }
 */
        private void PopulateMcpTypeDropdown(int groupNumber)
        {
            var mcpTypes = _context.McpTypes
                .FromSqlRaw("EXEC DDL_MBRCLSPLAN_ON_SCR_CERTIFICATEINFO @group_nmbr", groupNumber)
                .ToList();

            ViewData["DdlParamsMCP"] = mcpTypes;
        }


        [HttpGet]
        public IActionResult GroupPic()
        {

            DDL();
            return View();
        }

        [HttpPost]
        public IActionResult GroupPic(GroupPic groupPic)
        {
            try
            {
                var maxKdPic = _context.GroupPics
                    .Select(gp => gp.KdPic)
                    .OrderByDescending(kd => kd)
                    .FirstOrDefault();

                int i = 1;

                if (maxKdPic != null)
                {
                    var numberPart = Convert.ToInt32(maxKdPic.Substring(1));
                    i = numberPart + 1;
                }

                string no_urut = String.Format("{0}{1:0000}", "A", i);

                groupPic.KdPic = no_urut;

                // Ubah value ddl "Company Name" ke dalam properti GroupNmbr
                groupPic.GroupNmbr = Convert.ToInt32(Request.Form["Company"]);

                // Ubah value ddl "Title"  "IsActive" e
                groupPic.Title = Convert.ToString(Request.Form["Title"]);
                groupPic.IsActive = Request.Form["IsActive"] == "0" ? true : false;


                _context.GroupPics.Add(groupPic);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "GroupPic data has been saved successfully.";

                return RedirectToAction("NewBussinesGroupIndex");
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", $"Error while saving GroupPic data: {ex.Message}");
                DDL();
                return View(groupPic);
            }
        }


        [HttpGet]
        public IActionResult CertificateInfo()
        {
            DDL();
            GetFillDDL();
            FillDDLPaycenter();
            FillDDLGroup();
            return View();
        }

        [HttpPost]
        public IActionResult CertificateInfo(CertificateInfo certificate)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ExecuteCertificateStoredProcedure(certificate);
                    TempData["SuccessMessage"] = "Certificate information has been saved successfully.";
                    return RedirectToAction("NewBussinesClientIndex");
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", $"Error while saving certificate information: {ex.Message}");
                }
            }

            DDL();
            GetFillDDL();
            FillDDLPaycenter();
            FillDDLGroup();
            return View(certificate);
        }



        private void ExecuteCertificateStoredProcedure(CertificateInfo certificate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_certificate_i", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@cer_nmbr", SqlDbType.Int)).Value = certificate.CertificateNumber;
                        command.Parameters.Add(new SqlParameter("@old_cer_nmbr", SqlDbType.VarChar)).Value = certificate.OldCertificateNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@client_nmbr", SqlDbType.Int)).Value = certificate.ClientNumber;
                        command.Parameters.Add(new SqlParameter("@group_nmbr", SqlDbType.Int)).Value = certificate.GroupNumber;
                        command.Parameters.Add(new SqlParameter("@employee_nmbr", SqlDbType.VarChar)).Value = certificate.EmployeeNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@employment_dt", SqlDbType.DateTime)).Value = certificate.EmploymentDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@retirement_age", SqlDbType.Int)).Value = certificate.RetirementAge;
                        command.Parameters.Add(new SqlParameter("@paycenter_nmbr", SqlDbType.Int)).Value = certificate.PaycenterNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@payment_type_nmbr", SqlDbType.Int)).Value = certificate.PaymentTypeNumber;
                        command.Parameters.Add(new SqlParameter("@citizenship_cd", SqlDbType.Int)).Value = certificate.CitizenshipCode ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@tax_id_nmbr", SqlDbType.VarChar)).Value = certificate.TaxIdNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@job_vctn_nmbr", SqlDbType.Int)).Value = certificate.JobVacationNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@fund_src_nmbr", SqlDbType.Int)).Value = certificate.FundSourceNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@app_receive_dt", SqlDbType.DateTime)).Value = certificate.ApplicationReceiveDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@Completion_dt", SqlDbType.DateTime)).Value = certificate.CompletionDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@efctv_dt", SqlDbType.DateTime)).Value = certificate.EffectiveDate;
                        command.Parameters.Add(new SqlParameter("@termination_dt", SqlDbType.DateTime)).Value = certificate.TerminationDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@kit_delivery_dt", SqlDbType.DateTime)).Value = certificate.KitDeliveryDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@first_premium_flg", SqlDbType.Bit)).Value = certificate.FirstPremiumFlag;
                        command.Parameters.Add(new SqlParameter("@oth_DPPK_flg", SqlDbType.Bit)).Value = certificate.OtherDPPKFlag;
                        command.Parameters.Add(new SqlParameter("@sum_insured", SqlDbType.Float)).Value = certificate.SumInsured;
                        command.Parameters.Add(new SqlParameter("@sum_insured_efctv_dt", SqlDbType.DateTime)).Value = certificate.SumInsuredEffectiveDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@salary_amt", SqlDbType.Float)).Value = certificate.SalaryAmount;
                        command.Parameters.Add(new SqlParameter("@salary_efctv_dt", SqlDbType.DateTime)).Value = certificate.SalaryEffectiveDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@status_efctv_dt", SqlDbType.DateTime)).Value = certificate.StatusEffectiveDate ?? SqlDateTime.Null;
                        command.Parameters.Add(new SqlParameter("@status_type_nm", SqlDbType.VarChar)).Value = certificate.StatusTypeName ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar)).Value = certificate.Branch ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@Sales_Name", SqlDbType.VarChar)).Value = certificate.SalesName ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@premium_type_nmbr", SqlDbType.Int)).Value = certificate.PremiumTypeNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@rider_type_nmbr", SqlDbType.Int)).Value = certificate.RiderTypeNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@agent_nmbr", SqlDbType.Int)).Value = certificate.AgentNumber;
                        command.Parameters.Add(new SqlParameter("@commision_type_nmbr", SqlDbType.Int)).Value = certificate.CommissionTypeNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@plan_type_nmbr", SqlDbType.Int)).Value = certificate.PlanTypeNumber ?? (object)DBNull.Value;
                        command.Parameters.Add(new SqlParameter("@apu_ppt", SqlDbType.Bit)).Value = certificate.ApuPpt;

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
        }


        private void InsertGroup(GroupInfo group)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("sp_group_info_i", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@product_type", group.ProductType);
                    command.Parameters.AddWithValue("@termination_dt", group.TerminationDt);
                    command.Parameters.AddWithValue("@case_close_dt", group.CaseCloseDt);
                    command.Parameters.AddWithValue("@efctv_dt", group.EfctvDt);
                    command.Parameters.AddWithValue("@client_nmbr", group.ClientNmbr);
                    command.Parameters.AddWithValue("@ind_grp_cd", group.IndGrpCd);
                    command.Parameters.AddWithValue("@allow_with_nmbr", group.AllowWithNmbr);
                    command.Parameters.AddWithValue("@with_year", group.WithYear);
                    command.Parameters.AddWithValue("@min_annuity_prct", group.MinAnnuityPrct);
                    command.Parameters.AddWithValue("@min_annuity_amt", group.MinAnnuityAmt);
                    command.Parameters.AddWithValue("@anl_max_with_freq", group.AnlMaxWithFreq);
                    command.Parameters.AddWithValue("@min_with_amt", group.MinWithAmt);
                    command.Parameters.AddWithValue("@max_with_prct", group.MaxWithPrct);
                    command.Parameters.AddWithValue("@min_yr_for_with", group.MinYrForWith);
                    command.Parameters.AddWithValue("@early_retire_age", group.EarlyRetireAge);
                    command.Parameters.AddWithValue("@normal_retire_age", group.NormalRetireAge);
                    command.Parameters.AddWithValue("@min_cntrb_amt", group.MinCntrbAmt);
                    command.Parameters.AddWithValue("@max_cntrb_amt", group.MaxCntrbAmt);
                    command.Parameters.AddWithValue("@with_src_type_nmbr", group.WithSrcTypeNmbr);
                    command.Parameters.AddWithValue("@incl_contrib_flg", group.InclContribFlg);
                    command.Parameters.AddWithValue("@last_change_dt", DateTime.Now);
                    command.Parameters.AddWithValue("@affiliatedTo", group.AffiliatedTo);
                    command.Parameters.AddWithValue("@premium_mtd_type", group.PremiumMtdType);
                    command.Parameters.AddWithValue("@maturity_type_nmbr", group.MaturityTypeNmbr);
                    command.Parameters.AddWithValue("@maturity_val", group.MaturityVal);
                    command.Parameters.AddWithValue("@create_dt", DateTime.Now);
                    command.Parameters.AddWithValue("@mail_addr_opt", group.MailAddrOpt);
                    command.Parameters.AddWithValue("@bill_payctr_opt", group.BillPayctrOpt);
                    command.Parameters.AddWithValue("@psl_payment_freq", group.PslPaymentFreq);
                    command.Parameters.AddWithValue("@backdated_efctv_dt", group.BackdatedEfctvDt);
                    command.Parameters.AddWithValue("@accbal_freq_nmbr", group.AccbalFreqNmbr);
                    command.Parameters.AddWithValue("@Support_UU1992", group.SupportUu1992);
                    command.Parameters.AddWithValue("@completed_dt", group.CompletedDt);
                    command.Parameters.AddWithValue("@accbal_lstprn_dt", group.AccbalLstprnDt);
                    command.Parameters.AddWithValue("@prorate_fee_flg", group.ProrateFeeFlg);
                    command.Parameters.AddWithValue("@mpp_termination_dt", group.MppTerminationDt);
                    command.Parameters.AddWithValue("@SPAK_recv_dt", group.SpakRecvDt);
                    command.Parameters.AddWithValue("@have_psl", group.HavePsl);
                    command.Parameters.AddWithValue("@psl_type", group.PslType);
                    command.Parameters.AddWithValue("@pooled_flg", group.PooledFlg);
                    command.Parameters.AddWithValue("@old_grp_nmbr", group.OldGrpNmbr);
                    command.Parameters.AddWithValue("@claim_process_day", group.ClaimProcessDay);
                    command.Parameters.AddWithValue("@va_currency_nmbr", group.VaCurrencyNmbr);
                    command.Parameters.AddWithValue("@va_dplk_nmbr", group.VaDplkNmbr);
                    command.Parameters.AddWithValue("@commision_type", group.CommisionType);
                    command.Parameters.AddWithValue("@commision_flg", group.CommisionFlg);
                    command.Parameters.AddWithValue("@agent_nmbr", group.AgentNmbr);

                    command.ExecuteNonQuery();
                }

            }
        }

        private void DDL()
        {
            ViewData["DdlParamsBusinessSctr"] = GetDDL("business_sctr");
            ViewData["DdlParamsMnySrc"] = GetDDL("mny_src");
            ViewData["DdlParamsOptionType"] = GetDDL("option_type");
            ViewData["DdlParamsSuspenseType"] = GetDDL("suspense_type");
            ViewData["DdlParamsProductType"] = GetDDL("PRODUCT_TYPE");
            ViewData["DdlParamsAllowWithType"] = GetDDL("ALLOW_WITH_TYPE");
            ViewData["DdlParamsWithSourceType"] = GetDDL("WITH_SOURCE_TYPE");
            ViewData["DdlParamsFrequencyType"] = GetDDL("FREQUENCY_TYPE");
            ViewData["DdlParamsPremiumMethod"] = GetDDL("PREMIUM_METHOD");
            ViewData["DdlParamsMaturityType"] = GetDDL("MATURITY_TYPE");
            ViewData["DdlParamsCurrencyType"] = GetDDL("Currency_TYPE");
            ViewData["DdlParamsPslType"] = GetDDL("PSL_TYPE");
            ViewData["DdlParamsBeneType"] = GetDDL("BENE_TYPE"); //benefit
            ViewData["DdlParamsCoiType"] = GetDDL("COI_TYPE");
            ViewData["DdlParamsValue"] = GetDDL("si_calc_type");
            ViewData["DdlParamsInv"] = GetDDL("INV_TYPE"); //InvestmentDirection
            ViewData["DdlParamsRspnType"] = GetDDL("PAY_RSPN_TYPE");
            ViewData["DdlParamsFrequensy"] = GetDDL("FREQUENCY_TYPE");
            ViewData["DdlParamsOption"] = GetDDL("OPTION_TYPE");
            ViewData["DdlParamsCommissionType"] = GetDDL("COMMISSION_TYPE"); //s
            ViewData["DdlParamsStatusType"] = GetDDL("status_type");
            ViewData["DdlParamsPaymentType"] = GetDDL("payment_type");
            ViewData["DdlParamsCitizenship"] = GetDDL("citizenship");
            ViewData["DdlParamsFundSrcType"] = GetDDL("fund_src_type");
            ViewData["DdlParamsMoneyType"] = GetDDL("money_type");
            ViewData["DdlParamsPremiumType"] = GetDDL("premium_type");
            ViewData["DdlParamsRiderType"] = GetDDL("rider_type");
            ViewData["DdlParamsAgentMaster"] = GetDDL("agent_master");
            ViewData["DdlParamsMcpType"] = GetDDL("MCP_TYPE");
            ViewData["DdlStatusType"] = GetDDL("status_type");
            ViewData["DdlParamsChangeType"] = GetDDL("CHARGE_TYPE");
            ViewData["DdlParamsPayResponseType"] = GetDDL("PAY_RSPN_TYPE");
            ViewData["DdlParamIdType"] = GetDDL("id_type");
            ViewData["DdlParamMaritalStatusType"] = GetDDL("marital_status_type");
            ViewData["DdlParamsCompany"] = GetDDLParamsCompany();
            ViewData["DdlParamsPartner"] = GetDDLParamsPartner();
            ViewData["DdlParamsAgentName"] = GetDDLParamsAgentName();
            ViewData["DdlParamsAffiliated"] = GetDDLParamsAffiliated();
            ViewData["DdlParamsWD"] = GetDDLParamsWD();
            ViewData["DdlGroupPIC"] = GetCompaniesAndGroupNumbers();
            ViewData["DDLCompanyProcessClaimRequest"] = GetCompanyNamesFromDatabase();
            ViewData["TransactionTypes"] = GetTransactionTypes();
            ViewData["RekeningList"] = GetRekeningList();
            /*            ViewData["ReportList"] = GetShowReports();
            */



        }

        /*   private List<SelectListItem> GetShowReports()
           {
               var reportList = _context.SpdReports
                                       .OrderBy(r => r.Name)
                                       .Select(r => new SelectListItem { Value = r.Code.ToString(), Text = r.Name })
                                       .ToList();

               return reportList;
           }*/

        private List<SelectListItem> GetDDLParamsWD()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("select sub_trns_nmbr,sub_trns_nm from trns_type where trns_type_nmbr = 400 order by trns_type_nmbr asc", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }

        private List<SelectListItem> GetShowReport()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("select CODE, NAME from SPD_REPORTS order by NAME", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        private List<SelectListItem> GetRekeningList()
        {
            var rekeningList = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))

            {
                connection.Open();

                using (var command = new SqlCommand("SELECT Code_Bank, Rekening FROM tbRekBank", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var codeBank = reader["Code_Bank"].ToString();
                        var rekening = reader["Rekening"].ToString();

                        rekeningList.Add(new SelectListItem { Value = codeBank, Text = rekening });
                    }
                }
            }

            return rekeningList;
        }


        private List<SelectListItem> GetDDL(string ddlParamName)
        {
            var ddlParams = new List<SelectListItem>();

            var sql = $"EXEC DDL_PARAM '{ddlParamName}'";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        private List<SelectListItem> GetDDLParamsPartner()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT v.dplk_nmbr, r.dplk_nm FROM va_dplk_type v JOIN dplk_rollover r ON v.dplk_nmbr = r.dplk_nmbr", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        private List<SelectListItem> GetDDLParamsAgentName()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("select agent_nmbr, agent_nm from agent_master", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        private List<SelectListItem> GetDDLParamsCompany()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DDL_COMPANY_ON_SCR_GROUP", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var value = reader["client_nmbr"].ToString();
                            var text = reader["company_nm"].ToString();
                            ddlParams.Add(new SelectListItem { Value = value, Text = text });
                        }
                    }
                }
            }

            return ddlParams;
        }
        private List<SelectListItem> GetDDLParamsAffiliated()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT group_nmbr,company_nm + ' - ' + cast(group_nmbr as varchar(10)) FROM group_info g JOIN company co ON g.client_nmbr = co.client_nmbr ORDER BY company_nm ASC", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        private List<SelectListItem> GetCompaniesAndGroupNumbers()
        {
            List<SelectListItem> ddlItems = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT g.group_nmbr, co.company_nm + ' - ' + CAST(g.group_nmbr AS varchar(10)) AS DisplayText " +
                                                           "FROM group_info g " +
                                                           "JOIN company co ON g.client_nmbr = co.client_nmbr " +
                                                           "ORDER BY co.company_nm ASC", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader["group_nmbr"].ToString();
                            string text = reader["DisplayText"].ToString();

                            ddlItems.Add(new SelectListItem { Value = value, Text = text });
                        }
                    }
                }
            }

            return ddlItems;
        }


        [HttpGet]
        public IActionResult NewBussinesClientIndex()
        {
            try
            {
                var genderOptions = GetGenderOptions();
                ViewData["GenderOptions"] = genderOptions;
                DDL();
                GetFillDDL();
                FillDDLPaycenter();
                FillDDLGroup();
                return View();
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while processing your request: " + ex.Message;
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> NewBussinesClientIndex(int id, [Bind("ClientNmbr,ClientNm,IdentityType,IdentityNmbr,Gender,BirthDt,MaritalStatusNmbr,MaidenNm,EmailAddr,DobPlace,ClientNmbrOpf,Path")] Client client)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        await InsertClient(client);
                        TempData["SuccessMessage"] = "Client information created successfully";
                        return RedirectToAction("NewBussinesClientIndex");
                    }
                    catch (System.Exception ex)
                    {
                        ModelState.AddModelError("", $"Error while executing database operation: {ex.Message}");
                    }
                }
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", $"Error while processing client information: {ex.Message}");
            }

            var genderOptions = GetGenderOptions();
            ViewData["GenderOptions"] = genderOptions;
            GetFillDDL();
            FillDDLPaycenter();
            FillDDLGroup();
            DDL();
            return View(client);
        }

        private void ExecuteUspSumInsured(int cerNmbr, DateTime efctvDt, float sumInsured, string beneTypeNm)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("usp_sum_insured_i", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cer_nmbr", cerNmbr);
                    cmd.Parameters.AddWithValue("@efctv_dt", efctvDt);
                    cmd.Parameters.AddWithValue("@sum_insured", sumInsured);
                    cmd.Parameters.AddWithValue("@bene_type_nm", beneTypeNm);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private async Task InsertClient(Client client)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var cmd = new SqlCommand("sp_client_i", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@clientname", client.ClientNm);
                    cmd.Parameters.AddWithValue("@identitytype", client.IdentityType);
                    cmd.Parameters.AddWithValue("@identitynbr", client.IdentityNmbr);
                    cmd.Parameters.AddWithValue("@gender", client.Gender);
                    cmd.Parameters.AddWithValue("@birthdate", client.BirthDt);
                    cmd.Parameters.AddWithValue("@dob_place", client.DobPlace);
                    cmd.Parameters.AddWithValue("@maritalstatus", client.MaritalStatusNmbr);
                    cmd.Parameters.AddWithValue("@maidenname", client.MaidenNm);
                    cmd.Parameters.AddWithValue("@emailaddress", client.EmailAddr);
                    cmd.Parameters.AddWithValue("@path", client.Path);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        [HttpGet]
        public IActionResult StatusSalary()
        {
            return View();
        }
        /*    [HttpPost]
            public IActionResult StatusSalary()
            {
                return View();
            }*/

        private List<SelectListItem> GetGenderOptions()
        {
            var genderOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "", Text = "PLEASE SELECT" },
                new SelectListItem { Value = "M", Text = "Male" },
                new SelectListItem { Value = "F", Text = "Female" }
            };

            return genderOptions;
        }
        private List<SelectListItem> GetDDLParamsClient(string ddlParamName)
        {
            var ddlParams = new List<SelectListItem>();

            var sql = $"EXEC DDL_PARAM '{ddlParamName}'";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var value = reader[0].ToString();
                        var text = reader[1].ToString();
                        ddlParams.Add(new SelectListItem { Value = value, Text = text });
                    }
                }
            }

            return ddlParams;
        }
        public IActionResult UploadIndex()
        {
            return View();
        }
        public IActionResult UpdateCompanyIndex()
        {
            return View();
        }
        public IActionResult UpdateGroupIndex()
        {
            return View();
        }
        public IActionResult UpdateClientIndex()
        {
            return View();
        }
        public IActionResult UpdateUploadDataIndex()
        {
            return View();
        }
        /*        public IActionResult ProcessClaimRequest()
                {
                    return View();
                }
        */
        public IActionResult WithdrawalApproval()
        {
            return View();
        }
        public IActionResult WithdrawalEstimationApproval()
        {
            return View();
        }

        public IActionResult WithdrawEdit(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            try
            {
                var payments = _context.TferPayInfos.FromSqlRaw("EXEC DGR_ON_SCR_EDITING_CLAIM").ToList();
                //var payments = _context.TferPayInfos.ToList();

                ViewBag.currentFilter = searchString;

                // Filtering
                if (!string.IsNullOrEmpty(searchString))
                {
                    payments = payments.Where(payment =>
                        payment.Note.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                    ).ToList();
                }

                ViewBag.PageSize = new List<int> { 5, 10, 15, 20 };
                ViewBag.SortOrder = string.IsNullOrEmpty(sortOrder) ? "company_nm" : "";
                ViewBag.CurrentSort = sortOrder;

                switch (sortOrder)
                {
                    case "company_nm":
                        payments = payments.OrderByDescending(p => p.BankNm).ToList();
                        break;
                    default:
                        payments = payments.OrderBy(p => p.BankNm).ToList();
                        break;
                }

                return View(payments.ToPagedList(pageIndex, defaultSize));
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error: " + ex.Message;
                return View(new List<TferPayInfo>());
            }
        }

        /*        public IActionResult WithdrawEdit(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
                {
                    int pageIndex = page ?? 1;
                    int defaultSize = pageSize ?? 5;
                    ViewBag.psize = defaultSize;

                    if (searchString != null)
                    {
                        page = 1;
                    }
                    else
                    {
                        searchString = currentFilter;
                    }

                    try
                    {
                        var payments = (from p in _context.TferPayInfos
                                        join w in _context.TrnsHstWds on new { p.cer_nmbr, p.trns_seq_nmbr } equals new { w.cer_nmbr, w.trns_seq_nmbr }
                                        join c in _context.Certificates on p.cer_nmbr equals c.cer_nmbr
                                        join cl in _context.Clients on c.client_nmbr equals cl.client_nmbr
                                        join g in _context.GroupInfos on c.group_nmbr equals g.group_nmbr
                                        join co in _context.Companies on g.client_nmbr equals co.client_nmbr
                                        join tt in _context.TferTypes on p.tfer_type_nmbr equals tt.tfer_type_nmbr
                                        where !(_context.ClaimRegisterTracks
                                                .Where(track => track.track_type_nmbr > 9)
                                                .Select(track => track.cr_id)
                                                .Contains(dbo.fnclaimregissearch(p.note))
                                              )
                                        orderby co.company_nm
                                        select new
                                        {
                                            register = dbo.fnclaimregissearch(p.note),
                                            p.tfer_type_nmbr,
                                            p.trns_seq_nmbr,
                                            p.cer_nmbr,
                                            cl.client_nm,
                                            co.company_nm,
                                            tt.tfer_type_nm,
                                            p.tfer_amt,
                                            p.bank_central_nm,
                                            p.bank_addr,
                                            p.acct_nmbr,
                                            p.acct_nm,
                                            kode_bank = p.bank_bi_nmbr,
                                            BATCH_ID = w.BATCH_ID
                                        }).ToList();

                        ViewBag.currentFilter = searchString;

                        // Filtering
                        if (!string.IsNullOrEmpty(searchString))
                        {
                            payments = payments.Where(payment =>
                                payment.note.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                            ).ToList();
                        }

                        ViewBag.PageSize = new List<int> { 5, 10, 15, 20 };
                        ViewBag.SortOrder = string.IsNullOrEmpty(sortOrder) ? "company_nm" : "";
                        ViewBag.CurrentSort = sortOrder;

                        switch (sortOrder)
                        {
                            case "company_nm":
                                payments = payments.OrderByDescending(p => p.company_nm).ToList();
                                break;
                            default:
                                payments = payments.OrderBy(p => p.company_nm).ToList();
                                break;
                        }

                        return View(payments.ToPagedList(pageIndex, defaultSize));
                    }
                    catch (System.Exception ex)
                    {
                        ViewBag.ErrorMessage = "Error: " + ex.Message;
                        return View(new List<TferPayInfo>());
                    }
                }
        */
        [HttpGet]
        public IActionResult WithdrawEditing()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WithdrawEditing(TferPayInfo2 tferPayInfo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("usp_editing_claim_u", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@cer_nmbr", tferPayInfo.CerNmbr);
                            command.Parameters.AddWithValue("@trns_seq_nmbr", tferPayInfo.TrnsSeqNmbr);
                            command.Parameters.AddWithValue("@tfer_type_nmbr", tferPayInfo.TferTypeNmbr);
                            command.Parameters.AddWithValue("@Bank_update", tferPayInfo.BankNm);
                            command.Parameters.AddWithValue("@acct_nmbr", tferPayInfo.AcctNmbr);
                            command.Parameters.AddWithValue("@acct_nm", tferPayInfo.AcctNm);

                            command.ExecuteNonQuery();
                        }
                    }

                    TempData["SuccessMessage"] = "Withdraw data has been updated successfully.";
                    return RedirectToAction(nameof(WithdrawEditing));
                }
                catch (System.Exception ex)
                {
                    ViewBag.ErrorMessage = "Error: " + ex.Message;
                }
            }

            return View(tferPayInfo);
        }




        public IActionResult TransactionDeletingClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TransactionDeletingClaim(int cerNmbr, int batchId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("usp_delete_claim", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@cer_nmbr", cerNmbr);
                        command.Parameters.AddWithValue("@batch_id", batchId);

                        command.ExecuteNonQuery();
                    }
                }

                TempData["SuccessMessage"] = "Claim deleted successfully.";
                return RedirectToAction("TransactionDeletingClaim", "Claim");
            }
            catch (System.Exception ex)
            {
                TempData["ErrorMessage"] = "Error: " + ex.Message;
                return RedirectToAction("TransactionDeletingClaim", "Claim");
            }
        }
        public IActionResult EntryPayrollContribution()
        {
            return View();
        }
        public IActionResult BillContribution()
        {
            return View();
        }
        public IActionResult FundSwitching()
        {
            return View();
        }
        public IActionResult FundSwitchingByMoneyType()
        {
            return View();
        }
        public IActionResult CertificateMovement()
        {
            return View();
        }
        public IActionResult CertificateMovementByMoneyType()
        {
            return View();
        }
        public IActionResult CertificateChange()
        {
            return View();
        }


        public async Task<IActionResult> AdminSuspense(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 8;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var data = _context.AdminSuspenses
                .FromSqlRaw("EXEC GRID_SUSPENSE_ON_SCR_ADMINSUSPENSE")
                .ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                data = data.Where(item =>
                {
                    var properties = typeof(AdminSuspense).GetProperties();
                    foreach (var property in properties)
                    {
                        var value = property.GetValue(item);
                        if (value != null && value.ToString().ToLower().Contains(searchString.ToLower()))
                        {
                            return true;
                        }
                    }
                    return false;
                }).ToList();
            }
            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() { Value="5", Text= "5" },
                new SelectListItem() { Value="10", Text= "10" },
                new SelectListItem() { Value="15", Text= "15" },
                new SelectListItem() { Value="20", Text= "20" }
            };

            ViewBag.SortOrder = sortOrder == "company_nm" ? "" : "company_nm";
            ViewBag.CurrentSort = sortOrder;
            switch (sortOrder)
            {
                case "company_nm":
                    data = data.OrderBy(item => item.company_nm).ToList();
                    break;
                default:
                    data = data.OrderByDescending(item => item.company_nm).ToList();
                    break;
            }


            return View(data.ToPagedList(pageIndex, defaultSize));
        }

        // GET: AdminSuspense/Create
        public IActionResult AdminSuspenseCreate()
        {
            GetFillDDL();
            FillDDLPaycenter();
            FillDDLGroup();
            return View();
        }

        // POST: AdminSuspense/Create
        [HttpPost]
        public async Task<IActionResult> AdminSuspenseCreate([Bind("SuspnNmbr,GroupNmbr,PaycenterNmbr,CreateDt,SuspnAmt,SuspnUseAmt,FinApproveCd,AdmApproveCd,SuspnDesc1,SuspnDesc2,Remark,LastChangeDt,SuspnTypeNmbr,ReceivedDt,UseStatusCd,WaivedFlg,RcptvoucherFlg,RefBank")] SuspenseHst suspenseHst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suspenseHst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AdminSuspense));
            }
            GetFillDDL();
            FillDDLPaycenter();
            FillDDLGroup();
            return View(suspenseHst);
        }
        /*  [HttpPost]
          public async Task<IActionResult> AdminSuspenseCreate([Bind("SuspnNmbr,GroupNmbr,PaycenterNmbr,CreateDt,SuspnAmt,SuspnUseAmt,FinApproveCd,AdmApproveCd,SuspnDesc1,SuspnDesc2,Remark,LastChangeDt,SuspnTypeNmbr,ReceivedDt,UseStatusCd,WaivedFlg,RcptvoucherFlg,RefBank")] SuspenseHst suspenseHst)
          {
              if (ModelState.IsValid)
              {
                  var suspnNmbrParam = new SqlParameter("@suspn_nmbr", suspenseHst.SuspnNmbr);
                  var groupNmbrParam = new SqlParameter("@group_nmbr", suspenseHst.GroupNmbr);
                  var paycenterNmbrParam = new SqlParameter("@paycenter_nmbr", suspenseHst.PaycenterNmbr);
                  var suspnAmtParam = new SqlParameter("@suspn_amt", suspenseHst.SuspnAmt);
                  var suspnUseAmtParam = new SqlParameter("@suspn_use_amt", suspenseHst.SuspnUseAmt);
                  var finApproveCdParam = new SqlParameter("@fin_approve_cd", suspenseHst.FinApproveCd);
                  var admApproveCdParam = new SqlParameter("@adm_approve_cd", suspenseHst.AdmApproveCd);
                  var suspnDesc1Param = new SqlParameter("@suspn_desc1", suspenseHst.SuspnDesc1);
                  var suspnDesc2Param = new SqlParameter("@suspn_desc2", suspenseHst.SuspnDesc2);
                  var remarkParam = new SqlParameter("@remark", suspenseHst.Remark);
                  var suspnTypeNmbrParam = new SqlParameter("@suspn_type_nmbr", suspenseHst.SuspnTypeNmbr);
                  var receivedDtParam = new SqlParameter("@received_dt", suspenseHst.ReceivedDt);
                  var useStatusCdParam = new SqlParameter("@use_status_cd", suspenseHst.UseStatusCd);
                  var waivedFlgParam = new SqlParameter("@waived_flg", suspenseHst.WaivedFlg);
                  var rcptvoucherFlgParam = new SqlParameter("@rcptvoucher_flg", suspenseHst.RcptvoucherFlg);
                  var refBankParam = new SqlParameter("@ref_Bank", suspenseHst.RefBank);

                  await _context.Database.ExecuteSqlRawAsync(
                      "sp_suspense_hst_i @suspn_nmbr, @group_nmbr, @paycenter_nmbr, @suspn_amt, @suspn_use_amt, @fin_approve_cd, @adm_approve_cd, " +
                      "@suspn_desc1, @suspn_desc2, @remark, @suspn_type_nmbr, @received_dt, @use_status_cd, @waived_flg, @rcptvoucher_flg, @ref_Bank",
                      suspnNmbrParam, groupNmbrParam, paycenterNmbrParam, suspnAmtParam, suspnUseAmtParam, finApproveCdParam, admApproveCdParam,
                      suspnDesc1Param, suspnDesc2Param, remarkParam, suspnTypeNmbrParam, receivedDtParam, useStatusCdParam, waivedFlgParam,
                      rcptvoucherFlgParam, refBankParam);

                  return RedirectToAction(nameof(AdminSuspense));
              }

              FillDDLInViewData();
              GetFillDDL();
              FillDDLPaycenter();
              FillDDLGroup();
              return View(suspenseHst);
          }
    */
        private void GetFillDDL()
        {
            var ddlPaycenterParams = FillDDLPaycenter();
            var ddlGroupParams = FillDDLGroup();

            ViewBag.PaycenterList = new SelectList(ddlPaycenterParams, "Value", "Text");
            ViewBag.GroupList = new SelectList(ddlGroupParams, "Value", "Text");
        }

        private List<SelectListItem> FillDDLPaycenter()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DDL_PAYCENTER_ON_SCR_ADMINSUSPENSE", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@paycenter_nmbr", SqlDbType.VarChar) { Value = "PLEASE SELECT" });

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var value = reader["paycenter_nmbr"].ToString();
                            var text = reader["paycenter_nm"].ToString();
                            ddlParams.Add(new SelectListItem { Value = value, Text = text });
                        }
                    }
                }
            }

            return ddlParams;
        }

        private List<SelectListItem> FillDDLGroup()
        {
            var ddlParams = new List<SelectListItem>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DDL_GROUP_ON_SCR_CERTIFICATEINFO", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var value = reader["group_nmbr"].ToString();
                            var text = reader["company_nm"].ToString();
                            ddlParams.Add(new SelectListItem { Value = value, Text = text });
                        }
                    }
                }
            }

            return ddlParams;
        }





        // GET: AdminSuspense/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspenseHst = await _context.SuspenseHsts.FindAsync(id);
            if (suspenseHst == null)
            {
                return NotFound();
            }
            return View(suspenseHst);
        }

        /*     // POST: AdminSuspense/Edit/5
             [HttpPost]
             [ValidateAntiForgeryToken]
             public async Task<IActionResult> Edit(long id, [Bind("SuspnNmbr,GroupNmbr,PaycenterNmbr,CreateDt,SuspnAmt,SuspnUseAmt,FinApproveCd,AdmApproveCd,SuspnDesc1,SuspnDesc2,Remark,LastChangeDt,SuspnTypeNmbr,ReceivedDt,UseStatusCd,WaivedFlg,RcptvoucherFlg,RefBank")] SuspenseHst suspenseHst)
             {
                 if (id != suspenseHst.SuspnNmbr)
                 {
                     return NotFound();
                 }

                 if (ModelState.IsValid)
                 {
                     try
                     {
                         _context.Update(suspenseHst);
                         await _context.SaveChangesAsync();
                     }
                     catch (DbUpdateConcurrencyException)
                     {
                         if (!SuspenseHstExists(suspenseHst.SuspnNmbr))
                         {
                             return NotFound();
                         }
                         else
                         {
                             throw;
                         }
                     }
                     return RedirectToAction(nameof(AdminSuspense));
                 }
                 return View(suspenseHst);
             }
     */


        public IActionResult AdminSuspenseApproval()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DPLKRider()
        {
            return View();
        }
        /*    [HttpGet]
            public IActionResult DPLKRider()
            {
                return View();
            }*/

        public IActionResult SuratPengantarKartu()
        {
            return View();
        }

        public IActionResult UnapprovalPengantarKartuIndividu()
        {
            List<Dictionary<string, object>> suratKeluarData = new List<Dictionary<string, object>>();

            string query = @"
                select distinct sk.no_surat, sk.ditujukan, sk.tgl_surat, com.company_nm, cer.group_nmbr 
                from svrapp.dbhr.dbo.t_admsrt_surat_keluar sk
                inner join pengantar_kartu pk on pk.no_surat = sk.no_surat
                inner join certificate cer on cer.cer_nmbr = pk.cer_nmbr
                inner join group_info gi on gi.group_nmbr = cer.group_nmbr
                inner join company com on com.client_nmbr = gi.client_nmbr
                where cer.group_nmbr not in (10078,10341,10343,10344,10345,10346,10476) 
                and sk.status_surat = 1 
                order by sk.tgl_surat desc";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader[i];
                            }
                            suratKeluarData.Add(row);
                        }
                    }
                }
            }

            return View(suratKeluarData);
        }



        public async Task<IActionResult> AdjustmentAccrueFee(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 8;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var data = _context.CycleCertificateChargeAdjustments.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                data = data.Where(item =>
                    item.InvTypeNmbr.ToString().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() { Value="5", Text= "5" },
                new SelectListItem() { Value="10", Text= "10" },
                new SelectListItem() { Value="15", Text= "15" },
                new SelectListItem() { Value="20", Text= "20" }
            };

            ViewBag.SortOrder = sortOrder == "InvTypeNmbr" ? "" : "InvTypeNmbr";
            ViewBag.CurrentSort = sortOrder;
            switch (sortOrder)
            {
                case "InvTypeNmbr":
                    data = data.OrderBy(item => item.InvTypeNmbr).ToList();
                    break;
                default:
                    data = data.OrderByDescending(item => item.InvTypeNmbr).ToList();
                    break;
            }

            ViewBag.FundList = GetFundDataFromDatabase();

            return View(data.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult AdjustmentAccrueFeeCreate()
        {
            ViewBag.FundList = GetFundDataFromDatabase();
            return View();
        }
        [HttpPost]
        public IActionResult AdjustmentAccrueFeeCreate(CycleCertificateChargeAdjustment cycleCertificateChargeAdjustment)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("usp_cycle_certificate_charge_adjustment_iu", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@inv_type_nmbr", cycleCertificateChargeAdjustment.InvTypeNmbr);
                            command.Parameters.AddWithValue("@start_dt", cycleCertificateChargeAdjustment.FeePeriodStart);
                            command.Parameters.AddWithValue("@end_dt", cycleCertificateChargeAdjustment.FeePeriodEnd);
                            command.Parameters.AddWithValue("@adj_amt", cycleCertificateChargeAdjustment.AdjAmt);
                            command.Parameters.AddWithValue("@user_nm", cycleCertificateChargeAdjustment.UserNm);

                            command.ExecuteNonQuery();
                        }
                    }

                    TempData["SuccessMessage"] = "Data inserted/updated successfully";
                    return RedirectToAction(nameof(AdjustmentAccrueFee));
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while processing your request.");
                }
            }

            ViewBag.FundList = GetFundDataFromDatabase();
            return View();
        }

        private List<SelectListItem> GetFundDataFromDatabase()
        {
            List<SelectListItem> fundList = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("select inv_type_nmbr, inv_type_nm from inv_type", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fundList.Add(new SelectListItem
                            {
                                Value = reader["inv_type_nmbr"].ToString(),
                                Text = reader["inv_type_nm"].ToString()
                            });
                        }
                    }
                }
            }

            return fundList;
        }
        [HttpGet]
        public async Task<IActionResult> AdjustmentAccrueFeeEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _context.CycleCertificateChargeAdjustments
                .FirstOrDefaultAsync(item => item.InvTypeNmbr == id);

            if (data == null)
            {
                return NotFound();
            }

            ViewBag.FundList = GetFundDataFromDatabase();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> AdjustmentAccrueFeeEdit(int id, CycleCertificateChargeAdjustment cycleCertificateChargeAdjustment)
        {
            if (id != cycleCertificateChargeAdjustment.InvTypeNmbr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingData = await _context.CycleCertificateChargeAdjustments
                        .FirstOrDefaultAsync(item => item.InvTypeNmbr == id);

                    if (existingData != null)
                    {
                        existingData.FeePeriodStart = cycleCertificateChargeAdjustment.FeePeriodStart;
                        existingData.FeePeriodEnd = cycleCertificateChargeAdjustment.FeePeriodEnd;
                        existingData.AdjAmt = cycleCertificateChargeAdjustment.AdjAmt;
                        existingData.UserNm = cycleCertificateChargeAdjustment.UserNm;

                        await _context.SaveChangesAsync();

                        TempData["SuccessMessage"] = "Data updated successfully";
                        return RedirectToAction(nameof(AdjustmentAccrueFee));
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while processing your request.");
                }
            }

            ViewBag.FundList = GetFundDataFromDatabase();
            return View(cycleCertificateChargeAdjustment);
        }

        [HttpPost]
        public async Task<IActionResult> AdjustmentAccrueFeeConfirmDelete(int? id)
        {
            try
            {
                var x = await _context.CycleCertificateChargeAdjustments.FindAsync(id);
                if (x == null)
                {
                    return NotFound();
                }
                _context.CycleCertificateChargeAdjustments.Remove(x);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Company data deleted successfully";
                return RedirectToAction("AdjustmentAccrueFee");
            }
            catch (System.Exception ex)
            {
                TempData["ErrorMessage"] = $"Error while deleting company: {ex.Message}";
                return RedirectToAction("AdjustmentAccrueFee");
            }

        }


        [HttpGet]
        public async Task<IActionResult> AdjustmentAccrueFeeDelete(int id)
        {

            ViewBag.InvTypeNmbr = id;
            return View();
        }
        public IActionResult UnitPrice(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 7;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var unitPrices = _context.UnitPrices
                .Join(
                    _context.InvTypes,
                    up => up.InvTypeNmbr,
                    it => it.InvTypeNmbr,
                    (up, it) => new { UnitPrice = up, InvType = it }
                )
                .Select(result => new UnitPrice
                {
                    EfctvDt = result.UnitPrice.EfctvDt,
                    InvTypeNmbr = result.UnitPrice.InvTypeNmbr,
                    Price = result.UnitPrice.Price,
                    ApprovalFlg = result.UnitPrice.ApprovalFlg,
                    LastChangeDt = result.UnitPrice.LastChangeDt,
                    InvTypeName = result.InvType.InvTypeNm
                });

            ViewBag.currentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                unitPrices = unitPrices.Where(unitPrice =>
                    unitPrice.InvTypeName.ToLower().Contains(searchString.ToLower())
                );
            }

            switch (sortOrder)
            {
                case "InvTypeNmbr":
                    unitPrices = unitPrices.OrderBy(unitPrice => unitPrice.InvTypeNmbr);
                    break;
                default:
                    unitPrices = unitPrices.OrderByDescending(unitPrice => unitPrice.InvTypeNmbr);
                    break;
            }

            var model = unitPrices.ToPagedList(pageIndex, defaultSize);

            ViewBag.CurrentFilter = searchString;

            ViewBag.TotalItemCount = model.TotalItemCount;
            ViewBag.PageNumber = pageIndex;
            ViewBag.PageSize = model.PageSize;
            ViewBag.HasPreviousPage = model.HasPreviousPage;
            ViewBag.HasNextPage = model.HasNextPage;

            return View(model);
        }

        public async Task<IActionResult> VirtualAccount(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 8;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var virtualAccounts = await _context.VaGroups.ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                virtualAccounts = virtualAccounts.Where(va =>
                    va.VaAccnNmbr.ToLower().Contains(searchString.ToLower()) ||
                    va.GroupNmbr.ToString().Contains(searchString.ToLower()) ||
                    va.CompanyNm.ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>()
                {
                    new SelectListItem() { Value="5", Text= "5" },
                    new SelectListItem() { Value="10", Text= "10" },
                    new SelectListItem() { Value="15", Text= "15" },
                    new SelectListItem() { Value="20", Text= "20" }
                };

            ViewBag.SortOrder = sortOrder == "CompanyNm" ? "" : "CompanyNm";
            ViewBag.CurrentSort = sortOrder;
            switch (sortOrder)
            {
                case "CompanyNm":
                    virtualAccounts = virtualAccounts.OrderBy(va => va.CompanyNm).ToList();
                    break;
                default:
                    virtualAccounts = virtualAccounts.OrderByDescending(va => va.CompanyNm).ToList();
                    break;
            }

            return View(virtualAccounts.ToPagedList(pageIndex, defaultSize));
        }
        /* public async Task<IActionResult> VirtualAccountDetails(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var virtualAccount = await _context.VirtualAccounts.FirstOrDefaultAsync(va => va == id);

             if (virtualAccount == null)
             {
                 return NotFound();
             }

             return View(virtualAccount);
         }

         public IActionResult CreateVirtualAccount()
         {
             return View();
         }

         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> CreateVirtualAccount(VirtualAccount virtualAccount)
         {
             if (ModelState.IsValid)
             {
                 _context.Add(virtualAccount);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(VirtualAccount));
             }
             return View(virtualAccount);
         }*/



        //      SETUP PARTNER 



        public async Task<IActionResult> SetupPartner(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var query = _context.DplkRollovers.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                query = query.Where(partner =>
                    partner.DplkNm.ToLower().Contains(searchString) ||
                    partner.AcctNmbr.ToLower().Contains(searchString)
                );
            }

            var dplkRollover = await query.ToListAsync();

            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() { Value="5", Text= "5" },
                new SelectListItem() { Value="10", Text= "10" },
                new SelectListItem() { Value="15", Text= "15" },
                new SelectListItem() { Value="20", Text= "20" }
            };

            ViewBag.SortOrder = sortOrder == "DplkNm" ? "" : "DplkNm";
            ViewBag.CurrentSort = sortOrder;

            if (sortOrder == "DplkNm")
            {
                dplkRollover = dplkRollover.OrderBy(partner => partner.DplkNm).ToList();
            }
            else
            {
                dplkRollover = dplkRollover.OrderByDescending(partner => partner.DplkNm).ToList();
            }

            return View(dplkRollover.ToPagedList(pageIndex, defaultSize));
        }
        // GET: /Pension/SetupPartnerCreate
        [HttpGet]
        public IActionResult SetupPartnerCreate()
        {
            ViewBag.BankList = new SelectList(GetBankDataFromDatabase(), "Value", "Text");
            return View();
        }
        private List<SelectListItem> GetBankDataFromDatabase()
        {
            var bankData = _context.DbBanks.Select(bank => new SelectListItem
            {
                Value = bank.BankNm,
                Text = $"{bank.BankNm} {bank.BankAddr}"
            }).ToList();

            return bankData;
        }
        // POST: /Pension/SetupPartnerCreate
        [HttpPost]
        public async Task<IActionResult> SetupPartnerCreate(DplkRollover model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("usp_dplk_rollover_i", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@dplk_nmbr", "0");
                            command.Parameters.AddWithValue("@dplk_nm", model.DplkNm);
                            command.Parameters.AddWithValue("@bank_nm", model.BankNm ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@acct_nmbr", model.AcctNmbr ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@dplk_address1", model.DplkAddress1);
                            command.Parameters.AddWithValue("@dplk_address2", model.DplkAddress2);
                            command.Parameters.AddWithValue("@dplk_address3", model.DplkAddress3);
                            command.Parameters.AddWithValue("@dplk_city", model.DplkCity);
                            command.Parameters.AddWithValue("@dplk_postal_cd", model.DplkPostalCd);
                            command.Parameters.AddWithValue("@dplk_contact_person", model.DplkContactPerson);

                            await command.ExecuteNonQueryAsync();
                        }
                    }

                    TempData["SuccessMessage"] = "Request data sent";

                    return RedirectToAction(nameof(SetupPartner));
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while processing your request.");
                }
            }

            ViewBag.BankList = new SelectList(GetBankDataFromDatabase(), "Value", "Text");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SetupPartnerEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.DplkRollovers.FirstOrDefaultAsync(item => item.DplkNmbr == id);

            if (model != null)
            {
                ViewBag.BankList = new SelectList(GetBankDataFromDatabase(), "Value", "Text");
                return View(model);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetupPartnerEdit(DplkRollover model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (model.DplkNmbr == null)
                    {
                        ModelState.AddModelError("DplkNmbr", "Institution Code is required");
                        ViewBag.BankList = new SelectList(GetBankDataFromDatabase(), "Value", "Text");
                        return View(model);
                    }

                    _context.DplkRollovers.Update(model);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Request data updated";
                    return RedirectToAction(nameof(SetupPartner), new { id = model.DplkNmbr });
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while processing your request.");
                }
            }

            ViewBag.BankList = new SelectList(GetBankDataFromDatabase(), "Value", "Text");
            return View(model);
        }



        [HttpGet]
        public IActionResult DeleteSetupPartner(int id)
        {
            ViewBag.DplkNmbr = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSetupPartnerAction(int id)
        {
            var model = await _context.DplkRollovers.FindAsync(id);
            if (model != null)
            {
                _context.DplkRollovers.Remove(model);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Data deleted successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Data not found.";
            }

            return RedirectToAction(nameof(SetupPartner));
        }



        /*       [HttpPost]
               public async Task<IActionResult> NewBussinesCompanyDelete(int id)
               {

                       var company = await _context.Companies.FindAsync(id);

                       if (company == null)
                       {
                           return NotFound();
                       }

                       _context.Companies.Remove(company);
                       await _context.SaveChangesAsync();

                       TempData["SuccessMessage"] = "Company data deleted successfully";
                       return RedirectToAction("NewBussinesCompany");


               }*/
        public IActionResult ParameterMaker()
        {
            return View();
        }
        public async Task<IActionResult> ParameterMakerIDTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;

            }
            else
            {
                searchString = currentFilter;
            }
            var idTypes = await _context.IdTypes.ToListAsync();
            ViewBag.curruentfilter = searchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                idTypes = idTypes.Where(id =>
                    id.IdentityNm.ToString().ToLower().Contains(searchString.ToLower())
                    ).ToList();
            }

            // Set ViewBag.PageSize
            ViewBag.PageSize = new List<SelectListItem>
                {
                    new SelectListItem { Value = "5", Text = "5" },
                    new SelectListItem { Value = "10", Text = "10" },
                    new SelectListItem { Value = "15", Text = "15" },
                    new SelectListItem { Value = "20", Text = "20" }
                };

            ViewBag.SortOrder = sortOrder == "IdentityNm" ? "" : "IdentityNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "IdentityNm":
                    idTypes = idTypes.OrderBy(id => id.IdentityNm).ToList();
                    break;
                default:
                    idTypes = idTypes.OrderByDescending(id => id.IdentityNm).ToList();
                    break;
            }


            return View(idTypes.ToPagedList(pageIndex, defaultSize));

        }
        public IActionResult ParameterMakerIDTypeCreate()
        {
            return View();
        }
        //AddressType
        public IActionResult ParameterMakerAddressTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 7;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var addressTypes = _context.AddressTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                addressTypes = addressTypes.Where(address =>
                    address.AddrTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
                {
                    new SelectListItem { Value = "5", Text = "5" },
                    new SelectListItem { Value = "10", Text = "10" },
                    new SelectListItem { Value = "15", Text = "15" },
                    new SelectListItem { Value = "20", Text = "20" }
                };

            ViewBag.SortOrder = sortOrder == "TypeName" ? "" : "TypeName";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "TypeName":
                    addressTypes = addressTypes.OrderBy(address => address.AddrTypeNm).ToList();
                    break;
                default:
                    addressTypes = addressTypes.OrderByDescending(address => address.AddrTypeNm).ToList();
                    break;
            }

            return View(addressTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerAddressTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerAddressTypeCreate(AddressType addressType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Panggil stored procedure untuk insert data
                    var sql = $"exec sp_Insert_Parameter_all 'address_type', '1', '1', '{addressType.AddrTypeNmbr}', '{addressType.AddrTypeNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);
                    TempData["SuccessMessage"] = "Request data sent successfully";

                    return RedirectToAction(nameof(ParameterMakerAddressTypeIndex));
                }
                else
                {
                    return View("ParameterMakerAddressTypeCreate", addressType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Address Type: " + ex.Message;
                return View("Error");
            }
        }
        //SEC Type
        public IActionResult ParameterMakerSecTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var secTypes = _context.SecTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                secTypes = secTypes.Where(secType =>
                    secType.SecTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "SecTypeNm" ? "" : "SecTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "SecTypeNm":
                    secTypes = secTypes.OrderBy(secType => secType.SecTypeNm).ToList();
                    break;
                default:
                    secTypes = secTypes.OrderByDescending(secType => secType.SecTypeNm).ToList();
                    break;
            }

            return View(secTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerSecTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerSecTypeCreate(SecurityType securityType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'security_type', '1', '1', '{securityType.SecTypeNmbr}', '{securityType.SecTypeNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Request data sent";
                    return RedirectToAction(nameof(ParameterMakerSecTypeIndex));
                }
                else
                {
                    return View(securityType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Security Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerSecutiyTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var secTypes = _context.SecurityTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                secTypes = secTypes.Where(secType =>
                    secType.SecTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "SecTypeNmbr" ? "" : "SecTypeNmbr";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "SecTypeNmbr":
                    secTypes = secTypes.OrderBy(secType => secType.SecTypeNmbr).ToList();
                    break;
                default:
                    secTypes = secTypes.OrderByDescending(secType => secType.SecTypeNmbr).ToList();
                    break;
            }

            return View(secTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerSecurityTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerSecurityTypeCreate(SecurityType securityType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'security_type', '1', '1', '{securityType.SecTypeNmbr}', '{securityType.SecTypeNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Security Type created successfully.";
                    return RedirectToAction(nameof(ParameterMakerSecutiyTypeIndex));
                }
                else
                {
                    return View(securityType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Security Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerAppStatusTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var appStatusTypes = _context.AppStatusTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                appStatusTypes = appStatusTypes.Where(appStatusType =>
                    appStatusType.AppStatusNmbr.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "AppStatusNmbr" ? "" : "AppStatusNmbr";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "AppStatusNmbr":
                    appStatusTypes = appStatusTypes.OrderBy(appStatusType => appStatusType.AppStatusNmbr).ToList();
                    break;
                default:
                    appStatusTypes = appStatusTypes.OrderByDescending(appStatusType => appStatusType.AppStatusNmbr).ToList();
                    break;
            }

            return View(appStatusTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerAppStatusTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerAppStatusTypeCreate(AppStatusType appStatusType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'app_status_type', '1', '1', '{appStatusType.AppStatusNmbr}', '{appStatusType.AppStatusNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "App Status Type created successfully.";
                    return RedirectToAction(nameof(ParameterMakerAppStatusTypeIndex));
                }
                else
                {
                    return View(appStatusType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating App Status Type: " + ex.Message;
                return View("Error");
            }
        }
        public async Task<IActionResult> ParameterMakerInvestmentType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 10;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var investmentTypes = await _context.InvTypes.ToListAsync(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                investmentTypes = investmentTypes.Where(investmentType =>
                investmentType.InvTypeNm.ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "InvTypeNm" ? "" : "InvTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "InvTypeNm":
                    investmentTypes = investmentTypes.OrderBy(investmentType => investmentType.InvTypeNm).ToList();
                    break;
                default:
                    investmentTypes = investmentTypes.OrderByDescending(investmentType => investmentType.InvTypeNm).ToList();
                    break;
            }

            return View(investmentTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerJobFunction(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var jobFunctions = _context.JobVctnTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                jobFunctions = jobFunctions.Where(jobFunction =>
                    jobFunction.JobVctnNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "JobVctnNm" ? "" : "JobVctnNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "JobVctnNm":
                    jobFunctions = jobFunctions.OrderBy(jobFunction => jobFunction.JobVctnNm).ToList();
                    break;
                default:
                    jobFunctions = jobFunctions.OrderByDescending(jobFunction => jobFunction.JobVctnNm).ToList();
                    break;
            }

            return View(jobFunctions.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerMailingAddressType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var mailingAddressTypes = _context.MailAddrTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                mailingAddressTypes = mailingAddressTypes.Where(mailingAddressType =>
                    mailingAddressType.MailAddrNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "MailAddrNm" ? "" : "MailAddrNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "MailAddrNm":
                    mailingAddressTypes = mailingAddressTypes.OrderBy(mailingAddressType => mailingAddressType.MailAddrNm).ToList();
                    break;
                default:
                    mailingAddressTypes = mailingAddressTypes.OrderByDescending(mailingAddressType => mailingAddressType.MailAddrNm).ToList();
                    break;
            }

            return View(mailingAddressTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerMailingAddressTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerMailingAddressTypeCreate(MailAddrType mailingAddressType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'mail_addr_type', '1', '1', '{mailingAddressType.MailAddrOpt}', '{mailingAddressType.MailAddrNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Mailing Address Type created successfully.";
                    return RedirectToAction(nameof(ParameterMakerMailingAddressType));
                }
                else
                {
                    return View(mailingAddressType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Mailing Address Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerJobLevelType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var jobLevelTypes = _context.JobLvlTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                jobLevelTypes = jobLevelTypes.Where(jobLevelType =>
                    jobLevelType.JobLvlNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "JobLvlNm" ? "" : "JobLvlNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "JobLvlNm":
                    jobLevelTypes = jobLevelTypes.OrderBy(jobLevelType => jobLevelType.JobLvlNm).ToList();
                    break;
                default:
                    jobLevelTypes = jobLevelTypes.OrderByDescending(jobLevelType => jobLevelType.JobLvlNm).ToList();
                    break;
            }

            return View(jobLevelTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerJobLevelTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerJobLevelTypeCreate(JobLvlType jobLevelType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'job_lvl_type', '1', '1', '{jobLevelType.JobLvlNmbr}', '{jobLevelType.JobLvlNm}', '{jobLevelType.OldTypeNmbr}', '{jobLevelType.LastChangeDt}', null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Job Level Type created successfully.";
                    return RedirectToAction(nameof(ParameterMakerJobLevelType)); // Ganti dengan nama aksi index sesuai kebutuhan
                }
                else
                {
                    return View(jobLevelType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Job Level Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerProvince(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 10;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var provinces = _context.Provinces.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                provinces = provinces.Where(provincess =>
                    provincess.ProvinceNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "ProvinceNm" ? "" : "ProvinceNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "ProvinceNm":
                    provinces = provinces.OrderBy(name => name.ProvinceNm).ToList();
                    break;
                default:
                    provinces = provinces.OrderByDescending(name => name.ProvinceNm).ToList();
                    break;
            }

            return View(provinces.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerProvinceCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerProvinceCreate(Province province)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'province', '1', '1', '{province.ProvinceNmbr}', '{province.ProvinceNm}', '{province.OldTypeNmbr}', '{province.LastChangeDt.ToString("yyyy-MM-dd HH:mm:ss")}', null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Province created successfully.";
                    return RedirectToAction(nameof(ParameterMakerProvince));
                }
                else
                {
                    return View(province);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Province: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterBeneficiaryRelationType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var beneficiaryRelationTypes = _context.BeneRelationTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                beneficiaryRelationTypes = beneficiaryRelationTypes.Where(relationType =>
                    relationType.RelationNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "RelationNm" ? "" : "RelationNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "RelationNm":
                    beneficiaryRelationTypes = beneficiaryRelationTypes.OrderBy(relationType => relationType.RelationNm).ToList();
                    break;
                default:
                    beneficiaryRelationTypes = beneficiaryRelationTypes.OrderByDescending(relationType => relationType.RelationNm).ToList();
                    break;
            }

            return View(beneficiaryRelationTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterBeneficiaryRelationTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterBeneficiaryRelationTypeCreate(BeneRelationType relationType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'bene_relation_type', '1', '1', '{relationType.BeneRltnNmbr}', '{relationType.RelationNm}', '{relationType.OldTypeNmbr}', '{relationType.LastChangeDt.ToString("yyyy-MM-dd HH:mm:ss")}', null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Beneficiary Relation Type created successfully.";
                    return RedirectToAction(nameof(ParameterBeneficiaryRelationType));
                }
                else
                {
                    return View(relationType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Beneficiary Relation Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerMaturityType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var maturityTypes = _context.MaturityTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                maturityTypes = maturityTypes.Where(maturityType =>
                    maturityType.MaturityTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "MaturityTypeNm" ? "" : "MaturityTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "MaturityTypeNm":
                    maturityTypes = maturityTypes.OrderBy(maturityType => maturityType.MaturityTypeNm).ToList();
                    break;
                default:
                    maturityTypes = maturityTypes.OrderByDescending(maturityType => maturityType.MaturityTypeNm).ToList();
                    break;
            }

            return View(maturityTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerMaturityTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerMaturityTypeCreate(MaturityType maturityType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string formattedDate = maturityType.LastChangeDt?.ToString();
                    var sql = $"exec sp_Insert_Parameter_all 'maturity_type', '1', '1', '{maturityType.MaturityTypeNm}', '{maturityType.OldTypeNmbr}', '{formattedDate}', null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Maturity Type created successfully.";
                    return RedirectToAction(nameof(ParameterMakerMaturityType));
                }
                else
                {
                    return View(maturityType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Maturity Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMcpType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var mcpTypes = _context.McpTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                mcpTypes = mcpTypes.Where(mcpType =>
                mcpType.McpNmbr.ToString().Contains(searchString.ToLower()) ||
                mcpType.McpNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "McpNm" ? "" : "McpNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "McpNm":
                    mcpTypes = mcpTypes.OrderBy(mcpType => mcpType.McpNm).ToList();
                    break;
                default:
                    mcpTypes = mcpTypes.OrderByDescending(mcpType => mcpType.McpNm).ToList();
                    break;
            }

            return View(mcpTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerMcpTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerMcpTypeCreate(McpType mcpType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'mcp_type', '1', '1', '{mcpType.McpNmbr}', '{mcpType.McpNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "MCP Type created successfully.";
                    return RedirectToAction(nameof(ParameterMcpType)); // Ganti dengan nama aksi index sesuai kebutuhan
                }
                else
                {
                    return View(mcpType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating MCP Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterSunGLType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var sunGLTypes = _context.SunGlTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                sunGLTypes = sunGLTypes.Where(sunGLType =>
                    sunGLType.SunTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "SunTypeNm" ? "" : "SunTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "SunTypeNm":
                    sunGLTypes = sunGLTypes.OrderBy(sunGLType => sunGLType.SunTypeNm).ToList();
                    break;
                default:
                    sunGLTypes = sunGLTypes.OrderByDescending(sunGLType => sunGLType.SunTypeNm).ToList();
                    break;
            }

            return View(sunGLTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerSunGLTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerSunGLTypeCreate(SunGlType sunGLType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'sun_gl_type', '1', '1', '{sunGLType.SunTypeNmbr}', '{sunGLType.SunTypeNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);
                    TempData["SuccessMessage"] = "Request data sent successfully";

                    return RedirectToAction(nameof(ParameterSunGLType));
                }
                else
                {
                    return View(sunGLType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Sun GL Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerChargeType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var chargeTypes = _context.ChargeTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                chargeTypes = chargeTypes.Where(chargeType =>
                    chargeType.ChargeTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "ChargeTypeNm" ? "" : "ChargeTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "ChargeTypeNm":
                    chargeTypes = chargeTypes.OrderBy(chargeType => chargeType.ChargeTypeNm).ToList();
                    break;
                default:
                    chargeTypes = chargeTypes.OrderByDescending(chargeType => chargeType.ChargeTypeNm).ToList();
                    break;
            }

            return View(chargeTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerChargeTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerChargeTypeCreate(ChargeType chargeType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'charge_type', '1', '1', '{chargeType.ChargeTypeNmbr}', '{chargeType.ChargeTypeNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);
                    TempData["SuccessMessage"] = "Request data sent successfully";

                    return RedirectToAction(nameof(ParameterMakerChargeType));
                }
                else
                {
                    return View("ParameterMakerChargeTypeCreate", chargeType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Charge Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerMoneySource(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var moneySources = _context.MnySrcs.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                moneySources = moneySources.Where(moneySource =>
                    moneySource.MnySrcNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "MnySrcNm" ? "" : "MnySrcNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "MnySrcNm":
                    moneySources = moneySources.OrderBy(moneySource => moneySource.MnySrcNm).ToList();
                    break;
                default:
                    moneySources = moneySources.OrderByDescending(moneySource => moneySource.MnySrcNm).ToList();
                    break;
            }

            return View(moneySources.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerMoneySourceCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerMoneySourceCreate(MnySrc moneySource)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'mny_src', '1', '1', '{moneySource.MnySrcType}', '{moneySource.MnySrcNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);
                    TempData["SuccessMessage"] = "Request data sent successfully";

                    return RedirectToAction(nameof(ParameterMakerMoneySource));
                }
                else
                {
                    return View("ParameterMakerMoneySourceCreate", moneySource);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Money Source: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerSuspenseAdminApprovalType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var suspenseAdminApprovalTypes = _context.SuspnAdmApprvTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                suspenseAdminApprovalTypes = suspenseAdminApprovalTypes.Where(suspenseAdminApprovalType =>
                    suspenseAdminApprovalType.AdmApprvTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "AdmApprvTypeNm" ? "" : "AdmApprvTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "AdmApprvTypeNm":
                    suspenseAdminApprovalTypes = suspenseAdminApprovalTypes.OrderBy(suspenseAdminApprovalType => suspenseAdminApprovalType.AdmApprvTypeNm).ToList();
                    break;
                default:
                    suspenseAdminApprovalTypes = suspenseAdminApprovalTypes.OrderByDescending(suspenseAdminApprovalType => suspenseAdminApprovalType.AdmApprvTypeNm).ToList();
                    break;
            }

            return View(suspenseAdminApprovalTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerSuspenseAdminApprovalTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerSuspenseAdminApprovalTypeCreate(SuspnAdmApprvType suspenseAdminApprovalType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'suspense_admin_approval_type', '1', '1', '{suspenseAdminApprovalType.AdmApprvTypeNmbr}','{suspenseAdminApprovalType.AdmApprvTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Suspense Admin Approval Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerSuspenseAdminApprovalType));
                }
                else
                {
                    return View("ParameterMakerSuspenseAdminApprovalTypeCreate", suspenseAdminApprovalType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Suspense Admin Approval Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerChargesRateDetail(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var chargesRateDetails = _context.RateTableDetails.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                chargesRateDetails = chargesRateDetails.Where(chargesRateDetail =>
                    chargesRateDetail.RateTypeNmbr.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "RateTypeNmbr" ? "" : "RateTypeNmbr";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "RateTypeNmbr":
                    chargesRateDetails = chargesRateDetails.OrderBy(chargesRateDetail => chargesRateDetail.RateTypeNmbr).ToList();
                    break;
                default:
                    chargesRateDetails = chargesRateDetails.OrderByDescending(chargesRateDetail => chargesRateDetail.RateTypeNmbr).ToList();
                    break;
            }

            return View(chargesRateDetails.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerChargesRateDetailCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerChargesRateDetailCreate(RateTableDetail rateTableDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'rate_table_detail', '1', '1', '{rateTableDetail.RateTypeNmbr}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Request data sent";
                    return RedirectToAction(nameof(ParameterMakerChargesRateDetail));
                }
                else
                {
                    return View(rateTableDetail);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Rate Table Detail Charges: " + ex.Message;
                return View("Error");
            }
        }
        //EROR
        public IActionResult ParameterMakerMoneyType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var moneyTypesQuery = _context.MoneyTypes.AsQueryable();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                moneyTypesQuery = moneyTypesQuery.Where(moneyType =>
                    moneyType.MoneyTypeNm.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }

            ViewBag.PageSize = new List<SelectListItem>
                {
                    new SelectListItem { Value = "5", Text = "5" },
                    new SelectListItem { Value = "10", Text = "10" },
                    new SelectListItem { Value = "15", Text = "15" },
                    new SelectListItem { Value = "20", Text = "20" }
                };

            ViewBag.SortOrder = sortOrder == "MoneyTypeNm" ? "" : "MoneyTypeNm";
            ViewBag.CurrentSort = sortOrder;

            var sortedMoneyTypes = sortOrder switch
            {
                "MoneyTypeNm" => moneyTypesQuery.OrderBy(moneyType => moneyType.MoneyTypeNm),
                _ => moneyTypesQuery.OrderByDescending(moneyType => moneyType.MoneyTypeNm)
            };

            return View(sortedMoneyTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerMoneyTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerMoneyTypeCreate(MoneyType moneyType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'money_type', '1', '1', '{moneyType.MoneyTypeNmbr}','{moneyType.MoneyTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Money Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerMoneyType));
                }
                else
                {
                    return View("ParameterMakerMoneyTypeCreate", moneyType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Money Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerSuspenseFinanceApproveType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var suspenseFinanceApproveTypes = _context.SuspnFinApprvTypes.ToList(); // untuk manggil datanya
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                suspenseFinanceApproveTypes = suspenseFinanceApproveTypes.Where(suspenseFinanceApproveType =>
                    suspenseFinanceApproveType.FinApprvTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "FinApprvTypeNm" ? "" : "FinApprvTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "FinApprvTypeNm":
                    suspenseFinanceApproveTypes = suspenseFinanceApproveTypes.OrderBy(suspenseFinanceApproveType => suspenseFinanceApproveType.FinApprvTypeNm).ToList();
                    break;
                default:
                    suspenseFinanceApproveTypes = suspenseFinanceApproveTypes.OrderByDescending(suspenseFinanceApproveType => suspenseFinanceApproveType.FinApprvTypeNm).ToList();
                    break;
            }

            return View(suspenseFinanceApproveTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerSuspenseFinanceApproveTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerSuspenseFinanceApproveTypeCreate(SuspnFinApprvType suspenseFinanceApproveType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'suspn_finApprv_type', '1', '1', '{suspenseFinanceApproveType.FinApprvTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Suspense Finance Approve Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerSuspenseFinanceApproveType));
                }
                else
                {
                    return View("ParameterMakerSuspenseFinanceApproveTypeCreate", suspenseFinanceApproveType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Suspense Finance Approve Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerChargesRateMaster(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var chargesRateMasters = _context.RateTableTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                chargesRateMasters = chargesRateMasters.Where(chargesRateMaster =>
                    chargesRateMaster.RateTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "RateTypeNm" ? "" : "RateTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "RateTypeNm":
                    chargesRateMasters = chargesRateMasters.OrderBy(chargesRateMaster => chargesRateMaster.RateTypeNm).ToList();
                    break;
                default:
                    chargesRateMasters = chargesRateMasters.OrderByDescending(chargesRateMaster => chargesRateMaster.RateTypeNm).ToList();
                    break;
            }

            return View(chargesRateMasters.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerChargesRateMasterCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerChargesRateMasterCreate(RateTableType rateTableType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'rate_table_type', '1', '1', '{rateTableType.RateTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Charges Rate Master created successfully";

                    return RedirectToAction(nameof(ParameterMakerChargesRateMaster));
                }
                else
                {
                    return View("ParameterMakerChargesRateMasterCreate", rateTableType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Charges Rate Master: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerPaymentApprovalType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var paymentApprovalTypes = _context.PaymentApprvTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                paymentApprovalTypes = paymentApprovalTypes.Where(paymentApprovalType =>
                    paymentApprovalType.PaymentApprvNm != null && paymentApprovalType.PaymentApprvNm.ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PaymentApprvNm" ? "" : "PaymentApprvNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PaymentApprvNm":
                    paymentApprovalTypes = paymentApprovalTypes.OrderBy(paymentApprovalType => paymentApprovalType.PaymentApprvNm).ToList();
                    break;
                default:
                    paymentApprovalTypes = paymentApprovalTypes.OrderByDescending(paymentApprovalType => paymentApprovalType.PaymentApprvNm).ToList();
                    break;
            }

            return View(paymentApprovalTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerPaymentApprovalTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerPaymentApprovalTypeCreate(PaymentApprvType paymentApprvType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'payment_apprv_type', '2', '1', '{paymentApprvType.PaymentApprvNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Payment Approval Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerPaymentApprovalType));
                }
                else
                {
                    return View("ParameterMakerPaymentApprovalTypeCreate", paymentApprvType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Payment Approval Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerSuspenseStatusType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var suspenseStatusTypes = _context.SuspnStatusTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                suspenseStatusTypes = suspenseStatusTypes.Where(suspenseStatusType =>
                    suspenseStatusType.SuspnStatusNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "SuspnStatusNm" ? "" : "SuspnStatusNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "SuspnStatusNm":
                    suspenseStatusTypes = suspenseStatusTypes.OrderBy(suspenseStatusType => suspenseStatusType.SuspnStatusNm).ToList();
                    break;
                default:
                    suspenseStatusTypes = suspenseStatusTypes.OrderByDescending(suspenseStatusType => suspenseStatusType.SuspnStatusNm).ToList();
                    break;
            }

            return View(suspenseStatusTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerSuspenseStatusTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerSuspenseStatusTypeCreate(SuspnStatusType suspenseStatusType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'suspn_status_Type', '1', '1', '{suspenseStatusType.SuspnStatusNmbr}', '{suspenseStatusType.SuspnStatusNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Suspense Status Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerSuspenseStatusType));
                }
                else
                {
                    return View("ParameterMakerSuspenseStatusTypeCreate", suspenseStatusType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Suspense Status Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerCitizenship(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var citizenships = _context.Citizenships.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                citizenships = citizenships.Where(citizenship =>
                    citizenship.CitizenshipNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CitizenshipNm" ? "" : "CitizenshipNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CitizenshipNm":
                    citizenships = citizenships.OrderBy(citizenship => citizenship.CitizenshipNm).ToList();
                    break;
                default:
                    citizenships = citizenships.OrderByDescending(citizenship => citizenship.CitizenshipNm).ToList();
                    break;
            }

            return View(citizenships.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerCitizenshipCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerCitizenshipCreate(Citizenship citizenship)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'citizenship', '1', '1', '{citizenship.CitizenshipCd}', '{citizenship.CitizenshipNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Citizenship created successfully";

                    return RedirectToAction(nameof(ParameterMakerCitizenship));
                }
                else
                {
                    return View("ParameterMakerCitizenshipCreate", citizenship);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Citizenship: " + ex.Message;
                return View("Error");
            }
        }
        /*        public IActionResult ParameterMakerClaimTransferMethod(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
                {
                    int pageIndex = page ?? 1;
                    int defaultSize = pageSize ?? 5;
                    ViewBag.psize = defaultSize;

                    if (searchString != null)
                    {
                        page = 1;
                    }
                    else
                    {
                        searchString = currentFilter;
                    }

                    var claimTransferMethods = _context.claim.ToList(); 
                    ViewBag.curruentfilter = searchString;

                    if (!string.IsNullOrEmpty(searchString))
                    {
                        claimTransferMethods = claimTransferMethods.Where(claimTransferMethod =>
                            claimTransferMethod.MethodName.ToString().ToLower().Contains(searchString.ToLower())
                        ).ToList();
                    }

                    ViewBag.PageSize = new List<SelectListItem>
                    {
                        new SelectListItem { Value = "5", Text = "5" },
                        new SelectListItem { Value = "10", Text = "10" },
                        new SelectListItem { Value = "15", Text = "15" },
                        new SelectListItem { Value = "20", Text = "20" }
                    };

                    ViewBag.SortOrder = sortOrder == "MethodNmbr" ? "" : "MethodNmbr";
                    ViewBag.CurrentSort = sortOrder;

                    switch (sortOrder)
                    {
                        case "MethodNmbr":
                            claimTransferMethods = claimTransferMethods.OrderBy(claimTransferMethod => claimTransferMethod.MethodNmbr).ToList();
                            break;
                        default:
                            claimTransferMethods = claimTransferMethods.OrderByDescending(claimTransferMethod => claimTransferMethod.MethodNmbr).ToList();
                            break;
                    }

                    return View(claimTransferMethods.ToPagedList(pageIndex, defaultSize));
                }
        */
        //Ini belum
        public IActionResult ParameterMakerCOIStatusRate(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 12;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var coiStatusRates = _context.CoiTypeRates.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                coiStatusRates = coiStatusRates.Where(coiStatusRate =>
                    coiStatusRate.CoiAge.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CoiAge" ? "" : "CoiAge";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CoiAge":
                    coiStatusRates = coiStatusRates.OrderBy(coiStatusRate => coiStatusRate.CoiAge).ToList();
                    break;
                default:
                    coiStatusRates = coiStatusRates.OrderByDescending(coiStatusRate => coiStatusRate.CoiAge).ToList();
                    break;
            }

            return View(coiStatusRates.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerCOIStatusRateCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerCOIStatusRateCreate(CoiTypeRate coiTypeRate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'coi_type_rate', '2', '1', '{coiTypeRate.CoiAge}', '{coiTypeRate.CoiRate}', '{coiTypeRate.CoiAmount}', null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "COI Type Rate created successfully";

                    return RedirectToAction(nameof(ParameterMakerCOIStatusRate));
                }
                else
                {
                    return View("ParameterMakerCOIStatusRateCreate", coiTypeRate);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating COI Type Rate: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerCOISourceType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var coiStatusRates = _context.CoiTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                coiStatusRates = coiStatusRates.Where(coiStatusRate =>
                    coiStatusRate.CoiTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CoiTypeNm" ? "" : "CoiTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CoiTypeNm":
                    coiStatusRates = coiStatusRates.OrderBy(coiStatusRate => coiStatusRate.CoiTypeNm).ToList();
                    break;
                default:
                    coiStatusRates = coiStatusRates.OrderByDescending(coiStatusRate => coiStatusRate.CoiTypeNm).ToList();
                    break;
            }

            return View(coiStatusRates.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerCommisionRelationType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var commisionRelationTypes = _context.CommRltnTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                commisionRelationTypes = commisionRelationTypes.Where(commisionRelationType =>
                    commisionRelationType.CommRltnTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CommRltnTypeNm" ? "" : "CommRltnTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CommRltnTypeNm":
                    commisionRelationTypes = commisionRelationTypes.OrderBy(commisionRelationType => commisionRelationType.CommRltnTypeNm).ToList();
                    break;
                default:
                    commisionRelationTypes = commisionRelationTypes.OrderByDescending(commisionRelationType => commisionRelationType.CommRltnTypeNm).ToList();
                    break;
            }

            return View(commisionRelationTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerCommisionRelationTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerCommisionRelationTypeCreate(CommRltnType commRltnType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'comm_rltn_type', '1', '1', '{commRltnType.CommRltnTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Commision Relation Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerCommisionRelationType));
                }
                else
                {
                    return View("ParameterMakerCommisionRelationTypeCreate", commRltnType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Commision Relation Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerCommisionTitleType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var commisionTitleTypes = _context.CommisionTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                commisionTitleTypes = commisionTitleTypes.Where(commisionTitleType =>
                    commisionTitleType.CommisionTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CommisionTypeNm" ? "" : "CommisionTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CommisionTypeNm":
                    commisionTitleTypes = commisionTitleTypes.OrderBy(commisionTitleType => commisionTitleType.CommisionTypeNm).ToList();
                    break;
                default:
                    commisionTitleTypes = commisionTitleTypes.OrderByDescending(commisionTitleType => commisionTitleType.CommisionTypeNm).ToList();
                    break;
            }

            return View(commisionTitleTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerCommisionTitleTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerCommisionTitleTypeCreate(CommisionType commisionType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'commision_type', '1', '1', '{commisionType.CommisionTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Commision Title Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerCommisionTitleType));
                }
                else
                {
                    return View("ParameterMakerCommisionTitleTypeCreate", commisionType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Commision Title Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerCreditCardType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var creditCardTypes = _context.CreditCardTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                creditCardTypes = creditCardTypes.Where(creditCardType =>
                    creditCardType.CreditCardNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CreditCardNm" ? "" : "CreditCardNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CreditCardNm":
                    creditCardTypes = creditCardTypes.OrderBy(creditCardType => creditCardType.CreditCardNm).ToList();
                    break;
                default:
                    creditCardTypes = creditCardTypes.OrderByDescending(creditCardType => creditCardType.CreditCardNm).ToList();
                    break;
            }

            return View(creditCardTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerCurrency(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var currencies = _context.CurrencyTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                currencies = currencies.Where(currency =>
                    currency.CurrencyTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CurrencyTypeNm" ? "" : "CurrencyTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CurrencyTypeNm":
                    currencies = currencies.OrderBy(currency => currency.CurrencyTypeNm).ToList();
                    break;
                default:
                    currencies = currencies.OrderByDescending(currency => currency.CurrencyTypeNm).ToList();
                    break;
            }

            return View(currencies.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerDBInternalAccountNumber(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var dbInternalAccountNumbers = _context.AccTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                dbInternalAccountNumbers = dbInternalAccountNumbers.Where(accountNumber =>
                    accountNumber.AccTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "AccTypeNm" ? "" : "AccTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "AccTypeNm":
                    dbInternalAccountNumbers = dbInternalAccountNumbers.OrderBy(accountNumber => accountNumber.AccTypeNm).ToList();
                    break;
                default:
                    dbInternalAccountNumbers = dbInternalAccountNumbers.OrderByDescending(accountNumber => accountNumber.AccTypeNm).ToList();
                    break;
            }

            return View(dbInternalAccountNumbers.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerExceptionType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var exceptionTypes = _context.ExceptionTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                exceptionTypes = exceptionTypes.Where(exceptionType =>
                    exceptionType.ExceptionTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "ExceptionTypeNm" ? "" : "ExceptionTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "ExceptionTypeNm":
                    exceptionTypes = exceptionTypes.OrderBy(exceptionType => exceptionType.ExceptionTypeNm).ToList();
                    break;
                default:
                    exceptionTypes = exceptionTypes.OrderByDescending(exceptionType => exceptionType.ExceptionTypeNm).ToList();
                    break;
            }

            return View(exceptionTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerFrequencyType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var frequencyTypes = _context.FrequencyTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                frequencyTypes = frequencyTypes.Where(frequencyType =>
                    frequencyType.FreqTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "FreqTypeNm" ? "" : "FreqTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "FreqTypeNm":
                    frequencyTypes = frequencyTypes.OrderBy(frequencyType => frequencyType.FreqTypeNm).ToList();
                    break;
                default:
                    frequencyTypes = frequencyTypes.OrderByDescending(frequencyType => frequencyType.FreqTypeNm).ToList();
                    break;
            }

            return View(frequencyTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerFrequencyTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerFrequencyTypeCreate(FrequencyType frequencyType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'frequency_type', '1', '1', '{frequencyType.FreqTypeNm}', null, null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "Frequency Type created successfully";

                    return RedirectToAction(nameof(ParameterMakerFrequencyType));
                }
                else
                {
                    return View("ParameterMakerFrequencyTypeCreate", frequencyType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Frequency Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerFundSourceType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var fundSourceTypes = _context.FundSrcTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                fundSourceTypes = fundSourceTypes.Where(fundSourceType =>
                    fundSourceType.FundSrcNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "FundSrcNm" ? "" : "FundSrcNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "FundSrcNm":
                    fundSourceTypes = fundSourceTypes.OrderBy(fundSourceType => fundSourceType.FundSrcNm).ToList();
                    break;
                default:
                    fundSourceTypes = fundSourceTypes.OrderByDescending(fundSourceType => fundSourceType.FundSrcNm).ToList();
                    break;
            }

            return View(fundSourceTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPaymentResponsibilityType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var paymentResponsibilityTypes = _context.PayRspnTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                paymentResponsibilityTypes = paymentResponsibilityTypes.Where(paymentResponsibilityType =>
                    paymentResponsibilityType.PayRspnNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PayRspnNm" ? "" : "PayRspnNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PayRspnNm":
                    paymentResponsibilityTypes = paymentResponsibilityTypes.OrderBy(paymentResponsibilityType => paymentResponsibilityType.PayRspnNm).ToList();
                    break;
                default:
                    paymentResponsibilityTypes = paymentResponsibilityTypes.OrderByDescending(paymentResponsibilityType => paymentResponsibilityType.PayRspnNm).ToList();
                    break;
            }

            return View(paymentResponsibilityTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterPaymentTransactionType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var paymentTransactionTypes = _context.PaymentTrnsTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                paymentTransactionTypes = paymentTransactionTypes.Where(paymentTransactionType =>
                    paymentTransactionType.PaymentTrnsNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PaymentTrnsNm" ? "" : "PaymentTrnsNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PaymentTrnsNm":
                    paymentTransactionTypes = paymentTransactionTypes.OrderBy(paymentTransactionType => paymentTransactionType.PaymentTrnsNm).ToList();
                    break;
                default:
                    paymentTransactionTypes = paymentTransactionTypes.OrderByDescending(paymentTransactionType => paymentTransactionType.PaymentTrnsNm).ToList();
                    break;
            }

            return View(paymentTransactionTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPaymentType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var paymentTypes = _context.PaymentTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                paymentTypes = paymentTypes.Where(paymentType =>
                    paymentType.PaymentNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PaymentNm" ? "" : "PaymentNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PaymentNm":
                    paymentTypes = paymentTypes.OrderBy(paymentType => paymentType.PaymentNm).ToList();
                    break;
                default:
                    paymentTypes = paymentTypes.OrderByDescending(paymentType => paymentType.PaymentNm).ToList();
                    break;
            }

            return View(paymentTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPhoneType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var phoneTypes = _context.PhoneTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                phoneTypes = phoneTypes.Where(phoneType =>
                    phoneType.PhoneTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PhoneTypeNm" ? "" : "PhoneTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PhoneTypeNm":
                    phoneTypes = phoneTypes.OrderBy(phoneType => phoneType.PhoneTypeNm).ToList();
                    break;
                default:
                    phoneTypes = phoneTypes.OrderByDescending(phoneType => phoneType.PhoneTypeNm).ToList();
                    break;
            }

            return View(phoneTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPIC(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var pics = _context.Pics.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                pics = pics.Where(pic =>
                    pic.PicName.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PicName" ? "" : "PicName";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PicName":
                    pics = pics.OrderBy(pic => pic.PicName).ToList();
                    break;
                default:
                    pics = pics.OrderByDescending(pic => pic.PicName).ToList();
                    break;
            }

            return View(pics.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPremiumMethod(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var premiumMethods = _context.PremiumMethods.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                premiumMethods = premiumMethods.Where(premiumMethod =>
                    premiumMethod.PremiumMtdNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PremiumMtdNm" ? "" : "PremiumMtdNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PremiumMtdNm":
                    premiumMethods = premiumMethods.OrderBy(premiumMethod => premiumMethod.PremiumMtdNm).ToList();
                    break;
                default:
                    premiumMethods = premiumMethods.OrderByDescending(premiumMethod => premiumMethod.PremiumMtdNm).ToList();
                    break;
            }

            return View(premiumMethods.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPremiumType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var premiumTypes = _context.PremiumTypes.ToList(); // Ganti dengan koleksi yang sesuai
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                premiumTypes = premiumTypes.Where(premiumType =>
                    premiumType.PremiumTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PremiumTypeNm" ? "" : "PremiumTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PremiumTypeNm":
                    premiumTypes = premiumTypes.OrderBy(premiumType => premiumType.PremiumTypeNm).ToList();
                    break;
                default:
                    premiumTypes = premiumTypes.OrderByDescending(premiumType => premiumType.PremiumTypeNm).ToList();
                    break;
            }

            return View(premiumTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerProductType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var productTypes = _context.ProductTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                productTypes = productTypes.Where(productType =>
                    productType.ProductTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "ProductTypeNm" ? "" : "ProductTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "ProductTypeNm":
                    productTypes = productTypes.OrderBy(productType => productType.ProductTypeNm).ToList();
                    break;
                default:
                    productTypes = productTypes.OrderByDescending(productType => productType.ProductTypeNm).ToList();
                    break;
            }

            return View(productTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerPSLType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var pslTypes = _context.PslTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                pslTypes = pslTypes.Where(pslType =>
                    pslType.PslTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "PslTypeNm" ? "" : "PslTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "PslTypeNm":
                    pslTypes = pslTypes.OrderBy(pslType => pslType.PslTypeNm).ToList();
                    break;
                default:
                    pslTypes = pslTypes.OrderByDescending(pslType => pslType.PslTypeNm).ToList();
                    break;
            }

            return View(pslTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerRiderType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var riderTypes = _context.RiderTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                riderTypes = riderTypes.Where(riderType =>
                    riderType.RiderTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "RiderTypeNm" ? "" : "RiderTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "RiderTypeNm":
                    riderTypes = riderTypes.OrderBy(riderType => riderType.RiderTypeNm).ToList();
                    break;
                default:
                    riderTypes = riderTypes.OrderByDescending(riderType => riderType.RiderTypeNm).ToList();
                    break;
            }

            return View(riderTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult CreateRiderType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRiderType(RiderType riderType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'rider_type', '1', '1', '{riderType.RiderTypeNmbr}', '{riderType.RiderTypeNm}', null, null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);
                    TempData["SuccessMessage"] = "Request data sent successfully.";
                    return RedirectToAction(nameof(ParameterMakerRiderType));
                }
                else
                {
                    return View(riderType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating Rider Type: " + ex.Message;
                return View("Error");
            }
        }
        public IActionResult ParameterMakerRoleType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var roleTypes = _context.RoleTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                roleTypes = roleTypes.Where(roleType =>
                    roleType.RoleTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "RoleTypeNm" ? "" : "RoleTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "RoleTypeNm":
                    roleTypes = roleTypes.OrderBy(roleType => roleType.RoleTypeNm).ToList();
                    break;
                default:
                    roleTypes = roleTypes.OrderByDescending(roleType => roleType.RoleTypeNm).ToList();
                    break;
            }

            return View(roleTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerBenefit(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var benefits = _context.BeneTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                benefits = benefits.Where(benefit =>
                    benefit.BeneTypeNm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "BeneTypeNm" ? "" : "BeneTypeNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "BeneTypeNm":
                    benefits = benefits.OrderBy(benefit => benefit.BeneTypeNm).ToList();
                    break;
                default:
                    benefits = benefits.OrderByDescending(benefit => benefit.BeneTypeNm).ToList();
                    break;
            }

            return View(benefits.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerVACurrencyType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var vaCurrencyTypes = _context.VaCurrencyTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                vaCurrencyTypes = vaCurrencyTypes.Where(vaCurrencyType =>
                    vaCurrencyType.CurrencyTypeNmbr.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "CurrencyTypeNmbr" ? "" : "CurrencyTypeNmbr";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "CurrencyTypeNmbr":
                    vaCurrencyTypes = vaCurrencyTypes.OrderBy(vaCurrencyType => vaCurrencyType.CurrencyTypeNmbr).ToList();
                    break;
                default:
                    vaCurrencyTypes = vaCurrencyTypes.OrderByDescending(vaCurrencyType => vaCurrencyType.CurrencyTypeNmbr).ToList();
                    break;
            }

            return View(vaCurrencyTypes.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerVAOrganisation(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var vaOrganisations = _context.VaDplkTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                vaOrganisations = vaOrganisations.Where(vaOrganisation =>
                    vaOrganisation.DplkNmbr.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "DplkNmbr" ? "" : "DplkNmbr";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "DplkNmbr":
                    vaOrganisations = vaOrganisations.OrderBy(vaOrganisation => vaOrganisation.DplkNmbr).ToList();
                    break;
                default:
                    vaOrganisations = vaOrganisations.OrderByDescending(vaOrganisation => vaOrganisation.DplkNmbr).ToList();
                    break;
            }

            return View(vaOrganisations.ToPagedList(pageIndex, defaultSize));
        }
        public IActionResult ParameterMakerVAProductType(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var vaProductTypes = _context.VaProductTypes.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                vaProductTypes = vaProductTypes.Where(vaProductType =>
                    vaProductType.VaNmbr.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "VaNmbr" ? "" : "VaNmbr";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "VaNmbr":
                    vaProductTypes = vaProductTypes.OrderBy(vaProductType => vaProductType.VaNmbr).ToList();
                    break;
                default:
                    vaProductTypes = vaProductTypes.OrderByDescending(vaProductType => vaProductType.VaNmbr).ToList();
                    break;
            }

            return View(vaProductTypes.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ParameterMakerVAProductTypeCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ParameterMakerVAQProductTypeCreate(VaProductType vaProductType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sql = $"exec sp_Insert_Parameter_all 'va_product_type', '1', '1', '{vaProductType.VaNmbr}', '{vaProductType.ProductTypeNmbr}', '{vaProductType.LastChangeDt}', null, null, null";
                    _context.Database.ExecuteSqlRaw(sql);

                    TempData["SuccessMessage"] = "VA Product Type created successfully.";
                    return RedirectToAction(nameof(ParameterMakerVAProductType));
                }
                else
                {
                    return View("ParameterMakerVAProductTypeCreate", vaProductType);
                }
            }
            catch (System.Exception ex)
            {
                ViewBag.ErrorMessage = "Error creating VA Product Type: " + ex.Message;
                return View("Error");
            }
        }
        [HttpPost]
        public IActionResult PaymentApproval(int group_nmbr, int seq_nmbr, int trnsType, int paycenter_nmbr)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_approve_payment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@group_nmbr", group_nmbr);
                    cmd.Parameters.AddWithValue("@seq_nmbr", seq_nmbr);
                    cmd.Parameters.AddWithValue("@trnsType", trnsType);
                    cmd.Parameters.AddWithValue("@paycenter_nmbr", paycenter_nmbr);
                    cmd.Parameters.AddWithValue("@approveFlg", 1);
                    cmd.Parameters.AddWithValue("@user_nm", "User123");

                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToAction("PaymentApproval");
        }
        public async Task<IActionResult> AuditTrail(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)

        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 10;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var auditTrail = await _context.AuditTrails.ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                auditTrail = auditTrail.Where(search =>
                    search.AppNm.ToLower().Contains(searchString) ||
                    search.TableNm.ToLower().Contains(searchString) ||
                    search.FieldNm.ToLower().Contains(searchString) ||
                    search.UsrId.ToLower().Contains(searchString) ||
                    search.HostNm.ToLower().Contains(searchString) ||
                    search.OldData.ToLower().Contains(searchString) ||
                    search.NewData.ToLower().Contains(searchString) ||
                    search.Info1.ToLower().Contains(searchString) ||
                    search.Info2.ToLower().Contains(searchString) ||
                    search.Info3.ToLower().Contains(searchString)

                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>()
                {
                    new SelectListItem() { Value="20", Text= "20" },
                    new SelectListItem() { Value="25", Text= "25" },
                    new SelectListItem() { Value="30", Text= "30" },
                    new SelectListItem() { Value="50", Text= "50" }
                };
            ViewBag.SortOrder = sortOrder == "AppNm" ? "" : "AppNm";
            ViewBag.CurrentSort = sortOrder;
            switch (sortOrder)
            {
                case "AppNm":
                    auditTrail = auditTrail.OrderBy(search => search.AppNm).ToList();
                    break;
                default:
                    auditTrail = auditTrail.OrderByDescending(search => search.AppNm).ToList();
                    break;
            }

            return View(auditTrail.ToPagedList(pageIndex, defaultSize));


        }

        public async Task<IActionResult> SetupAgentIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var agentMasters = await _context.AgentMasters.ToListAsync();

            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                agentMasters = agentMasters.Where(item =>
                    item.AgentNm != null &&
                    item.AgentNm.ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "AgentNm" ? "" : "AgentNm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "AgentNm":
                    agentMasters = agentMasters.OrderBy(item => item.AgentNm).ToList();
                    break;
                default:
                    agentMasters = agentMasters.OrderByDescending(item => item.AgentNm).ToList();
                    break;
            }

            return View(agentMasters.ToPagedList(pageIndex, defaultSize));
        }


        [HttpGet]
        public IActionResult SetupAgentCreate(int? agentNumber)
        {
            AgentMaster agentMaster = agentNumber.HasValue ? LoadAgentData(agentNumber.Value) : new AgentMaster();

            return View(agentMaster);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetupAgentCreate(AgentMaster model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.AgentMasters.Add(model);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Agent data created. Agent Code: " + model.AgentNmbr;
                    return RedirectToAction(nameof(SetupAgentIndex));
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while processing your request.");
                }
            }

            return View(model);
        }

        /*
                [HttpPost]
                public IActionResult SetupAgentCreate(AgentMaster agentMaster)
                {
                    try
                    {
                        if (ModelState.IsValid)
                        {
                            if (string.IsNullOrEmpty(agentMaster.AgentNmbr))
                            {
                                ModelState.AddModelError("", "Agent Number is required.");
                            }
                            else
                            {
                                SaveAgentData(agentMaster);
                                TempData["SuccessMessage"] = "Agent data saved successfully";
                                return RedirectToAction(nameof(SetupAgentCreate));
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        ModelState.AddModelError("", "An error occurred while saving agent data: " + ex.Message);
                    }

                    return View(agentMaster);
                }*/
        private AgentMaster LoadAgentData(int agentNumber)
        {
            AgentMaster agentMaster = new AgentMaster();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("usp_agent_master_r", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@agent_nmbr", agentNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                agentMaster.AgentNm = reader["agent_nm"].ToString();
                                agentMaster.EmployeeCode = reader["employee_code"].ToString();
                                agentMaster.BirthDt = (DateTime)reader["birth_dt"];
                                agentMaster.Address = reader["address"].ToString();
                                agentMaster.City = reader["city"].ToString();
                                agentMaster.PostalCd = reader["postal_cd"].ToString();
                                agentMaster.PhoneNmbr = reader["phone_nmbr"].ToString();
                                agentMaster.MobilePhone = reader["mobile_phone"].ToString();
                                agentMaster.Email = reader["email"].ToString();
                                agentMaster.AcctNmbr = reader["acct_nmbr"].ToString();
                                agentMaster.AcctNm = reader["acct_nm"].ToString();
                                agentMaster.BankNm = reader["bank_nm"].ToString();
                                agentMaster.BankAddress = reader["bank_address"].ToString();
                                agentMaster.AgentStatus = reader["agent_status"].ToString();
                                agentMaster.TaxIdNmbr = reader["tax_id_nmbr"].ToString();
                                agentMaster.AgentType = reader["agent_type"].ToString();
                                agentMaster.OldAgentNmbr = reader["old_agent_nmbr"].ToString();
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while loading agent data.");
            }

            return agentMaster;
        }

        private void SaveAgentData(AgentMaster agentMaster)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand("usp_agent_master_iu", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@agent_nmbr", agentMaster.AgentNmbr);
                    command.Parameters.AddWithValue("@agent_nm", agentMaster.AgentNm);
                    command.Parameters.AddWithValue("@employee_code", agentMaster.EmployeeCode);
                    command.Parameters.AddWithValue("@birth_dt", agentMaster.BirthDt);
                    command.Parameters.AddWithValue("@address", agentMaster.Address);
                    command.Parameters.AddWithValue("@city", agentMaster.City);
                    command.Parameters.AddWithValue("@postal_cd", agentMaster.PostalCd);
                    command.Parameters.AddWithValue("@phone_nmbr", agentMaster.PhoneNmbr);
                    command.Parameters.AddWithValue("@mobile_phone", agentMaster.MobilePhone);
                    command.Parameters.AddWithValue("@email", agentMaster.Email);
                    command.Parameters.AddWithValue("@acct_nmbr", agentMaster.AcctNmbr);
                    command.Parameters.AddWithValue("@acct_nm", agentMaster.AcctNm);
                    command.Parameters.AddWithValue("@bank_nm", agentMaster.BankNm);
                    command.Parameters.AddWithValue("@bank_address", agentMaster.BankAddress);
                    command.Parameters.AddWithValue("@agent_status", agentMaster.AgentStatus);
                    command.Parameters.AddWithValue("@tax_id_nmbr", agentMaster.TaxIdNmbr);
                    command.Parameters.AddWithValue("@agent_type", agentMaster.AgentType);
                    command.Parameters.AddWithValue("@old_agent_nmbr", agentMaster.OldAgentNmbr);

                    command.ExecuteNonQuery();
                }

                TempData["SuccessMessage"] = "Agent data saved successfully";
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while saving agent data: " + ex.Message);
            }
        }

        public IActionResult ProssesClaimRequest(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            return View();
        }


        [HttpGet]
        public IActionResult SetupBank()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetupBank(DbBank dbBank)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("usp_db_bank_i", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@bank_code", int.Parse(dbBank.BankNmbr));
                            command.Parameters.AddWithValue("@bank_nm", dbBank.BankNm);
                            command.Parameters.AddWithValue("@bank_addr", dbBank.BankAddr);

                            command.ExecuteNonQuery();
                        }
                    }
                    TempData["SuccessMessage"] = "Bank created successfully.";
                    ViewBag.SuccessMessage = "Bank setup successfully!";
                }
                catch (System.Exception ex)
                {
                    ViewBag.ErrorMessage = "Error: " + ex.Message;
                }
            }

            return View(dbBank);
        }

        /*   [HttpGet]
           public IActionResult GetAgentInfo(string agentNmbr)
           {
               if (!string.IsNullOrEmpty(agentNmbr))
               {
                   using (SqlConnection connection = new SqlConnection(_connectionString))
                   {
                       connection.Open();

                       using (SqlCommand command = new SqlCommand("usp_agent_master_r", connection))
                       {
                           command.CommandType = CommandType.StoredProcedure;
                           command.Parameters.AddWithValue("@agent_nmbr", agentNmbr);

                           using (SqlDataReader reader = command.ExecuteReader())
                           {
                               if (reader.Read())
                               {
                                   var agentInfo = new
                                   {
                                       agent_nm = reader["agent_nm"],
                                   };

                                   return Json(agentInfo);
                               }
                           }
                       }
                   }
               }

               return Json(null);
           }
    */

        public async Task<IActionResult> AgentCommision(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 20;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            /*            var agentCommisions = await _context.AgentCommMethods.ToListAsync();
            */
            var agentCommisions = _context.AgentCommisions.FromSqlRaw("EXEC DGR_ON_SCR_AGENT_COMMISION").ToList();

            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                agentCommisions = agentCommisions.Where(item =>
                    item.agent_nm != null &&
                    item.agent_nm.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "agent_nm" ? "" : "agent_nm";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "agent_nm":
                    agentCommisions = agentCommisions.OrderBy(item => item.agent_nm).ToList();
                    break;
                default:
                    agentCommisions = agentCommisions.OrderByDescending(item => item.agent_nm).ToList();
                    break;
            }

            return View(agentCommisions.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult SetupAgentCreateCommision()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetupAgentCreateCommision(AgentCommMethod agentCommMethod)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string query = $"exec usp_agent_comm_method_iu {agentCommMethod.GroupNmbr}, {agentCommMethod.AgentNmbr}, '{agentCommMethod.EfctvDt}', {agentCommMethod.CommPct}, {agentCommMethod.CommAmt}, {agentCommMethod.MaxComm}, '{agentCommMethod.TerminationDt}'";
                    _context.Database.ExecuteSqlRaw(query);
                    _context.SaveChanges();

                    TempData["SuccessMessage"] = "Data has been saved.";
                    return RedirectToAction(nameof(SetupAgentCreateCommision));
                }
                catch (System.Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Error: " + ex.Message);
                }
            }

            return View(agentCommMethod);
        }


        /*  [HttpGet]
          public async Task<JsonResult> GetAgentName(string name)
          {
              try
              {
                  var agentName = await _context.AgentMasters
                      .Where(a => a.AgentNmbr.ToString().Contains(name))
                      .Select(a => a.AgentNm)
                      .ToListAsync();

                  return Json(agentName);
              }
              catch (System.Exception ex)
              {
                  return Json(new { Error = "An error occurred: " + ex.Message });
              }
          }*/
        [HttpGet]
        public JsonResult GetAgentName(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("select agent_nmbr from agent_master where agent_nmbr = @agent_nm", connection))
                    {
                        command.Parameters.AddWithValue("@agent_nm", name);
                        int groupNumber = (int)command.ExecuteScalar();

                        return Json(new { GroupNumber = groupNumber });
                    }
                }
            }
            catch (System.Exception ex)
            {
                return Json(new { Error = "An error occurred: " + ex.Message });
            }
        }

        public IActionResult PengantarKartuApproval(PengantarKartu pengantar)
        {
            return View();
        }
        public IActionResult PaymentForApproval(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var payments = _context.PaymentForApprovals.FromSqlRaw("EXEC sp_get_payment_forApproval").ToList();

            ViewBag.currentFilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                payments = payments.Where(payment =>
                    payment.CompanyName.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            ViewBag.PageSize = new List<int> { 5, 10, 15, 20 };
            ViewBag.SortOrder = string.IsNullOrEmpty(sortOrder) ? "GroupNumber_desc" : "";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "GroupNumber_desc":
                    payments = payments.OrderByDescending(p => p.GroupNumber).ToList();
                    break;
                default:
                    payments = payments.OrderBy(p => p.GroupNumber).ToList();
                    break;
            }

            return View(payments.ToPagedList(pageIndex, defaultSize));
        }

        public IActionResult PayoutSuspense(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 5;
            int defaultSize = pageSize ?? 5;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var payments = _context.SuspenseRecords.FromSqlRaw("EXEC GRID_SUSPNREST_ON_SCR_SUSPENSEAPPROVED").ToList();

            ViewBag.currentFilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                payments = payments.Where(payment =>
                    payment.company_nm.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            ViewBag.PageSize = new List<int> { 5, 10, 15, 20 };
            ViewBag.SortOrder = string.IsNullOrEmpty(sortOrder) ? "company_nm" : "";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "company_nm":
                    payments = payments.OrderByDescending(p => p.company_nm).ToList();
                    break;
                default:
                    payments = payments.OrderBy(p => p.company_nm).ToList();
                    break;
            }

            return View(payments.ToPagedList(pageIndex, defaultSize));
        }
        [HttpGet]
        public IActionResult ProcessClaimRequest()
        {
            DDL();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcessClaimRequest(VClaimRequest2 claimRequest)
        {
            DDL();
            return View();
        }
        private List<SelectListItem> GetCompanyNamesFromDatabase()
        {
            List<SelectListItem> companyNames = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT DISTINCT [company name] FROM V_CLAIM_REQUEST_2 ORDER BY 1", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string companyName = reader.GetString(0);
                        companyNames.Add(new SelectListItem { Value = companyName, Text = companyName });
                    }
                }
            }

            return companyNames;
        }
        private List<SelectListItem> GetTransactionTypes()
        {
            List<SelectListItem> transactionTypes = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("select sub_trns_nmbr, sub_trns_nm from trns_type where trns_type_nmbr=400 order by 2", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int subTrnsNmbr = reader.GetInt32(0);
                        string subTrnsNm = reader.GetString(1);

                        transactionTypes.Add(new SelectListItem { Value = subTrnsNmbr.ToString(), Text = subTrnsNm });
                    }
                }
            }

            return transactionTypes;
        }


        public IActionResult MutationsFunds(int sourceCer, string sourceNm, float amount, string processorId, int destinationCer, string destinationNm)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("sp_mutation_fund", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@source_cer", sourceCer);
                    command.Parameters.AddWithValue("@source_nm", sourceNm);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.Parameters.AddWithValue("@processor_id", processorId);
                    command.Parameters.AddWithValue("@destination_cer", destinationCer);
                    command.Parameters.AddWithValue("@destination_nm", destinationNm);

                    var result = new MutationResult();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.result = reader["result"].ToString();
                        }
                    }

                    return View(result);
                }
            }
        }

        [HttpGet]
        public IActionResult EntryNota()
        {
            DDL();
            return View();
        }
        [HttpPost]
        public IActionResult EntryNota(TNotaHeader nota)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("SPD_NOTA_DEBET_INSERT", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@No_Nota", nota.NoNota);
                    command.Parameters.AddWithValue("@No_Kontrak", nota.NoKontrak);
                    command.Parameters.AddWithValue("@Tgl_Jatuh_Tempo", nota.TglJatuhTempo);
                    command.Parameters.AddWithValue("@Jml_Karyawan", nota.JmlKaryawan);
                    command.Parameters.AddWithValue("@Jangka_Pembayaran", nota.JangkaPembayaran);
                    command.Parameters.AddWithValue("@Tgl_Terbit", nota.TglTerbit);
                    command.Parameters.AddWithValue("@Kantor_Perwakilan", nota.KantorPerwakilan);
                    command.Parameters.AddWithValue("@Up", nota.Up);
                    command.Parameters.AddWithValue("@Nama_Perusahaan", nota.NamaPerusahaan);
                    command.Parameters.AddWithValue("@Alamat1", nota.Alamat1);
                    command.Parameters.AddWithValue("@Alamat2", nota.Alamat2);
                    command.Parameters.AddWithValue("@Alamat3", nota.Alamat3);
                    command.Parameters.AddWithValue("@Kode_Pos", nota.KodePos);
                    command.Parameters.AddWithValue("@Perihal", nota.Perihal);
                    command.Parameters.AddWithValue("@Nama_Bank", nota.NamaBank);
                    command.Parameters.AddWithValue("@Cabang_Bank", nota.CabangBank);
                    command.Parameters.AddWithValue("@No_Rekening", nota.NoRekening);
                    command.Parameters.AddWithValue("@Atas_Nama", nota.AtasNama);
                    command.Parameters.AddWithValue("@Penyetuju", nota.Penyetuju);
                    command.Parameters.AddWithValue("@hostname", "your_hostname");
                    command.Parameters.AddWithValue("@UserID", "your_user_id");

                    command.ExecuteNonQuery();
                }
            }

            return RedirectToAction("EntryNota");
        }

        public IActionResult SuspensePayoutApproval()
        {
            List<SuspensePayoutViewModel> suspensePayouts = new List<SuspensePayoutViewModel>();


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT seq_nmbr, regisid, cer_nmbr, client_nm, " +
                    "COALESCE(bank_nm, '') AS bank_nm, COALESCE(bank_address, '') AS bank_address, " +
                    "acct_nmbr, acct_nm, amount, check_amt, amount - check_amt AS net_amt, " +
                    "Remarks, Suspense_nmbr, Prepare_by, approval_dt " +
                    "FROM retur_info " +
                    "WHERE approval_dt IS NULL " +
                    "ORDER BY retur_dt ASC;", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SuspensePayoutViewModel payout = new SuspensePayoutViewModel
                            {
                                SeqNmbr = Convert.ToInt32(reader["seq_nmbr"]),
                                RegisId = reader["regisid"].ToString(),
                                CerNmbr = Convert.ToInt32(reader["cer_nmbr"]),
                                ClientNm = reader["client_nm"].ToString(),
                                BankNm = reader["bank_nm"].ToString(),
                                BankAddress = reader["bank_address"].ToString(),
                                AcctNmbr = reader["acct_nmbr"].ToString(),
                                AcctNm = reader["acct_nm"].ToString(),
                                Amount = Convert.ToDecimal(reader["amount"]),
                                CheckAmt = Convert.ToDecimal(reader["check_amt"]),
                                NetAmt = Convert.ToDecimal(reader["net_amt"]),
                                Remarks = reader["Remarks"].ToString(),
                                SuspenseNmbr = Convert.ToInt32(reader["Suspense_nmbr"]),
                                PrepareBy = reader["Prepare_by"].ToString(),
                                ApprovalDt = reader["approval_dt"] == DBNull.Value ? null : (DateTime?)reader["approval_dt"]
                            };
                            suspensePayouts.Add(payout);
                        }
                    }
                }
            }

            return View(suspensePayouts);
        }

        /*        public IActionResult KartuIndividu()
                {
                    List<GetKartuIndividu> suratKeluarList = new List<GetKartuIndividu>();

                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(
                            "SELECT DISTINCT sk.no_surat, sk.ditujukan, sk.tgl_surat, cl.client_nm, pk.cer_nmbr " +
                            "FROM svrapp.dbhr.dbo.t_admsrt_surat_keluar sk " +
                            "INNER JOIN pengantar_kartu pk ON pk.no_surat = sk.no_surat " +
                            "INNER JOIN certificate cer ON cer.cer_nmbr = pk.cer_nmbr " +
                            "INNER JOIN client cl ON cl.client_nmbr = cer.client_nmbr " +
                            "WHERE cer.group_nmbr IN (10078, 10341, 10343, 10344, 10345, 10346) " +
                            "AND status_surat = 0 " +
                            "ORDER BY sk.tgl_surat DESC;", connection))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GetKartuIndividu suratKeluar = new GetKartuIndividu
                                {
                                    NoSurat = reader.GetString(0),
                                    Ditujukan = reader.GetString(1),
                                    TglSurat = reader.GetDateTime(2),
                                    ClientNm = reader.GetString(3),
                                    CerNmbr = reader.GetInt32(4)
                                };

                                suratKeluarList.Add(suratKeluar);
                            }
                        }
                    }

                    return View(suratKeluarList);
                }
        */
        public async Task<JsonResult> KartuIndividu(string name)
        {
            var kartuIndivu = await _context.GetKartuIndividus
                .FromSqlRaw("SELECT DISTINCT sk.no_surat, sk.ditujukan, sk.tgl_surat, cl.client_nm, pk.cer_nmbr " +
                            "FROM svrapp.dbhr.dbo.t_admsrt_surat_keluar sk " +
                            "INNER JOIN pengantar_kartu pk ON pk.no_surat = sk.no_surat " +
                            "INNER JOIN certificate cer ON cer.cer_nmbr = pk.cer_nmbr " +
                            "INNER JOIN client cl ON cl.client_nmbr = cer.client_nmbr " +
                            "WHERE cer.group_nmbr IN (10078, 10341, 10343, 10344, 10345, 10346) " +
                            "AND status_surat = 0 " +
                            "ORDER BY sk.tgl_surat DESC")
                .ToListAsync();

            return Json(kartuIndivu);
        }

        public IActionResult JoinAccount()
        {
            return View();
        }

        public async Task<IActionResult> AccountListing()
        {
            var result = await _context.AccountListingModels.FromSqlRaw("EXEC sp_join_account_listing").ToListAsync();

            return View(result);
        }
        public IActionResult JoinAccountCreate()
        {
            return View(new JoinAccountCheckingResult());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult JointAccountCheck(JoinAccountCheckingResult input)
        {
            if (ModelState.IsValid)
            {
                List<JoinAccountCheckingResult> results = CallStoredProcedures(input);

                if (results != null)
                {
                    return View("Result", results);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "An error occurred while processing the request.");
                }
            }

            return View("Create", input);
        }

        private List<JoinAccountCheckingResult> CallStoredProcedures(JoinAccountCheckingResult input)
        {
            try
            {
                var cerNmbrSrcParam = new SqlParameter("@cer_nmbr_src", input.CerNmbrSrc);
                var cerNmbrDstParam = new SqlParameter("@cer_nmbr_dst", input.CerNmbrDst);
                var efctvDtParam = new SqlParameter("@efctv_dt", input.EfctvDt);
                var trnsTypeParam = new SqlParameter("@trns_type", input.TrnsType);
                var groupNmbrParam = new SqlParameter("@group_nmbr", SqlDbType.Int);
                groupNmbrParam.Value = (object)input.GroupNmbr ?? DBNull.Value;

                var results = _context.JoinAccountCheckingResults.FromSqlRaw(
                    "EXEC sp_join_account_cheking @cer_nmbr_src, @cer_nmbr_dst, @efctv_dt, @trns_type, @group_nmbr",
                    cerNmbrSrcParam, cerNmbrDstParam, efctvDtParam, trnsTypeParam, groupNmbrParam
                ).ToList();

                return results;
            }
            catch (System.Exception ex)
            {

                return null;
            }
        }

        /*  public IActionResult UploadNewParticipant()
          {
              return View();
          }

          [HttpPost]
          public IActionResult UploadNewParticipant(SpdFtp model, IFormFile uploadedFile)
          {
              if (ModelState.IsValid)
              {
                  try
                  {
                      if (uploadedFile != null && uploadedFile.Length > 0)
                      {
                          // Lokasi untuk menyimpan file yang diunggah
                          string uploadPath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                          string fileName = Path.GetFileName(uploadedFile.FileName);
                          string filePath = Path.Combine(uploadPath, fileName);

                          if (!Directory.Exists(uploadPath))
                          {
                              Directory.CreateDirectory(uploadPath);
                          }

                          using (var stream = new FileStream(filePath, FileMode.Create))
                          {
                              uploadedFile.CopyTo(stream);
                          }

                          string fileExtension = Path.GetExtension(fileName).ToLower();
                          if (fileExtension == ".xls" || fileExtension == ".xlsx")
                          {
                              using (var package = new ExcelPackage(new FileInfo(filePath)))
                              {
                                  var worksheet = package.Workbook.Worksheets[0];

                                  for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                                  {
                                      var participant = new UploadNewParticipant
                                      {
                                          GroupNumber = worksheet.Cells[row, 1].Value.ToString(),
                                          Gender = worksheet.Cells[row, 2].Value.ToString(),
                                          Nip = worksheet.Cells[row, 3].Value.ToString(),
                                          Client_Name = worksheet.Cells[row, 4].Value.ToString(),
                                      };

                                      _context.UploadNewParticipants.Add(participant);
                                  }

                                  _context.SaveChanges(); // Simpan perubahan ke database
                              }
                          }
                          else
                          {
                              ModelState.AddModelError(string.Empty, "Format file yang diunggah tidak valid. Harap unggah file Excel (XLS atau XLSX).");
                              return View(model);
                          }

                          return RedirectToAction("ActionSetelahUpload");
                      }
                      else
                      {
                          ModelState.AddModelError(string.Empty, "Anda harus memilih file untuk diunggah.");
                          return View(model);
                      }
                  }
                  catch (System.Exception ex)
                  {
                      _logger.LogError(ex, "Terjadi kesalahan saat mengunggah atau memproses data.");
                      ModelState.AddModelError(string.Empty, "Terjadi kesalahan saat mengunggah atau memproses data.");
                  }
              }

              return View(model);
          }*/

        public IActionResult UploadParticipant()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadParticipant(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError(string.Empty, "Please select a file to upload.");
                return View();
            }

            if (Path.GetExtension(file.FileName).ToLower() != ".xlsx")
            {
                ModelState.AddModelError(string.Empty, "Please upload a valid Excel file (.xlsx).");
                return View();
            }

            try
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Proses file Excel dan simpan data ke database
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var participant = new UploadNewParticipant
                        {
                            GroupNumber = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
                            Gender = worksheet.Cells[row, 2].Value.ToString(),
                            Nip = worksheet.Cells[row, 3].Value.ToString(),
                            ClientName = worksheet.Cells[row, 4].Value.ToString(),
                            MaidenName = worksheet.Cells[row, 5].Value.ToString(),
                            Dob = DateTime.Parse(worksheet.Cells[row, 6].Value.ToString()),
                            DobLocation = worksheet.Cells[row, 7].Value.ToString(),
                            CoverageDate = DateTime.Parse(worksheet.Cells[row, 8].Value.ToString()),
                            EmploymentDate = DateTime.Parse(worksheet.Cells[row, 9].Value.ToString()),
                            EmploymentLevel = int.Parse(worksheet.Cells[row, 10].Value.ToString()),
                            RetirementAge = int.Parse(worksheet.Cells[row, 11].Value.ToString()),
                            IdentityType = int.Parse(worksheet.Cells[row, 12].Value.ToString()),
                            IdentityNumber = worksheet.Cells[row, 13].Value.ToString(),
                            MaritalStatus = int.Parse(worksheet.Cells[row, 14].Value.ToString()),
                            TaxIdNumber = worksheet.Cells[row, 15].Value.ToString(),
                            Citizenship = int.Parse(worksheet.Cells[row, 16].Value.ToString()),
                            ApplicationReceivedDate = DateTime.Parse(worksheet.Cells[row, 17].Value.ToString()),
                            CompletedFlag = int.Parse(worksheet.Cells[row, 18].Value.ToString()),
                            JobType = int.Parse(worksheet.Cells[row, 19].Value.ToString()),
                            FundSource = int.Parse(worksheet.Cells[row, 20].Value.ToString()),
                            AddressType = int.Parse(worksheet.Cells[row, 21].Value.ToString()),
                            Address1 = worksheet.Cells[row, 22].Value.ToString(),
                            Address2 = worksheet.Cells[row, 23].Value.ToString(),
                            Address3 = worksheet.Cells[row, 24].Value.ToString(),
                            City = worksheet.Cells[row, 25].Value.ToString(),
                            Province = int.Parse(worksheet.Cells[row, 26].Value.ToString()),
                            PostalCode = worksheet.Cells[row, 27].Value.ToString(),
                            HomePhone = worksheet.Cells[row, 28].Value.ToString(),
                            MobilePhone = worksheet.Cells[row, 29].Value.ToString(),
                            Fax = worksheet.Cells[row, 30].Value.ToString(),
                            OfficePhone = worksheet.Cells[row, 31].Value.ToString(),
                            Paycenter = int.Parse(worksheet.Cells[row, 32].Value.ToString()),
                            SalaryAmount = double.Parse(worksheet.Cells[row, 33].Value.ToString()),
                            BeneTypeNmbr = int.Parse(worksheet.Cells[row, 34].Value.ToString()),
                            SumInsured = double.Parse(worksheet.Cells[row, 35].Value.ToString()),
                            BeneficiaryName1 = worksheet.Cells[row, 36].Value.ToString(),
                            BeneficiaryDob1 = DateTime.Parse(worksheet.Cells[row, 37].Value.ToString()),
                            BeneficiaryRelation1 = int.Parse(worksheet.Cells[row, 38].Value.ToString()),
                            BeneficiaryName2 = worksheet.Cells[row, 39].Value.ToString(),
                            BeneficiaryDob2 = DateTime.Parse(worksheet.Cells[row, 40].Value.ToString()),
                            BeneficiaryRelation2 = int.Parse(worksheet.Cells[row, 41].Value.ToString()),
                            BeneficiaryName3 = worksheet.Cells[row, 42].Value.ToString(),
                            BeneficiaryDob3 = DateTime.Parse(worksheet.Cells[row, 43].Value.ToString()),
                            BeneficiaryRelation3 = int.Parse(worksheet.Cells[row, 44].Value.ToString()),
                            BeneficiaryName4 = worksheet.Cells[row, 45].Value.ToString(),
                            BeneficiaryDob4 = DateTime.Parse(worksheet.Cells[row, 46].Value.ToString()),
                            BeneficiaryRelation4 = int.Parse(worksheet.Cells[row, 47].Value.ToString()),
                            BeneficiaryName5 = worksheet.Cells[row, 48].Value.ToString(),
                            BeneficiaryDob5 = DateTime.Parse(worksheet.Cells[row, 49].Value.ToString()),
                            BeneficiaryRelation5 = int.Parse(worksheet.Cells[row, 50].Value.ToString()),
                            ContributionRateEr = double.Parse(worksheet.Cells[row, 51].Value.ToString()),
                            ContributionAmountEr = double.Parse(worksheet.Cells[row, 52].Value.ToString()),
                            ContributionRateMbr = double.Parse(worksheet.Cells[row, 53].Value.ToString()),
                            ContributionAmountMbr = double.Parse(worksheet.Cells[row, 54].Value.ToString()),
                            ContributionRateTu = double.Parse(worksheet.Cells[row, 55].Value.ToString()),
                            ContributionAmountTu = double.Parse(worksheet.Cells[row, 56].Value.ToString()),
                            ContributionRateFt = double.Parse(worksheet.Cells[row, 57].Value.ToString()),
                            ContributionAmountFt = double.Parse(worksheet.Cells[row, 58].Value.ToString()),
                            InvestmentType1 = int.Parse(worksheet.Cells[row, 59].Value.ToString()),
                            InvestmentRate1 = double.Parse(worksheet.Cells[row, 60].Value.ToString()),
                            InvestmentType2 = int.Parse(worksheet.Cells[row, 61].Value.ToString()),
                            InvestmentRate2 = double.Parse(worksheet.Cells[row, 62].Value.ToString()),
                            InvestmentType3 = int.Parse(worksheet.Cells[row, 63].Value.ToString()),
                            InvestmentRate3 = double.Parse(worksheet.Cells[row, 64].Value.ToString()),
                            InvestmentType4 = int.Parse(worksheet.Cells[row, 65].Value.ToString()),
                            InvestmentRate4 = double.Parse(worksheet.Cells[row, 66].Value.ToString()),
                            InvestmentType5 = int.Parse(worksheet.Cells[row, 67].Value.ToString()),
                            InvestmentRate5 = double.Parse(worksheet.Cells[row, 68].Value.ToString()),
                            Hostname = worksheet.Cells[row, 69].Value.ToString(),
                            OldCerNmbr = worksheet.Cells[row, 70].Value.ToString(),
                            Branch = worksheet.Cells[row, 71].Value.ToString(),
                            SalesName = worksheet.Cells[row, 72].Value.ToString(),
                            Mail = worksheet.Cells[row, 73].Value.ToString()
                        };


                        _context.UploadNewParticipants.Add(participant);
                    }

                    await _context.SaveChangesAsync();
                }

                ViewBag.Message = "File uploaded and data processed successfully.";
            }
            catch (System.Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
            }

            return View();
        }

    }
}






