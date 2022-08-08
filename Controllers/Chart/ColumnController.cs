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
        // GET: Column
        public ActionResult Column()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "USA", yValue= 46, yValue1=37, yValue2=38 },
                new ColumnChartData { x= "GBR", yValue= 27, yValue1=23, yValue2=17 },
                new ColumnChartData { x= "CHN", yValue= 26, yValue1=18, yValue2=26 }
            };
            ViewBag.dataSource = chartData;
            ViewBag.Font = new { fontWeight = "600", color = "#ffffff" };
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }
    }
}