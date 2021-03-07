using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Générateur_de_mots_de_passe_3.Classes;
using System.IO;
using Générateur_de_mots_de_passe_3.Forms;

namespace Générateur_de_mots_de_passe_3
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            LoadVersion(); // Charger la version
        }

        private void gunaPanel2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Leo-Corporation/Generateur-de-mots-de-passe/"); // Lien vers GitHub
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://leopeyronnet.wixsite.com/leopeyronnetcorp"); // Lien vers le site de Léo Corp
        }

        private void About_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this); // Mettre de l'ombre
            if (Properties.Settings.Default.DarkTheme == true) // Si le thème sombre est activé
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaLabel2.ForeColor = Color.White;
                gunaLabel3.ForeColor = Color.White;
                gunaLabel4.ForeColor = Color.White;
                gunaLabel6.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            else // Si le thème clair est activé
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaLabel2.ForeColor = Color.Black;
                gunaLabel3.ForeColor = Color.Black;
                gunaLabel4.ForeColor = Color.Black;
                gunaLabel6.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
        }

        private async void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (await IsUpdaterNeedUpdate()) // SI Xalyus Updater a besoin d'une mise à jour
            {
                new UpdateXalyusUpdater(false).Show();
            }
            else
            {
                string lastVersion = await LeoCorpLibrary.Update.GetLastVersionAsync("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/Version.txt");
                LeoCorpLibrary.Update.Check(Definitions.Version, lastVersion, new UpdateAv(), new UpdateUn());
            }
        }
        public bool UpdateAvailable(string version)
        {
            WebClient webClient = new WebClient();
            string lastVersion = webClient.DownloadString("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/Version.txt"); // Dernière version
            bool res; // Résultat final
            if (version == lastVersion)
            {
                res = false; // Pas de MAJs dispos
            }
            else
            {
                res = true; // MAJs dispos
            }
            return res;
        }
        public async Task<bool> IsUpdaterNeedUpdate()
        {
            bool result = false;
            try
            {

                WebClient webClient = new WebClient();
                var fileVersionInfo = FileVersionInfo.GetVersionInfo(Application.StartupPath + "/Xalyus Updater.exe");
                string version = fileVersionInfo.FileVersion;
                string lastVersion = await LeoCorpLibrary.Update.GetLastVersionAsync("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/Xalyus%20Updater/Version.txt");
                if (version != lastVersion)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;

            }
            catch (Exception ex)
            {
                new ErrorDialog(ex.Message, ex, Properties.Resources.hugo_fatal_error).Show();
                return false;
            }

        }

        private void LoadVersion() // Charger la version
        {
            gunaLabel3.Text = $"Version {Definitions.Version}"; // Mettre la version sur le label
            gunaLabel3.Left = (gunaPanel1.Width - gunaLabel3.Width) / 2; // Centrer le label
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://bit.ly/DownloadPassliss");
        }
    }
}
