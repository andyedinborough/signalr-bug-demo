using System.Web.Routing;

namespace signalr_webapp {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			AuthenticateRequest += MvcApplication_AuthenticateRequest;
		}

		void MvcApplication_AuthenticateRequest(object sender, System.EventArgs e) {

		}
	}
}