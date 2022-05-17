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

        // POST: HR/AddConsultancyServices
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

        // POST: HR/AddConsultancyServices
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
