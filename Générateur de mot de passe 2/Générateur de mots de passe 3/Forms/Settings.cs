using Générateur_de_mots_de_passe_3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_de_mots_de_passe_3
{
    public partial class Settings : Form
    {
        Form1 ths;
        public Settings(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            if (Properties.Settings.Default.DarkTheme == true)
            {
                gunaWinSwitch1.Checked = true;
                // Change le thème de Form1
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
                gunaComboBox1.BaseColor = Color.FromArgb(50, 50, 72);
            }
            else
            {
                gunaWinSwitch1.Checked = false;
                // Change le thème de Form1
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
                gunaComboBox1.BaseColor = Color.White;
            }
            if (Properties.Settings.Default.NotifyUpdate == true)
            {
                gunaWinSwitch2.Checked = true;
            }
            else
            {
                gunaWinSwitch2.Checked = false;
            }

            if (Language.Curent() == Languages.frFR)
            {
                gunaComboBox1.SelectedIndex = 0; // fr-FR
            }
            else if (Language.Curent() == Languages.enUS)
            {
                gunaComboBox1.SelectedIndex = 1; // en-US
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close(); // Close
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaWinSwitch1.Checked == true)
            {
                if (Language.Curent() == Languages.frFR)
                {
                    gunaLabel4.Text = "Activé";
                }
                else if (Language.Curent() == Languages.enUS)
                {
                    gunaLabel4.Text = "Enabled";
                }
            }
            else
            {
                if (Language.Curent() == Languages.frFR)
                {
                    gunaLabel4.Text = "Désactivé";
                }
                else if (Language.Curent() == Languages.enUS)
                {
                    gunaLabel4.Text = "Disabled";
                }
            }
            
        }

        private void gunaWinSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaWinSwitch2.Checked == true)
            {
                if (Language.Curent() == Languages.frFR)
                {
                    gunaLabel7.Text = "Activé";
                }
                else if (Language.Curent() == Languages.enUS)
                {
                    gunaLabel7.Text = "Enabled";
                }
            }
            else
            {
                if (Language.Curent() == Languages.frFR)
                {
                    gunaLabel7.Text = "Disabled";
                }
                else if (Language.Curent() == Languages.enUS)
                {
                    gunaLabel7.Text = "Disabled";
                }
            }
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (gunaWinSwitch1.Checked == true)
            {
                Properties.Settings.Default.DarkTheme = true;
                ths.ChangeTheme(1);
            }
            else
            {
                Properties.Settings.Default.DarkTheme = false;
                ths.ChangeTheme(0);
            }
            if (gunaWinSwitch2.Checked == true)
            {
                Properties.Settings.Default.NotifyUpdate = true;
            }
            else
            {
                Properties.Settings.Default.NotifyUpdate = false;
            }

            string curentLanguage = Properties.Settings.Default.Language;

            if (gunaComboBox1.Text.Contains("fr-FR"))
            {
                Properties.Settings.Default.Language = "fr-FR";
            }
            else if (gunaComboBox1.Text.Contains("en-US"))
            {
                Properties.Settings.Default.Language = "en-US";
            }

            if (Properties.Settings.Default.Language != curentLanguage)
            {
                if (Language.Curent() == Languages.frFR)
                {
                    MessageBox.Show("La langue du logiciel a changé, le logiciel va redémarrer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Language.Curent() == Languages.enUS)
                {
                    MessageBox.Show("The software's language has changed, to apply changes, the software will restart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Properties.Settings.Default.Save();
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }

            Properties.Settings.Default.Save();
            Close();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Language.Curent() == Languages.frFR)
            {
                string theme = "Thème sombre : " + Properties.Settings.Default.DarkTheme;
                string notifyUpdate = "Notifier des mises à jour : " + Properties.Settings.Default.NotifyUpdate;
                string presetSet = "Préréglage personnalisé configuré : " + Properties.Settings.Default.CustomSet;
                string presetChar = "Caractères personnalisées : " + Properties.Settings.Default.CustomChar;
                MessageBox.Show("Voici vos données" + Environment.NewLine + theme + Environment.NewLine + notifyUpdate + Environment.NewLine + presetSet + Environment.NewLine + presetChar, "Vos données", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Language.Curent() == Languages.enUS)
            {
                string theme = "Dark theme: " + Properties.Settings.Default.DarkTheme;
                string notifyUpdate = "Notify updates: " + Properties.Settings.Default.NotifyUpdate;
                string presetSet = "Custom preset configured: " + Properties.Settings.Default.CustomSet;
                string presetChar = "Custom characters: " + Properties.Settings.Default.CustomChar;
                MessageBox.Show("Here's your data" + Environment.NewLine + theme + Environment.NewLine + notifyUpdate + Environment.NewLine + presetSet + Environment.NewLine + presetChar, "Your data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void gunaLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Réinitialiser les données
            Properties.Settings.Default.CustomChar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,/,é,&,ç,à";
            Properties.Settings.Default.CustomNumber = 0;
            Properties.Settings.Default.CustomRandom1 = 0;
            Properties.Settings.Default.CustomRandom2 = 0;
            Properties.Settings.Default.CustomSet = false;
            Properties.Settings.Default.CharLenght = 0;
            Properties.Settings.Default.RandomGeneration = false;
            Properties.Settings.Default.DefaultPreset = "Simple";
            if (Language.Curent() == Languages.frFR)
            {
                MessageBox.Show("Données réinitialisées");
            }
            else if (Language.Curent() == Languages.enUS)
            {
                MessageBox.Show("Data reinitialized");
            }
        }

        private void gunaLinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Réinitialiser le logiciel
            Properties.Settings.Default.Reset();
            gunaWinSwitch1.Checked = false;
            gunaWinSwitch2.Checked = true;
            if (Language.Curent() == Languages.frFR)
            {
                MessageBox.Show("Le logiciel a été réinitialisé");
            }
            else if (Language.Curent() == Languages.enUS)
            {
                MessageBox.Show("The spftware has been reinitialized");
            }
        }

        private void gunaLinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SetDefaultPreset().Show();
        }
    }
}
