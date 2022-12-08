
namespace SQLBackup
{
    partial class frmSQLYedekleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLYedekleme));
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.SQLYedek_Icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cnt_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctn_Menu_Cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_YedeklenecekLokasyon = new System.Windows.Forms.TextBox();
            this.lbl_YedeklenecekLokasyon = new System.Windows.Forms.Label();
            this.lbl_SQLBaglanti = new System.Windows.Forms.Label();
            this.txt_Connection = new System.Windows.Forms.TextBox();
            this.dateTimePicker_CalismaZamani = new System.Windows.Forms.DateTimePicker();
            this.lbl_PlanlananSaat = new System.Windows.Forms.Label();
            this.btn_KaydetBaslat = new System.Windows.Forms.Button();
            this.lbl_KalanSure = new System.Windows.Forms.Label();
            this.lbl_YedeklemeKalanSure = new System.Windows.Forms.Label();
            this.timer_Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.btn_KayitYeri = new System.Windows.Forms.Button();
            this.cmb_Server = new System.Windows.Forms.ComboBox();
            this.lbl_VeritabaniSunucusu = new System.Windows.Forms.Label();
            this.lbl_Veritabani = new System.Windows.Forms.Label();
            this.lst_PlanlananSaatler = new System.Windows.Forms.ListBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.lbl_PlanlanmisSaatler = new System.Windows.Forms.Label();
            this.chk_WindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Kopyala = new System.Windows.Forms.Button();
            this.linkLabel_Katilim = new System.Windows.Forms.LinkLabel();
            this.lbl_Dil = new System.Windows.Forms.Label();
            this.cmb_UygulamaDili = new System.Windows.Forms.ComboBox();
            this.cmb_Database = new PresentationControls.CheckBoxComboBox();
            this.chk_Windows_baslata_ekle = new System.Windows.Forms.CheckBox();
            this.cnt_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQLYedek_Icon
            // 
            this.SQLYedek_Icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SQLYedek_Icon.ContextMenuStrip = this.cnt_Menu;
            this.SQLYedek_Icon.Icon = ((System.Drawing.Icon)(resources.GetObject("SQLYedek_Icon.Icon")));
            this.SQLYedek_Icon.Text = "SQL Kolay Yedekleme";
            this.SQLYedek_Icon.Visible = true;
            this.SQLYedek_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SQLYedek_Icon_MouseDoubleClick);
            // 
            // cnt_Menu
            // 
            this.cnt_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctn_Menu_Cikis});
            this.cnt_Menu.Name = "cnt_Menu";
            this.cnt_Menu.Size = new System.Drawing.Size(100, 26);
            // 
            // ctn_Menu_Cikis
            // 
            this.ctn_Menu_Cikis.Name = "ctn_Menu_Cikis";
            this.ctn_Menu_Cikis.Size = new System.Drawing.Size(99, 22);
            this.ctn_Menu_Cikis.Text = "Çıkış";
            this.ctn_Menu_Cikis.Click += new System.EventHandler(this.ctn_Menu_Cikis_Click);
            // 
            // txt_YedeklenecekLokasyon
            // 
            this.txt_YedeklenecekLokasyon.Location = new System.Drawing.Point(11, 457);
            this.txt_YedeklenecekLokasyon.Name = "txt_YedeklenecekLokasyon";
            this.txt_YedeklenecekLokasyon.Size = new System.Drawing.Size(241, 20);
            this.txt_YedeklenecekLokasyon.TabIndex = 0;
            // 
            // lbl_YedeklenecekLokasyon
            // 
            this.lbl_YedeklenecekLokasyon.AutoSize = true;
            this.lbl_YedeklenecekLokasyon.Location = new System.Drawing.Point(12, 438);
            this.lbl_YedeklenecekLokasyon.Name = "lbl_YedeklenecekLokasyon";
            this.lbl_YedeklenecekLokasyon.Size = new System.Drawing.Size(125, 13);
            this.lbl_YedeklenecekLokasyon.TabIndex = 1;
            this.lbl_YedeklenecekLokasyon.Text = "Yedeklenecek Lokasyon";
            // 
            // lbl_SQLBaglanti
            // 
            this.lbl_SQLBaglanti.AutoSize = true;
            this.lbl_SQLBaglanti.Location = new System.Drawing.Point(12, 380);
            this.lbl_SQLBaglanti.Name = "lbl_SQLBaglanti";
            this.lbl_SQLBaglanti.Size = new System.Drawing.Size(162, 13);
            this.lbl_SQLBaglanti.TabIndex = 5;
            this.lbl_SQLBaglanti.Text = "SQL Bağlantı (Connection String)";
            // 
            // txt_Connection
            // 
            this.txt_Connection.Location = new System.Drawing.Point(11, 399);
            this.txt_Connection.Name = "txt_Connection";
            this.txt_Connection.ReadOnly = true;
            this.txt_Connection.Size = new System.Drawing.Size(241, 20);
            this.txt_Connection.TabIndex = 4;
            // 
            // dateTimePicker_CalismaZamani
            // 
            this.dateTimePicker_CalismaZamani.CustomFormat = "HH:mm";
            this.dateTimePicker_CalismaZamani.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CalismaZamani.Location = new System.Drawing.Point(13, 338);
            this.dateTimePicker_CalismaZamani.Name = "dateTimePicker_CalismaZamani";
            this.dateTimePicker_CalismaZamani.ShowUpDown = true;
            this.dateTimePicker_CalismaZamani.Size = new System.Drawing.Size(59, 20);
            this.dateTimePicker_CalismaZamani.TabIndex = 6;
            // 
            // lbl_PlanlananSaat
            // 
            this.lbl_PlanlananSaat.AutoSize = true;
            this.lbl_PlanlananSaat.Location = new System.Drawing.Point(12, 320);
            this.lbl_PlanlananSaat.Name = "lbl_PlanlananSaat";
            this.lbl_PlanlananSaat.Size = new System.Drawing.Size(65, 13);
            this.lbl_PlanlananSaat.TabIndex = 7;
            this.lbl_PlanlananSaat.Text = "Planan Saat";
            // 
            // btn_KaydetBaslat
            // 
            this.btn_KaydetBaslat.Location = new System.Drawing.Point(165, 510);
            this.btn_KaydetBaslat.Name = "btn_KaydetBaslat";
            this.btn_KaydetBaslat.Size = new System.Drawing.Size(126, 23);
            this.btn_KaydetBaslat.TabIndex = 8;
            this.btn_KaydetBaslat.Text = global::SQLBackup.Localization.KaydetBaslat;
            this.btn_KaydetBaslat.UseVisualStyleBackColor = true;
            this.btn_KaydetBaslat.Click += new System.EventHandler(this.btn_KaydetBaslat_Click);
            // 
            // lbl_KalanSure
            // 
            this.lbl_KalanSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KalanSure.Location = new System.Drawing.Point(12, 29);
            this.lbl_KalanSure.Name = "lbl_KalanSure";
            this.lbl_KalanSure.Size = new System.Drawing.Size(279, 49);
            this.lbl_KalanSure.TabIndex = 9;
            this.lbl_KalanSure.Text = "00:00";
            this.lbl_KalanSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_YedeklemeKalanSure
            // 
            this.lbl_YedeklemeKalanSure.AutoSize = true;
            this.lbl_YedeklemeKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YedeklemeKalanSure.Location = new System.Drawing.Point(10, 5);
            this.lbl_YedeklemeKalanSure.Name = "lbl_YedeklemeKalanSure";
            this.lbl_YedeklemeKalanSure.Size = new System.Drawing.Size(256, 24);
            this.lbl_YedeklemeKalanSure.TabIndex = 10;
            this.lbl_YedeklemeKalanSure.Text = "Yedekleme için kalan süre";
            // 
            // timer_Zamanlayici
            // 
            this.timer_Zamanlayici.Interval = 1000;
            this.timer_Zamanlayici.Tick += new System.EventHandler(this.timer_Zamanlayici_Tick);
            // 
            // btn_KayitYeri
            // 
            this.btn_KayitYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitYeri.Location = new System.Drawing.Point(258, 457);
            this.btn_KayitYeri.Name = "btn_KayitYeri";
            this.btn_KayitYeri.Size = new System.Drawing.Size(33, 20);
            this.btn_KayitYeri.TabIndex = 11;
            this.btn_KayitYeri.Text = "...";
            this.btn_KayitYeri.UseVisualStyleBackColor = true;
            this.btn_KayitYeri.Click += new System.EventHandler(this.btn_KayitYeri_Click);
            // 
            // cmb_Server
            // 
            this.cmb_Server.FormattingEnabled = true;
            this.cmb_Server.Location = new System.Drawing.Point(15, 145);
            this.cmb_Server.Name = "cmb_Server";
            this.cmb_Server.Size = new System.Drawing.Size(237, 21);
            this.cmb_Server.TabIndex = 12;
            this.cmb_Server.SelectedIndexChanged += new System.EventHandler(this.cmb_Server_SelectedIndexChanged);
            // 
            // lbl_VeritabaniSunucusu
            // 
            this.lbl_VeritabaniSunucusu.AutoSize = true;
            this.lbl_VeritabaniSunucusu.Location = new System.Drawing.Point(12, 125);
            this.lbl_VeritabaniSunucusu.Name = "lbl_VeritabaniSunucusu";
            this.lbl_VeritabaniSunucusu.Size = new System.Drawing.Size(105, 13);
            this.lbl_VeritabaniSunucusu.TabIndex = 13;
            this.lbl_VeritabaniSunucusu.Text = "Veritabanı Sunucusu";
            // 
            // lbl_Veritabani
            // 
            this.lbl_Veritabani.AutoSize = true;
            this.lbl_Veritabani.Location = new System.Drawing.Point(12, 173);
            this.lbl_Veritabani.Name = "lbl_Veritabani";
            this.lbl_Veritabani.Size = new System.Drawing.Size(54, 13);
            this.lbl_Veritabani.TabIndex = 15;
            this.lbl_Veritabani.Text = "Veritabanı";
            // 
            // lst_PlanlananSaatler
            // 
            this.lst_PlanlananSaatler.FormattingEnabled = true;
            this.lst_PlanlananSaatler.Location = new System.Drawing.Point(145, 314);
            this.lst_PlanlananSaatler.Name = "lst_PlanlananSaatler";
            this.lst_PlanlananSaatler.Size = new System.Drawing.Size(107, 56);
            this.lst_PlanlananSaatler.Sorted = true;
            this.lst_PlanlananSaatler.TabIndex = 16;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(81, 338);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(58, 20);
            this.btn_Ekle.TabIndex = 17;
            this.btn_Ekle.Text = "Ekle ->";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // lbl_PlanlanmisSaatler
            // 
            this.lbl_PlanlanmisSaatler.AutoSize = true;
            this.lbl_PlanlanmisSaatler.Location = new System.Drawing.Point(143, 301);
            this.lbl_PlanlanmisSaatler.Name = "lbl_PlanlanmisSaatler";
            this.lbl_PlanlanmisSaatler.Size = new System.Drawing.Size(93, 13);
            this.lbl_PlanlanmisSaatler.TabIndex = 18;
            this.lbl_PlanlanmisSaatler.Text = "Planlanmış Saatler";
            // 
            // chk_WindowsAuthentication
            // 
            this.chk_WindowsAuthentication.AutoSize = true;
            this.chk_WindowsAuthentication.Checked = true;
            this.chk_WindowsAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_WindowsAuthentication.Location = new System.Drawing.Point(15, 227);
            this.chk_WindowsAuthentication.Name = "chk_WindowsAuthentication";
            this.chk_WindowsAuthentication.Size = new System.Drawing.Size(141, 17);
            this.chk_WindowsAuthentication.TabIndex = 19;
            this.chk_WindowsAuthentication.Text = "Windows Authentication";
            this.chk_WindowsAuthentication.UseVisualStyleBackColor = true;
            this.chk_WindowsAuthentication.CheckedChanged += new System.EventHandler(this.chk_WindowsAuthentication_CheckedChanged);
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(12, 252);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.lbl_KullaniciAdi.TabIndex = 20;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(143, 252);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_Sifre.TabIndex = 21;
            this.lbl_Sifre.Text = "Şifre";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Enabled = false;
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(15, 268);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(122, 20);
            this.txt_KullaniciAdi.TabIndex = 22;
            this.txt_KullaniciAdi.TextChanged += new System.EventHandler(this.txt_KullaniciAdiSifre_TextChanged);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Enabled = false;
            this.txt_Sifre.Location = new System.Drawing.Point(146, 268);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(106, 20);
            this.txt_Sifre.TabIndex = 23;
            this.txt_Sifre.TextChanged += new System.EventHandler(this.txt_KullaniciAdiSifre_TextChanged);
            // 
            // btn_Kopyala
            // 
            this.btn_Kopyala.BackgroundImage = global::SQLBackup.Properties.Resources.copy;
            this.btn_Kopyala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Kopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kopyala.Location = new System.Drawing.Point(256, 392);
            this.btn_Kopyala.Name = "btn_Kopyala";
            this.btn_Kopyala.Size = new System.Drawing.Size(33, 33);
            this.btn_Kopyala.TabIndex = 24;
            this.btn_Kopyala.Text = "...";
            this.btn_Kopyala.UseVisualStyleBackColor = true;
            this.btn_Kopyala.Click += new System.EventHandler(this.btn_Kopyala_Click);
            // 
            // linkLabel_Katilim
            // 
            this.linkLabel_Katilim.AutoSize = true;
            this.linkLabel_Katilim.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel_Katilim.Location = new System.Drawing.Point(9, 512);
            this.linkLabel_Katilim.Name = "linkLabel_Katilim";
            this.linkLabel_Katilim.Size = new System.Drawing.Size(118, 18);
            this.linkLabel_Katilim.TabIndex = 25;
            this.linkLabel_Katilim.TabStop = true;
            this.linkLabel_Katilim.Text = "Uygulama Hakkında";
            this.linkLabel_Katilim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Katilim_LinkClicked);
            // 
            // lbl_Dil
            // 
            this.lbl_Dil.AutoSize = true;
            this.lbl_Dil.Location = new System.Drawing.Point(12, 96);
            this.lbl_Dil.Name = "lbl_Dil";
            this.lbl_Dil.Size = new System.Drawing.Size(19, 13);
            this.lbl_Dil.TabIndex = 26;
            this.lbl_Dil.Text = "Dil";
            // 
            // cmb_UygulamaDili
            // 
            this.cmb_UygulamaDili.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UygulamaDili.FormattingEnabled = true;
            this.cmb_UygulamaDili.Items.AddRange(new object[] {
            "English",
            "Turkish"});
            this.cmb_UygulamaDili.Location = new System.Drawing.Point(113, 93);
            this.cmb_UygulamaDili.Name = "cmb_UygulamaDili";
            this.cmb_UygulamaDili.Size = new System.Drawing.Size(139, 21);
            this.cmb_UygulamaDili.TabIndex = 27;
            this.cmb_UygulamaDili.SelectedValueChanged += new System.EventHandler(this.cmb_UygulamaDili_SelectedValueChanged);
            // 
            // cmb_Database
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmb_Database.CheckBoxProperties = checkBoxProperties1;
            this.cmb_Database.DisplayMemberSingleItem = "";
            this.cmb_Database.FormattingEnabled = true;
            this.cmb_Database.Location = new System.Drawing.Point(15, 193);
            this.cmb_Database.Name = "cmb_Database";
            this.cmb_Database.Size = new System.Drawing.Size(237, 21);
            this.cmb_Database.TabIndex = 28;
            this.cmb_Database.SelectedIndexChanged += new System.EventHandler(this.cmb_Database_SelectedIndexChanged);
            // 
            // chk_Windows_baslata_ekle
            // 
            this.chk_Windows_baslata_ekle.AutoSize = true;
            this.chk_Windows_baslata_ekle.Location = new System.Drawing.Point(13, 488);
            this.chk_Windows_baslata_ekle.Name = "chk_Windows_baslata_ekle";
            this.chk_Windows_baslata_ekle.Size = new System.Drawing.Size(198, 17);
            this.chk_Windows_baslata_ekle.TabIndex = 29;
            this.chk_Windows_baslata_ekle.Text = "Bilgisayarın açılışında otomatik başlat";
            this.chk_Windows_baslata_ekle.UseVisualStyleBackColor = true;
            // 
            // frmSQLYedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 537);
            this.Controls.Add(this.chk_Windows_baslata_ekle);
            this.Controls.Add(this.cmb_Database);
            this.Controls.Add(this.cmb_UygulamaDili);
            this.Controls.Add(this.lbl_Dil);
            this.Controls.Add(this.linkLabel_Katilim);
            this.Controls.Add(this.btn_Kopyala);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.chk_WindowsAuthentication);
            this.Controls.Add(this.lbl_PlanlanmisSaatler);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.lst_PlanlananSaatler);
            this.Controls.Add(this.lbl_Veritabani);
            this.Controls.Add(this.lbl_VeritabaniSunucusu);
            this.Controls.Add(this.cmb_Server);
            this.Controls.Add(this.btn_KayitYeri);
            this.Controls.Add(this.lbl_YedeklemeKalanSure);
            this.Controls.Add(this.lbl_KalanSure);
            this.Controls.Add(this.btn_KaydetBaslat);
            this.Controls.Add(this.lbl_PlanlananSaat);
            this.Controls.Add(this.dateTimePicker_CalismaZamani);
            this.Controls.Add(this.lbl_SQLBaglanti);
            this.Controls.Add(this.txt_Connection);
            this.Controls.Add(this.lbl_YedeklenecekLokasyon);
            this.Controls.Add(this.txt_YedeklenecekLokasyon);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSQLYedekleme";
            this.Text = "SQL Kolay Yedekleme";
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmSQLYedekleme_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSQLYedekleme_FormClosing);
            this.Load += new System.EventHandler(this.frmSQLYedekleme_Load);
            this.Shown += new System.EventHandler(this.frmSQLYedekleme_Shown);
            this.cnt_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SQLYedek_Icon;
        private System.Windows.Forms.TextBox txt_YedeklenecekLokasyon;
        private System.Windows.Forms.Label lbl_YedeklenecekLokasyon;
        private System.Windows.Forms.Label lbl_SQLBaglanti;
        private System.Windows.Forms.TextBox txt_Connection;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CalismaZamani;
        private System.Windows.Forms.Label lbl_PlanlananSaat;
        private System.Windows.Forms.Button btn_KaydetBaslat;
        private System.Windows.Forms.Label lbl_KalanSure;
        private System.Windows.Forms.Label lbl_YedeklemeKalanSure;
        private System.Windows.Forms.Timer timer_Zamanlayici;
        private System.Windows.Forms.Button btn_KayitYeri;
        private System.Windows.Forms.ComboBox cmb_Server;
        private System.Windows.Forms.Label lbl_VeritabaniSunucusu;
        private System.Windows.Forms.Label lbl_Veritabani;
        private System.Windows.Forms.ListBox lst_PlanlananSaatler;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label lbl_PlanlanmisSaatler;
        private System.Windows.Forms.ContextMenuStrip cnt_Menu;
        private System.Windows.Forms.ToolStripMenuItem ctn_Menu_Cikis;
        private System.Windows.Forms.CheckBox chk_WindowsAuthentication;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_Kopyala;
        private System.Windows.Forms.LinkLabel linkLabel_Katilim;
        private System.Windows.Forms.Label lbl_Dil;
        private System.Windows.Forms.ComboBox cmb_UygulamaDili;
        private PresentationControls.CheckBoxComboBox cmb_Database;
        private System.Windows.Forms.CheckBox chk_Windows_baslata_ekle;
    }
}

