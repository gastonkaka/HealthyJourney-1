using HealthyJourney.Angular.Models;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HealthyJourney.Angular.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Charge()
        {
            ViewBag.Message = "Process Payment with Stripe";
            return View(new StripeChargeModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Charge(StripeChargeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var chargeId = await ProcessPayment(model);
            // You should do something with the chargeId --> Persist it maybe?

            return View("Index");
        }
        private async Task<string> ProcessPayment(StripeChargeModel model)
        {
            return await Task.Run(() =>
            {
                var myCharge = new StripeChargeCreateOptions
                {
                    Amount = (int)(model.Amount),
                    Currency = "usd",
                    Description = "Description for test charge",
                    Source = new StripeSourceOptions
                    {
                        TokenId = model.Token
                    }
                };

                var chargeService = new StripeChargeService("sk_test_Z5ouryHEqLHYoVPxq1V9NN8a");
                var stripeCharge = chargeService.Create(myCharge);

                return stripeCharge.Id;
            });
        }
    }
}
