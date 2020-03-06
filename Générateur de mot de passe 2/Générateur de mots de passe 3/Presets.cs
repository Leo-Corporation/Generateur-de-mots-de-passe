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
    public partial class Presets : Form
    {
        Form1 ths;
        public Presets(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void Presets_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            if (Properties.Settings.Default.DarkTheme == true) // Si thème sombre est activé
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            else // Si thème clair est activé
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            int lenght = new Random().Next(9, 15);
            ths.GeneratePassword(lenght, 60);
            Close();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            int lenght = new Random().Next(19, 30);
            ths.GeneratePassword(lenght, 65);
            Close();
        }
    }
}
