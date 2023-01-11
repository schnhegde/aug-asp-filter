using Microsoft.AspNetCore.Mvc.Filters;

namespace ASPFilter
{
    public class LogActionFilter : ActionFilterAttribute
    {
        private readonly ILogger<LogActionFilter> _logger;

        public LogActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<LogActionFilter>();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string firstName = context.ActionArguments["firstName"] as string;
            string lastName = context.ActionArguments["lastName"] as string;
            string logMessage = "Hello " + firstName + " " + lastName + "!";

            _logger.LogInformation(logMessage);
            base.OnActionExecuting(context);
        }
    }
}
