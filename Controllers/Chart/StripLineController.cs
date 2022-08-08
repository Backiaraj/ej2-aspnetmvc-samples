﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: StripLine
        public ActionResult StripLine()
        {

            List<StripLineChartData> chartData = new List<StripLineChartData>
            {
               new StripLineChartData { x = "Sun", y = 25 },
               new StripLineChartData { x = "Mon", y = 27 },
               new StripLineChartData { x = "Tue", y = 33 },
               new StripLineChartData { x = "Wed", y = 36 },
               new StripLineChartData { x = "Thu", y = 26 },
               new StripLineChartData { x = "Fri", y = 27.5 },
               new StripLineChartData { x = "Sat", y = 23 }
            };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "Vertical", "Horizontal", "Segment" };
           return View();
        }
        public class StripLineChartData
        {
            public string x;
            public double y;
        }
    }
}