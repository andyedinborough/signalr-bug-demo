using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace signalr_webapp.Lib {
	public class MyConnection : PersistentConnection {
		protected override System.Threading.Tasks.Task OnReceived(IRequest request, string connectionId, string data) {
			return Task.Run(() => {
				GlobalHost.ConnectionManager.GetConnectionContext<MyConnection>()
					.Connection.Send(connectionId, data);
			});
		}
	}
}