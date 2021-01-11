using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterPipeline.Filters
{
  public class CustomControllerFilter : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext context)
    {
      Console.WriteLine("do something BEFORE the action executes");
    }
    
    public override void OnActionExecuted(ActionExecutedContext context)
    {
      Console.WriteLine("do something AFTER the action executes");
    }
  }
}