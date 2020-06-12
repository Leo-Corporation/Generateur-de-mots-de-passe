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
    public partial class Presets : Form
    {
        Form1 ths;
        string CharList = ("A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,/,é,&,ç,à");
        public Presets(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void Presets_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            if (Properties.Settings.Default.DarkTheme == true) // Si thème sombre est activé
            {
                BackColor = Color.FromArgb(50, 50, 72);
                gunaLabel1.ForeColor = Color.White;
                gunaControlBox1.IconColor = Color.White;
            }
            else // Si thème clair est activé
            {
                BackColor = Color.White;
                gunaLabel1.ForeColor = Color.Black;
                gunaControlBox1.IconColor = Color.Black;
            }
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            int lenght = new Random().Next(9, 15);
            ths.GeneratePassword(lenght, 60, CharList);
            Close();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            int lenght = new Random().Next(19, 30);
            ths.GeneratePassword(lenght, 65, CharList);
            Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            new EditCustomPreset().Show();
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            bool IsRandomGen = Properties.Settings.Default.RandomGeneration;
            bool IsCustomSet = Properties.Settings.Default.CustomSet;
            int number = Properties.Settings.Default.CustomNumber;
            int random1 = Properties.Settings.Default.CustomRandom1;
            int random2 = Properties.Settings.Default.CustomRandom2;
            int charLenght = Properties.Settings.Default.CharLenght;
            string characters = Properties.Settings.Default.CustomChar;
            if (IsCustomSet) // Si le preset custom est réglé
            {
                if (IsRandomGen) // Si la génération de nombre aléatoire est activée
                {
                    int finalNumber = new Random().Next(random1, random2);
                    ths.GeneratePassword(finalNumber, charLenght, characters);
                }
                else
                {
                    ths.GeneratePassword(number, charLenght, characters);
                }
                Close();
            }
            else
            {
                new EditCustomPreset().Show();
            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SetDefaultPreset().Show();
        }
    }
}
