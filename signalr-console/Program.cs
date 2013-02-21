using Microsoft.AspNet.SignalR.Client;
using System;

namespace signalr_console {
	class Program {
		static void Main(string[] args) {

			var conn = new Connection("http://localhost:54841/-/echo", "access_token=" + Guid.NewGuid());
			conn.Start().ContinueWith(_ => {
				if (_.Exception != null && _.Exception.InnerExceptions.Count > 0) {
					foreach (var x in _.Exception.InnerExceptions) {
						Console.WriteLine(x);
					}
				} else Console.WriteLine("OK!");

				var msg = Guid.NewGuid().ToString();

				conn.Received += data => {
					Console.WriteLine("Date sent matches received? {0}", msg == data);
				};

				conn.Send(msg);
			});

			Console.ReadLine();
		}

	}
}
