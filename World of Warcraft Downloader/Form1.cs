using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
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

        private string WoWD_File1;
        private string WoWD_File2;
        private string WoWD_File3;
        private string WoWD_File4;
        private string WoWD_File5;
        private string WoWD_File6;

        private void DownloadClient(int client_id)
        {
            Thread thread = new Thread(() => 
            {
                WebClient webClient = new WebClient();

                switch (client_id)
                {
                    case 1: // vanilla
                        {
                            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged1);
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted1);

                            WoWD_File1 = Path.GetTempPath() + Guid.NewGuid().ToString() + ".torrent";
                            webClient.DownloadFileAsync(new Uri(Properties.Settings.Default.WoWD_DLink1), WoWD_File1);
                        }
                        break;
                    case 2: // tbc
                        {
                            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged2);
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted2);

                            WoWD_File2 = Path.GetTempPath() + Guid.NewGuid().ToString() + ".torrent";
                            webClient.DownloadFileAsync(new Uri(Properties.Settings.Default.WoWD_DLink2), WoWD_File2);
                        }
                        break;
                    case 3: // wotlk
                        {
                            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged3);
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted3);

                            WoWD_File3 = Path.GetTempPath() + Guid.NewGuid().ToString() + ".torrent";
                            webClient.DownloadFileAsync(new Uri(Properties.Settings.Default.WoWD_DLink3), WoWD_File3);
                        }
                        break;
                    case 4: // cata
                        {
                            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged4);
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted4);

                            WoWD_File4 = Path.GetTempPath() + Guid.NewGuid().ToString() + ".torrent";
                            webClient.DownloadFileAsync(new Uri(Properties.Settings.Default.WoWD_DLink4), WoWD_File4);
                        }
                        break;
                    case 5: // mop
                        {
                            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged5);
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted5);

                            WoWD_File5 = Path.GetTempPath() + Guid.NewGuid().ToString() + ".torrent";
                            webClient.DownloadFileAsync(new Uri(Properties.Settings.Default.WoWD_DLink5), WoWD_File5);
                        }
                        break;
                    case 6: // wod
                        {
                            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged6);
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted6);

                            WoWD_File6 = Path.GetTempPath() + Guid.NewGuid().ToString() + ".torrent";
                            webClient.DownloadFileAsync(new Uri(Properties.Settings.Default.WoWD_DLink6), WoWD_File6);
                        }
                        break;
                }
            });
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadClient(1); // vanilla
        }

        private void client_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e) { }

        private void client_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => WindowState = FormWindowState.Minimized));
            }
            Process.Start(WoWD_File1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadClient(2); // tbc
        }

        private void client_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e) { }

        private void client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => WindowState = FormWindowState.Minimized));
            }
            Process.Start(WoWD_File2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadClient(3); // wotlk
        }

        private void client_DownloadProgressChanged3(object sender, DownloadProgressChangedEventArgs e) { }

        private void client_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => WindowState = FormWindowState.Minimized));
            }
            Process.Start(WoWD_File3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DownloadClient(4); // cata
        }

        private void client_DownloadProgressChanged4(object sender, DownloadProgressChangedEventArgs e) { }

        private void client_DownloadFileCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => WindowState = FormWindowState.Minimized));
            }
            Process.Start(WoWD_File4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DownloadClient(5); // mop
        }

        private void client_DownloadProgressChanged5(object sender, DownloadProgressChangedEventArgs e) { }

        private void client_DownloadFileCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => WindowState = FormWindowState.Minimized));
            }
            Process.Start(WoWD_File5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DownloadClient(6); // wod
        }

        private void client_DownloadProgressChanged6(object sender, DownloadProgressChangedEventArgs e) { }

        private void client_DownloadFileCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => WindowState = FormWindowState.Minimized));
            }
            Process.Start(WoWD_File6);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Asandru/World-of-Warcraft-Downloader/issues");
        }
    }
}
