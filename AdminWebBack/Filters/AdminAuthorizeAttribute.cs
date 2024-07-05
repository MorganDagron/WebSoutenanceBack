using System.Web.Mvc;

namespace AdminWebBack.Filters
{
    public class AdminAuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session;
            if (session["AdminUsername"] == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
