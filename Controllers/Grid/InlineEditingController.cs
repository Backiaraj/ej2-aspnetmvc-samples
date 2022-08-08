﻿using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: InlineEditing
        public ActionResult InlineEditing()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            ViewBag.ddData = new string[] { "Top", "Bottom" };
            return View();
        }
    }
}