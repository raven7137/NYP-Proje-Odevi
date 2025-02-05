namespace nypdeniz.UI.UserControls
{
    partial class OdaControl
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
            this.odaTipiTxtbx = new System.Windows.Forms.TextBox();
            this.odaFiyatiTxtbx = new System.Windows.Forms.TextBox();
            this.odaNoTxtbx = new System.Windows.Forms.TextBox();
            this.odaFiyatiLbl = new System.Windows.Forms.Label();
            this.odalarDatagrid = new System.Windows.Forms.DataGridView();
            this.odaTipiLbl = new System.Windows.Forms.Label();
            this.odaNoLbl = new System.Windows.Forms.Label();
            this.odaIdTxt = new System.Windows.Forms.TextBox();
            this.odalarGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odalarDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // odalarGrpbx
            // 
            this.odalarGrpbx.Controls.Add(this.odaIdTxt);
            this.odalarGrpbx.Controls.Add(this.ekleBtn);
            this.odalarGrpbx.Controls.Add(this.guncelleBtn);
            this.odalarGrpbx.Controls.Add(this.silBtn);
            this.odalarGrpbx.Controls.Add(this.odaTipiTxtbx);
            this.odalarGrpbx.Controls.Add(this.odaFiyatiTxtbx);
            this.odalarGrpbx.Controls.Add(this.odaNoTxtbx);
            this.odalarGrpbx.Controls.Add(this.odaFiyatiLbl);
            this.odalarGrpbx.Controls.Add(this.odalarDatagrid);
            this.odalarGrpbx.Controls.Add(this.odaTipiLbl);
            this.odalarGrpbx.Controls.Add(this.odaNoLbl);
            this.odalarGrpbx.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odalarGrpbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odalarGrpbx.Location = new System.Drawing.Point(21, 18);
            this.odalarGrpbx.Name = "odalarGrpbx";
            this.odalarGrpbx.Size = new System.Drawing.Size(781, 429);
            this.odalarGrpbx.TabIndex = 2;
            this.odalarGrpbx.TabStop = false;
            this.odalarGrpbx.Text = "Odalar";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(6, 341);
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
            // odaTipiTxtbx
            // 
            this.odaTipiTxtbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odaTipiTxtbx.Location = new System.Drawing.Point(64, 208);
            this.odaTipiTxtbx.Name = "odaTipiTxtbx";
            this.odaTipiTxtbx.Size = new System.Drawing.Size(116, 26);
            this.odaTipiTxtbx.TabIndex = 5;
            // 
            // odaFiyatiTxtbx
            // 
            this.odaFiyatiTxtbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odaFiyatiTxtbx.Location = new System.Drawing.Point(64, 283);
            this.odaFiyatiTxtbx.Name = "odaFiyatiTxtbx";
            this.odaFiyatiTxtbx.Size = new System.Drawing.Size(116, 26);
            this.odaFiyatiTxtbx.TabIndex = 6;
            this.odaFiyatiTxtbx.TextChanged += new System.EventHandler(this.odaFiyatiTxtbx_TextChanged);
            // 
            // odaNoTxtbx
            // 
            this.odaNoTxtbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odaNoTxtbx.Location = new System.Drawing.Point(64, 128);
            this.odaNoTxtbx.Name = "odaNoTxtbx";
            this.odaNoTxtbx.Size = new System.Drawing.Size(116, 26);
            this.odaNoTxtbx.TabIndex = 4;
            // 
            // odaFiyatiLbl
            // 
            this.odaFiyatiLbl.AutoSize = true;
            this.odaFiyatiLbl.Location = new System.Drawing.Point(61, 262);
            this.odaFiyatiLbl.Name = "odaFiyatiLbl";
            this.odaFiyatiLbl.Size = new System.Drawing.Size(90, 18);
            this.odaFiyatiLbl.TabIndex = 3;
            this.odaFiyatiLbl.Text = "Oda Fiyatı:";
            // 
            // odalarDatagrid
            // 
            this.odalarDatagrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.odalarDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odalarDatagrid.Location = new System.Drawing.Point(295, 25);
            this.odalarDatagrid.Name = "odalarDatagrid";
            this.odalarDatagrid.RowHeadersWidth = 51;
            this.odalarDatagrid.RowTemplate.Height = 24;
            this.odalarDatagrid.Size = new System.Drawing.Size(463, 379);
            this.odalarDatagrid.TabIndex = 2;
            this.odalarDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odalarDatagrid_CellContentClick);
            // 
            // odaTipiLbl
            // 
            this.odaTipiLbl.AutoSize = true;
            this.odaTipiLbl.Location = new System.Drawing.Point(61, 187);
            this.odaTipiLbl.Name = "odaTipiLbl";
            this.odaTipiLbl.Size = new System.Drawing.Size(75, 18);
            this.odaTipiLbl.TabIndex = 1;
            this.odaTipiLbl.Text = "Oda Tipi:";
            // 
            // odaNoLbl
            // 
            this.odaNoLbl.AutoSize = true;
            this.odaNoLbl.Location = new System.Drawing.Point(61, 107);
            this.odaNoLbl.Name = "odaNoLbl";
            this.odaNoLbl.Size = new System.Drawing.Size(119, 18);
            this.odaNoLbl.TabIndex = 0;
            this.odaNoLbl.Text = "Oda Numarası:";
            // 
            // odaIdTxt
            // 
            this.odaIdTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odaIdTxt.Location = new System.Drawing.Point(64, 48);
            this.odaIdTxt.Name = "odaIdTxt";
            this.odaIdTxt.Size = new System.Drawing.Size(116, 26);
            this.odaIdTxt.TabIndex = 10;
            // 
            // OdaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.odalarGrpbx);
            this.Name = "OdaControl";
            this.Size = new System.Drawing.Size(823, 465);
            this.odalarGrpbx.ResumeLayout(false);
            this.odalarGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odalarDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox odalarGrpbx;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.TextBox odaTipiTxtbx;
        private System.Windows.Forms.TextBox odaFiyatiTxtbx;
        private System.Windows.Forms.TextBox odaNoTxtbx;
        private System.Windows.Forms.Label odaFiyatiLbl;
        private System.Windows.Forms.DataGridView odalarDatagrid;
        private System.Windows.Forms.Label odaTipiLbl;
        private System.Windows.Forms.Label odaNoLbl;
        private System.Windows.Forms.TextBox odaIdTxt;
    }
}
