using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using System;

namespace DSM
{
    public class DiscordController
    {
		public bool Connected { get => client.IsDisposed == false && client != null; }
		public RichPresence Presence { get => presence; }

		public Action<string> OnLogging;

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

			client.OnReady += OnClientReady;
			client.OnPresenceUpdate += OnPresenceUpdate;
            client.OnError += OnClientError;
            client.OnClose += OnClientClose;

			client.Initialize();
			client.SetPresence(presence);
		}

        public void Disconnect()
        {
			client.ClearPresence();
			client.Dispose();
        }

		public void UpdatePresence()
        {
			if (Connected == false)
				throw new NullReferenceException("Discord isn't connected");

			client.SetPresence(presence);
		}

		private void OnClientReady(object sender, ReadyMessage args)
		{
			OnLogging?.Invoke($"Client ready {args.User.Username}");
		}

		private void OnPresenceUpdate(object sender, PresenceMessage args)
		{
			OnLogging?.Invoke("Presence updated");
		}

		private void OnClientError(object sender, ErrorMessage args)
		{
			OnLogging?.Invoke($"Client error ({args.Message})");
		}
		private void OnClientClose(object sender, CloseMessage args)
		{
			OnLogging?.Invoke($"Client closed (Reason: {args.Reason})");
		}

	}
}
