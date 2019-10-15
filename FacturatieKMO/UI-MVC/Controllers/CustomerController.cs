﻿using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerManager mgr = new CustomerManager();

        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<Customer> customers = mgr.GetCustomers();
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer customer = mgr.GetCustomer(id);
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string name = Request.Form["Name"];
                string firstName = Request.Form["FirstName"];
                string email = Request.Form["Email"];
                string address = Request.Form["Address"];

                mgr.AddCustomers(1, name, firstName, email, address);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View(mgr.GetCustomer(id));
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                string name = Request.Form["Name"];
                string firstName = Request.Form["FirstName"];
                string email = Request.Form["Email"];
                string address = Request.Form["Address"];

                Customer customer = new Customer(id, name, firstName, email, address);

                mgr.ChangeCustomer(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(mgr.GetCustomer(id));
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.RemoveCustomer(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
