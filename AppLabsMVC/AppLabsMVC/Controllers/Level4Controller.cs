using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLabs.DTOs.Level4;
using AppLabs.Operations.Level4;
using AppLabsMVC.Models.Level4;

namespace AppLabsMVC.Controllers
{
    public class Level4Controller : Controller
    {
        //
        // GET: /Level4/


        public ActionResult Index()
        {
            return View();
        }

        
        
        public ActionResult ConvertRequest()
        {
            var model = new NumericRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayResult(NumericRequest req)
        {
            if (ModelState.IsValid)
            {
                double input = req.InputNum;
                var wm = new WordManager();
                NumberPlaces places = wm.SplitNumber(input);
                var model = new NumbersAsWordsResponse();
                model.FinalResult = wm.FormatOutput(places);
                return View(model);
            }
            return View("ConvertRequest", req);


        }

        
        
        public ActionResult NumRowsRequest()
        {
            var model = new PascalRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayPascalsTriangle(PascalRequest numRows)
        {
            if (ModelState.IsValid)
            {
                int input = numRows.PascalInput;
                var pc = new PascalCalculator();
                var model = new Triangle();
                model.Elements = pc.Calculate(input);
                return View("DisplayPascalsTriangle", model);
            }
            return View("NumRowsRequest", numRows);

        }
    }
}