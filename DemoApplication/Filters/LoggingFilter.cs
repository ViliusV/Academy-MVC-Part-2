using System.Web.Mvc;

namespace DemoApplication.Filters
{
	public class LoggingFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			//Do some logging before action is executed
		}

		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			//Do some logging after action is executed
		}
	}
}