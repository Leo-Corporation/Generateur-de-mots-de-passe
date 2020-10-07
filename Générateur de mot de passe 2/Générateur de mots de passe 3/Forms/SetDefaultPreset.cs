using Générateur_de_mots_de_passe_3.Classes;
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
            if (Properties.Settings.Default.DarkTheme)
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close();
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
                        if (Language.Curent() == Languages.frFR)
                        {
                            MessageBox.Show("Pas de préréglage personnalisé trouvé, veuillez en créer un.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Lors que le preset perso n'est pas set
                        }
                        else if (Language.Curent() == Languages.enUS)
                        {
                            MessageBox.Show("No custom preset found, please create one.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // Lors que le preset perso n'est pas set
                        }
                        new EditCustomPreset().Show();
                    }
                }
                else // Si aucun preset n'est sélectionné
                {
                    if (Language.Curent() == Languages.frFR)
                    {
                        MessageBox.Show("Veuillez sélectionner un préréglage"); // Si aucun préréglage n'est sélectionné
                    }
                    else if (Language.Curent() == Languages.enUS)
                    {
                        MessageBox.Show("Please select a preset"); // Si aucun préréglage n'est sélectionné
                    }
                }
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            SavePreference("Simple"); // Mettre le préréglage simple
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            SavePreference("Complexe"); // Mettre le préréglage complexe
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            SavePreference("Personnalisé"); // Mettre le préréglage personnalisé
        }
    }
}
