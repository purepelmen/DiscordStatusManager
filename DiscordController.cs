using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM
{
    public class DiscordController
    {
		public RichPresence Presence { get => presence; }
		public bool Connected { get => client != null; }

		private DiscordRpcClient client;
		private RichPresence presence;

		public DiscordController()
        {
			presence = new RichPresence();
		}

		public void ConnectDiscord(string applicatioId)
		{
			client = new DiscordRpcClient(applicatioId);

			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			client.OnReady += (sender, e) =>
			{
				Console.WriteLine("Received Ready from user {0}", e.User.Username);
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				Console.WriteLine("Received Update! {0}", e.Presence);
			};

			client.Initialize();
			client.SetPresence(presence);
		}

		public void UpdatePresence()
        {
			if (Connected == false)
				throw new NullReferenceException("Discord isn't connected");

			client.SetPresence(presence);
		}
	}
}
