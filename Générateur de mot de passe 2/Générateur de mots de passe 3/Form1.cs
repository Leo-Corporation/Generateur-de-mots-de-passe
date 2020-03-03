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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this); // Ajout de l'ombre sur Form1 (this)
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            // Système de génération d'un nombre aléatoire entre 9 et 20
            Random random = new Random();
            int number = random.Next(9, 20);
            gunaLineTextBox1.Text = number.ToString(); // Le nombre va dans la textbox qui demande le nombre de caractères
        }
    }
}
