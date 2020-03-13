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
    public partial class SetDefaultPreset : Form
    {
        public SetDefaultPreset()
        {
            InitializeComponent();
        }

        private void SetDefaultPreset_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            SavePreference(gunaComboBox1.Text);
        }
        private void SavePreference(string preset)
        {
            if (!string.IsNullOrWhiteSpace(preset)) // Si le preset n'est pas vide ou 'null'
            {
                if (preset == "Simple") // Si le preset est simple (valeur par défaut)
                {
                    Properties.Settings.Default.DefaultPreset = "Simple"; // Update Settings
                    Close();
                }
                else if (preset == "Complexe") // Si le preset est complexe
                {
                    Properties.Settings.Default.DefaultPreset = "Complexe"; // Update Settings
                    Close();
                }
                else if (preset == "Personnalisé") // Si le preset est personnalisé
                {
                    if (Properties.Settings.Default.CustomSet) // Vérification si le preset perso est défini
                    {
                        Properties.Settings.Default.DefaultPreset = "Personnalisé"; // Update Settings
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Pas de préréglage personnalisé trouvé, veuillez en créer un."); // Lors que le preset perso n'est pas set
                        new EditCustomPreset().Show();
                    }
                }
                else // Si aucun preset n'est sélectionné
                {
                    MessageBox.Show("Veuillez sélectionner un préréglage"); // Si aucun préréglage n'est sélectionné
                }
            }
        }
    }
}
