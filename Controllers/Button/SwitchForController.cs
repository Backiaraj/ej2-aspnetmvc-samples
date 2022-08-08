using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EJ2MVCSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult SwitchFor()
        {
            SwitchModel model = new SwitchModel();
            model.check = true;
            return View(model);
        }

        [HttpPost]
        public ActionResult SwitchFor(SwitchModel model)
        {
            return View(model);
        }
    }

    public class SwitchModel
    {
        [Range(typeof(bool), "true", "true", ErrorMessage = "You need to agree to receive newsletter")]
        public bool check { get; set; }
    }

}