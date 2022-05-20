using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRMSNUML.Data;
using HRMSNUML.Models;

namespace HRMSNUML.Controllers
{
    public class HRController : Controller
    {
        private HRMSNUMLContext db = new HRMSNUMLContext();

        // GET: HR/AddConsultancyServices
        public ActionResult AddConsultancyServices()
        {
            return View();
        }

        // GET: HR/AddNotification
        public ActionResult AddNotifications()
        {
            return View();
        }

        // GET: HR/AddIPRight
        public ActionResult AddIPRight()
        {
            List<SelectListItem> ddlDesignation = new List<SelectListItem>();
            List<Designations> _VMDesignationDetail = new List<Designations>();
            ddlDesignation.Add(new SelectListItem { Text = "Select", Value = "" });
            _VMDesignationDetail = db.Designations.ToList();
            foreach (var item in _VMDesignationDetail)
            {
                ddlDesignation.Add(new SelectListItem { Text = item.Title, Value = item.DesignationId.ToString() });
            }
            ViewData["ddlDesignation"] = ddlDesignation;


            List<SelectListItem> ddlcategory = new List<SelectListItem>();
            List<Categories> _VMCategory = new List<Categories>();
            ddlcategory.Add(new SelectListItem { Text = "Select", Value = "" });
            _VMCategory = db.Categories.ToList();
            foreach (var item in _VMCategory)
            {
                ddlcategory.Add(new SelectListItem { Text = item.Title, Value = item.IPRightCategoryId.ToString() });
            }

            ViewData["ddlcategory"] = ddlcategory;

            List<SelectListItem> ddldevelopmentstatus = new List<SelectListItem>();
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Select", Value = "" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Videos", Value = "1" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Prototype", Value = "2" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Validation", Value = "3" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Production", Value = "4" });

            ViewData["ddldevelopmentstatus"] = ddldevelopmentstatus;

            List<SelectListItem> ddltype = new List<SelectListItem>();
            ddltype.Add(new SelectListItem { Text = "Select", Value = "" });
            ddltype.Add(new SelectListItem { Text = "National", Value = "1" });
            ddltype.Add(new SelectListItem { Text = "International", Value = "2" });

            ViewData["ddltype"] = ddltype;

            return View();
        }

        // GET: HR/AddCategory
        public ActionResult AddCategory()
        {
            return View();
        }


        // GET: ViewCategory
        public ActionResult ViewCategory()
        {
            return View(db.Categories.ToList());
        }

        // GET: EditCategory
        public ActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = db.Categories.Find(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }

