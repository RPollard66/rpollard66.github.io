using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLabs.DTOs.Level2;
using AppLabs.Operations.Level2;
using AppLabsMVC.Models;
using AppLabsMVC.Models.Level2;

namespace AppLabsMVC.Controllers
{
    public class Level2Controller : Controller
    {
        //
        // GET: /Level2/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FibonacciRequest()
        {
            var model = new FibonacciRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayFibonacciSequence(int num)
        {
            var model=new Fibonacci();
            model.Sequence = new FibonacciGenerator().Generate(num);
            return View(model);

        } 
        
        public ActionResult PalindromeQuery()
        {
            var model = new PalindromeRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult PalindromeVerdict(PalindromeRequest input)
        {
           
            var model = new PalindromeResult();

            model.Verdict = new PalindromeDetector().ReverseAndCheck(input.UserChoice);
            return View(model);
        }

        public ActionResult NextPrimeQuery()
        {
            var model = new PrimeRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayNextPrime(PrimeRequest p)
        {
            var f = new FindNextPrime();
            var model = new NextPrimeResult();
            model.NextPrime = f.NextPrime(p.Number);
            return View(model);
        }

        public ActionResult CountCharacters()
        {
            var model = new CountCharRequest();
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayCountCharsResults(CountCharRequest req)
        {
            var c = new CharacterCounter();
            var model = new CountCharsResult();
            model = c.GetResults(req.UserInput);
            return View(model);
        }
    }
}