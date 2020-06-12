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
using System.Runtime.CompilerServices;

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
            foreach (GunaAdvenceButton advenceButton in Controls)
            {
                if (advenceButton.Checked)
                {
                    advenceButton.ImageSize = new Size(15, 15);
                    advenceButton.ImageOffsetX = -4;
                }
                else
                {
                    advenceButton.ImageSize = new Size(25, 25);
                    advenceButton.ImageOffsetX = -4;
                }
            }
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
            Properties.Settings.Default.Save();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
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
            foreach (GunaAdvenceButton advenceButton in Controls)
            {
                if (advenceButton.Checked)
                {
                    advenceButton.ImageSize = new Size(15, 15);
                    advenceButton.ImageOffsetX = -4;
                }
                else
                {
                    advenceButton.ImageSize = new Size(25, 25);
                    advenceButton.ImageOffsetX = -4;
                }
            }
        }

        private int _theme;

        public int ThemeSet
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                ChangeTheme(value);
            }
        }

        private void ChangeTheme(int themeId)
        {
            if (themeId == 0) // Si le thème est clair
            {
                BackColor = Color.White;
                gunaAdvenceButton1.BaseColor = Color.White;
                gunaAdvenceButton2.BaseColor = Color.White;
                gunaAdvenceButton5.BaseColor = Color.White;
                gunaAdvenceButton1.ForeColor = Color.Black;
                gunaAdvenceButton2.ForeColor = Color.Black;
                gunaAdvenceButton5.ForeColor = Color.Black;
                gunaAdvenceButton1.Image = Properties.Resources.advanced_processor_black;
                gunaAdvenceButton2.Image = Properties.Resources.edit_black;
                gunaAdvenceButton5.Image = Properties.Resources.processor_black;
            }
            else // Si le thème est sombre
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaAdvenceButton1.BaseColor = Color.FromArgb(50, 50, 72);
                gunaAdvenceButton2.BaseColor = Color.FromArgb(50, 50, 72); ;
                gunaAdvenceButton5.BaseColor = Color.FromArgb(50, 50, 72); ;
                gunaAdvenceButton1.ForeColor = Color.White;
                gunaAdvenceButton2.ForeColor = Color.White;
                gunaAdvenceButton5.ForeColor = Color.White;
                gunaAdvenceButton1.Image = Properties.Resources.advanced_processor;
                gunaAdvenceButton2.Image = Properties.Resources.edit;
                gunaAdvenceButton5.Image = Properties.Resources.processor;
            }
        }
    }
}
