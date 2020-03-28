using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sevemed_CRM
{
	/// <summary>
	/// Summary description for frm_anasayfa.
	/// </summary>
	public class frm_anasayfa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btn_filtre;
		private System.Windows.Forms.Button btn_musterifiltre;
		private System.Windows.Forms.Button btn_servisfiltre;
		private System.Windows.Forms.Panel pnl_filtre;
		privaееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееows.Forms.Button();
			this.btn_musteri = new System.Windows.Forms.Button();
			this.btn_musteriac = new System.Windows.Forms.Button();
			this.btn_musteriduzenle = new System.Windows.Forms.Button();
			this.pnl_musteri = new System.Windows.Forms.Panel();
			this.btn_servisfisi = new System.Windows.Forms.Button();
			this.btn_servisac = new System.Windows.Forms.Button();
			this.btn_servisduzenle = new System.Windows.Forms.Button();
			this.pnl_servisfisi = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.btn_fatura = new System.Windows.Forms.Button();
			this.btn_faturaac = new System.Windows.Forms.Button();
			this.btn_faturaduzenle = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnl_filtre.SuspendLayout();
			this.pnl_musteri.SuspendLayout();
			this.pnl_servisfisi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_filtre
			// 
			this.btn_filtre.Location = new System.Drawing.Point(16, 16);
			this.btn_filtre.Name = "btn_filtre";
			this.btn_filtre.TabIndex = 0;
			this.btn_filtre.Text = "Filtre";
			this.btn_filtre.Click += new System.EventHandler(this.btn_filtre_Click);
			// 
			// btn_musterifiltre
			// 
			this.btn_musterifiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_musterifiltre.Location = new System.Drawing.Point(0, 0);
			this.btn_musterifiltre.Name = "btn_musterifiltre";
			this.btn_musterifiltre.TabIndex = 4;
			this.btn_musterifiltre.Text = "Mьюteri";
			this.btn_musterifiltre.Click += new System.EventHandler(this.btn_musterifiltre_Click);
			// 
			// btn_servisfiltre
			// 
			this.btn_servisfiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_servisfiltre.Location = new System.Drawing.Point(0, 24);
			this.btn_servisfiltre.Name = "btn_servisfiltre";
			this.btn_servisfiltre.TabIndex = 5;
			this.btn_servisfiltre.Text = "Servis Fiюi";
			this.btn_servisfiltre.Click += new System.EventHandler(this.btn_servisfiltre_Click);
			// 
			// pnl_filtre
			// 
			this.pnl_filtre.Controls.Add(this.btn_musterifiltre);
			this.pnl_filtre.Controls.Add(this.btn_servisfiltre);
			this.pnl_filtre.Controls.Add(this.btn_faturaara);
			this.pnl_filtre.Location = new System.Drawing.Point(16, 40);
			this.pnl_filtre.Name = "pnl_filtre";
			this.pnl_filtre.Size = new System.Drawing.Size(75, 71);
			this.pnl_filtre.TabIndex = 9;
			this.pnl_filtre.Visible = false;
			// 
			// btn_faturaara
			// 
			this.btn_faturaara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_faturaara.Location = new System.Drawing.Point(0, 48);
			this.btn_faturaara.Name = "btn_faturaara";
			this.btn_faturaara.TabIndex = 24;
			this.btn_faturaara.Text = "Fatura";
			// 
			// btn_musteri
			// 
			this.btn_musteri.Location = new System.Drawing.Point(104, 16);
			this.btn_musteri.Name = "btn_musteri";
			this.btn_musteri.TabIndex = 10;
			this.btn_musteri.Text = "Mьюteri";
			this.btn_musteri.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_musteriac
			// 
			this.btn_musteriac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_musteriac.Location = new System.Drawing.Point(0, 0);
			this.btn_musteriac.Name = "btn_musteriac";
			this.btn_musteriaееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееthis.pnl_musteri.Controls.Add(this.btn_musteriac);
			this.pnl_musteri.Controls.Add(this.btn_musteriduzenle);
			this.pnl_musteri.Location = new System.Drawing.Point(104, 40);
			this.pnl_musteri.Name = "pnl_musteri";
			this.pnl_musteri.Size = new System.Drawing.Size(75, 47);
			this.pnl_musteri.TabIndex = 13;
			this.pnl_musteri.Visible = false;
			// 
			// btn_servisfisi
			// 
			this.btn_servisfisi.Location = new System.Drawing.Point(192, 16);
			this.btn_servisfisi.Name = "btn_servisfisi";
			this.btn_servisfisi.TabIndex = 14;
			this.btn_servisfisi.Text = "Servis Fiюi";
			this.btn_servisfisi.Click += new System.EventHandler(this.btn_servisfisi_Click);
			// 
			// btn_servisac
			// 
			this.btn_servisac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_servisac.Location = new System.Drawing.Point(0, 0);
			this.btn_servisac.Name = "btn_servisac";
			this.btn_servisac.TabIndex = 15;
			this.btn_servisac.Text = "Aз";
			this.btn_servisac.Click += new System.EventHandler(this.btn_servisac_Click);
			// 
			// btn_servisduzenle
			// 
			this.btn_servisduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_servisduzenle.Location = new System.Drawing.Point(0, 24);
			this.btn_servisduzenle.Name = "btn_servisduzenle";
			this.btn_servisduzenle.TabIndex = 16;
			this.btn_servisduzenle.Text = "Dьzenle";
			// 
			// pnl_servisfisi
			// 
			this.pnl_servisfisi.Controls.Add(this.btn_servisac);
			this.pnl_servisfisi.Controls.Add(this.btn_servisduzenle);
			this.pnl_servisfisi.Location = new System.Drawing.Point(192, 40);
			this.pnl_servisfisi.Name = "pnl_servisfisi";
			this.pnl_servisfisi.Size = new System.Drawing.Size(75, 47);
			this.pnl_servisfisi.TabIndex = 17;
			this.pnl_servisfisi.Visible = false;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 104);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(856, 280);
			this.dataGrid1.TabIndex = 18;
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(16, 392);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(856, 280);
			this.dataGrid2.TabIndex = 19;
			// 
			// btn_fatura
			// 
			this.btn_fatura.Location = new System.Drawing.Point(280, 16);
			this.btn_fatura.Name = "btn_fatura";
			this.btn_fatura.TabIndex = 20;
			this.btn_fatura.Text = "Fatura";
			// 
			// btn_faturaac
			// 
			this.btn_faturaac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_faturaac.Location = new System.Drawing.Point(0, 0);
			this.btn_faturaac.Name = "btn_faturaac";
			this.btn_faturaac.TabIndex = 21;
			this.btn_faturaac.Text = "Aз";
			// 
			// btn_faturaduzenle
			// 
			this.btn_faturaduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_faturaduzenle.Location = new System.Drawing.Point(0, 24);
			this.btn_faturaduzenle.Name = "btn_faturaduzenle";
			this.btn_faturaduzenle.TabIndex = 22;
			this.btn_faturaduzenle.Text = "Dьzenle";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_faturaac);
			this.panel1.Controls.Add(this.btn_faturaduzenle);
			this.panel1.Location = new System.Drawing.Point(280, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(75, 47);
			this.panel1.TabIndex = 23;
			this.panel1.Visible = false;
			// 
			// frm_anasayfa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1016, 741);
			this.Controls.Add(this.pnl_filtre);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_fatura);
			this.Controls.Add(this.dataGrid2);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.pnl_servisfisi);
			this.Controls.Add(this.btn_servisfisi);
			this.Controls.Add(this.pnl_musteri);
			this.Controls.Add(this.btn_musteri);
			this.Controls.Add(this.btn_filtre);
			this.Name = "frm_anasayfa";
			this.Text = "Welcome to Sevemed CRM - зalэюэn.. зalэюэn... ;)";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frm_anasayfa_Load);
			this.pnl_filtre.ResumeLayout(false);
			this.pnl_musteri.ResumeLayout(false);
			this.pnl_servisfisi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new frm_anasayfa());
		}
		private void frm_anasayfa_Load(object sender, System.EventArgs e)
		{
		
		}

	

		ееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееlse
			{
				pnl_musteri.Visible = true;
			}
		}

		private void btn_servisfisi_Click(object sender, System.EventArgs e)
		{
			pnl_filtre.Visible = false;
			pnl_musteri.Visible = false;
			if (pnl_servisfisi.Visible == true)
			{
				pnl_servisfisi.Visible = false;
			}
			else
			{
				pnl_servisfisi.Visible = true;
			}
		}

		private void btn_servisac_Click(object sender, System.EventArgs e)
		{
			frm_servisac ac=new frm_servisac();
			ac.Show();
			this.Hide();
		}

		privеееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееее