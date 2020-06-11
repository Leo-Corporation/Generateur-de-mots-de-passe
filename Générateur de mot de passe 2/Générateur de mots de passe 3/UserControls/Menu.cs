using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Générateur_de_mots_de_passe_3.UserControls
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            Check(sender);
            UpdateSettings();
        }

        private void Check(object sender)
        {
            GunaAdvenceButton gunaAdvenceButton = (GunaAdvenceButton)sender;
            if (gunaAdvenceButton.Checked)
            {
                gunaAdvenceButton.ImageSize = new Size(15, 15);
            }
            else
            {
                gunaAdvenceButton.ImageSize = new Size(25, 25);
            }
        }

        private void UpdateSettings()
        {
            if (gunaAdvenceButton5.Checked) // Si "Simple"
            {
                Properties.Settings.Default.DefaultPreset = "Simple";
            }
            else if (gunaAdvenceButton1.Checked) // Si "Complexe"
            {
                Properties.Settings.Default.DefaultPreset = "Complexe";
            }
            else if (gunaAdvenceButton2.Checked) // Si "Personnalisé
            {
                Properties.Settings.Default.DefaultPreset = "Personnalisé";
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.CustomSet)
            {
                gunaAdvenceButton2.Checked = false; // Décocher
                gunaAdvenceButton2.Enabled = false; // Désactiver le bouton
            }
            switch (Properties.Settings.Default.DefaultPreset)
            {
                case "Simple": // Si "Simple"
                    gunaAdvenceButton5.Checked = true;
                    gunaAdvenceButton5.ImageSize = new Size(15, 15); // Changer la taille de l'image
                    break;
                case "Complexe": // Si "Complexe"
                    gunaAdvenceButton1.Checked = true;
                    gunaAdvenceButton1.ImageSize = new Size(15, 15); // Changer la taille de l'image
                    break;
                case "Personnalisé": // Si "Personnalisé"
                    gunaAdvenceButton2.Checked = true;
                    gunaAdvenceButton2.ImageSize = new Size(15, 15); // Changer la taille de l'image
                    break;
            }
        }
    }
}
