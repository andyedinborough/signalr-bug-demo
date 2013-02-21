using System;
using System.Linq;

namespace signalr_webapp.Lib {
	public class Principal : System.Security.Principal.IIdentity, System.Security.Principal.IPrincipal {
		public string AuthenticationType {
			get { return "Forms"; }
		}

		public bool IsAuthenticated { get; set; }

		public string Name { get; set; }
		public string[] Roles { get; set; }

		public System.Security.Principal.IIdentity Identity {
			get { return this; }
		}

		public bool IsInRole(string role) {
			return Roles != null && Roles.Contains(role, StringComparer.OrdinalIgnoreCase);
		}
	}
}