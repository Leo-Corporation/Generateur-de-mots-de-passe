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
    public partial class EditCustomPreset : Form
    {
        bool IsGenRandom = false;
        public EditCustomPreset()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaRadioButton1.Checked == true) // Si Fixe sélectionné
            {
                gunaGroupBox1.Enabled = true;
                gunaGroupBox2.Enabled = false;
                IsGenRandom = false;
            }
            else // Si Aléatoire sélectionné
            {
                gunaGroupBox1.Enabled = false;
                gunaGroupBox2.Enabled = true;
                IsGenRandom = true;
            }
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (IsGenRandom)
            {
                try
                {
                    int randomNumber1 = int.Parse(gunaLineTextBox2.Text);
                    int randomNumber2 = int.Parse(gunaLineTextBox3.Text);
                    if (randomNumber1 > 0 && randomNumber2 > 0)
                    {
                        if (randomNumber1 < randomNumber2)
                        {
                            string[] UsableChar;
                            UsableChar = gunaTextBox1.Text.Split(new string[] { "," }, StringSplitOptions.None);
                            Properties.Settings.Default.CharLenght = UsableChar.Length;
                            Properties.Settings.Default.CustomRandom1 = randomNumber1;
                            Properties.Settings.Default.CustomRandom2 = randomNumber2;
                            Properties.Settings.Default.RandomGeneration = true;
                            Properties.Settings.Default.CustomChar = gunaTextBox1.Text;
                            Properties.Settings.Default.CustomSet = true;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            MessageBox.Show("Le premier nombre doit être inférieur au second", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le nombre sélectionné doit être plus grand que 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex) // En cas d'erreur
                {
                    MessageBox.Show("Veuillez spécifier un nombre valide." + Environment.NewLine + "Détails :" + Environment.NewLine + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // En cas d'erreur
                {
                    MessageBox.Show("Erreur :" + Environment.NewLine + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    int number = int.Parse(gunaLineTextBox1.Text);
                    if (number > 0) // Si le nombre de caractères est plus grand que 0
                    {
                        string[] UsableChar;
                        UsableChar = gunaTextBox1.Text.Split(new string[] { "," }, StringSplitOptions.None);
                        Properties.Settings.Default.CharLenght = UsableChar.Length;
                        Properties.Settings.Default.CustomNumber = number;
                        Properties.Settings.Default.CustomChar = gunaTextBox1.Text;
                        Properties.Settings.Default.CustomSet = true;
                        Properties.Settings.Default.RandomGeneration = false;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("La longueur du mot de passe doit être plus grande que 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex) // En cas d'erreur
                {
                    MessageBox.Show("Veuillez spécifier un nombre valide." + Environment.NewLine + "Détails :" + Environment.NewLine + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // En cas d'erreur
                {
                    MessageBox.Show("Erreur :" + Environment.NewLine + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void EditCustomPreset_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DarkTheme == true) // Si thème sombre activé
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaTextBox1.BaseColor = Color.FromArgb(50, 50, 72);
                gunaLineTextBox1.BackColor = Color.FromArgb(50, 50, 72);
                gunaLineTextBox2.BackColor = Color.FromArgb(50, 50, 72);
                gunaLineTextBox3.BackColor = Color.FromArgb(50, 50, 72);
                gunaTextBox1.FocusedBaseColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                gunaTextBox1.BaseColor = Color.White;
                gunaLineTextBox1.BackColor = Color.White;
                gunaLineTextBox2.BackColor = Color.White;
                gunaLineTextBox3.BackColor = Color.White;
                gunaTextBox1.FocusedBaseColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
            // Charger la configuration
            gunaTextBox1.Text = Properties.Settings.Default.CustomChar;
            if (Properties.Settings.Default.RandomGeneration)
            {
                gunaRadioButton2.Checked = true;
                gunaGroupBox2.Enabled = true;
                gunaLineTextBox2.Text = Properties.Settings.Default.CustomRandom1.ToString();
                gunaLineTextBox3.Text = Properties.Settings.Default.CustomRandom2.ToString();
            }
            else
            {
                gunaRadioButton1.Checked = true;
                gunaGroupBox1.Enabled = true;
                gunaLineTextBox1.Text = Properties.Settings.Default.CustomNumber.ToString();
            }
        }
    }
}
