using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLabs.DTOs.Level3;
using AppLabs.Operations.Level3;

namespace AppLabsMVC.Controllers
{
    public class Level3Controller : Controller
    {
        //
        // GET: /Level3/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LcmRequest()
        {
            var model = new Fractions();
            return View(model);
        }

        [HttpPost]
        public ActionResult LcmResult(Fractions fractions)
        {
            if (ModelState.IsValid)
            {
                var f = new LcmFinder();
                fractions.CommonDenom = f.Execute(fractions.Input1, fractions.Input2);
            }
            else
            {
                return View("LcmRequest", fractions);
            }
            
            
            return View(fractions);

        }
	}
}