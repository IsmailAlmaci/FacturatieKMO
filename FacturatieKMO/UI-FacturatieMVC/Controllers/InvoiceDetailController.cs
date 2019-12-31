using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize]
    public class InvoiceDetailController : Controller
    {
        private IInvoiceDetailManager mgr = new InvoiceDetailManager();

        // GET: InvoiceDetails
        public ActionResult Index()
        {
            IEnumerable<InvoiceDetailDTO> details = mgr.GetInvoiceDetails();
            return View(details);
        }

        // GET: InvoiceDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InvoiceDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceDetails/Create
        [HttpPost]
        public ActionResult Create(InvoiceDetailDTO invoiceDetail)
        {
            try
            {
                // TODO: Add insert logic here
                mgr.AddInvoiceDetail(invoiceDetail);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceDetails/Edit/5
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

        // GET: InvoiceDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceDetails/Delete/5
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
