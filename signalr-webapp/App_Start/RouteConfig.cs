﻿using signalr_webapp.Lib;
using System.Web.Mvc;
using System.Web.Routing;

namespace signalr_webapp {
	public class RouteConfig {
		public static void RegisterRoutes(RouteCollection routes) {
			routes.MapConnection<MyConnection>("Echo", "-/echo", new Microsoft.AspNet.SignalR.ConnectionConfiguration {
				EnableCrossDomain = true
			});

			routes.MapRoute(
					"Default",                                              // Route name
					"{controller}/{action}/{id}",                           // URL with parameters
					new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
			);
		}
	}
}