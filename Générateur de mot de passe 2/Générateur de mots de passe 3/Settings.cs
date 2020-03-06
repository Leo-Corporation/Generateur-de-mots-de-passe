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
    }
}
