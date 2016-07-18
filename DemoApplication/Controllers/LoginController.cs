using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
	[Authorize]
	public class LoginController : Controller
    {


        // GET: Login
		[AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }


		[HttpPost]
		[AllowAnonymous]
		public ActionResult Login(LoginViewModel model)
		{
			using (var dbContext = new UsersEntities())
			{
				var user = dbContext.Members.SingleOrDefault(
					u => 
					u.UserName.Equals(model.UserName, StringComparison.InvariantCultureIgnoreCase)
					&& u.Password.Equals(model.Password));

				if (user == null)
				{
					return View(model);
				}
				FormsAuthentication.SetAuthCookie(user.UserName, false);

				return RedirectToAction("Success");
			}
		}

		[AllowAnonymous]
		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public ActionResult Register(LoginViewModel model)
		{
			using (var dbContext = new UsersEntities())
			{
				dbContext.Members.Add(new Members
				{
					UserName = model.UserName,
					Password = model.Password
				});

				dbContext.SaveChanges();
			}

			return RedirectToAction("Success");
		}




	    public ActionResult Success()
	    {
		    return View();
	    }
    }
}