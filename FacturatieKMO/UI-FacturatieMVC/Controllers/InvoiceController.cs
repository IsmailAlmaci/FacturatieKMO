using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class InvoiceController : Controller
    {
        private IInvoiceManager mgr;
        private CustomerManager customerManager;

        public InvoiceController()
        {
            mgr = new InvoiceManager();
        }

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
            customerManager = new CustomerManager();
            InvoiceDTO invoice;

            List<string> names = new List<string>();
            foreach (CustomerDTO customer in customerManager.GetCustomers())
            {
                names.Add(customer.Name);
            }
            ViewBag.Customers = names;
            invoice = mgr.GetInvoice(1);
            return View();
        }

        // POST: Invoice/Create
        [HttpPost]
        public ActionResult Create(InvoiceDTO invoice)
        {
            try
            {
                CustomerDTO customer = new CustomerDTO();
                InvoiceDTO.Counter++;

                if (InvoiceDTO.LastMonth != invoice.InvoiceDate.Month)
                {
                    InvoiceDTO.Counter = 0;
                    InvoiceDTO.LastMonth = invoice.InvoiceDate.Month;
                }

                invoice.InvoiceCode = invoice.InvoiceDate.Year.ToString() 
                    + invoice.InvoiceDate.Month.ToString("00") + "-" + InvoiceDTO.Counter.ToString("0000");
                foreach (var item in customerManager.GetCustomers())
                {
                    if(item.Name.Equals(invoice.CustomerName))
                    {
                        customer = item;
                    }
                }
                invoice.Customer = customer;

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
        public ActionResult Edit(InvoiceDTO invoice)
        {
            try
            {
                if (!invoice.InvoiceStatus.Equals(StatusDTO.Completed))
                {
                    mgr.ChangeInvoice(invoice);
                }
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
                if(mgr.GetInvoice(id).Details == null)
                {
                    mgr.RemoveInvoice(id);
                }
                else 
                {
                    InvoiceDTO invoice = mgr.GetInvoice(id);
                    invoice.IsDeleted = true;
                    mgr.ChangeInvoice(invoice);
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
