using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sevemed_CRM
{
	/// <summary>
	/// Summary description for frm_musteriara.
	/// </summary>
	public class frm_musteriara : System.Windows.Forms.Form
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_ara;
		private System.Windows.Forms.TextBox txt_ara;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_musteriara()
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
            this.btn_servisfiltre = new System.Windows.Forms.ווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווduzenle = new System.Windows.Forms.Button();
            this.btn_servisfisi = new System.Windows.Forms.Button();
            this.pnl_musteri = new System.Windows.Forms.Panel();
            this.btn_musteriac = new System.Windows.Forms.Button();
            this.btn_musteriduzenle = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.btn_filtre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_filtre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_servisfisi.SuspendLayout();
            this.pnl_musteri.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_filtre
            // 
            this.pnl_filtre.Controls.Add(this.btn_musterifiltre);
            this.pnl_filtre.Controls.Add(this.btn_servisfiltre);
            this.pnl_filtre.Controls.Add(this.btn_faturaara);
            this.pnl_filtre.Location = new System.Drawing.Point(16, 40);
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
            this.btn_musterifiltre.Size = new System.Drawing.Size(75, 23);
            this.btn_musterifiltre.TabIndex = 4;
            this.btn_musterifiltre.Text = "Mü‏teri";
            // 
            // btn_servisfiltre
            // 
            this.btn_servisfiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servisfiltre.Location = new System.Drawing.Point(0, 24);
            this.btn_servisfiltre.Name = "btn_servisfiltre";
            this.btn_servisfiltre.Size = new System.Drawing.Size(75, 23);
            this.btn_servisfiltre.TabIndex = 5;
            this.btn_servisfiltre.Text = "Servis Fi‏i";
            // 
            // btn_faturaara
            // 
            this.btn_faturaara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faturaara.Location = new System.Drawing.Point(0, 48);
            this.btn_faturaara.Name = "btn_faturaara";
            this.btn_faturaara.Size = new System.Drawing.Size(75, 23);
            this.btn_faturaara.TabIndex = 24;
            this.btn_faturaara.Text = "Fatura";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_faturaac);
            this.panel1.Controls.Add(this.btn_faturaduzenle);
            this.panel1.Location = new System.Drawing.Point(280, 40);
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
            this.btn_faturaac.Size = new System.Drawing.Size(75, 23);
            this.btn_faturaac.TabIndex = 21;
            this.btn_faturaac.Text = "Aח";
            // 
            // btn_faturaduzenle
            // 
            this.btn_faturaduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faturaduzenle.Location = new System.Drawing.Point(0, 24);
            this.btn_faturaduzenle.Name = "btn_faturaduzenle";
            this.btn_faturaduzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_faturaduzenle.TabIndex = 22;
            this.btn_faturaduzenle.Text = "Düzenle";
            // 
            // btn_fatura
            // 
            this.btn_fatura.Location = new System.Drawing.Point(280, 16);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(75, 23);
            this.btn_fatura.TabIndex = 30;
            this.btn_fatura.Text = "Fatura";
            // 
            // pnl_servisfisi
            // 
            this.pnl_servisfisi.Controls.Add(this.btn_servisac);
            this.pnl_servisfisi.Controls.Add(this.btn_servisduzenle);
            this.pnl_servisfisi.Location = new System.Drawing.Point(192, 40);
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
            this.btn_servisac.Size = new System.Drawing.Size(75, 23);
            this.btn_servisac.TabIndex = 15;
            this.btn_servisac.Text = "Aח";
            // 
            // btn_servisduzenle
            // 
            this.btn_servisduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servisduzenle.Location = new System.Drawing.Point(0, 24);
            this.btn_servisduzenle.Name = "btn_servisduzenle";
            this.btn_servisduzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_servisduzenle.TabIndex = 16;
            this.btn_servisduzenle.Text = "Düzenle";
            // 
            // btn_servisfisi
            // 
            this.btn_servisfisi.Location = new System.Drawing.Point(192, 16);
            this.btn_servisfisi.Name = "btn_servisfisi";
            this.btn_servisfisi.Size = new System.Drawing.Size(75, 23);
            this.btn_servisfisi.TabIndex = 28;
            this.btn_servisfisi.Text = "Servis Fi‏i";
            // 
            // pnl_musteri
            // 
            this.pnl_musteri.Controls.Add(this.btn_musteriac);
            this.pnl_musteri.Controls.Add(this.btn_musteriduzenle);
            this.pnl_musteri.Location = new System.Drawing.Point(104, 40);
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
            this.btn_musteriac.Size = new System.Drawing.Size(75, 23);
            this.btn_musteriac.TabIndex = 11;
            this.btn_musteriac.Text = "Aח";
            // 
            // btn_musteriduzenle
            // 
            this.btn_musteriduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_musteriduzenle.Location = new System.Drawing.Point(0, 24);
            this.btn_musteriduzenle.Name = "btn_musteriduzenle";
            this.btn_musteriduzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_musteriduzenle.TabIndex = 12;
            this.btn_musteriduzenle.Text = "Düzenle";
            // 
            // btn_musteri
            // 
            this.btn_musteri.Location = new System.Drawing.Point(104, 16);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(75, 23);
            this.btn_musteri.TabIndex = 26;
            this.btn_musteri.Text = "Mü‏teri";
            // 
            // btn_filtre
            // 
            this.btn_filtre.Location = new System.Drawing.Point(16, 16);
            this.btn_filtre.Name = "btn_filtre";
            this.btn_filtre.Size = new System.Drawing.Size(75, 23);
            this.btn_filtre.TabIndex = 24;
            this.btn_filtre.Text = "Filtre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_ara);
            this.panel2.Controls.Add(this.btn_ara);
            this.panel2.Location = new System.Drawing.Point(8, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 48);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Aranacak :";
            // 
            // txt_ara
            //ווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווווze = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 33;
            this.btn_ara.Text = "Ara";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(840, 530);
            this.dataGrid1.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.dataGrid1);
            this.panel3.Location = new System.Drawing.Point(8, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 545);
            this.panel3.TabIndex = 35;
            // 
            // frm_musteriara
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_filtre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_fatura);
            this.Controls.Add(this.pnl_servisfisi);
            this.Controls.Add(this.btn_servisfisi);
            this.Controls.Add(this.pnl_musteri);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.btn_filtre);
            this.Name = "frm_musteriara";
            this.Text = "frm_musteriara";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_musteriara_Load);
            this.pnl_filtre.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_servisfisi.ResumeLayout(false);
            this.pnl_musteri.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private void frm_musteriara_Load(object sender, EventArgs e)
        {

        }
	}
}
