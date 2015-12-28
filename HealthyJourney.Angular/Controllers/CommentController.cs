using HealthyJourney.Data.Repositories;
using HealthyJourney.Domain.Entities;
using HealthyJourney.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyJourney.Angular.Controllers
{
    public class CommentController : Controller
    {

        private ICommentServices repo;
        
        public CommentController()
        {
            repo = new CommentServices();
        }
        // GET: Comment
        public ActionResult Index()
        {
            var comments = repo.GetAllComments();
            return View(comments);
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            try
            {
                // TODO: Add insert logic here
                repo.CreateComment(comment);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(comment);
            }
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Comment comment)
        {
            try
            {                // TODO: Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comment/Delete/5
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
