using signalr_webapp.Lib;
using System.Web.Routing;

namespace signalr_webapp {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			RouteTable.Routes.MapConnection<MyConnection>("Echo", "echo", new Microsoft.AspNet.SignalR.ConnectionConfiguration {
				EnableCrossDomain = true
			});

			AuthenticateRequest += MvcApplication_AuthenticateRequest;
		}

		void MvcApplication_AuthenticateRequest(object sender, System.EventArgs e) {

		}
	}
}