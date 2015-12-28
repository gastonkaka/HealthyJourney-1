using HealthyJourney.Domain.Entities;
using HealthyJourney.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyJourney.Angular.Controllers
{
    public class ForumController : Controller
    {

        private IForumServices repo;
        private ISpecialityServices repo2;

        public ForumController()
        {
            repo = new ForumServices();
            repo2 = new SpecialityServices();
        }


        // GET: Forum
        public ActionResult Index()
        {
            var specialities = repo2.GetAllSpecialities();
            ViewBag.Specialities = specialities;
            var forums = repo.GetAllForums();
            return View(forums);
        }

        // GET: Forum/Details/5
        public ActionResult Details(int id)
        {
            var forum = repo.GetForumById(id);
            return View(forum);
        }

        // GET: Forum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forum/Create
        [HttpPost]
        public ActionResult Create(Forum forum)
        {
            try
            {

                repo.AddForum(forum);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(forum);
            }
        }

        // GET: Forum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Forum/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Forum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Forum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
