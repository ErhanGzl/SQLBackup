using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SQLBackup
{
    public partial class frmSQLYedekleme : Form
    {
        public frmSQLYedekleme()
        {
            InitializeComponent();
        }

        #region Degiskenler

        TimeSpan PlanlananSaat;
        bool Cikis = false;
        private SQLBackupAyarlar ayarlar = null;
        List<TimeSpan> PlanlananSaatler = new List<TimeSpan>();
        List<string> PlanlananSaatlerList = new List<string>();

        #endregion Degiskenler

        private void frmSQLYedekleme_Load(object sender, EventArgs e)
        {
            dateTimePicker_CalismaZamani.Value = dateTimePicker_CalismaZamani.Value.AddHours(2);

            // Uygulamayı sağ alt bölüme yerleştirme
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

            linkLabel_Katilim.Text = Localization.GorusOneri;
            linkLabel_Katilim.Links.Clear();
            linkLabel_Katilim.Links.Add(0, "https://www.linkedin.com/in/erhan-g%C3%BCzel-7992b2b7".Length, "https://www.linkedin.com/in/erhan-g%C3%BCzel-7992b2b7");

            Baslat();

        }

        #region Eventler
        private void timer_Zamanlayici_Tick(object sender, EventArgs e)
        {
            PlanlananSaat += TimeSpan.FromSeconds(-1);
            if (PlanlananSaat.TotalSeconds < 0)
            {
                // Planlanan zaman geldiğinde yedeklemenin tetiklenmesi
                SQLYedekle();

                //Bir Sonraki Planlamanın ayarlanması
                BirSonrakiYedekleme();
            }
            lbl_KalanSure.Text = (PlanlananSaat).ToString(Localization.SaatFormati);
        }
        private void btn_KayitYeri_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            DialogResult dr = Fbd.ShowDialog();
            if (dr == DialogResult.OK)
                txt_YedeklenecekLokasyon.Text = Fbd.SelectedPath;
        }
        private void btn_KaydetBaslat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_Server.Text))
            {
                MessageBox.Show("Veritabanı Sunucusu Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cmb_Database.Text))
            {
                MessageBox.Show("Veri Tabanı Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lst_PlanlananSaatler.Items.Count == 0)
            {
                MessageBox.Show("Planan yedekleme zamanı ekleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_YedeklenecekLokasyon.Text))
            {
                MessageBox.Show("Yedeklenecek Lokasyon Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!chk_WindowsAuthentication.Checked)
            {
                if (string.IsNullOrEmpty(txt_KullaniciAdi.Text))
                {
                    MessageBox.Show("Kullanıcı Adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_Sifre.Text))
                {
                    MessageBox.Show("Şifre Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (SQLBaglantiTest())
            {
                var json = new JavaScriptSerializer().Serialize(new SQLBackupAyarlar() { Server = cmb_Server.Text, Veritabani = cmb_Database.Text, ConnectionString = txt_Connection.Text, GorevCalismaZamani = lst_PlanlananSaatler.Items.Cast<String>().ToList().ToArray(), YedeklenmeLokasyonu = txt_YedeklenecekLokasyon.Text, SQLYedeklemeKlasoru = GetirSQLYedeklemeKlasoru(), WindowsAuthentication = chk_WindowsAuthentication.Checked, SQLKullaniciAdi = chk_WindowsAuthentication.Checked ? string.Empty : txt_KullaniciAdi.Text, SQLSifre = chk_WindowsAuthentication.Checked ? string.Empty : txt_Sifre.Text, UygulamaDili = cmb_UygulamaDili.Text == "Turkish" ? "tr-TR" : "en-US" });
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\" + "Ayarlar.json", json);
                Baslat();
            }

        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            PlanlananSaatlerList.Add(dateTimePicker_CalismaZamani.Value.TimeOfDay.ToString("hh\\:mm"));
            lst_PlanlananSaatler.DataSource = null;
            lst_PlanlananSaatler.DataSource = PlanlananSaatlerList;
        }
        private void cmb_Server_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(string.Format("data source ='{0}';Initial Catalog = Master; Integrated Security = SSPI; ", cmb_Server.Text));
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM sys.databases where name not in ('master','tempdb','model','msdb')";
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Database.Items.Add(dr["name"]);
                }

                dr.Close();
                con.Close();
            }
            catch (Exception)
            { }
        }
        private void cmb_Database_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionStringOlustur();
        }
        private void ctn_Menu_Cikis_Click(object sender, EventArgs e)
        {
            Cikis = true;
            Application.Exit();
        }
        private void chk_WindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_WindowsAuthentication.Checked)
            {
                txt_KullaniciAdi.Enabled = false;
                txt_Sifre.Enabled = false;
            }
            else
            {
                txt_KullaniciAdi.Enabled = true;
                txt_Sifre.Enabled = true;
            }
            ConnectionStringOlustur();
        }
        private void txt_KullaniciAdiSifre_TextChanged(object sender, EventArgs e)
        {
            ConnectionStringOlustur();
        }
        private void SQLYedek_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.Show();
            SQLYedek_Icon.Visible = false;
        }
        private void frmSQLYedekleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cikis)
            {
                Hide();
                SQLYedek_Icon.Visible = true;
                SQLYedek_Icon.Text = "SQL Kolay Yedekleme";
                SQLYedek_Icon.BalloonTipText = "SQL Kolay Yedekleme Çalışıyor";
                SQLYedek_Icon.BalloonTipIcon = ToolTipIcon.Info;
                SQLYedek_Icon.ShowBalloonTip(2000);

                e.Cancel = true;

            }
        }
        private void frmSQLYedekleme_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            new AboutBox().Show();
        }
        private void linkLabel_Katilim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        private void cmb_UygulamaDili_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_Kopyala_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txt_Connection.Text);
        }

        private void frmSQLYedekleme_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion Eventler

        #region Methodlar

        private void Baslat()
        {
            SQLInstanceSorgula();

            // Kayıtlı Ayarlar var ise yükle
            if (AyarlariOku() != null)
            {
                PlanlananSaatlerList = ayarlar.GorevCalismaZamani.ToList();
                lst_PlanlananSaatler.DataSource = PlanlananSaatlerList;
                PlanlananSaatler = ayarlar.GorevCalismaZamani.Select(TimeSpan.Parse).ToList();
                cmb_Server.SelectedItem = ayarlar.Server;
                txt_YedeklenecekLokasyon.Text = ayarlar.YedeklenmeLokasyonu;
                chk_WindowsAuthentication.Checked = ayarlar.WindowsAuthentication;
                txt_KullaniciAdi.Text = ayarlar.SQLKullaniciAdi;
                txt_Sifre.Text = ayarlar.SQLSifre;

                string[] Database = ayarlar.Veritabani.Split(new[] { ", " }, StringSplitOptions.None);
                if (Database != null && Database.Length > 0)
                    foreach (var item in Database)
                    {
                        foreach (var chkitem in cmb_Database.CheckBoxItems)
                        {
                            if (chkitem.Text == item)
                                chkitem.Checked = true;
                        }

                    }

                ConnectionStringOlustur();

                cmb_UygulamaDili.Text = ayarlar.UygulamaDili == "tr-TR" ? "Turkish" : "English";

                TimeSpan PlanlananSaat = SonrakiSaat();

                BirSonrakiYedekleme();

                timer_Zamanlayici.Enabled = true;
                timer_Zamanlayici.Start();

            }

            // Açılışta sağ alta kapalı kalması için
            this.Close();

            // Uygulamayı windows açılışına ekle
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk.GetValue("SQLBackup") == null)
                rk.SetValue("SQLBackup", Application.ExecutablePath);
        }
        private void BirSonrakiYedekleme()
        {
            TimeSpan _PlanlananSaat = SonrakiSaat();

            DateTime date = new DateTime(DateTime.Now.Year, 1, 1);
            date = date.Add(_PlanlananSaat);
            dateTimePicker_CalismaZamani.Value = new DateTime(DateTime.Now.Year, 1, 1).Add(_PlanlananSaat);
            PlanlananSaat += _PlanlananSaat > DateTime.Now.TimeOfDay ? TimeSpan.FromHours(0) : TimeSpan.FromHours(24);// Saat 24 kadar planan yedekleme varmı var ise 0 yok ise +24
            PlanlananSaat = ((TimeSpan)(dateTimePicker_CalismaZamani.Value.TimeOfDay) - DateTime.Now.TimeOfDay);
            PlanlananSaat += PlanlananSaat.Hours < 0 ? TimeSpan.FromDays(1) : TimeSpan.FromMinutes(0);
        }
        private void SQLInstanceSorgula()
        {
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        cmb_Server.Items.Add(ServerName + (instanceName == "MSSQLSERVER" ? string.Empty : "\\" + instanceName.ToString()));
                    }
                }
            }
        }
        private void ConnectionStringOlustur()
        {
            if (chk_WindowsAuthentication.Checked)
                txt_Connection.Text = string.Format("data source ='{0}';Initial Catalog = Master; Integrated Security = SSPI; ", cmb_Server.Text, cmb_Database.Text);
            else
                txt_Connection.Text = string.Format("data source ={0};Initial Catalog = Master; User Id={2};Password='{3}';", cmb_Server.Text, cmb_Database.Text, txt_KullaniciAdi.Text, txt_Sifre.Text);
        }
        private string GetirSQLYedeklemeKlasoru()
        {
            string BackupDirectory = string.Empty;
            SqlConnection con = new SqlConnection(string.Format("data source ={0};Initial Catalog = Master; Integrated Security = SSPI; ", cmb_Server.Text));
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "declare @rc int, @dir nvarchar(4000) exec @rc = master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE', N'Software\\Microsoft\\MSSQLServer\\MSSQLServer', N'BackupDirectory', @dir output, 'no_output'select @dir AS BackupDirectory";
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BackupDirectory = dr["BackupDirectory"].ToString();
            }

            dr.Close();
            con.Close();

            return BackupDirectory;
        }
        private void SQLYedekle()
        {
            try
            {
                string[] Database = ayarlar.Veritabani.Split(new[] { ", " }, StringSplitOptions.None);
                if (Database != null && Database.Length > 0)
                {
                    foreach (var item in Database)
                    {
                        string BackupFileName = item + "_" + DateTime.Now.ToString("ddMMyyyyHHmms") + ".bak";
                        SqlConnection con = new SqlConnection(txt_Connection.Text);
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "BACKUP DATABASE " + item + " TO DISK = '" + ayarlar.SQLYedeklemeKlasoru + "\\" + BackupFileName + "';";

                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();

                        File.Move(ayarlar.SQLYedeklemeKlasoru + "\\" + BackupFileName, ayarlar.YedeklenmeLokasyonu + "\\" + BackupFileName);
                    }
                }

            }
            catch (Exception exx)
            {
                MessageBox.Show("Yedekleme yapılamadı :\r\n" + exx.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SQLBaglantiTest()
        {
            bool result = false;
            try
            {
                SqlConnection con = new SqlConnection(txt_Connection.Text);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                con.Close();
                return true;
            }
            catch (Exception exx)
            {
                MessageBox.Show("Bağlantı Başarısız.\r\nBilgilerinizi kontrol edin ve tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private SQLBackupAyarlar AyarlariOku()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Ayarlar.json"))
            {
                return ayarlar = new JavaScriptSerializer().Deserialize<SQLBackupAyarlar>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\" + "Ayarlar.json"));
            }
            else
                return null;
        }
        private TimeSpan SonrakiSaat()
        {
            foreach (TimeSpan item in PlanlananSaatler)
            {
                if (item > DateTime.Now.TimeOfDay)
                    return item;
            }

            return PlanlananSaatler[0];
        }

        #endregion Methodlar


    }

    /// <summary>
    /// Kullanıcın seçimlerini işleyebilmek için tanımlanan sınıf
    /// </summary>
    public class SQLBackupAyarlar
    {
        public string Server { get; set; }
        public string Veritabani { get; set; }
        public string ConnectionString { get; set; }
        public string[] GorevCalismaZamani { get; set; }
        public string YedeklenmeLokasyonu { get; set; }
        public string SQLYedeklemeKlasoru { get; set; }
        public bool WindowsAuthentication { get; set; }
        public string SQLKullaniciAdi { get; set; }
        public string SQLSifre { get; set; }
        public string UygulamaDili { get; set; }
    }
}
