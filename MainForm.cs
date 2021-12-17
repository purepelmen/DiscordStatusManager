using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSM
{
    public partial class MainForm : Form
    {
        private DiscordController discord;

        public MainForm()
        {
            InitializeComponent();

            discord = new DiscordController();
            discord.OnLogging += OnLogging;
        }

        private void ConnectBtnClick(object sender, EventArgs e)
        {
            string appId = applicationIdField.Text;

            if(string.IsNullOrWhiteSpace(appId))
            {
                MessageBox.Show("Type application ID!", "Error");
                return;
            }

            discord.ConnectDiscord(appId);
        }

        private void UpdatePresenceBtnClick(object sender, EventArgs e)
        {
            if(discord.Connected == false)
            {
                MessageBox.Show("Not connected to Discord", "Error");
                return;
            }

            discord.Presence.State = stateField.Text;
            discord.Presence.Assets = new Assets()
            {
                LargeImageKey = largeImageKeyField.Text,
                LargeImageText = largeImageTextField.Text
            };

            discord.UpdatePresence();
        }

        private void OnLogging(string text)
        {
            logsBox.Invoke(new Action(() => logsBox.Items.Add(text)));
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            discord.Disconnect();
        }
    }
}
