namespace nypdeniz.UI.UserControls
{
    partial class RezervasyonIslemleri
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
            this.toplamFiyatTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.idTxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cikisTarihiLbl = new System.Windows.Forms.Label();
            this.girisTarihiLbl = new System.Windows.Forms.Label();
            this.cikisTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.girisTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.odaNoTxtbx = new System.Windows.Forms.TextBox();
            this.isimSoyisimTxtbx = new System.Windows.Forms.TextBox();
            this.odaFiyatiLbl = new System.Windows.Forms.Label();
            this.rezervasyonDataGrid = new System.Windows.Forms.DataGridView();
            this.isimSoyisimLbl = new System.Windows.Forms.Label();
            this.odalarGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // odalarGrpbx
            // 
            this.odalarGrpbx.Controls.Add(this.toplamFiyatTxt);
            this.odalarGrpbx.Controls.Add(this.label2);
            this.odalarGrpbx.Controls.Add(this.silBtn);
            this.odalarGrpbx.Controls.Add(this.idTxtbx);
            this.odalarGrpbx.Controls.Add(this.label1);
            this.odalarGrpbx.Controls.Add(this.cikisTarihiLbl);
            this.odalarGrpbx.Controls.Add(this.girisTarihiLbl);
            this.odalarGrpbx.Controls.Add(this.cikisTarihiDtp);
            this.odalarGrpbx.Controls.Add(this.girisTarihiDtp);
            this.odalarGrpbx.Controls.Add(this.ekleBtn);
            this.odalarGrpbx.Controls.Add(this.odaNoTxtbx);
            this.odalarGrpbx.Controls.Add(this.isimSoyisimTxtbx);
            this.odalarGrpbx.Controls.Add(this.odaFiyatiLbl);
            this.odalarGrpbx.Controls.Add(this.rezervasyonDataGrid);
            this.odalarGrpbx.Controls.Add(this.isimSoyisimLbl);
            this.odalarGrpbx.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odalarGrpbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odalarGrpbx.Location = new System.Drawing.Point(21, 18);
            this.odalarGrpbx.Name = "odalarGrpbx";
            this.odalarGrpbx.Size = new System.Drawing.Size(781, 429);
            this.odalarGrpbx.TabIndex = 3;
            this.odalarGrpbx.TabStop = false;
            this.odalarGrpbx.Text = "Rezervasyon İşlemleri";
            // 
            // toplamFiyatTxt
            // 
            this.toplamFiyatTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.toplamFiyatTxt.Location = new System.Drawing.Point(64, 330);
            this.toplamFiyatTxt.Name = "toplamFiyatTxt";
            this.toplamFiyatTxt.Size = new System.Drawing.Size(116, 26);
            this.toplamFiyatTxt.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Toplam Fiyat:";
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(143, 375);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(85, 29);
            this.silBtn.TabIndex = 17;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // idTxtbx
            // 
            this.idTxtbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.idTxtbx.Location = new System.Drawing.Point(64, 57);
            this.idTxtbx.Name = "idTxtbx";
            this.idTxtbx.Size = new System.Drawing.Size(116, 26);
            this.idTxtbx.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // cikisTarihiLbl
            // 
            this.cikisTarihiLbl.AutoSize = true;
            this.cikisTarihiLbl.Location = new System.Drawing.Point(61, 255);
            this.cikisTarihiLbl.Name = "cikisTarihiLbl";
            this.cikisTarihiLbl.Size = new System.Drawing.Size(98, 18);
            this.cikisTarihiLbl.TabIndex = 14;
            this.cikisTarihiLbl.Text = "Çıkış Tarihi:";
            // 
            // girisTarihiLbl
            // 
            this.girisTarihiLbl.AutoSize = true;
            this.girisTarihiLbl.Location = new System.Drawing.Point(61, 200);
            this.girisTarihiLbl.Name = "girisTarihiLbl";
            this.girisTarihiLbl.Size = new System.Drawing.Size(97, 18);
            this.girisTarihiLbl.TabIndex = 13;
            this.girisTarihiLbl.Text = "Giriş Tarihi:";
            // 
            // cikisTarihiDtp
            // 
            this.cikisTarihiDtp.Location = new System.Drawing.Point(28, 276);
            this.cikisTarihiDtp.Name = "cikisTarihiDtp";
            this.cikisTarihiDtp.Size = new System.Drawing.Size(200, 26);
            this.cikisTarihiDtp.TabIndex = 12;
            // 
            // girisTarihiDtp
            // 
            this.girisTarihiDtp.Location = new System.Drawing.Point(28, 221);
            this.girisTarihiDtp.Name = "girisTarihiDtp";
            this.girisTarihiDtp.Size = new System.Drawing.Size(200, 26);
            this.girisTarihiDtp.TabIndex = 11;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(37, 375);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(85, 29);
            this.ekleBtn.TabIndex = 10;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // odaNoTxtbx
            // 
            this.odaNoTxtbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.odaNoTxtbx.Location = new System.Drawing.Point(64, 167);
            this.odaNoTxtbx.Name = "odaNoTxtbx";
            this.odaNoTxtbx.Size = new System.Drawing.Size(116, 26);
            this.odaNoTxtbx.TabIndex = 6;
            this.odaNoTxtbx.TextChanged += new System.EventHandler(this.odaNoTxtbx_TextChanged);
            // 
            // isimSoyisimTxtbx
            // 
            this.isimSoyisimTxtbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.isimSoyisimTxtbx.Location = new System.Drawing.Point(64, 114);
            this.isimSoyisimTxtbx.Name = "isimSoyisimTxtbx";
            this.isimSoyisimTxtbx.Size = new System.Drawing.Size(116, 26);
            this.isimSoyisimTxtbx.TabIndex = 4;
            // 
            // odaFiyatiLbl
            // 
            this.odaFiyatiLbl.AutoSize = true;
            this.odaFiyatiLbl.Location = new System.Drawing.Point(61, 146);
            this.odaFiyatiLbl.Name = "odaFiyatiLbl";
            this.odaFiyatiLbl.Size = new System.Drawing.Size(119, 18);
            this.odaFiyatiLbl.TabIndex = 3;
            this.odaFiyatiLbl.Text = "Oda Numarası:";
            // 
            // rezervasyonDataGrid
            // 
            this.rezervasyonDataGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.rezervasyonDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezervasyonDataGrid.Location = new System.Drawing.Point(295, 25);
            this.rezervasyonDataGrid.Name = "rezervasyonDataGrid";
            this.rezervasyonDataGrid.RowHeadersWidth = 51;
            this.rezervasyonDataGrid.RowTemplate.Height = 24;
            this.rezervasyonDataGrid.Size = new System.Drawing.Size(463, 379);
            this.rezervasyonDataGrid.TabIndex = 2;
            this.rezervasyonDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rezervasyonDataGrid_CellContentClick);
            // 
            // isimSoyisimLbl
            // 
            this.isimSoyisimLbl.AutoSize = true;
            this.isimSoyisimLbl.Location = new System.Drawing.Point(61, 93);
            this.isimSoyisimLbl.Name = "isimSoyisimLbl";
            this.isimSoyisimLbl.Size = new System.Drawing.Size(109, 18);
            this.isimSoyisimLbl.TabIndex = 0;
            this.isimSoyisimLbl.Text = "İsim Soyisim:";
            // 
            // RezervasyonIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.odalarGrpbx);
            this.Name = "RezervasyonIslemleri";
            this.Size = new System.Drawing.Size(823, 465);
            this.odalarGrpbx.ResumeLayout(false);
            this.odalarGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox odalarGrpbx;
        private System.Windows.Forms.TextBox idTxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cikisTarihiLbl;
        private System.Windows.Forms.Label girisTarihiLbl;
        private System.Windows.Forms.DateTimePicker cikisTarihiDtp;
        private System.Windows.Forms.DateTimePicker girisTarihiDtp;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.TextBox odaNoTxtbx;
        private System.Windows.Forms.TextBox isimSoyisimTxtbx;
        private System.Windows.Forms.Label odaFiyatiLbl;
        private System.Windows.Forms.DataGridView rezervasyonDataGrid;
        private System.Windows.Forms.Label isimSoyisimLbl;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.TextBox toplamFiyatTxt;
        private System.Windows.Forms.Label label2;
    }
}
