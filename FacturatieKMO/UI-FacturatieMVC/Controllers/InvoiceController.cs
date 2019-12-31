using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize(Roles ="Admin")]
    public class InvoiceController : Controller
    {
        private IInvoiceManager mgr = new InvoiceManager();

        // GET: Invoice
        [AllowAnonymous]
        public ActionResult Index()
        {
            IEnumerable<InvoiceDTO> invoices = mgr.GetInvoices();
            return View(invoices);
        }

        // GET: Invoice/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            return View(mgr.GetInvoice(id));
        }

        // GET: Invoice/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoice/Create
        [HttpPost]
        public ActionResult Create(InvoiceDTO invoice)
        {
            try
            {
                // TODO: Add insert logic here
                mgr.AddInvoice(invoice);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Invoice/Edit/5
        public ActionResult Edit(int id)
        {
            return View(mgr.GetInvoice(id));
        }

        // POST: Invoice/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                InvoiceDTO currentInvoice = mgr.GetInvoice(id);
                string companyInfo = Request.Form["CompanyInfo"];
                string customerInfo = Request.Form["CustomerInfo"];

                InvoiceDTO invoice = new InvoiceDTO(companyInfo, customerInfo, 
                    currentInvoice.InvoiceDate, currentInvoice.Details, currentInvoice.InvoiceStatus, null);
                mgr.ChangeInvoice(invoice);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Invoice/Delete/5
        public ActionResult Delete(int id)
        {
            return View(mgr.GetInvoice(id));
        }

        // POST: Invoice/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.RemoveInvoice(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
