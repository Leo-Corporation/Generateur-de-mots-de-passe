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
    public partial class UpdateUn : Form
    {
        public UpdateUn()
        {
            InitializeComponent();
        }

        private void UpdateUn_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ChangeTheme(int themeID)
        {
            // themeID = 0 Clair
            // themeID = 1 Sombre
            if (themeID == 0) // Thème clair
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            else // Thème sombre
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
        }
    }
}
