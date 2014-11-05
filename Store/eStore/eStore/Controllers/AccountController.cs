using System.Web.Mvc;
using System.Web.Security;
using eStore.DBO;
using eStore.BL.BO;
using eStore.Models;


namespace eStore.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: /Account/SignUp
        [AllowAnonymous]
        public ActionResult SignUp()
        {
            return View("SignUp");
        }

        // POST: /Account/SignUp
        [HttpPost]
        [AllowAnonymous]
        public ActionResult SignUp(UserRegisterView user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserManager userManager = new UserManager();
                    if (!userManager.IsUserLoginIDExist(user.UserName))
                    {
                        User usr = new User();
                        usr.LoginName = user.UserName;
                        usr.Password = user.Password;
                        usr.Name = user.Name;
                        usr.Surname = user.Surname;
                        usr.Phone = user.Phone;
                        userManager.Add(usr);

                        FormsAuthentication.SetAuthCookie(user.UserName, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "LogID already taken");
                    }
                }
            }
            catch
            {
                return View(user);
            }

            return View(user);
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            //ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(UserLoginView model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                UserManager userManager = new UserManager();
                string password = userManager.GetUserPassword(model.UserName);

                if (string.IsNullOrEmpty(password))
                {

                    ModelState.AddModelError("", "The user login or password provided is incorrect.");
                }

                if (model.Password == password)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, true);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        // GET: /Account/LogOff 
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }        
    }
}