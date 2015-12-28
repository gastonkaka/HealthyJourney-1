using HealthyJourney.Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HealthyJourney.Angular.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
        public ActionResult Sent()
        {
            return View();
        }

        public ActionResult Speciality()
        {
            ViewBag.Message = "Your Speciality page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Speciality(EmailFormModel model)
        {
           
            if (ModelState.IsValid)
            {
                var user = User.Identity.Name;
                var body = "<h1>User : {0} </h1><h4><i>Email : ({1})</i></h4><h4>Message:</h4><h4>{2}</h4>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.FromEmail)); //replace with valid value
                message.Subject = "Speciality Related Questions";
                message.Body = string.Format(body, model.FromName, user, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }


        public ActionResult Infos()
        {
            ViewBag.Message = "Your infos page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Infos(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.Name;
                var body = "<h1>User : {0} </h1><h4><i>Email : ({1})</i></h4><h4>Message:</h4><h4>{2}</h4>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.FromEmail)); //replace with valid value
                message.Subject = "Provider's Related Questions";
                message.Body = string.Format(body, model.FromName, user, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }


        public ActionResult Blog()
        {
            ViewBag.Message = "Your Blog page.";

            return View();
        }
    }
}