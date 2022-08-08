﻿using EJ2MVCSampleBrowser.Models;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult SearchEvents()
        {
            ViewBag.datasource = new ScheduleData().GetScheduleData();
            return View();
        }
    }
}