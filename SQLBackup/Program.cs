using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SQLBackup
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SQLBackupAyarlar Ayarlar = AyarlariOku();
            if (Ayarlar != null)
                Localization.Culture = new CultureInfo(Ayarlar.UygulamaDili);
            else
                Localization.Culture = new CultureInfo("tr-TR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSQLYedekleme());
        }

        private static SQLBackupAyarlar AyarlariOku()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Ayarlar.json"))
            {
                return new JavaScriptSerializer().Deserialize<SQLBackupAyarlar>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\" + "Ayarlar.json"));
            }
            else
                return null;
        }
    }


}
