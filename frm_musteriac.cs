using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Sevemed_CRM
{
	/// <summary>
	/// Summary description for frm_musteriac.
	/// </summary>
	public class frm_musteriac : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel pnl_servisfisi;
		private System.Windows.Forms.Button btn_servisac;
		private System.Windows.Forms.Button btn_servisduzenle;
		private System.Windows.Forms.Button btn_servisfisi;
		private System.Windows.Forms.Panel pnl_musteri;
		private System.Windows.Forms.Button btn_musteriac;
		private System.Windows.Forms.Button btn_musteriduzenle;
		private System.Windows.Forms.Button btn_musteri;
		private System.Windows.Forms.Panel pnl_filtre;
		private System.Windows.Forms.Button btn_musterifiltre;
		private System.Windows.Forms.Button btn_servisfiltre;
		private System.Windows.Forms.Button btn_filtre;
		private System.Windows.Forms.Button btn_kaydet;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_cep;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txt_kmail;
		private System.Windows.Forms.TextBox txt_dahili;
		private System.Windows.Forms.TextBox txt_soyad;
		private System.Windows.Forms.TextBox txt_ad;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox rtb_notlar;
		private System.Windows.Forms.ComboBox cb_il;
		private System.Windows.Forms.TextBox txt_fmail;
		private System.Windows.Forms.TextBox txt_web;
		private System.Windows.Forms.TextBox txt_vergino;
		private System.Windows.Forms.TextBox txt_vergi;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_posta;
		private System.Windows.Forms.TextBox txt_faks;
		private System.Windows.Forms.TextBox txt_tel2;
		private System.Windows.Forms.TextBox txt_tel1;
		private System.Windows.Forms.TextBox txt_ilce;
		private System.Windows.Forms.TextBox txt_adres;
		private System.Windows.Forms.TextBox txt_firma;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_musteriac()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnl_servisfisi = new System.Windows.Forms.Panel();
			this.btn_servisac = new System.Windows.Forms.Button();
			this.btn_servisduzenle = new System.Windows.Forms.Button();
			this.btn_servisfisi = new System.Windows.Forms.Button();
			this.pnl_musteri = new System.Windows.Forms.Panel();
			this.btn_musteriac = new System.Windows.Forms.Button();
			this.btn_musteriduzenle = new System.Windows.Forms.Button();
			this.btn_musteri = new System.Windows.Forms.Button();
			this.pnl_filtre = new System.Windows.Forms.Panel();
			this.btn_musterifiltre = new System.Windows.Forms.Button();
			this.btn_servisfiltre = new System.Windows.Forms.Button();
			this.btn_filtre = new System.Windows.Forms.Button();
			this.btn_kaydet = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt_cep = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txt_kmail = new System.Windows.Forms.TextBox();
			this.txt_dahili = new System.Windows.Forms.TextBox();
			this.txt_soyad = new System.Windows.Forms.TextBox();
			this.txt_ad = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rtb_notlar = new System.Windows.Forms.RichTextBox();
			this.cb_il = new System.Windows.Forms.ComboBox();
			this.txt_fmail = new System.Windows.Forms.TextBox();
			this.txt_web = new System.Windows.Forms.TextBox();
			this.txt_vergino = new System.Windows.Forms.TextBox();
			this.txt_vergi = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_posta = new System.Windows.Forms.TextBox();
			this.txt_faks = new System.Windows.Forms.TextBox();
			this.txt_tel2 = new System.Windows.Forms.TextBox();
			this.txt_tel1 = new System.Windows.Forms.TextBox();
			this.txt_ilce = new System.Windows.Forms.TextBox();
			this.txt_adres = new System.Windows.Forms.TextBox();
			this.txt_firma = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnl_servisfisi.SuspendLayout();
			this.pnl_musteri.SuspendLayout();
			this.pnl_filtre.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_servisfisi
			// 
			this.pnl_servisfisi.Controls.Add(this.btn_servisac);
			this.pnl_servisfisi.Controls.Add(this.btn_servisduzenle);
			this.pnl_servisfisi.Location = new System.Drawing.Point(192, 40);
			this.pnl_servisfisi.Name = "pnl_servisfisi";
			this.pnl_servisfisi.Size = new System.Drawing.Size(75, 47);
			this.pnl_servisfisi.TabIndex = 32;
			this.pnl_servisfisi.Visible = false;
			// 
			// btn_servisac
			// 
			this.btn_servisac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_servisac.Location = new System.Drawing.Point(0, 0);
			this.btn_servisac.Name = "btn_servisac";
			this.btn_servisac.TabIndex = 15;
			this.btn_servisac.Text = "Aç";
			// 
			// btn_servisduzenle
			// 
			this.btn_servisduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_servisduzenle.Location = new System.Drawing.Point(0, 24);
			this.btn_servisduzenle.Name = "btn_servisduzenle";
			this.btn_servisduzenle.TabIndex = 16;
			this.btn_servisduzenle.Text = "Düzenle";
			// 
			// btn_servisfisi
			// 
			this.btn_servisfisi.Location = new System.Drawing.Point(192, 16);
			this.btn_servisfisi.Name = "btn_servisfisi";
			this.btn_servisfisi.TabIndex = 31;
			this.btn_servisfisi.Text = "Servis Fiþi";
			// 
			// pnl_musteri
			// 
			this.pnl_musteri.Controls.Add(this.btn_musteriac);
			this.pnl_musteri.Controls.Add(this.btn_musteriduzenle);
			this.pnl_musteri.Location = new System.Drawing.Point(104, 40);
			this.pnl_musteri.Name = "pnl_musteri";
			this.pnl_musteri.Size = new System.Drawing.Size(75, 47);
			this.pnl_musteri.TabIndex = 30;
			this.pnl_musteri.Visible = false;
			// 
			// btn_musteriac
			// 
			this.btn_musteriac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_musteriac.Location = new System.Drawing.Point(0, 0);
			this.btn_musteriac.Name = "btn_musteriac";
			this.btn_musteriac.TabIndex = 11;
			this.btn_musteriac.Text = "Aç";
			// 
			// btn_musteriduzenle
			// 
			this.btn_musteriduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_musteriduzenle.Location = new System.Drawing.Point(0, 24);
			this.btn_musteriduzenle.Name = "btn_musteriduzenle";
			this.btn_musteriduzenle.TabIndex = 12;
			this.btn_musteriduzenle.Text = "Düzenle";
			// 
			// btn_musteri
			// 
			this.btn_musteri.Location = new System.Drawing.Point(104, 16);
			this.btn_musteri.Name = "btn_musteri";
			this.btn_musteri.TabIndex = 29;
			this.btn_musteri.Text = "Müþteri";
			// 
			// pnl_filtre
			// 
			this.pnl_filtre.Controls.Add(this.btn_musterifiltre);
			this.pnl_filtre.Controls.Add(this.btn_servisfiltre);
			this.pnl_filtre.Location = new System.Drawing.Point(16, 40);
			this.pnl_filtre.Name = "pnl_filtre";
			this.pnl_filtre.Size = new System.Drawing.Size(75, 47);
			this.pnl_filtre.TabIndex = 28;
			this.pnl_filtre.Visible = false;
			// 
			// btn_musterifiltre
			// 
			this.btn_musterifiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_musterifiltre.Location = new System.Drawing.Point(0, 0);
			this.btn_musterifiltre.Name = "btn_musterifiltre";
			this.btn_musterifiltre.TabIndex = 4;
			this.btn_musterifiltre.Text = "Müþteri";
			// 
			// btn_servisfiltre
			// 
			this.btn_servisfiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_servisfiltre.Location = new System.Drawing.Point(0, 24);
			this.btn_servisfiltre.Name = "btn_servisfiltre";
			this.btn_servisfiltre.TabIndex = 5;
			this.btn_servisfiltre.Text = "Servis Fiþi";
			// 
			// btn_filtre
			// 
			this.btn_filtre.Location = new System.Drawing.Point(16, 16);
			this.btn_filtre.Name = "btn_filtre";
			this.btn_filtre.TabIndex = 27;
			this.btn_filtre.Text = "Filtre";
			// 
			// btn_kaydet
			// 
			this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_kaydet.Location = new System.Drawing.Point(512, 592);
			this.btn_kaydet.Name = "btn_kaydet";
			this.btn_kaydet.TabIndex = 26;
			this.btn_kaydet.Text = "Kaydet";
			this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txt_cep);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.txt_kmail);
			this.groupBox2.Controls.Add(this.txt_dahili);
			this.groupBox2.Controls.Add(this.txt_soyad);
			this.groupBox2.Controls.Add(this.txt_ad);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Location = new System.Drawing.Point(16, 376);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(576, 200);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kiþi Bilgileri";
			// 
			// txt_cep
			// 
			this.txt_cep.Location = new System.Drawing.Point(136, 160);
			this.txt_cep.Name = "txt_cep";
			this.txt_cep.Size = new System.Drawing.Size(144, 20);
			this.txt_cep.TabIndex = 31;
			this.txt_cep.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(24, 160);
			this.label18.Name = "label18";
			this.label18.TabIndex = 30;
			this.label18.Text = "Cep Numarasý :";
			// 
			// txt_kmail
			// 
			this.txt_kmail.Location = new System.Drawing.Point(136, 128);
			this.txt_kmail.Name = "txt_kmail";
			this.txt_kmail.Size = new System.Drawing.Size(144, 20);
			this.txt_kmail.TabIndex = 29;
			this.txt_kmail.Text = "";
			// 
			// txt_dahili
			// 
			this.txt_dahili.Location = new System.Drawing.Point(136, 96);
			this.txt_dahili.Name = "txt_dahili";
			this.txt_dahili.Size = new System.Drawing.Size(144, 20);
			this.txt_dahili.TabIndex = 28;
			this.txt_dahili.Text = "";
			// 
			// txt_soyad
			// 
			this.txt_soyad.Location = new System.Drawing.Point(136, 64);
			this.txt_soyad.Name = "txt_soyad";
			this.txt_soyad.Size = new System.Drawing.Size(144, 20);
			this.txt_soyad.TabIndex = 27;
			this.txt_soyad.Text = "";
			// 
			// txt_ad
			// 
			this.txt_ad.Location = new System.Drawing.Point(136, 32);
			this.txt_ad.Name = "txt_ad";
			this.txt_ad.Size = new System.Drawing.Size(144, 20);
			this.txt_ad.TabIndex = 26;
			this.txt_ad.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(24, 128);
			this.label17.Name = "label17";
			this.label17.TabIndex = 24;
			this.label17.Text = "E-Mail Adresi :";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(24, 96);
			this.label16.Name = "label16";
			this.label16.TabIndex = 23;
			this.label16.Text = "Dahili Numarasý :";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(24, 64);
			this.label15.Name = "label15";
			this.label15.TabIndex = 22;
			this.label15.Text = "Soyad :";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(24, 32);
			this.label14.Name = "label14";
			this.label14.TabIndex = 21;
			this.label14.Text = "Ad :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rtb_notlar);
			this.groupBox1.Controls.Add(this.cb_il);
			this.groupBox1.Controls.Add(this.txt_fmail);
			this.groupBox1.Controls.Add(this.txt_web);
			this.groupBox1.Controls.Add(this.txt_vergino);
			this.groupBox1.Controls.Add(this.txt_vergi);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txt_posta);
			this.groupBox1.Controls.Add(this.txt_faks);
			this.groupBox1.Controls.Add(this.txt_tel2);
			this.groupBox1.Controls.Add(this.txt_tel1);
			this.groupBox1.Controls.Add(this.txt_ilce);
			this.groupBox1.Controls.Add(this.txt_adres);
			this.groupBox1.Controls.Add(this.txt_firma);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 296);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Firma Bilgileri";
			// 
			// rtb_notlar
			// 
			this.rtb_notlar.Location = new System.Drawing.Point(408, 160);
			this.rtb_notlar.Name = "rtb_notlar";
			this.rtb_notlar.Size = new System.Drawing.Size(144, 112);
			this.rtb_notlar.TabIndex = 27;
			this.rtb_notlar.Text = "";
			// 
			// cb_il
			// 
			this.cb_il.Location = new System.Drawing.Point(136, 96);
			this.cb_il.Name = "cb_il";
			this.cb_il.Size = new System.Drawing.Size(144, 21);
			this.cb_il.TabIndex = 26;
			this.cb_il.Text = "Seçiniz";
			// 
			// txt_fmail
			// 
			this.txt_fmail.Location = new System.Drawing.Point(408, 128);
			this.txt_fmail.Name = "txt_fmail";
			this.txt_fmail.Size = new System.Drawing.Size(144, 20);
			this.txt_fmail.TabIndex = 24;
			this.txt_fmail.Text = "";
			// 
			// txt_web
			// 
			this.txt_web.Location = new System.Drawing.Point(408, 96);
			this.txt_web.Name = "txt_web";
			this.txt_web.Size = new System.Drawing.Size(144, 20);
			this.txt_web.TabIndex = 23;
			this.txt_web.Text = "";
			// 
			// txt_vergino
			// 
			this.txt_vergino.Location = new System.Drawing.Point(408, 64);
			this.txt_vergino.Name = "txt_vergino";
			this.txt_vergino.Size = new System.Drawing.Size(144, 20);
			this.txt_vergino.TabIndex = 22;
			this.txt_vergino.Text = "";
			// 
			// txt_vergi
			// 
			this.txt_vergi.Location = new System.Drawing.Point(408, 32);
			this.txt_vergi.Name = "txt_vergi";
			this.txt_vergi.Size = new System.Drawing.Size(144, 20);
			this.txt_vergi.TabIndex = 21;
			this.txt_vergi.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(296, 160);
			this.label13.Name = "label13";
			this.label13.TabIndex = 20;
			this.label13.Text = "Notlar :";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(296, 128);
			this.label12.Name = "label12";
			this.label12.TabIndex = 19;
			this.label12.Text = "E-Mail Adresi :";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(296, 96);
			this.label11.Name = "label11";
			this.label11.TabIndex = 18;
			this.label11.Text = "Web Adresi :";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(296, 64);
			this.label10.Name = "label10";
			this.label10.TabIndex = 17;
			this.label10.Text = "Vergi Numarasý :";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(296, 32);
			this.label9.Name = "label9";
			this.label9.TabIndex = 16;
			this.label9.Text = "Vergi Adresi :";
			// 
			// txt_posta
			// 
			this.txt_posta.Location = new System.Drawing.Point(136, 256);
			this.txt_posta.Name = "txt_posta";
			this.txt_posta.Size = new System.Drawing.Size(144, 20);
			this.txt_posta.TabIndex = 15;
			this.txt_posta.Text = "";
			// 
			// txt_faks
			// 
			this.txt_faks.Location = new System.Drawing.Point(136, 224);
			this.txt_faks.Name = "txt_faks";
			this.txt_faks.Size = new System.Drawing.Size(144, 20);
			this.txt_faks.TabIndex = 14;
			this.txt_faks.Text = "";
			// 
			// txt_tel2
			// 
			this.txt_tel2.Location = new System.Drawing.Point(136, 192);
			this.txt_tel2.Name = "txt_tel2";
			this.txt_tel2.Size = new System.Drawing.Size(144, 20);
			this.txt_tel2.TabIndex = 13;
			this.txt_tel2.Text = "";
			// 
			// txt_tel1
			// 
			this.txt_tel1.Location = new System.Drawing.Point(136, 160);
			this.txt_tel1.Name = "txt_tel1";
			this.txt_tel1.Size = new System.Drawing.Size(144, 20);
			this.txt_tel1.TabIndex = 12;
			this.txt_tel1.Text = "";
			// 
			// txt_ilce
			// 
			this.txt_ilce.Location = new System.Drawing.Point(136, 128);
			this.txt_ilce.Name = "txt_ilce";
			this.txt_ilce.Size = new System.Drawing.Size(144, 20);
			this.txt_ilce.TabIndex = 11;
			this.txt_ilce.Text = "";
			// 
			// txt_adres
			// 
			this.txt_adres.Location = new System.Drawing.Point(136, 64);
			this.txt_adres.Name = "txt_adres";
			this.txt_adres.Size = new System.Drawing.Size(144, 20);
			this.txt_adres.TabIndex = 9;
			this.txt_adres.Text = "";
			// 
			// txt_firma
			// 
			this.txt_firma.Location = new System.Drawing.Point(136, 32);
			this.txt_firma.Name = "txt_firma";
			this.txt_firma.Size = new System.Drawing.Size(144, 20);
			this.txt_firma.TabIndex = 8;
			this.txt_firma.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 256);
			this.label8.Name = "label8";
			this.label8.TabIndex = 7;
			this.label8.Text = "Posta Numarasý :";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 224);
			this.label7.Name = "label7";
			this.label7.TabIndex = 6;
			this.label7.Text = "Faks Numarasý :";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 192);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Telefon Numarasý :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 160);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Telefon Numarasý :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Ýlçe :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Ýl :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Adres :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Firma Ýsim :";
			// 
			// frm_musteriac
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnl_servisfisi);
			this.Controls.Add(this.btn_servisfisi);
			this.Controls.Add(this.pnl_musteri);
			this.Controls.Add(this.btn_musteri);
			this.Controls.Add(this.pnl_filtre);
			this.Controls.Add(this.btn_filtre);
			this.Controls.Add(this.btn_kaydet);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frm_musteriac";
			this.Text = "frm_musteriac";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frm_musteriac_Load);
			this.pnl_servisfisi.ResumeLayout(false);
			this.pnl_musteri.ResumeLayout(false);
			this.pnl_filtre.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btn_kaydet_Click(object sender, System.EventArgs e)
		{
			SqlCommand veri = new SqlCommand();
			veri.Connection = connection.baglantim;
			veri.CommandText = "INSERT INTO tbl_cari (ca_ad,ca_soyad,ca_firma,ca_adres,ca_il,ca_ilce,ca_tel1,ca_tel2,ca_faks,ca_cep,ca_notlar,ca_fmail,ca_kmail,ca_web,ca_dahili,ca_vergi,ca_vergino,ca_posta) VALUES ('"+txt_ad.Text+"','"+txt_soyad.Text+"','"+txt_firma.Text+"','"+txt_adres.Text+"','"+cb_il.Text+"','"+txt_ilce.Text+"','"+txt_tel1.Text+"','"+txt_tel2.Text+"','"+txt_faks.Text+"','"+txt_cep.Text+"','"+rtb_notlar.Text+"','"+txt_fmail.Text+"','"+txt_kmail.Text+"','"+txt_web.Text+"','"+txt_dahili.Text+"','"+txt_vergi.Text+"','"+txt_vergino.Text+"','"+txt_posta.Text+"')";
			try
			{
				connection.baglantim.Open();
				veri.ExecuteNonQuery();
				connection.baglantim.Close();
				MessageBox.Show(this, "Kayýt iþlemi baþarýlý þekilde tamamlandý.", "Bilgi Mesajý");
				txt_firma.Clear();
				txt_adres.Clear();
				cb_il.SelectedIndex = 0;
				txt_ilce.Clear();
				txt_posta.Clear();
				txt_tel1.Clear();
				txt_tel2.Clear();
				txt_faks.Clear();
				txt_fmail.Clear();
				txt_web.Clear();
				txt_vergi.Clear();
				txt_vergino.Clear();
				rtb_notlar.Clear();
				txt_ad.Clear();
				txt_soyad.Clear();
				txt_dahili.Clear();
				txt_cep.Clear();
				txt_kmail.Clear();

			}
			catch
			{
				MessageBox.Show(this, "Veri tabanýna baðlanýlýrken bir hata oluþtu.", "Hata Mesajý");
			}
		}

		private void frm_musteriac_Load(object sender, System.EventArgs e)
		{
			cb_il.Items.Add("Seçiniz");
			SqlDataAdapter verial =new SqlDataAdapter("SELECT i_ad FROM tbl_il",connection.baglantim);
			DataSet al=new DataSet();
			verial.Fill(al,"tbl_il");
			DataTable myDataTable = al.Tables["tbl_il"];
			foreach (DataRow myDataRow in myDataTable.Rows)
			{
				cb_il.Items.Add(myDataRow["i_ad"]);
			}
		}
	}
}
