﻿using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    public class UserController : Controller
    {
        private IUserManager mgr = new UserManager();

        // GET: Gebruiker
        public ActionResult Index()
        {
            IEnumerable<User> users = mgr.GetUsers();
            return View(users);
        }

        // GET: Gebruiker/Details/5
        public ActionResult Details(int id)
        {
            IEnumerable<User> users = mgr.GetUsers();
            return View(users.ElementAt(id));
        }

        // GET: Gebruiker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gebruiker/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gebruiker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gebruiker/Edit/5
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

        // GET: Gebruiker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gebruiker/Delete/5
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
