using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;
using System.Drawing;

namespace TaxSystem.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            string NassimRegular = $"{Environment.CurrentDirectory}\\MainFonts\\Bahij Nassim-Regular.ttf";
            string NassimBold = $"{Environment.CurrentDirectory}\\MainFonts\\Bahij Nassim-Bold.ttf";
            fontCollection.AddFontFile(NassimRegular);
            fontCollection.AddFontFile(NassimBold);
            FontFamily Regular = fontCollection.Families[0];
            FontFamily Bold = fontCollection.Families[1];
            Defaults.NassimRegular = new Font(Regular, 14, FontStyle.Regular);
            Defaults.NassimBold = new Font(Bold, 14, FontStyle.Bold);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
