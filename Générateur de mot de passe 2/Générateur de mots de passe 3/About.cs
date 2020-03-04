using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Process.Start("https://github.com/Leo-Corporation/Generateur-de-mots-de-passe/");
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://leopeyronnet.wixsite.com/leopeyronnetcorp");
        }
    }
}
