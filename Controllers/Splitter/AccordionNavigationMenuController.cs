﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;
namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SplitterController : Controller
    {
        List<AccordionAccordionItem> accItems = new List<AccordionAccordionItem>();
        // GET: AccordionNavigation
        public ActionResult AccordionNavigationMenu()
        {
            accItems.Add(new AccordionAccordionItem { Header = "ASP.NET", Expanded = true, Content = "<div id='nested_Acc1'></div>" });
            accItems.Add(new AccordionAccordionItem { Header = "ASP.NET MVC", Content = "<div id='nested_Acc2'></div>" });
            accItems.Add(new AccordionAccordionItem { Header = "JavaScript", Content = "<div id='nested_Acc3'></div>" });
            ViewBag.AccordionItems = accItems;
            return View();
        }
    }
}