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
        private RoleManager<IdentityRole> roleManager;

        public RoleController()
        {
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
        }

        // GET: Role
        public ActionResult Index()
        {
            return View(roleManager.Roles);
        }

        // GET: Role/Details/5
        public ActionResult Details(string id)
        {
            return View(roleManager.FindById(id));
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                if (!roleManager.RoleExists(collection["Name"]))
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = collection["Name"];
                    roleManager.Create(role);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Edit/5
        public ActionResult Edit(string id)
        {
            return View(roleManager.FindById(id));
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                if(!roleManager.FindById(id).Name.Equals("Admin"))
                {
                    IdentityRole role = roleManager.FindById(id);
                    role.Name = collection["Name"];
                    roleManager.Update(role);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Delete/5
        public ActionResult Delete(string id)
        {
            return View(roleManager.FindById(id));
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                if (!roleManager.FindById(id).Name.Equals("Admin"))
                {
                    roleManager.Delete(roleManager.FindById(id));
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
