using signalr_webapp.Lib;
using System.Web.Routing;

namespace signalr_webapp {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			AuthenticateRequest += MvcApplication_AuthenticateRequest;
		}

		void MvcApplication_AuthenticateRequest(object sender, System.EventArgs e) {
			var user = new Principal {
				Name = "Some User", Roles = new[] { "User" }, IsAuthenticated = true
			};
			Context.User = user;
		}
	}
}