using System.Web.Mvc;
using DemoApplication.Filters;
using DemoApplication.Models;

namespace DemoApplication.Controllers
{
    public class CountriesController : Controller
    {
		[LoggingFilter]
        public ActionResult Index()
        {
	        var country = new CountryViewModel
	        {
		        Title = "Lithuania",
		        Capital = "Vilnius",
		        Population = 3000000
	        };

            return View(country);
        }

	    public ActionResult Create()
	    {
		    var model = new CountryViewModel();

		    return View(model);
	    }

	    [HttpPost]
		[ValidateAntiForgeryToken]
	    public ActionResult Create(CountryViewModel model)
	    {
			//ToDo: Add country to DB

		    return RedirectToAction("Index");
	    }
    }
}