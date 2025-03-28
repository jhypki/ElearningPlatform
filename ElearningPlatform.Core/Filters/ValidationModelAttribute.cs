using ElearningPlatform.Core.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ElearningPlatform.Core.Filters;

public class ValidateModelAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid) throw new ValidationException(context.ModelState);
    }
}