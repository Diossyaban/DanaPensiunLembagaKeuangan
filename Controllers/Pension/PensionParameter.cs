using DPLK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace DPLK.Controllers.Pension
{
    public class PensionParameter : Controller
    {
        private readonly PensionContext _context;
        private readonly string _connectionString;
        public PensionParameter(ILogger<PensionParameter> logger, PensionContext context, IConfiguration configuration)
        {
            
            _context = context;

            _connectionString = configuration.GetConnectionString("Pension");
        }
        public IActionResult ParameterApproval()
        {
            return View();
        }
        public async Task<IActionResult> ParameterApprovalIDTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
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
            var idTypes = await _context.TidTypes.ToListAsync();
            ViewBag.curruentfilter = searchString;
            if (!string.IsNullOrEmpty(searchString))
            {
                idTypes = idTypes.Where(id =>
                    id.IdentityNm.ToString().ToLower().Contains(searchString.ToLower())
                    ).ToList();
            }

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
        public IActionResult ParameterApprovalAddressTypeIndex(string searchString, string currentFilter, string sortOrder, int? page, int? pageSize)
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

            var addressTypes = _context.TaddressTypes.ToList();
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

            var suspenseStatusTypes = _context.SuspnStatusTypes.ToList(); // Ganti dengan koleksi yang sesuai
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

            var coiStatusRates = _context.CoiTypes.ToList(); // Ganti dengan koleksi yang sesuai
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
    }
}