using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize(Roles = "Admin, User")]
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
            return View(mgr.GetInvoiceDetail(id));
        }

        // GET: InvoiceDetails/Create
        public ActionResult Create()
        {
            InvoiceManager invoiceManager = new InvoiceManager();
            InvoiceDetailDTO.Invoices = invoiceManager.GetInvoices();
            return View();
        }

        // POST: InvoiceDetails/Create
        [HttpPost]
        public ActionResult Create(InvoiceDetailDTO invoiceDetail)
        {
            try
            {
                if (!invoiceDetail.Invoice.InvoiceStatus.Equals(StatusDTO.Completed))
                {
                    mgr.AddInvoiceDetail(invoiceDetail);
                }
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
            return View(mgr.GetInvoiceDetail(id));
        }

        // POST: InvoiceDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(InvoiceDetailDTO invoiceDetail)
        {
            try
            {
                if (!invoiceDetail.Invoice.InvoiceStatus.Equals(StatusDTO.Completed))
                {
                    mgr.ChangeInvoiceDetail(invoiceDetail);
                }

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
            return View(mgr.GetInvoiceDetail(id));
        }

        // POST: InvoiceDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (!mgr.GetInvoiceDetail(id).Invoice.InvoiceStatus.Equals(StatusDTO.Completed))
                {
                    mgr.RemoveInvoiceDetail(id);
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
