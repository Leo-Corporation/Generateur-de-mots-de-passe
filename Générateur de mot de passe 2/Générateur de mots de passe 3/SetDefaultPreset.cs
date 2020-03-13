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

        }
        private void SavePreference(string preset)
        {
            if (!string.IsNullOrWhiteSpace(preset))
            {
                if (preset == "Simple")
                {
                    Properties.Settings.Default.DefaultPreset = "Simple";
                }
                else if (preset == "Complexe")
                {
                    Properties.Settings.Default.DefaultPreset = "Complexe";
                }
                else if (preset == "Personnalisé")
                {
                    if (Properties.Settings.Default.CustomSet)
                    {
                        Properties.Settings.Default.DefaultPreset = "Personnalisé";
                    }
                    else
                    {
                        MessageBox.Show("Pas de préréglage personnalisé trouvé, veuillez en créer un.");
                        new EditCustomPreset().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un préréglage");
                }
            }
        }
    }
}
