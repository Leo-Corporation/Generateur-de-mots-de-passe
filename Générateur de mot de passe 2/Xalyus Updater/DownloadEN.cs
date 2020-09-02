using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xalyus_Updater
{
    public partial class DownloadEN : Form
    {
        WebClient client = new WebClient();
        public DownloadEN()
        {
            InitializeComponent();
        }

        private void DownloadEN_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/en-US/Générateur de mots de passe 3.resources.dll";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(Application.StartupPath + "/en-US");
            }
            File.Delete(path);
            client = new WebClient();
            WebClient maj = new WebClient();
            string link = maj.DownloadString("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/downloadFR.txt");
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            if (!string.IsNullOrEmpty(link))
            {
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(link);
                    client.DownloadFileAsync(uri, path);
                });
                thread.Start();
            }
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                Process.Start(Application.StartupPath + "/Générateur de mots de passe 3.exe");
                Close();
            }));
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                gunaProgressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                gunaLabel6.Text = $"{string.Format("{0:0.##}", percentage)}%";
                gunaLabel6.Left = (this.ClientSize.Width - gunaLabel6.Width) / 2;
                gunaProgressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }
    }
}
