using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApplication.Filters;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class DemoPersonController : Controller
    {
        public ActionResult Index()
        {
	        var countries = new List<CountryViewModel>
	        {
		        new CountryViewModel {Title = "LT"},
		        new CountryViewModel {Title = "DK"},
		        new CountryViewModel {Title = "US"},
		        new CountryViewModel {Title = "UK"},
	        };

	        ViewBag.Countries = countries;

			var person = new DemoPersonViewModel
			{
				FirstName = "John",
				LastName = "Doe",
				Age = 25
			};
            return View(person);
        }

		[HttpPost]
	    public ActionResult Index(DemoPersonViewModel model)
	    {
			if (!ModelState.IsValid)
			{
				model.FirstName = String.Empty;
				model.LastName = String.Empty;
				model.Age = 25;
				

				return View(model);
			}
			else
			{
				//update person in DB
				return RedirectToAction("Index", "Countries");
			}
	    }
    }
}