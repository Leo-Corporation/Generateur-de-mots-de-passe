using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            }
            else
            {
                gunaWinSwitch1.Checked = false;
                // Change le thème de Form1
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
            if (Properties.Settings.Default.NotifyUpdate == true)
            {
                gunaWinSwitch2.Checked = true;
            }
            else
            {
                gunaWinSwitch2.Checked = false;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaWinSwitch1.Checked == true)
            {
                gunaLabel4.Text = "Activé";
            }
            else
            {
                gunaLabel4.Text = "Désactivé";
            }
            
        }

        private void gunaWinSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaWinSwitch2.Checked == true)
            {
                gunaLabel7.Text = "Activé";
            }
            else
            {
                gunaLabel7.Text = "Désactivé";
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
            Properties.Settings.Default.Save();
            Close();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string theme = "Thème sombre : " + Properties.Settings.Default.DarkTheme;
            string notifyUpdate = "Notifier des mises à jour : " + Properties.Settings.Default.NotifyUpdate;
            string presetSet = "Préréglage personnalisé configuré : " + Properties.Settings.Default.CustomSet;
            string presetChar = "Charactères personnalisées : " + Properties.Settings.Default.CustomChar;
            MessageBox.Show("Voici vos données" + Environment.NewLine + theme + Environment.NewLine + notifyUpdate + Environment.NewLine + presetSet + Environment.NewLine + presetChar, "Vos données", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Données réinitialisées");
        }

        private void gunaLinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Réinitialiser le logiciel
            Properties.Settings.Default.Reset();
            gunaWinSwitch1.Checked = false;
            gunaWinSwitch2.Checked = true;
            MessageBox.Show("Le logiciel a été réinitialisé");
        }
    }
}
