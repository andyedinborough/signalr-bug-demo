using signalr_webapp.Lib;

namespace signalr_webapp {
	public class RouteConfig {
		public static void RegisterRoutes(RouteCollection routes) {
			routes.MapConnection<MyConnection>("Echo", "echo", new Microsoft.AspNet.SignalR.ConnectionConfiguration {
				EnableCrossDomain = true
			});
		}
	}
}