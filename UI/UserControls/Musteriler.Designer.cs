namespace nypdeniz.UI.UserControls
{
    partial class MusteriControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.odalarGrpbx = new System.Windows.Forms.GroupBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.musteriTelTxt = new System.Windows.Forms.TextBox();
            this.musteriMailTxt = new System.Windows.Forms.TextBox();
            this.musteriAdTxt = new System.Windows.Forms.TextBox();
            this.odaFiyatiLbl = new System.Windows.Forms.Label();
            this.musterilerDatagrid = new System.Windows.Forms.DataGridView();
            this.odaTipiLbl = new System.Windows.Forms.Label();
            this.odaNoLbl = new System.Windows.Forms.Label();
            this.musteriIdTxt = new System.Windows.Forms.TextBox();
            this.odalarGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // odalarGrpbx
            // 
            this.odalarGrpbx.Controls.Add(this.musteriIdTxt);
            this.odalarGrpbx.Controls.Add(this.ekleBtn);
            this.odalarGrpbx.Controls.Add(this.guncelleBtn);
            this.odalarGrpbx.Controls.Add(this.silBtn);
            this.odalarGrpbx.Controls.Add(this.musteriTelTxt);
            this.odalarGrpbx.Controls.Add(this.musteriMailTxt);
            this.odalarGrpbx.Controls.Add(this.musteriAdTxt);
            this.odalarGrpbx.Controls.Add(this.odaFiyatiLbl);
            this.odalarGrpbx.Controls.Add(this.musterilerDatagrid);
            this.odalarGrpbx.Controls.Add(this.odaTipiLbl);
            this.odalarGrpbx.Controls.Add(this.odaNoLbl);
            this.odalarGrpbx.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odalarGrpbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odalarGrpbx.Location = new System.Drawing.Point(21, 18);
            this.odalarGrpbx.Name = "odalarGrpbx";
            this.odalarGrpbx.Size = new System.Drawing.Size(781, 429);
            this.odalarGrpbx.TabIndex = 3;
            this.odalarGrpbx.TabStop = false;
            this.odalarGrpbx.Text = "Müşteriler";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(4, 341);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(85, 29);
            this.ekleBtn.TabIndex = 9;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(95, 341);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(103, 29);
            this.guncelleBtn.TabIndex = 8;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(204, 341);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(85, 29);
            this.silBtn.TabIndex = 7;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // musteriTelTxt
            // 
            this.musteriTelTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.musteriTelTxt.Location = new System.Drawing.Point(64, 208);
            this.musteriTelTxt.Name = "musteriTelTxt";
            this.musteriTelTxt.Size = new System.Drawing.Size(116, 26);
            this.musteriTelTxt.TabIndex = 5;
            // 
            // musteriMailTxt
            // 
            this.musteriMailTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.musteriMailTxt.Location = new System.Drawing.Point(64, 283);
            this.musteriMailTxt.Name = "musteriMailTxt";
            this.musteriMailTxt.Size = new System.Drawing.Size(116, 26);
            this.musteriMailTxt.TabIndex = 6;
            // 
            // musteriAdTxt
            // 
            this.musteriAdTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.musteriAdTxt.Location = new System.Drawing.Point(64, 128);
            this.musteriAdTxt.Name = "musteriAdTxt";
            this.musteriAdTxt.Size = new System.Drawing.Size(116, 26);
            this.musteriAdTxt.TabIndex = 4;
            // 
            // odaFiyatiLbl
            // 
            this.odaFiyatiLbl.AutoSize = true;
            this.odaFiyatiLbl.Location = new System.Drawing.Point(61, 262);
            this.odaFiyatiLbl.Name = "odaFiyatiLbl";
            this.odaFiyatiLbl.Size = new System.Drawing.Size(121, 18);
            this.odaFiyatiLbl.TabIndex = 3;
            this.odaFiyatiLbl.Text = "Müşteri E-mail:";
            // 
            // musterilerDatagrid
            // 
            this.musterilerDatagrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.musterilerDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerDatagrid.Location = new System.Drawing.Point(295, 25);
            this.musterilerDatagrid.Name = "musterilerDatagrid";
            this.musterilerDatagrid.RowHeadersWidth = 51;
            this.musterilerDatagrid.RowTemplate.Height = 24;
            this.musterilerDatagrid.Size = new System.Drawing.Size(463, 379);
            this.musterilerDatagrid.TabIndex = 2;
            this.musterilerDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musterilerDatagrid_CellContentClick);
            // 
            // odaTipiLbl
            // 
            this.odaTipiLbl.AutoSize = true;
            this.odaTipiLbl.Location = new System.Drawing.Point(61, 187);
            this.odaTipiLbl.Name = "odaTipiLbl";
            this.odaTipiLbl.Size = new System.Drawing.Size(206, 18);
            this.odaTipiLbl.TabIndex = 1;
            this.odaTipiLbl.Text = "Müşteri Telefon Numarası:";
            // 
            // odaNoLbl
            // 
            this.odaNoLbl.AutoSize = true;
            this.odaNoLbl.Location = new System.Drawing.Point(61, 107);
            this.odaNoLbl.Name = "odaNoLbl";
            this.odaNoLbl.Size = new System.Drawing.Size(143, 18);
            this.odaNoLbl.TabIndex = 0;
            this.odaNoLbl.Text = "Müşteri Ad Soyad:";
            // 
            // musteriIdTxt
            // 
            this.musteriIdTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.musteriIdTxt.Location = new System.Drawing.Point(64, 59);
            this.musteriIdTxt.Name = "musteriIdTxt";
            this.musteriIdTxt.Size = new System.Drawing.Size(116, 26);
            this.musteriIdTxt.TabIndex = 10;
            // 
            // MusteriControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.odalarGrpbx);
            this.Name = "MusteriControl";
            this.Size = new System.Drawing.Size(823, 465);
            this.odalarGrpbx.ResumeLayout(false);
            this.odalarGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox odalarGrpbx;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.TextBox musteriTelTxt;
        private System.Windows.Forms.TextBox musteriMailTxt;
        private System.Windows.Forms.TextBox musteriAdTxt;
        private System.Windows.Forms.Label odaFiyatiLbl;
        private System.Windows.Forms.DataGridView musterilerDatagrid;
        private System.Windows.Forms.Label odaTipiLbl;
        private System.Windows.Forms.Label odaNoLbl;
        private System.Windows.Forms.TextBox musteriIdTxt;
    }
}
