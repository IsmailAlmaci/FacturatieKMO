﻿using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class CustomerController : Controller
    {
        private ICustomerManager mgr = new CustomerManager();

        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<CustomerDTO> customers = mgr.GetCustomers();
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            CustomerDTO customer = mgr.GetCustomer(id);
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerDTO customer)
        {
            try
            {
                // TODO: Add insert logic here
                mgr.AddCustomers(customer);
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
        public ActionResult Edit(CustomerDTO customer)
        {
            try
            {
                // TODO: Add update logic here
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
        public ActionResult Delete(CustomerDTO dto)
        {
            try
            {
                dto.IsDeleted = true;
                mgr.ChangeCustomer(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
