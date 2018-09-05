using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.Privat
{
    public partial class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="routeBuilder">Route builder</param>
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            //PDT
            routeBuilder.MapRoute("Plugin.Payments.Pivat.PDTHandler", "Plugins/Payments/Pivat/PDTHandler",
                 new { controller = "Pivat", action = "PDTHandler" });

            //IPN
            routeBuilder.MapRoute("Plugin.Payments.Pivat.IPNHandler", "Plugins/Payments/Pivat/IPNHandler",
                 new { controller = "Pivat", action = "IPNHandler" });

            //Cancel
            routeBuilder.MapRoute("Plugin.Payments.Privat.CancelOrder", "Plugins/Payments/Privat/CancelOrder",
                 new { controller = "Privat", action = "CancelOrder" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority
        {
            get { return -1; }
        }
    }
}
