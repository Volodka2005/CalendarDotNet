using CalendarDotNet.Data;
using CalendarDotNet.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Security.Claims;

namespace CalendarDotNet.Controllers.ActionFilters
{
    public class UserAccessOnly: ActionFilterAttribute, IActionFilter
    {
        private DAL _dal = new DAL();

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.RouteData.Values.ContainsKey("id"))
            {
                int id = int.Parse((string)context.RouteData.Values["id"]);
                if (context.HttpContext.User != null)
                {
                    var username = context.HttpContext.User.Identity.Name;
                    if (username != null)
                    {
                        var myevent = _dal.GetEvent(id);
                        if (myevent.User != null)
                        {
                            if (myevent.User.UserName != username)
                            {
                                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Not Found" }));
                            } 
                        }    
                       
                    }
                }
            }
        }
    }
}
