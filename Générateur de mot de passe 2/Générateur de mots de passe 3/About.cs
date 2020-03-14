﻿using System;
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

namespace Générateur_de_mots_de_passe_3
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (UpdateAvailable("3.0.0.2003"))
            {
                new UpdateAv().Show();
            }
            else
            {
                new UpdateUn().Show();
            }
        }
        public bool UpdateAvailable(string version)
        {
            WebClient webClient = new WebClient();
            string lastVersion = webClient.DownloadString("https://www.dropbox.com/s/vznptlc9no896z1/Version.txt?dl=0"); // Dernière version
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
    }
}
