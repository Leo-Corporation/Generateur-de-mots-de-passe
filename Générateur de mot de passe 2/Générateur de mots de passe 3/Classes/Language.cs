using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Générateur_de_mots_de_passe_3.Classes
{
    public static class Language
    {
        public static void Change(Form form)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);
        }

        public static Languages Curent()
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr-FR":
                    return Languages.frFR;
                case "en-US":
                    return Languages.enUS;
                default:
                    return Languages.frFR;
            }
        }

        public static string LanguageToString(Languages language)
        {
            switch (language)
            {
                case Languages.frFR:
                    return "fr-FR";
                case Languages.enUS:
                    return "en-US";
                default:
                    return "fr-FR";
            }
        }
    }

    public enum Languages
    {
        frFR, // French
        enUS // English
    }
}
