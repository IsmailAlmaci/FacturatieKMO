using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UI_FacturatieMVC.Models;

namespace UI_FacturatieMVC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private ApplicationDbContext context;
        private List<ApplicationUser> allUsers;

        public UserController()
        {
            context = new ApplicationDbContext();
            allUsers = context.Users.ToList();
        }

        public UserController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: User
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(allUsers);
        }

        // GET: User/Details/5
        public ActionResult Details()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userid = User.Identity.GetUserId();
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                ApplicationUser user = userManager.FindByIdAsync(userid).Result;

                return View(user);
            }
            else return RedirectToAction("Login", "Account");
        }

        // GET: User/Register
        [Authorize(Roles = "Admin")]
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Register
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            // TODO: Add insert logic here

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.Firstname,
                Name = model.Name,
                Address = model.Address,
                EmailConfirmed = true
            };

            var result = await UserManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await UserManager.AddToRoleAsync(user.Id, model.SelectedRole);

                await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // GET: User/Edit/5
        public ActionResult Edit(string id)
        {
            ApplicationUser appUser = new ApplicationUser();
            appUser = UserManager.FindById(id);

            return View(appUser);
        }

        // POST: User/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(string id, ApplicationUser model)
        {
            if (!ModelState.IsValid || !id.Equals(User.Identity.GetUserId()))
            {
                return View(model);
            }

            var store = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var manager = new UserManager<ApplicationUser>(store);
            var currentUser = manager.FindByEmail(model.Email);

            currentUser.Email = model.Email;
            currentUser.Name = model.Name;
            currentUser.FirstName = model.FirstName;
            currentUser.Address = model.Address;
            currentUser.PhoneNumber = model.PhoneNumber;

            await manager.UpdateAsync(currentUser);
            TempData["msg"] = "Profile Updated";
            return RedirectToAction("Index");
        }

        // GET: User/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = context.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(ApplicationUser user)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            context.Users.Attach(user);

            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                TempData["UserDeleted"] = "User Successfully Deleted";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["UserDeleted"] = "Error Deleting User";
                return RedirectToAction("Index");
            }
        }

        //
        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }

        //
        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }
            var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("ResetPasswordConfirmation", "Account");
            }

            return View();
        }

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }
    }
}
