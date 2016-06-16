using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace AnadiendoFuncionalidades.Constraints
{
    public class StartsWithConstraint : IRouteConstraint
    {
        private readonly string _substr;
        public StartsWithConstraint(string substr)
        {
            _substr = substr;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName,
                          RouteValueDictionary values, RouteDirection routeDirection)
        {
            return values.ContainsKey(parameterName)
                   && values[parameterName].ToString().StartsWith(_substr);
        }
    }
}