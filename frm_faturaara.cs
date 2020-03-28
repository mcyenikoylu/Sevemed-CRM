using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sevemed_CRM
{
	/// <summary>
	/// Summary description for frm_faturaara.
	/// </summary>
	public class frm_faturaara : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel pnl_filtre;
		private System.Windows.Forms.Button btn_musterifiltre;
		private System.Windows.Forms.Button btn_servisfiltre;
		private System.Windows.Forms.Button btn_faturaara;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_faturaac;
		private System.Windows.Forms.Button btn_faturaduzenle;
		private System.Windows.Forms.Button btn_fatura;
		private System.Windows.Forms.Panel pnl_servisfisi;
		private System.Windows.Forms.Button btn_servisac;
		private System.Windows.Forms.Button btn_servisduzenle;
		private System.Windows.Forms.Button btn_servisfisi;
		private System.Windows.Forms.Panel pnl_musteri;
		private System.Windows.Forms.Button btn_musteriac;
		private System.Windows.Forms.Button btn_musteriduzenle;
		private System.Windows.Forms.Button btn_musteri;
		private System.Windows.Forms.Button btn_filtre;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_faturaara()
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
			this.pnl_filtre = new System.Windows.Forms.Panel();
			this.btn_musterifiltre = new System.Windows.Forms.Button();
			this.btn_servisfiltre = new System.Windows.Forms.Button();
			this.btn_faturaara = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_faturaac = new System.Windows.Forms.Button();
			this.btn_faturaduzenle = new System.Windows.Forms.Button();
			this.btn_fatura = new System.Windows.Forms.Button();
			this.pnl_servisfisi = new System.Windows.Forms.Panel();
			this.btn_servisac = new System.Windows.Forms.Button();
			this.btn_servisduzenle = new System.Windows.Forms.Button();
			this.btn_servisfisi = new System.Windows.Forms.Button();
			this.pnl_musteri = new System.Windows.Forms.Panel();
			this.btn_musteriac = new System.Windows.Forms.Button();
			this.btn_musteriduzenle = new System.Windows.Forms.Button();
			this.btn_musteri = new System.Windows.Forms.Button();
			this.btn_filtre = new System.Windows.Forms.Button();
			this.pnl_filtre.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnl_servisfisi.SuspendLayout();
			this.pnl_musteri.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_filtre
			// 
			this.pnl_filtre.Controls.Add(this.btn_musterifiltre);
			this.pnl_filtre.Controls.Add(this.btn_servisfiltre);
			this.pnl_filtre.Controls.Add(this.btn_faturaara);
			this.pnl_filtre.Location = new System.Drawing.Point(-23, 113);
			this.pnl_filtre.Name = "pnl_filtre";
			this.pnl_filtre.Size = new System.Drawing.Size(75, 71);
			this.pnl_filtre.TabIndex = 25;
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
			// btn_faturaara
			// 
			this.btn_faturaara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_faturaara.Location = new System.Drawing.Point(0, 48);
			this.btn_faturaara.Name = "btn_faturaara";
			this.btn_faturaara.TabIndex = 24;
			this.btn_faturaara.Text = "Fatura";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_faturaac);
			this.panel1.Controls.Add(this.btn_faturaduzenle);
			this.panel1.Location = new System.Drawing.Point(241, 113);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(75, 47);
			this.panel1.TabIndex = 31;
			this.panel1.Visible = false;
			// 
			// btn_faturaac
			// 
			this.btn_faturaac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_faturaac.Location = new System.Drawing.Point(0, 0);
			this.btn_faturaac.Name = "btn_faturaac";
			this.btn_faturaac.TabIndex = 21;
			this.btn_faturaac.Text = "Aç";
			// 
			// btn_faturaduzenle
			// 
			this.btn_faturaduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_faturaduzenle.Location = new System.Drawing.Point(0, 24);
			this.btn_faturaduzenle.Name = "btn_faturaduzenle";
			this.btn_faturaduzenle.TabIndex = 22;
			this.btn_faturaduzenle.Text = "Düzenle";
			// 
			// btn_fatura
			// 
			this.btn_fatura.Location = new System.Drawing.Point(241, 89);
			this.btn_fatura.Name = "btn_fatura";
			this.btn_fatura.TabIndex = 30;
			this.btn_fatura.Text = "Fatura";
			// 
			// pnl_servisfisi
			// 
			this.pnl_servisfisi.Controls.Add(this.btn_servisac);
			this.pnl_servisfisi.Controls.Add(this.btn_servisduzenle);
			this.pnl_servisfisi.Location = new System.Drawing.Point(153, 113);
			this.pnl_servisfisi.Name = "pnl_servisfisi";
			this.pnl_servisfisi.Size = new System.Drawing.Size(75, 47);
			this.pnl_servisfisi.TabIndex = 29;
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
			this.btn_servisfisi.Location = new System.Drawing.Point(153, 89);
			this.btn_servisfisi.Name = "btn_servisfisi";
			this.btn_servisfisi.TabIndex = 28;
			this.btn_servisfisi.Text = "Servis Fiþi";
			// 
			// pnl_musteri
			// 
			this.pnl_musteri.Controls.Add(this.btn_musteriac);
			this.pnl_musteri.Controls.Add(this.btn_musteriduzenle);
			this.pnl_musteri.Location = new System.Drawing.Point(65, 113);
			this.pnl_musteri.Name = "pnl_musteri";
			this.pnl_musteri.Size = new System.Drawing.Size(75, 47);
			this.pnl_musteri.TabIndex = 27;
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
			this.btn_musteri.Location = new System.Drawing.Point(65, 89);
			this.btn_musteri.Name = "btn_musteri";
			this.btn_musteri.TabIndex = 26;
			this.btn_musteri.Text = "Müþteri";
			// 
			// btn_filtre
			// 
			this.btn_filtre.Location = new System.Drawing.Point(-23, 89);
			this.btn_filtre.Name = "btn_filtre";
			this.btn_filtre.TabIndex = 24;
			this.btn_filtre.Text = "Filtre";
			// 
			// frm_faturaara
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.pnl_filtre);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_fatura);
			this.Controls.Add(this.pnl_servisfisi);
			this.Controls.Add(this.btn_servisfisi);
			this.Controls.Add(this.pnl_musteri);
			this.Controls.Add(this.btn_musteri);
			this.Controls.Add(this.btn_filtre);
			this.Name = "frm_faturaara";
			this.Text = "frm_faturaara";
			this.pnl_filtre.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnl_servisfisi.ResumeLayout(false);
			this.pnl_musteri.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
