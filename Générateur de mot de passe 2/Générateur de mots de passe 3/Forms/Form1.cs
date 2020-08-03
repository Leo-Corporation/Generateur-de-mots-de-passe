using Générateur_de_mots_de_passe_3.Forms;
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
            menu1.ThemeSet = themeID;
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
            menu1.Visible = false; // Cacher le menu
            // Système de génération d'un nombre aléatoire entre 9 et 20
            Random random = new Random();
            int number = random.Next(13, 25); // Nombre qui va être généré
            gunaLineTextBox1.Text = number.ToString(); // Le nombre va dans la textbox qui demande le nombre de caractères
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            menu1.Visible = false; // Cacher le menu
            if (Properties.Settings.Default.DefaultPreset == "Simple")
            {
                if (!string.IsNullOrWhiteSpace(gunaLineTextBox1.Text))
                {
                    int textBoxNumber = int.Parse(gunaLineTextBox1.Text); // Conversion de 'string' en 'int'
                    GeneratePassword(textBoxNumber, 60, CharList);
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un nombre");
                }
            }
            else if (Properties.Settings.Default.DefaultPreset == "Complexe")
            {
                if (!string.IsNullOrWhiteSpace(gunaLineTextBox1.Text))
                {
                    int textBoxNumber = int.Parse(gunaLineTextBox1.Text); // Conversion de 'string' en 'int'
                    GeneratePassword(textBoxNumber, 65, CharList);
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un nombre");
                }
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

        public void GeneratePassword(int passwordLenght, int charLenght, string charList)
        {
            try //Essai
            {
                gunaLineTextBox1.Text = passwordLenght.ToString();
                UsableChar = charList.Split(new string[] { "," }, StringSplitOptions.None);
                FinalPassword = "";
                Number = 0;
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
                    new ErrorDialog("Le mot de passe doit être au moins long d'un caractère.", new Exception(), Properties.Resources.hugo_internet_security).Show();
                }
            }
            catch (FormatException ex) // En cas d'erreur où le nombre spécifié n'est pas valide
            {
                new ErrorDialog("Impossible de générer le mot de passe, car le nombre spécifié est invalide.", ex, Properties.Resources.hugo_internet_security).Show();
            }
            catch (Exception ex) // En cas d'erreur inconnue
            {
                new ErrorDialog("Impossibile de générer le mot de passe.", ex, Properties.Resources.hugo_fatal_error).Show();
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            menu1.Visible = false; // Cacher le menu
            new About().Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            menu1.Visible = false; // Cacher le menu
            new Settings(this).Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            menu1.Visible = false; // Cacher le menu
            new Presets(this).Show();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            menu1.Init();
            if (menu1.Visible) // Si le menu est visible
            {
                menu1.Visible = false; // Cacher
            }
            else
            {
                menu1.Visible = true; // Montrer
            }
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            menu1.Visible = false; // Cacher le menu
        }

        private void gunaLineTextBox1_Click(object sender, EventArgs e)
        {
            menu1.Visible = false; // Cacher le menu
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gunaTextBox1.Text)) // Vérifier si la textbox n'est pas vide
                Clipboard.SetText(gunaTextBox1.Text); // Copier le mot de passe
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Text = ""; // Effacer la textbox
        }
    }
}
