using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLabs.DTOs.Level1;
using AppLabs.Operations.Level1;
using AppLabsMVC.Models.Level1;

namespace AppLabsMVC.Controllers
{
    public class Level1Controller : Controller
    {
        //
        // GET: /Level1/
        public ActionResult Index()
        {
            return View();
        }

        // tip calc
        public ActionResult TipCalculator()
        {
            var model = new TipCalculatorRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult TipCalculator(TipCalculatorRequest request)
        {
            if (ModelState.IsValid)
            {
                var calc = new TipCalculator();

                // convert tip calculator model to tip calculation

                var tipData = new TipCalculation();
                tipData.MealTotal = request.MealTotal.Value;
                tipData.TipPercent = request.TipPercent.Value / 100;

                var result = calc.CalculateTip(tipData);
                return View("TipCalculatorResult", result);
            }
            else
            {
                return View(request);
            }
        }

        // leap years
        public ActionResult LeapYearsRequest()
        {
            var model = new LeapYearsData();
            return View(model);
        }

        [HttpPost]
        public ActionResult LeapYearsDisplay(LeapYearsData model)
        {
            var list = new LeapYearsResult();

            if (ModelState.IsValid)
            {

                var data = new LeapYearsData();

                data.BeginYear = model.BeginYear;
                data.EndYear = model.EndYear;

                for (var i = data.BeginYear.Value; i <= data.EndYear.Value; i++)
                {
                    if ((i % 4 == 0 && i % 100 != 0) || (i % 100 == 0 && i % 400 == 0))

                        list.LeapYrsList.Add(i);
                }

                return View("LeapYearsDisplay", list);
            }
            else
            {
                return View("LeapYearsRequest",model);
            }

        }

        public ActionResult ReverseRequest()
        {
            var model = new StringRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayReversedString(StringRequest model)
        {

            if (ModelState.IsValid)
            {
                var g = new FindStringReverseResult(model.StringToReverse);
                var result = new StringResult();
                result.ReversedString = g.Reverse();
                return View("DisplayReversedString", result);
            }
            return View("ReverseRequest", model);


        }

        public ActionResult FlooringRequest()
        {
            var model = new FlooringValues();
            return View(model);
        }

        [HttpPost]
        public ActionResult FlooringDisplay(FlooringValues values)
        {
            if (ModelState.IsValid)
            {
                var result = new FlooringCalculator(values);
                var model = new FlooringTotals();
                model.MaterialCost = result.FindCost();
                return View(model);
            }
            return View("FlooringRequest", values);
        }

    }
}