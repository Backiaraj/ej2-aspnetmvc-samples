#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class DateTimePickerController : Controller
    {
        // GET: DefaultFunctionalities
        public ActionResult DateRange()
        {
            ViewBag.value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 09, 11, 00, 00);
            ViewBag.minDate =new DateTime(DateTime.Now.Year, DateTime.Now.Month, 07, 10, 00, 00);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27, 22, 30, 00);
            return View();
        }
    }
}