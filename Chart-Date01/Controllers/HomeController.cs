using Chart_Date01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chart_Date01.Controllers
{
    public class HomeController : Controller
    {
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult diagramma()
		{
			return View();
		}
		public ContentResult CSV()
		{
			List<DataPoint> dataPoints = new List<DataPoint>();

			dataPoints.Add(new DataPoint(new DateTime(2015, 01, 01),  3));
			dataPoints.Add(new DataPoint(new DateTime(2015, 02, 01),    2.4));
			dataPoints.Add(new DataPoint(new DateTime(2015, 03, 01),  5));

			//dataPoints.Add(new DataPoint(new DateTime(2015, 04, 01), 336969900));

			string csv = "";

			foreach (DataPoint DataPoint in dataPoints)
			{
				csv += DataPoint.X.ToString("yyyy-MM-dd") + "," + DataPoint.Y.ToString() + "\n";
			}

			return Content(csv);
		}
	}
}