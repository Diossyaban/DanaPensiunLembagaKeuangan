using DPLK.Controllers.CashManagement;
using DPLK.Controllers.Pension;
using DPLK.ModelAcc;
using DPLK.ModelAcc.dto;
using DPLK.Models.context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using static System.Net.WebRequestMethods;

namespace DPLK.Controllers.Accounting
{
    public class AccountingController : Controller
    {
        private readonly PensionContext _context;
        private readonly PensionAccContext _contextAcc;
        private readonly string _connectionString;
        private readonly string _connectionStrings;

        public AccountingController(ILogger<AccountingController> logger, PensionContext context, PensionAccContext contextAcc, IConfiguration configuration)
        {
            _context = context;
            _contextAcc = contextAcc;
            _connectionString = configuration.GetConnectionString("Pension");
            _connectionStrings = configuration.GetConnectionString("PensionAcc");
        }

        private List<SelectListItem> GetDDLFund()
        {
            List<SelectListItem> transactionTypes = new List<SelectListItem>();

            using (SqlConnection connection = new SqlConnection(_connectionStrings))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT owner, descr FROM SPD_FUND_MAPPING order by 2", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string owner = reader.GetString(0);
                        string description = reader.GetString(1);

                        transactionTypes.Add(new SelectListItem { Value = owner, Text = description });
                    }
                }
            }

            return transactionTypes;
        }
        private void DDL()
        {
            ViewData["GetAdd"] = GetDDLFund();

        }
        public IActionResult CreateJurnal()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SetupBankIndex()
        {
            /* List<FLPPEntry> banks = _context.FLPPEntries.FromSqlRaw("SELECT * FROM BankTypes").ToList();
 */
            // Kirim data ke view untuk ditampilkan
            return View();
        }
        public IActionResult GLIndex()
        {
            return View();
        }
        public IActionResult GLPajakIndex()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateFLPFPPEntryFLP()
        {
            return View();
        }

        // POST: Accounting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFLPFPPEntryFLP([Bind("TrnsId,GlCode,Slcode,TrnsTypeNmbr,SubTrnsNmbr,Inv,Company,Grp,CerNmbr,MonthPeriod,YearPeriod,Description,Debet,Credit,DateJurnal,Correction")] SpdJurnalTemp spdJurnalTemp)
        {
            if (ModelState.IsValid)
            {
                _contextAcc.Add(spdJurnalTemp);
                await _contextAcc.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spdJurnalTemp);
        }

        public IActionResult CreateFLPFPPEntryFPP()
        {
            return View();
        }
        public IActionResult UnapprovedPenerimaan()
        {
            return View();
        }
        public IActionResult UnapprovedPembayaran()
        {
            return View();
        }
        public IActionResult PostedCDVCRV()
        {
            return View();
        }

        public IActionResult UnapprovedJurnalMemorial()
        {
            return View();
        }
        public IActionResult PostedMemorialJurnal()
        {
            return View();
        }

        //public IActionResult QueryFLPPendingApproval()
        //{
        //    List<FundData> jurnalData = new List<FundData>();

        //    using (SqlConnection connection = new SqlConnection(_connectionStrings))

        //    {
        //        string sql = "SELECT [ID] = a.trns_id, a.Description, [Jurnal Date] = CONVERT(VARCHAR(15), DateJurnal, 106), " +
        //                     "[Amount] = CONVERT(VARCHAR(100), CONVERT(MONEY, CASE WHEN Debet > 0 THEN Debet ELSE Credit END), 1), " +
        //                     "[Fund] = b.descr, correction = CASE WHEN correction = 1 THEN 'Correction' ELSE '' END " +
        //                     "FROM SPD_JURNAL_TEMP a INNER JOIN (SELECT owner, descr FROM SPD_FUND_MAPPING) b ON a.inv = b.owner " +
        //                     "WHERE trns_type_nmbr LIKE '22222%' AND sub_trns_nmbr = '0' AND a.trns_id LIKE '%ACCIDR%' " +
        //                     "AND a.trns_id IN (SELECT DISTINCT new_trns_id FROM SPD_JURNAL_KONSOLIDASI_MAPPING WHERE status = 5) " +
        //                     "ORDER BY a.DateJurnal";

        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            connection.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    FundData data = new FundData
        //                    {
        //                        ID = reader["ID"].ToString(),
        //                        Description = reader["Description"].ToString(),
        //                        JurnalDate = reader["Jurnal Date"].ToString(),
        //                        Amount = reader["Amount"].ToString(),
        //                        Fund = reader["Fund"].ToString(),
        //                        Correction = reader["correction"].ToString()
        //                    };

        //                    jurnalData.Add(data);
        //                }
        //            }
        //        }
        //    }

        //    return View(jurnalData);
        //}


        /*        public async Task<IActionResult> QueryFLPPendingApproval()
                {
                    var deleteJurnals = await _contextAcc.FundDatas
                        .FromSqlRaw("SELECT [ID] = a.trns_id, a.Description, [Jurnal Date] = CONVERT(VARCHAR(15), DateJurnal, 106), [Amount] = CONVERT(VARCHAR(100), CONVERT(MONEY, CASE WHEN Debet > 0 THEN Debet ELSE Credit END), 1), [Fund] = b.descr, correction = CASE WHEN correction = 1 THEN 'Correction' ELSE '' END FROM SPD_JURNAL_TEMP a INNER JOIN (SELECT owner, descr FROM SPD_FUND_MAPPING) b ON a.inv = b.owner WHERE trns_type_nmbr LIKE '22222%' AND sub_trns_nmbr = '0' AND a.trns_id LIKE '%ACCIDR%' AND a.trns_id IN (SELECT DISTINCT new_trns_id FROM SPD_JURNAL_KONSOLIDASI_MAPPING WHERE status = 5) ORDER BY a.DateJurnal")
                        .ToListAsync();

                    return View(deleteJurnals);
                }*/


        public IActionResult QueryFLPPendingApproval(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
        {
            int pageIndex = page ?? 1;
            int defaultSize = pageSize ?? 100;
            ViewBag.psize = defaultSize;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var jobLevelTypes = _contextAcc.SpdJurnalTemps.ToList();
            ViewBag.curruentfilter = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                jobLevelTypes = jobLevelTypes.Where(jobLevelType =>
                    jobLevelType.TrnsId.ToString().ToLower().Contains(searchString.ToLower())
                ).ToList();
            }

            ViewBag.PageSize = new List<SelectListItem>
            {
                new SelectListItem { Value = "5", Text = "5" },
                new SelectListItem { Value = "10", Text = "10" },
                new SelectListItem { Value = "15", Text = "15" },
                new SelectListItem { Value = "20", Text = "20" }
            };

            ViewBag.SortOrder = sortOrder == "TrnsId" ? "" : "TrnsId";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "TrnsId":
                    jobLevelTypes = jobLevelTypes.OrderBy(jobLevelType => jobLevelType.TrnsId).ToList();
                    break;
                default:
                    jobLevelTypes = jobLevelTypes.OrderByDescending(jobLevelType => jobLevelType.TrnsId).ToList();
                    break;
            }

            return View(jobLevelTypes.ToPagedList(pageIndex, defaultSize));
        }

        [HttpPost]
        public IActionResult CreateJurnal(string trnsId, string description, DateTime dateJurnal, string owner, int type, int correction)
        {

            using (SqlConnection connection = new SqlConnection(_connectionStrings))
            {
                using (SqlCommand command = new SqlCommand("SPD_JURNAL_ACC_INSERT", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@trns_id", SqlDbType.VarChar).Value = trnsId;
                    command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;
                    command.Parameters.Add("@datejurnal", SqlDbType.DateTime).Value = dateJurnal;
                    command.Parameters.Add("@owner", SqlDbType.VarChar).Value = owner;
                    command.Parameters.Add("@type", SqlDbType.Int).Value = type;
                    command.Parameters.Add("@correction", SqlDbType.Int).Value = correction;

                    connection.Open();
                    string newTrnsId = command.ExecuteScalar()?.ToString();
                    DDL();

                    return Ok(newTrnsId);
                }
            }

        }
    }
}