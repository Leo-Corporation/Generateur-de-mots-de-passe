using Générateur_de_mots_de_passe_3.Classes;
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

namespace Générateur_de_mots_de_passe_3
{
    public partial class UpdateAv : Form
    {
        public UpdateAv()
        {
            InitializeComponent();
        }

        private void UpdateAv_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            if (Language.Curent() == Languages.frFR)
            {
                gunaLabel3.Text = $"Version : {CheckVersion()}"; // Le label += dernière version (ex : 3.0.0.0)
            }
            else if (Language.Curent() == Languages.enUS)
            {
                gunaLabel3.Text = $"Version: {CheckVersion()}"; // Le label += dernière version (ex : 3.0.0.0)
            }
            if (Properties.Settings.Default.DarkTheme)
            {
                ChangeTheme(1); // Mettre le thème sombre
            }
            else
            {
                ChangeTheme(0); // Mettre le thème clair
            }
        }
        private string CheckVersion()
        {
            WebClient webClient = new WebClient();
            string version = webClient.DownloadString("https://raw.githubusercontent.com/Leo-Corporation/LeoCorp-Docs/master/Liens/Update%20System/G%C3%A9n%C3%A9rateur%20de%20mots%20de%20passe%203/Version.txt"); // Télécharger le numéro de version
            return version; // Retourne la version
        }
        private void ChangeTheme(int themeID)
        {
            // themeID = 0 White
            // themeID = 1 Dark
            if (themeID == 0) // Si thème clair
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
            else // Si thème sombre
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "/Xalyus Updater.exe");
            Application.Exit();
        }
    }
}
