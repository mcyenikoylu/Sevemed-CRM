using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Sevemed_CRM
{
	/// <summary>
	/// Summary description for frm_servisac.
	/// </summary>
	public class frm_servisac : System.Windows.Forms.Form
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_fisno;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btn_kaydet;
		private System.Windows.Forms.ComboBox cb_firma;
		private System.Windows.Forms.TextBox txt_adres;
		private System.Windows.Forms.TextBox txt_tel1;
		private System.Windows.Forms.TextBox txt_tel2;
		private System.Windows.Forms.DateTimePicker dtp_alim;
		private System.Windows.Forms.DateTimePicker dtp_gidis;
		private System.Windows.Forms.RadioButton rb_var;
		private System.Windows.Forms.RadioButton rb_yok;
		private System.Windows.Forms.TextBox txt_marka;
		private System.Windows.Forms.TextBox txt_model;
		private System.Windows.Forms.TextBox txt_serino;
		private System.Windows.Forms.RichTextBox rtb_muracat;
		private System.Windows.Forms.RichTextBox rtb_islem;
		private System.Windows.Forms.RichTextBox rtb_notlar;
		private System.Windows.Forms.RadioButton rb_bir;
		private System.Windows.Forms.RadioButton rb_birkac;
		private System.Windows.Forms.TextBox txt_teslim;
		private System.Windows.Forms.TextBox txt_il;
		private System.Windows.Forms.TextBox txt_ilce;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.ComboBox cb_teknisyen;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_servisac()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.txt_ilce = new System.Windows.Forms.TextBox();
			this.txt_il = new System.Windows.Forms.TextBox();
			this.cb_teknisyen = new System.Windows.Forms.ComboBox();
			this.txt_teslim = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rb_birkac = new System.Windows.Forms.RadioButton();
			this.rb_bir = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.rtb_notlar = new System.Windows.Forms.RichTextBox();
			this.rtb_islem = new System.Windows.Forms.RichTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.rtb_muracat = new System.Windows.Forms.RichTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_serino = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_model = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_marka = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rb_var = new System.Windows.Forms.RadioButton();
			this.rb_yok = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.dtp_gidis = new System.Windows.Forms.DateTimePicker();
			this.dtp_alim = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_tel2 = new System.Windows.Forms.TextBox();
			this.txt_tel1 = new System.Windows.Forms.TextBox();
			this.txt_adres = new System.Windows.Forms.TextBox();
			this.cb_firma = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_fisno = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_kaydet = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label27 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label26 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label28 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.pnl_servisfisi.SuspendLayout();
			this.pnl_musteri.SuspendLayout();
			this.pnl_filtre.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_servisfisi
			// 
			this.pnl_servisfisi.Controls.Add(this.btn_servisac);
			this.pnl_servisfisi.Controls.Add(this.btn_servisduzenle);
			this.pnl_servisfisi.Location = new System.Drawing.Point(192, 40);
			this.pnl_servisfisi.Name = "pnl_servisfisi";
			this.pnl_servisfisi.Size = new System.Drawing.Size(75, 47);
			this.pnl_servisfisi.TabIndex = 38;
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
			this.btn_servisfisi.TabIndex = 37;
			this.btn_servisfisi.Text = "Servis Fiþi";
			// 
			// pnl_musteri
			// 
			this.pnl_musteri.Controls.Add(this.btn_musteriac);
			this.pnl_musteri.Controls.Add(this.btn_musteriduzenle);
			this.pnl_musteri.Location = new System.Drawing.Point(104, 40);
			this.pnl_musteri.Name = "pnl_musteri";
			this.pnl_musteri.Size = new System.Drawing.Size(75, 47);
			this.pnl_musteri.TabIndex = 36;
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
			this.btn_musteri.TabIndex = 35;
			this.btn_musteri.Text = "Müþteri";
			// 
			// pnl_filtre
			// 
			this.pnl_filtre.Controls.Add(this.btn_musterifiltre);
			this.pnl_filtre.Controls.Add(this.btn_servisfiltre);
			this.pnl_filtre.Location = new System.Drawing.Point(16, 40);
			this.pnl_filtre.Name = "pnl_filtre";
			this.pnl_filtre.Size = new System.Drawing.Size(75, 47);
			this.pnl_filtre.TabIndex = 34;
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
			this.btn_filtre.TabIndex = 33;
			this.btn_filtre.Text = "Filtre";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.txt_ilce);
			this.panel1.Controls.Add(this.txt_il);
			this.panel1.Controls.Add(this.cb_teknisyen);
			this.panel1.Controls.Add(this.txt_teslim);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.rtb_notlar);
			this.panel1.Controls.Add(this.rtb_islem);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.rtb_muracat);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txt_serino);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txt_model);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txt_marka);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.dtp_gidis);
			this.panel1.Controls.Add(this.dtp_alim);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txt_tel2);
			this.panel1.Controls.Add(this.txt_tel1);
			this.panel1.Controls.Add(this.txt_adres);
			this.panel1.Controls.Add(this.cb_firma);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txt_fisno);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(16, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(568, 608);
			this.panel1.TabIndex = 39;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(16, 112);
			this.label17.Name = "label17";
			this.label17.TabIndex = 40;
			this.label17.Text = "Ýl / Ýlçe";
			// 
			// txt_ilce
			// 
			this.txt_ilce.BackColor = System.Drawing.SystemColors.Window;
			this.txt_ilce.Location = new System.Drawing.Point(232, 112);
			this.txt_ilce.Name = "txt_ilce";
			this.txt_ilce.ReadOnly = true;
			this.txt_ilce.Size = new System.Drawing.Size(104, 20);
			this.txt_ilce.TabIndex = 39;
			this.txt_ilce.Text = "";
			// 
			// txt_il
			// 
			this.txt_il.BackColor = System.Drawing.SystemColors.Window;
			this.txt_il.Location = new System.Drawing.Point(128, 112);
			this.txt_il.Name = "txt_il";
			this.txt_il.ReadOnly = true;
			this.txt_il.TabIndex = 38;
			this.txt_il.Text = "";
			// 
			// cb_teknisyen
			// 
			this.cb_teknisyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_teknisyen.Location = new System.Drawing.Point(32, 560);
			this.cb_teknisyen.Name = "cb_teknisyen";
			this.cb_teknisyen.Size = new System.Drawing.Size(200, 21);
			this.cb_teknisyen.TabIndex = 37;
			// 
			// txt_teslim
			// 
			this.txt_teslim.Location = new System.Drawing.Point(336, 560);
			this.txt_teslim.Name = "txt_teslim";
			this.txt_teslim.Size = new System.Drawing.Size(192, 20);
			this.txt_teslim.TabIndex = 36;
			this.txt_teslim.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(336, 536);
			this.label16.Name = "label16";
			this.label16.TabIndex = 35;
			this.label16.Text = "Teslim Alan :";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(32, 536);
			this.label15.Name = "label15";
			this.label15.TabIndex = 34;
			this.label15.Text = "Teknisyen :";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(424, 488);
			this.label14.Name = "label14";
			this.label14.TabIndex = 33;
			this.label14.Text = "gidermiþtir.";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(72, 488);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(144, 23);
			this.label13.TabIndex = 32;
			this.label13.Text = "Servis teknisyeniniz sorunu";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.rb_birkac);
			this.panel3.Controls.Add(this.rb_bir);
			this.panel3.Location = new System.Drawing.Point(216, 488);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 24);
			this.panel3.TabIndex = 31;
			// 
			// rb_birkac
			// 
			this.rb_birkac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rb_birkac.Location = new System.Drawing.Point(72, 0);
			this.rb_birkac.Name = "rb_birkac";
			this.rb_birkac.Size = new System.Drawing.Size(128, 24);
			this.rb_birkac.TabIndex = 30;
			this.rb_birkac.Text = "bir kaç defa gelerek";
			// 
			// rb_bir
			// 
			this.rb_bir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rb_bir.Location = new System.Drawing.Point(0, 0);
			this.rb_bir.Name = "rb_bir";
			this.rb_bir.Size = new System.Drawing.Size(72, 24);
			this.rb_bir.TabIndex = 29;
			this.rb_bir.Text = "bir defada";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 400);
			this.label12.Name = "label12";
			this.label12.TabIndex = 28;
			this.label12.Text = "Not :";
			// 
			// rtb_notlar
			// 
			this.rtb_notlar.Location = new System.Drawing.Point(128, 400);
			this.rtb_notlar.Name = "rtb_notlar";
			this.rtb_notlar.Size = new System.Drawing.Size(400, 80);
			this.rtb_notlar.TabIndex = 27;
			this.rtb_notlar.Text = "";
			// 
			// rtb_islem
			// 
			this.rtb_islem.Location = new System.Drawing.Point(128, 312);
			this.rtb_islem.Name = "rtb_islem";
			this.rtb_islem.Size = new System.Drawing.Size(400, 72);
			this.rtb_islem.TabIndex = 26;
			this.rtb_islem.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 312);
			this.label11.Name = "label11";
			this.label11.TabIndex = 25;
			this.label11.Text = "Yapýlan Ýþlem :";
			// 
			// rtb_muracat
			// 
			this.rtb_muracat.Location = new System.Drawing.Point(128, 232);
			this.rtb_muracat.Name = "rtb_muracat";
			this.rtb_muracat.Size = new System.Drawing.Size(400, 64);
			this.rtb_muracat.TabIndex = 24;
			this.rtb_muracat.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 232);
			this.label10.Name = "label10";
			this.label10.TabIndex = 23;
			this.label10.Text = "Müracat Sebebi :";
			// 
			// txt_serino
			// 
			this.txt_serino.Location = new System.Drawing.Point(408, 192);
			this.txt_serino.Name = "txt_serino";
			this.txt_serino.TabIndex = 22;
			this.txt_serino.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(352, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Seri No :";
			// 
			// txt_model
			// 
			this.txt_model.Location = new System.Drawing.Point(240, 192);
			this.txt_model.Name = "txt_model";
			this.txt_model.TabIndex = 20;
			this.txt_model.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(184, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "Model :";
			// 
			// txt_marka
			// 
			this.txt_marka.Location = new System.Drawing.Point(72, 192);
			this.txt_marka.Name = "txt_marka";
			this.txt_marka.TabIndex = 18;
			this.txt_marka.Text = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rb_var);
			this.panel2.Controls.Add(this.rb_yok);
			this.panel2.Location = new System.Drawing.Point(344, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 40);
			this.panel2.TabIndex = 17;
			// 
			// rb_var
			// 
			this.rb_var.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rb_var.Location = new System.Drawing.Point(0, 8);
			this.rb_var.Name = "rb_var";
			this.rb_var.Size = new System.Drawing.Size(88, 24);
			this.rb_var.TabIndex = 14;
			this.rb_var.Text = "Garanti Var";
			// 
			// rb_yok
			// 
			this.rb_yok.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rb_yok.Location = new System.Drawing.Point(104, 8);
			this.rb_yok.Name = "rb_yok";
			this.rb_yok.Size = new System.Drawing.Size(88, 24);
			this.rb_yok.TabIndex = 15;
			this.rb_yok.Text = "Garanti Yok";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Marka :";
			// 
			// dtp_gidis
			// 
			this.dtp_gidis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_gidis.Location = new System.Drawing.Point(456, 88);
			this.dtp_gidis.Name = "dtp_gidis";
			this.dtp_gidis.Size = new System.Drawing.Size(96, 20);
			this.dtp_gidis.TabIndex = 13;
			// 
			// dtp_alim
			// 
			this.dtp_alim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_alim.Location = new System.Drawing.Point(456, 56);
			this.dtp_alim.Name = "dtp_alim";
			this.dtp_alim.Size = new System.Drawing.Size(96, 20);
			this.dtp_alim.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(344, 88);
			this.label6.Name = "label6";
			this.label6.TabIndex = 11;
			this.label6.Text = "Ser. Gid. Tarihi :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(344, 56);
			this.label5.Name = "label5";
			this.label5.TabIndex = 10;
			this.label5.Text = "Ser. Alým Tarihi :";
			// 
			// txt_tel2
			// 
			this.txt_tel2.BackColor = System.Drawing.SystemColors.Window;
			this.txt_tel2.Location = new System.Drawing.Point(232, 144);
			this.txt_tel2.Name = "txt_tel2";
			this.txt_tel2.ReadOnly = true;
			this.txt_tel2.Size = new System.Drawing.Size(104, 20);
			this.txt_tel2.TabIndex = 9;
			this.txt_tel2.Text = "";
			// 
			// txt_tel1
			// 
			this.txt_tel1.BackColor = System.Drawing.SystemColors.Window;
			this.txt_tel1.Location = new System.Drawing.Point(128, 144);
			this.txt_tel1.Name = "txt_tel1";
			this.txt_tel1.ReadOnly = true;
			this.txt_tel1.TabIndex = 8;
			this.txt_tel1.Text = "";
			// 
			// txt_adres
			// 
			this.txt_adres.BackColor = System.Drawing.SystemColors.Window;
			this.txt_adres.Location = new System.Drawing.Point(128, 80);
			this.txt_adres.Name = "txt_adres";
			this.txt_adres.ReadOnly = true;
			this.txt_adres.Size = new System.Drawing.Size(208, 20);
			this.txt_adres.TabIndex = 7;
			this.txt_adres.Text = "";
			// 
			// cb_firma
			// 
			this.cb_firma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_firma.Location = new System.Drawing.Point(128, 48);
			this.cb_firma.Name = "cb_firma";
			this.cb_firma.Size = new System.Drawing.Size(208, 21);
			this.cb_firma.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 144);
			this.label4.Name = "label4";
			this.label4.TabIndex = 5;
			this.label4.Text = "Telefon Numarasý :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "Adres :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "Ýsim :";
			// 
			// txt_fisno
			// 
			this.txt_fisno.Location = new System.Drawing.Point(456, 16);
			this.txt_fisno.Name = "txt_fisno";
			this.txt_fisno.Size = new System.Drawing.Size(96, 20);
			this.txt_fisno.TabIndex = 2;
			this.txt_fisno.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(344, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "Fiþ Numarasý :";
			// 
			// btn_kaydet
			// 
			this.btn_kaydet.Location = new System.Drawing.Point(496, 680);
			this.btn_kaydet.Name = "btn_kaydet";
			this.btn_kaydet.TabIndex = 40;
			this.btn_kaydet.Text = "Kaydet";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox14);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(600, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 512);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Masraf";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(136, 480);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(168, 20);
			this.textBox14.TabIndex = 7;
			this.textBox14.Text = "textBox14";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(24, 480);
			this.label31.Name = "label31";
			this.label31.TabIndex = 6;
			this.label31.Text = "Malzeme :";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label27);
			this.groupBox5.Controls.Add(this.textBox10);
			this.groupBox5.Controls.Add(this.textBox7);
			this.groupBox5.Controls.Add(this.textBox6);
			this.groupBox5.Controls.Add(this.textBox5);
			this.groupBox5.Controls.Add(this.label24);
			this.groupBox5.Controls.Add(this.label23);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.Location = new System.Drawing.Point(16, 312);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(296, 160);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Gida";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(16, 120);
			this.label27.Name = "label27";
			this.label27.TabIndex = 7;
			this.label27.Text = "Toplam :";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(128, 120);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(152, 20);
			this.textBox10.TabIndex = 6;
			this.textBox10.Text = "textBox10";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(128, 88);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(152, 20);
			this.textBox7.TabIndex = 5;
			this.textBox7.Text = "textBox7";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(128, 56);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(152, 20);
			this.textBox6.TabIndex = 4;
			this.textBox6.Text = "textBox6";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(128, 24);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(152, 20);
			this.textBox5.TabIndex = 3;
			this.textBox5.Text = "textBox5";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(16, 88);
			this.label24.Name = "label24";
			this.label24.TabIndex = 2;
			this.label24.Text = "Akþam :";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 56);
			this.label23.Name = "label23";
			this.label23.TabIndex = 1;
			this.label23.Text = "Öðle :";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(16, 24);
			this.label22.Name = "label22";
			this.label22.TabIndex = 0;
			this.label22.Text = "Sabah :";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label26);
			this.groupBox4.Controls.Add(this.textBox9);
			this.groupBox4.Controls.Add(this.textBox8);
			this.groupBox4.Controls.Add(this.label25);
			this.groupBox4.Controls.Add(this.textBox4);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Location = new System.Drawing.Point(16, 176);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(296, 136);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Konaklama";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(16, 88);
			this.label26.Name = "label26";
			this.label26.TabIndex = 8;
			this.label26.Text = "Toplam :";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(128, 88);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(152, 20);
			this.textBox9.TabIndex = 7;
			this.textBox9.Text = "textBox9";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(128, 56);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(48, 20);
			this.textBox8.TabIndex = 6;
			this.textBox8.Text = "textBox8";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(16, 56);
			this.label25.Name = "label25";
			this.label25.TabIndex = 5;
			this.label25.Text = "Kaç Gece :";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(128, 24);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(152, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "textBox4";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(16, 24);
			this.label21.Name = "label21";
			this.label21.TabIndex = 3;
			this.label21.Text = "Otel :";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label28);
			this.groupBox3.Controls.Add(this.textBox11);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Location = new System.Drawing.Point(16, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 160);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ulaþým";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(16, 120);
			this.label28.Name = "label28";
			this.label28.TabIndex = 7;
			this.label28.Text = "Toplam :";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(128, 120);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(152, 20);
			this.textBox11.TabIndex = 6;
			this.textBox11.Text = "textBox11";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(128, 88);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "textBox3";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(128, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "textBox2";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(128, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "textBox1";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(16, 88);
			this.label20.Name = "label20";
			this.label20.TabIndex = 2;
			this.label20.Text = "Uçak :";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(16, 56);
			this.label19.Name = "label19";
			this.label19.TabIndex = 1;
			this.label19.Text = "Otobüs :";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(16, 24);
			this.label18.Name = "label18";
			this.label18.TabIndex = 0;
			this.label18.Text = "Dolmuþ / Taksi :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox13);
			this.groupBox2.Controls.Add(this.textBox12);
			this.groupBox2.Controls.Add(this.label30);
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Location = new System.Drawing.Point(600, 576);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(328, 88);
			this.groupBox2.TabIndex = 42;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ücret";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(136, 56);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(168, 20);
			this.textBox13.TabIndex = 3;
			this.textBox13.Text = "textBox13";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(136, 24);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(168, 20);
			this.textBox12.TabIndex = 2;
			this.textBox12.Text = "textBox12";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(16, 56);
			this.label30.Name = "label30";
			this.label30.TabIndex = 1;
			this.label30.Text = "Genel Toplam";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(16, 24);
			this.label29.Name = "label29";
			this.label29.TabIndex = 0;
			this.label29.Text = "Servis Ücreti";
			// 
			// frm_servisac
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_kaydet);
			this.Controls.Add(this.pnl_servisfisi);
			this.Controls.Add(this.btn_servisfisi);
			this.Controls.Add(this.pnl_musteri);
			this.Controls.Add(this.btn_musteri);
			this.Controls.Add(this.pnl_filtre);
			this.Controls.Add(this.btn_filtre);
			this.Controls.Add(this.panel1);
			this.Name = "frm_servisac";
			this.Text = "frm_servisac";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frm_servisac_Load);
			this.Closed += new System.EventHandler(this.frm_servisac_Closed);
			this.pnl_servisfisi.ResumeLayout(false);
			this.pnl_musteri.ResumeLayout(false);
			this.pnl_filtre.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frm_servisac_Load(object sender, System.EventArgs e)
		{
            //cb_firma.Items.Add("Seçiniz");
            //cb_teknisyen.Items.Add("Seçiniz");
            //cb_firma.SelectedIndex = 0;
            //cb_teknisyen.SelectedIndex = 0;
            //SqlDataAdapter verial =new SqlDataAdapter("SELECT ca_firma FROM tbl_cari",connection.baglantim);
            //DataSet al=new DataSet();
            //verial.Fill(al,"tbl_cari");
            //DataTable myDataTable = al.Tables["tbl_cari"];
            //foreach (DataRow myDataRow in myDataTable.Rows)
            //{
            //    cb_firma.Items.Add(myDataRow["ca_firma"]);
            //}
            //SqlDataAdapter verial2 =new SqlDataAdapter("SELECT ty_ad FROM tbl_teknisyen",connection.baglantim);
            //DataSet al2=new DataSet();
            //verial2.Fill(al2,"tbl_teknisyen");
            //DataTable myDataTable2 = al2.Tables["tbl_teknisyen"];
            //foreach (DataRow myDataRow2 in myDataTable2.Rows)
            //{
            //    cb_teknisyen.Items.Add(myDataRow2["ty_ad"]);
            //}
		}

		
		private void frm_servisac_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		
	}
}
