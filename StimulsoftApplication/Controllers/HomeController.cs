using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.Web.Mvc;
namespace StimulsoftApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult GetReport()
		{
			var report = StiReport.CreateNewReport();
			var path = Server.MapPath("~/Reports/VehicleProduction.mrt");
			report.Load(path);
			return StiMvcDesigner.GetReportResult(report);
		}
		public ActionResult SaveReport()
		{
			var report = StiMvcDesigner.GetReportObject();
			var path = Server.MapPath("~/Reports/VehicleProduction.mrt");
			report.Save(path);
			return StiMvcDesigner.SaveReportResult();
		}
		public ActionResult DesignerEvent()
		{
			return StiMvcDesigner.DesignerEventResult();
		}
	}
}