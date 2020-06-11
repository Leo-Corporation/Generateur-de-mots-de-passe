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
        string[] UsableChar;
        Random RandomClass = new Random();
        string CharList = ("A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,/,é,&,ç,à");
        string FinalPassword = "";
        int Number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this); // Ajout de l'ombre sur Form1 (this)
            Guna.UI.Lib.GraphicsHelper.DrawLineShadow(menu1, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HorizontalBottom); // Ombre
            if (Properties.Settings.Default.DarkTheme == true)
            {
                ChangeTheme(1);
            }
            else
            {
                ChangeTheme(0);
            }
        }

        public void ChangeTheme(int themeID)
        {
            // themeID 0 = White
            // themeID 1 = Dark
            if (themeID == 1)
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaTextBox1.BaseColor = Color.FromArgb(50, 50, 72);
                gunaTextBox1.FocusedBaseColor = Color.FromArgb(50, 50, 72);
                gunaLineTextBox1.BackColor = Color.FromArgb(50, 50, 72);
                gunaControlBox1.IconColor = Color.White;
                gunaControlBox2.IconColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaTextBox1.BaseColor = Color.White;
                gunaTextBox1.FocusedBaseColor = Color.White;
                gunaLineTextBox1.BackColor = Color.White;
                gunaControlBox1.IconColor = Color.Black;
                gunaControlBox2.IconColor = Color.Black;
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            // Système de génération d'un nombre aléatoire entre 9 et 20
            Random random = new Random();
            int number = random.Next(9, 20);
            gunaLineTextBox1.Text = number.ToString(); // Le nombre va dans la textbox qui demande le nombre de caractères
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(gunaLineTextBox1.Text))
            {
                if (Properties.Settings.Default.DefaultPreset == "Simple")
                {
                    int textBoxNumber = int.Parse(gunaLineTextBox1.Text); // Conversion de 'string' en 'int'
                    GeneratePassword(textBoxNumber, 60, CharList);
                }
                else if (Properties.Settings.Default.DefaultPreset == "Complexe")
                {
                    int textBoxNumber = int.Parse(gunaLineTextBox1.Text); // Conversion de 'string' en 'int'
                    GeneratePassword(textBoxNumber, 65, CharList);
                }
                else if (Properties.Settings.Default.DefaultPreset == "Personnalisé")
                {
                    if (Properties.Settings.Default.RandomGeneration) // Si la génération de nombre aléatoire est activée
                    {
                        Random random = new Random(); // Génère un nombre aléatoire
                        int pwrLenght = random.Next(Properties.Settings.Default.CustomRandom1, Properties.Settings.Default.CustomRandom2);
                        GeneratePassword(pwrLenght, Properties.Settings.Default.CharLenght, Properties.Settings.Default.CustomChar);
                    }
                    else // Dans le cas contraire
                    {
                        int pwrLenght = Properties.Settings.Default.CustomNumber;
                        GeneratePassword(pwrLenght, Properties.Settings.Default.CharLenght, Properties.Settings.Default.CustomChar);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre");
            }
        }

        public void GeneratePassword(int passwordLenght, int charLenght, string charList)
        {
            gunaLineTextBox1.Text = passwordLenght.ToString();
            UsableChar = charList.Split(new string[] { "," }, StringSplitOptions.None);
            FinalPassword = "";
            Number = 0;
            try //Essai
            {
                if (passwordLenght > 0)
                {
                    for (int i = 0; i < passwordLenght; i++) // Tant que i < longueur du mot de passe
                    {
                        Number = RandomClass.Next(0, charLenght); // Générer un nombre aléatoire entre 0 et 60
                        FinalPassword = FinalPassword + UsableChar[Number]; // Ajouter au mot de passe un élément tiré au hasard de UsableChar.
                    }
                    gunaTextBox1.Text = FinalPassword;
                }
                else
                {
                    MessageBox.Show("Le mot de passe doit être au moins long d'un caractère.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex) // En cas d'erreur où le nombre spécifié n'est pas valide
            {
                MessageBox.Show("Impossible de générer le mot de passe, car le nombre spécifié est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // En cas d'erreur inconnue
            {
                MessageBox.Show("Impossible de générer le mot de passe." + Environment.NewLine + ex, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            new Settings(this).Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            new Presets(this).Show();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            if (menu1.Visible) // Si le menu est visible
            {
                menu1.Visible = false; // Cacher
            }
            else
            {
                menu1.Visible = true; // Montrer
            }
        }
    }
}
