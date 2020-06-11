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

namespace Générateur_de_mots_de_passe_3
{
    public partial class UpdateXalyusUpdater : Form
    {
        WebClient client;
        bool isAdmin;
        public UpdateXalyusUpdater(bool fromAdmin)
        {
            InitializeComponent();
            isAdmin = fromAdmin;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            gunaAdvenceButton5.Enabled = false;
            string path = Application.StartupPath + "/Xalyus Updater.exe";
            File.Delete(path);
            client = new WebClient();
            WebClient maj = new WebClient();
            string link = maj.DownloadString("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/Xalyus%20Updater/Download.txt");
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
                if (new About().UpdateAvailable("3.1.0.2004"))
                {
                    new UpdateAv().Show();
                    Close();
                }
                else
                {
                    Application.Exit();
                    Process.Start(Application.StartupPath + "/Générateur de mots de passe 3.exe");
                }
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

        private void UpdateXalyusUpdater_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            if (isAdmin)
            {

            }
            else
            {
                MessageBox.Show("Des mises à jour pour un des services de Xalyus Store sont disponibles" + Environment.NewLine + "L'application va redémarrer en tant qu'administrateur.", "Mise à jour d'un service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                ExecuteAsAdmin(Application.StartupPath + "/Générateur de mots de passe 3.exe");
            }
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.Arguments = "adminmode";
            proc.Start();
        }
    }
}
