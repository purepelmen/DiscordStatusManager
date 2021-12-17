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
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            string appId = applicationIdField.Text;

            if(string.IsNullOrWhiteSpace(appId))
            {
                MessageBox.Show("Type application ID!");
                return;
            }

            discord.ConnectDiscord(appId);
        }

        private void updatePresenceBtn_Click(object sender, EventArgs e)
        {
            if(discord.Connected == false)
            {
                MessageBox.Show("Error: Not connected to Discord");
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
    }
}
