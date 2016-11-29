using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyPeopleSearchApplication.DataAccessLayer;
using MyPeopleSearchApplication.Models;

namespace MyPeopleSearchApplication.Controllers
{
    public class SearchPeoplesController : Controller
    {
        private PeopleContext db = new PeopleContext();

        //GET: SearchPeoples
        //[HttpPost]
        public ActionResult Index(string searchQuery = "")
        {
            if (Request.IsAjaxRequest()) {
                var persons = db.SearchPeoples.Where(i => (i.FirstName.Contains(searchQuery) || i.LastName.Contains(searchQuery))).ToList();
                return Json(persons);
            }
            else
            {
                return View(db.SearchPeoples.ToList());
            }
        }

        // GET: SearchPeoples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SearchPeoples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Occupation,City,State,Country,Age,Gender,Interest")] SearchPeople searchPeople)
        {
            if (ModelState.IsValid)
            {
                db.SearchPeoples.Add(searchPeople);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(searchPeople);
        }
    }
}
