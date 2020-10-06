using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Générateur_de_mots_de_passe_3.Classes
{
    public static class Definitions
    {
        public static readonly string Version = "3.7.0.2010-rc1"; // Version du logiciel
        public static readonly Color WeakPasswordColor = Color.FromArgb(255, 50, 0); // Couleur si le mot de passe est faible
        public static readonly Color GoodPasswordColor = Color.FromArgb(140, 223, 23); // Couleur si le mot de passe est bon
        public static readonly Color StrongPasswordColor = Color.FromArgb(29, 225, 55); // Couleur si le mot de passe est faible
        public static readonly string WeakPasswordMessage = "Le mot de passe est faible"; // Message si le mot de passe est faible
        public static readonly string GoodPasswordMessage = "Le mot de passe est bon"; // Message si le mot de passe est bon
        public static readonly string StrongPasswordMessage = "Le mot de passe est excellent"; // Message si le mot de passe est excellent

        public static readonly string WeakPasswordMessageENUS = "The password is weak"; // Message si le mot de passe est faible
        public static readonly string GoodPasswordMessageENUS = "The password is good"; // Message si le mot de passe est bon
        public static readonly string StrongPasswordMessageENUS = "The password is strong"; // Message si le mot de passe est excellent
    }
}