        // GET: DeleteCategory
        public ActionResult DeleteCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categories categories = db.Categories.Find(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddConsultancyServices([Bind(Include = "CS_Id,CS_Title,CS_StartDate,CS_EndDate,CS_CompanyName,CS_Description,CS_Picture,File")] ConsultancyServices consultancyService)
        {
            if (ModelState.IsValid)
            {
                string filename = Path.GetFileName(consultancyService.File.FileName);
                string _filename = DateTime.Now.ToString("hhmmssfff") + filename;
                string path = Path.Combine(Server.MapPath("~/Images/"), _filename);
                consultancyService.CS_Picture = "~/Images/" + _filename;

                db.ConsultancyServices.Add(consultancyService);

                if (db.SaveChanges() > 0)
                {
                    consultancyService.File.SaveAs(path);
                    ViewBag.Message = "Consultancy Services Saved Successfully";
                }

            }

            return View(consultancyService);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNotifications([Bind(Include = "NFT_Id,NTF_Title,NTFDate,NFT_Remarks,NFT_Picture,File")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                string filename = Path.GetFileName(notification.File.FileName);
                string _filename = DateTime.Now.ToString("hhmmssfff") + filename;
                string path = Path.Combine(Server.MapPath("~/Images/"), _filename);
                notification.NFT_Picture = "~/Images/" + _filename;

                db.Notification.Add(notification);

                if (db.SaveChanges() > 0)
                {
                    notification.File.SaveAs(path);
                    ViewBag.Message = "Notification/Miscellaneous Documents Saved Successfully";
                }

            }

            return View(notification);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddIPRight(IPRights ipright)
        {
            List<SelectListItem> ddlDesignation = new List<SelectListItem>();
            List<Designations> _VMDesignationDetail = new List<Designations>();
            ddlDesignation.Add(new SelectListItem { Text = "Select", Value = "" });
            _VMDesignationDetail = db.Designations.ToList();
            foreach (var item in _VMDesignationDetail)
            {
                ddlDesignation.Add(new SelectListItem { Text = item.Title, Value = item.DesignationId.ToString() });
            }
            ViewData["ddlDesignation"] = ddlDesignation;


            List<SelectListItem> ddlcategory = new List<SelectListItem>();
            List<Categories> _VMCategory = new List<Categories>();
            ddlcategory.Add(new SelectListItem { Text = "Select", Value = "" });
            _VMCategory = db.Categories.ToList();
            foreach (var item in _VMCategory)
            {
                ddlcategory.Add(new SelectListItem { Text = item.Title, Value = item.IPRightCategoryId.ToString() });
            }

            ViewData["ddlcategory"] = ddlcategory;

            List<SelectListItem> ddldevelopmentstatus = new List<SelectListItem>();
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Select", Value = "" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Videos", Value = "1" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Prototype", Value = "2" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Validation", Value = "3" });
            ddldevelopmentstatus.Add(new SelectListItem { Text = "Production", Value = "4" });

            ViewData["ddldevelopmentstatus"] = ddldevelopmentstatus;

            List<SelectListItem> ddltype = new List<SelectListItem>();
            ddltype.Add(new SelectListItem { Text = "Select", Value = "" });
            ddltype.Add(new SelectListItem { Text = "National", Value = "1" });
            ddltype.Add(new SelectListItem { Text = "International", Value = "2" });

            ViewData["ddltype"] = ddltype;

            string filename = Path.GetFileName(ipright.File.FileName);
            string _filename = DateTime.Now.ToString("hhmmssfff") + filename;
            string path = Path.Combine(Server.MapPath("~/Images/"), _filename);
            ipright.IPFormCopy = "~/Images/" + _filename;

            IPRights entity = new IPRights
            {
                IPID = ipright.IPID,
                IPInventerName = ipright.IPInventerName,
                IPLeadInventer = ipright.IPLeadInventer,
                DesignationId = ipright.DesignationId,
                IPTitle = ipright.IPTitle,
                IPRightCategoryId = ipright.IPRightCategoryId,
                IPDevelopmentStatus = ipright.IPDevelopmentStatus,
                IPKey_S_Aspects = ipright.IPKey_S_Aspects,
                IPCommericalPartner = ipright.IPCommericalPartner,
                IPFormCopy = ipright.IPFormCopy,
                IPType = ipright.IPType,
                IPF_Support = ipright.IPF_Support,
                IPDescription = ipright.IPDescription,
                IPStatus = ipright.IPStatus,
                IPApprovalDate = ipright.IPApprovalDate,
                IPRegisterDate = ipright.IPRegisterDate,
            };
            db.IPRights.Add(entity);
            if (db.SaveChanges() > 0)
            {
                ipright.File.SaveAs(path);
                ViewBag.Message = "Patent/IP Right Saved Successfully";
            }
            return View();
;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategory(Categories categories)
        {
            Categories entity = new Categories
            {
                IPRightCategoryId = categories.IPRightCategoryId,
                Title = categories.Title,
            };

            db.Categories.Add(entity);
            if (db.SaveChanges() > 0)
            {
                ViewBag.Message = "Category Saved Successfully";
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCategory( Categories categories)
        {
            Categories entity = new Categories
            {
                IPRightCategoryId = categories.IPRightCategoryId,
                Title = categories.Title,
            };

            if (ModelState.IsValid)
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewCategory");
            }
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCategory(int id)
        {
            Categories categories = db.Categories.Find(id);
            db.Categories.Remove(categories);
            db.SaveChanges();
            return RedirectToAction("ViewCategory");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
