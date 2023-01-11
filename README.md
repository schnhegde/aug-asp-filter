Filters:

ActionFilterAttribute - Abstract class (has support for async as well)

has access to the parameters and the Actioncontext which can be changed like adding headers

lifecycle methods:

onActionExecuting - executes before the action
onActionExecuted - after the action
onActionExecutedAsync - code before the next() call runs before the action and code written after next() is executed runs after the    
                        action


Other types of filters:

AuthorizationFilter - runs before any other filter (user auth)

ResourceFilter - runs after auth but before the rest of the filters after other filters are completed

ActionFilter - before and after action method

ExceptionFilters - global filters to handle exceptions before writing the response

ResultFilter - before and after action results (action method must execute successfully)
