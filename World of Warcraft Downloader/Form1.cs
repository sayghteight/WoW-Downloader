using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace World_of_Warcraft_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void DownloadUsingThatMagnetLink(string refferedMagnet)
        {
            var client = new WebClient();
            using (var stream = client.OpenRead("https://raw.githubusercontent.com/SuperDevRealm/WoW-Downloader/master/magnets.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(refferedMagnet))
                        {
                            Process.Start(line.Replace(refferedMagnet, ""));
                        }
                    }
                }
            }
        }

        private void DownloadClient(int client_id)
        {
            var client = new WebClient();

            switch (client_id)
            {
                case 1:
                    DownloadUsingThatMagnetLink("downloader_vanilla=");
                    break;
                case 2:
                    DownloadUsingThatMagnetLink("downloader_tbc=");
                    break;
                case 3:
                    DownloadUsingThatMagnetLink("downloader_wotlk=");
                    break;
                case 4:
                    DownloadUsingThatMagnetLink("downloader_cata=");
                    break;
                case 5:
                    DownloadUsingThatMagnetLink("downloader_mop=");
                    break;
                case 6:
                    DownloadUsingThatMagnetLink("downloader_wod=");
                    break;
                case 7:
                    DownloadUsingThatMagnetLink("downloader_legion=");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadClient(1); // vanilla
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadClient(2); // tbc
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadClient(3); // wotlk
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DownloadClient(4); // cata
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DownloadClient(5); // mop
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DownloadClient(6); // wod
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DownloadClient(7); // legion
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/SuperDevRealm/IssueTracker");
        }
    }
}
