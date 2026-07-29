
using System.Text.RegularExpressions;

namespace aspnet_pro020_RouteValuesConstraintsImplemention.RoutingConstraints
{
    public class MonthsCustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey))
            {
                return false;
            }

            Regex reg = new Regex("^(apr|may|jun|jul)$");

            string? monthValue = Convert.ToString(values[routeKey]);

            if (reg.IsMatch(monthValue))
            {
                return true;
            }
            return false;
        }
    }
}
