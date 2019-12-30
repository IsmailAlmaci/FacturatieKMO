using FacturatieKMO.BL;
using FacturatieKMO.BL.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UI_FacturatieMVC.Models;

namespace AP.UI.Web.MVC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private ApplicationDbContext ctx = new ApplicationDbContext();

        // GET: Gebruiker
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            IEnumerable<ApplicationUser> users = ctx.Users.AsEnumerable();
            return View(users);
        }

        // GET: Gebruiker/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gebruiker/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gebruiker/Create
        [Authorize(Roles = "Admin")]
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
            return View(ctx.Users.ElementAt(id));
        }

        // POST: Gebruiker/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                string name = Request.Form["Name"];
                string firstName = Request.Form["FirstName"];
                string email = Request.Form["Email"];
                string address = Request.Form["Address"];

                UserDTO user = new UserDTO(id, name, firstName, email, address, null, null);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gebruiker/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gebruiker/Delete/5
        [Authorize(Roles = "Admin")]
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
