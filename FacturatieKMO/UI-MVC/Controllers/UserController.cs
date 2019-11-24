using FacturatieKMO.BL;
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
            IEnumerable<UserDTO> users = mgr.GetUsers();
            return View(users);
        }

        // GET: Gebruiker/Details/5
        public ActionResult Details(int id)
        {
            UserDTO user = mgr.GetUser(id);
            return View(user);
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
                string name = Request.Form["Name"];
                string firstName = Request.Form["FirstName"];
                string email = Request.Form["Email"];
                string address = Request.Form["Address"];

                mgr.AddUsers(3, name, firstName, email, address, null);
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
            return View(mgr.GetUser(id));
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

                UserDTO user = new UserDTO(id, name, firstName, email, address, null);
                mgr.ChangeUser(user);

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
            return View(mgr.GetUser(id));
        }

        // POST: Gebruiker/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.RemoveUser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
