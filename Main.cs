using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_Project.Discord;



namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        private void Form1_Load(object sender, EventArgs e)
        {
           this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(textBox1.Text, ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(textBox1.Text, ref this.handlers, true, null);
            this.presence.details = textBox2.Text;
            this.presence.state = textBox3.Text;
            this.presence.largeImageKey = textBox4.Text;
            this.presence.smallImageKey = textBox5.Text;
            this.presence.largeImageText = textBox6.Text;
            this.presence.smallImageText = textBox7.Text;
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRpc.UpdatePresence(ref this.presence);
            }

        }
