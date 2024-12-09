using FlowNest.Entities.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FlowNest.Endpoint.Helpers
{
    public class ValidationFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

            if (!context.ModelState.IsValid)
            {
                var errorMessages = context.ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                if (errorMessages.Any())
                {
                    var error = new ErrorModel(string.Join(",", errorMessages));
                    context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                    context.Result = new JsonResult(error);
                }
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) { }

    }
}
