using HealthyJourney.Domain.Entities;
using HealthyJourney.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLteMvc.Controllers
{
    /// <summary>
    /// This is an example controller using the AdminLTE NuGet package's CSHTML templates, CSS, and JavaScript
    /// You can delete these, or use them as handy references when building your own applications
    /// </summary>
    public class AdminLteController : Controller
    {
        
        private UserServices repo ;
        private SpecialityServices repoSpe;
        public AdminLteController()
        {
            repo = new UserServices();
            repoSpe = new SpecialityServices();
        }

        public ActionResult Index()
        {
            return View();
        }
           public ActionResult UsersList()
        {
            var users = repo.GetAllInfos();
            return View(users);
        }

        public ActionResult CreateInfos()
        {

            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        public ActionResult CreateInfos(Infos infos)
        {
            try
            {
                // TODO: Add insert logic here
                repo.AddInfos(infos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(infos);
            }
        }

        public ActionResult Specialities()
        {
           var specialities = repoSpe.GetAllSpecialities();
            return View(specialities);
        }

        public ActionResult CreateSpecialities()
        {

            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        public ActionResult CreateSpecialities(Speciality speciality)
        {
            try
            {
                // TODO: Add insert logic here
                repoSpe.AddSpeciality(speciality);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(speciality);
            }
        }

        /// <summary>
        /// The color page of the AdminLTE demo, demonstrating the AdminLte.Color enum and supporting methods
        /// </summary>
        /// <returns></returns>
        public ActionResult Colors()
        {
            return View();
        }
    }
}