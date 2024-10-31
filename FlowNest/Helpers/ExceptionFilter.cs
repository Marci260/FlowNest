using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using FlowNest.Entities.Helpers;

namespace FlowNest.Endpoint.Helpers
{
    public class ExceptionFilter : IExceptionFilter
    {
       

        public void OnException(ExceptionContext context)
        {
            var error = new ErrorModel(context.Exception.Message);

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new JsonResult(error);
        }
    }
}
