using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_de_mots_de_passe_3.Forms
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog(string message, Exception exception, Image image)
        {
            InitializeComponent();
            gunaLabel3.Text = message; // Afficher le message
            gunaLabel4.Text = exception.ToString(); // Afficher l'erreur
            pictureBox1.Image = image; // Mettre l'image
        }
    }
}
