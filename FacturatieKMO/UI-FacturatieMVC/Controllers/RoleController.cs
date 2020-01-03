using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using UI_FacturatieMVC.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private ApplicationDbContext ctx;
        private RoleManager<IdentityRole> roleManager;
        private IEnumerable<IdentityRole> roles;


        public RoleController()
        {
            ctx = new ApplicationDbContext();
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(ctx));
            roles = roleManager.Roles;
        }

        // GET: Role
        public ActionResult Index()
        {
            return View(roles);
        }

        // GET: Role/Details/5
        public ActionResult Details(int id)
        {
            return View(roles.ElementAt(id));
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(IdentityRole role)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Roles.Add(role);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            return View(roles.ElementAt(id));
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit(IdentityRole role)
        {
            try
            {
                // TODO: Add update logic here
                ctx.Entry(role).State = System.Data.Entity.EntityState.Modified;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ctx.Roles.Remove(ctx.Roles.ElementAt(id));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
