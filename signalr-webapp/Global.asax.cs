using signalr_webapp.Lib;
using System.Web.Mvc;
using System.Web.Routing;

namespace signalr_webapp {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
		}

		public override void Init() {
			base.Init();
			AuthenticateRequest += MvcApplication_AuthenticateRequest;
		}

		void MvcApplication_AuthenticateRequest(object sender, System.EventArgs e) {
			var user = new Principal {
				Name = "Bob", IsAuthenticated = true, Roles = new[] { "User" }
			};
			System.Web.HttpContext.Current.User = user;
		}
	}
}