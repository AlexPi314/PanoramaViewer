using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text;

namespace PanoramaViewer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static MainForm MainF;
        public static SettingsForm SettingsF;

        public static bool ShowPanoramaName = Convert.ToBoolean(File.ReadAllLines(@"Data\Settings.data")[0].Remove(0, 10));
        public static bool SmoothCamera = Convert.ToBoolean(File.ReadAllLines(@"Data\Settings.data")[1].Remove(0, 10));
        public static bool ResizeImage = Convert.ToBoolean(File.ReadAllLines(@"Data\Settings.data")[2].Remove(0, 10));


        public static string Locale = File.ReadAllLines(@"Localizations\Localization.loc")[0];

        public static string[] LocaleBtns;
        public static string[] LocaleWindowsNames;
        public static string[] LocaleMessageBoxes;
        public static string[] LocaleLabelsMF;
        public static string[] LocaleLabelsSF;
        public static string[] LocaleOther;

        public static bool Luck = false;

        [STAThread]

        static void Main()
        {
            LangSystem();
            Parcer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainF = new MainForm());
        }

        public static void LangSystem()
        {
            if (File.ReadAllLines(@"Localizations\Localization.loc")[1] != "1")
            {
                for (int i = 0; i < Directory.GetDirectories(@"Localizations").Length; i++)
                {
                    if (Directory.GetDirectories(@"Localizations")[i].Remove(0, 14) == System.Globalization.CultureInfo.InstalledUICulture.Name)
                    {
                        File.WriteAllText(@"Localizations\Localization.loc", System.Globalization.CultureInfo.InstalledUICulture.Name + "\n1");
                        Locale = System.Globalization.CultureInfo.InstalledUICulture.Name;

                        LocaleBtns = File.ReadAllLines(@"Localizations\" + Locale + "\\Buttons.txt", Encoding.Default);
                        LocaleWindowsNames = File.ReadAllLines(@"Localizations\" + Locale + "\\Windows Names.txt", Encoding.Default);
                        LocaleMessageBoxes = File.ReadAllLines(@"Localizations\" + Locale + "\\Message Boxes.txt", Encoding.Default);
                        LocaleLabelsMF = File.ReadAllLines(@"Localizations\" + Locale + "\\Labels MF.txt", Encoding.Default);
                        LocaleLabelsSF = File.ReadAllLines(@"Localizations\" + Locale + "\\Labels SF.txt", Encoding.Default);
                        LocaleOther = File.ReadAllLines(@"Localizations\" + Locale + "\\Other.txt", Encoding.Default);

                        Luck = true;


                        break;
                    }
                }

                if (Luck == false)
                {
                    File.WriteAllText(@"Localizations\Localization.loc", "en-EN\n1");
                    Locale = "en-EN";
                    LocaleBtns = File.ReadAllLines(@"Localizations\" + Locale + "\\Buttons.txt", Encoding.Default);
                    LocaleWindowsNames = File.ReadAllLines(@"Localizations\" + Locale + "\\Windows Names.txt", Encoding.Default);
                    LocaleMessageBoxes = File.ReadAllLines(@"Localizations\" + Locale + "\\Message Boxes.txt", Encoding.Default);
                    LocaleLabelsMF = File.ReadAllLines(@"Localizations\" + Locale + "\\Labels MF.txt", Encoding.Default);
                    LocaleLabelsSF = File.ReadAllLines(@"Localizations\" + Locale + "\\Labels SF.txt", Encoding.Default);
                    LocaleOther = File.ReadAllLines(@"Localizations\" + Locale + "\\Other.txt", Encoding.Default);
                }
            }
            else
            {
                Locale = File.ReadAllLines(@"Localizations\Localization.loc")[0];

                LocaleBtns = File.ReadAllLines(@"Localizations\" + Locale + "\\Buttons.txt", Encoding.Default);
                LocaleWindowsNames = File.ReadAllLines(@"Localizations\" + Locale + "\\Windows Names.txt", Encoding.Default);
                LocaleMessageBoxes = File.ReadAllLines(@"Localizations\" + Locale + "\\Message Boxes.txt", Encoding.Default);
                LocaleLabelsMF = File.ReadAllLines(@"Localizations\" + Locale + "\\Labels MF.txt", Encoding.Default);
                LocaleLabelsSF = File.ReadAllLines(@"Localizations\" + Locale + "\\Labels SF.txt", Encoding.Default);
                LocaleOther = File.ReadAllLines(@"Localizations\" + Locale + "\\Other.txt", Encoding.Default);
            }
        }

        public static void Parcer()
        {
            for (int i = 0; i < LocaleMessageBoxes.Length; i++)
            {
                if (LocaleMessageBoxes[i].Contains(@"\n"))
                {
                    LocaleMessageBoxes[i] = LocaleMessageBoxes[i].Replace(@"\n", Environment.NewLine);
                }
            }
        }
    }
}
