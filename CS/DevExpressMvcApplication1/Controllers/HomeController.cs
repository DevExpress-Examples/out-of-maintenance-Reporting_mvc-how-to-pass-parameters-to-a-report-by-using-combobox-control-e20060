using System.IO;
using System.Web.Mvc;
using DevExpress.XtraPrinting.InternalAccess;
using DevExpress.XtraReports.UI;
using DevExpressMvcApplication1.Models;
using DevExpressMvcApplication1.Reports;
using System.Linq;
using System;
// ...

namespace DevExpressMvcApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            ViewData["Categories"] = new NorthwindEntities().Categories;
            return View();
        }

        public ActionResult CallbackPanelPartial() {
            return PartialView("CallbackPanelPartial");
        }

        public ActionResult ReportViewerPartial() {
            var categoryId = Request.Params["CategoryID"].ToString() != "null" ? Request.Params["CategoryID"] : null;
            ViewData["Report"] = GetReport(categoryId);
            return PartialView("ReportViewerPartial");
        }

        public ActionResult ExportReportViewerPartial() {
            return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(GetReport(Session["CategoryID"].ToString()));
        }

        XtraReport GetReport(object categoryID) {
            XtraReport1 report = new XtraReport1();

            if (categoryID != null)
                report.CatId.Value = Convert.ToInt32(categoryID);
            else
                report.FilterString = string.Empty;

            report.DataSourceDemanded += (s, e) => {
                ((XtraReport)s).DataSource = new NorthwindEntities().Products;
            };

            return report;
        }
    }
}
