namespace nypdeniz.UI.Forms
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.anaMenuLbl = new System.Windows.Forms.Label();
            this.rezervasyonIslemleriBtn = new System.Windows.Forms.Button();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.odalarBtn = new System.Windows.Forms.Button();
            this.faturaBilgileriBtn = new System.Windows.Forms.Button();
            this.yapilacakIslemLbl = new System.Windows.Forms.Label();
            this.islemlerGrpbx = new System.Windows.Forms.GroupBox();
            this.musterilerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rezervBtn = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.odaBtn = new System.Windows.Forms.Button();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.islemLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.faturaBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.islemlerGrpbx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anaMenuLbl
            // 
            this.anaMenuLbl.AutoSize = true;
            this.anaMenuLbl.BackColor = System.Drawing.Color.Transparent;
            this.anaMenuLbl.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anaMenuLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.anaMenuLbl.Location = new System.Drawing.Point(12, 9);
            this.anaMenuLbl.Name = "anaMenuLbl";
            this.anaMenuLbl.Size = new System.Drawing.Size(174, 45);
            this.anaMenuLbl.TabIndex = 10;
            this.anaMenuLbl.Text = "Ana Menü";
            // 
            // rezervasyonIslemleriBtn
            // 
            this.rezervasyonIslemleriBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.rezervasyonIslemleriBtn.Location = new System.Drawing.Point(6, 25);
            this.rezervasyonIslemleriBtn.Name = "rezervasyonIslemleriBtn";
            this.rezervasyonIslemleriBtn.Size = new System.Drawing.Size(182, 83);
            this.rezervasyonIslemleriBtn.TabIndex = 0;
            this.rezervasyonIslemleriBtn.Text = "Rezervasyon İşlemleri";
            this.rezervasyonIslemleriBtn.UseVisualStyleBackColor = false;
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Azure;
            this.cikisBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisBtn.Location = new System.Drawing.Point(44, 423);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(97, 27);
            this.cikisBtn.TabIndex = 4;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.UseVisualStyleBackColor = false;
            // 
            // odalarBtn
            // 
            this.odalarBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.odalarBtn.Location = new System.Drawing.Point(6, 114);
            this.odalarBtn.Name = "odalarBtn";
            this.odalarBtn.Size = new System.Drawing.Size(182, 83);
            this.odalarBtn.TabIndex = 1;
            this.odalarBtn.Text = "Odalar";
            this.odalarBtn.UseVisualStyleBackColor = false;
            // 
            // faturaBilgileriBtn
            // 
            this.faturaBilgileriBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.faturaBilgileriBtn.Location = new System.Drawing.Point(6, 203);
            this.faturaBilgileriBtn.Name = "faturaBilgileriBtn";
            this.faturaBilgileriBtn.Size = new System.Drawing.Size(182, 83);
            this.faturaBilgileriBtn.TabIndex = 3;
            this.faturaBilgileriBtn.Text = "Müşteriler";
            this.faturaBilgileriBtn.UseVisualStyleBackColor = false;
            // 
            // yapilacakIslemLbl
            // 
            this.yapilacakIslemLbl.AutoSize = true;
            this.yapilacakIslemLbl.BackColor = System.Drawing.Color.Transparent;
            this.yapilacakIslemLbl.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapilacakIslemLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.yapilacakIslemLbl.Location = new System.Drawing.Point(459, 253);
            this.yapilacakIslemLbl.Name = "yapilacakIslemLbl";
            this.yapilacakIslemLbl.Size = new System.Drawing.Size(363, 18);
            this.yapilacakIslemLbl.TabIndex = 12;
            this.yapilacakIslemLbl.Text = "Lütfen yapmak istediğiniz işlemi soldan seçiniz.";
            this.yapilacakIslemLbl.Click += new System.EventHandler(this.yapilacakIslemLbl_Click);
            // 
            // islemlerGrpbx
            // 
            this.islemlerGrpbx.BackColor = System.Drawing.Color.Azure;
            this.islemlerGrpbx.Controls.Add(this.musterilerBtn);
            this.islemlerGrpbx.Controls.Add(this.rezervasyonIslemleriBtn);
            this.islemlerGrpbx.Controls.Add(this.cikisBtn);
            this.islemlerGrpbx.Controls.Add(this.odalarBtn);
            this.islemlerGrpbx.Controls.Add(this.faturaBilgileriBtn);
            this.islemlerGrpbx.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemlerGrpbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.islemlerGrpbx.Location = new System.Drawing.Point(20, 57);
            this.islemlerGrpbx.Name = "islemlerGrpbx";
            this.islemlerGrpbx.Size = new System.Drawing.Size(200, 465);
            this.islemlerGrpbx.TabIndex = 11;
            this.islemlerGrpbx.TabStop = false;
            this.islemlerGrpbx.Text = "İşlemler";
            // 
            // musterilerBtn
            // 
            this.musterilerBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.musterilerBtn.Location = new System.Drawing.Point(6, 292);
            this.musterilerBtn.Name = "musterilerBtn";
            this.musterilerBtn.Size = new System.Drawing.Size(182, 83);
            this.musterilerBtn.TabIndex = 5;
            this.musterilerBtn.Text = "Fatura Bilgileri";
            this.musterilerBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(226, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 465);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ana Menü";
            // 
            // rezervBtn
            // 
            this.rezervBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.rezervBtn.Location = new System.Drawing.Point(6, 51);
            this.rezervBtn.Name = "rezervBtn";
            this.rezervBtn.Size = new System.Drawing.Size(182, 83);
            this.rezervBtn.TabIndex = 0;
            this.rezervBtn.Text = "Rezervasyon İşlemleri";
            this.rezervBtn.UseVisualStyleBackColor = false;
            this.rezervBtn.Click += new System.EventHandler(this.rezervBtn_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Azure;
            this.cikis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.Location = new System.Drawing.Point(44, 423);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(97, 27);
            this.cikis.TabIndex = 4;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // odaBtn
            // 
            this.odaBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.odaBtn.Location = new System.Drawing.Point(6, 140);
            this.odaBtn.Name = "odaBtn";
            this.odaBtn.Size = new System.Drawing.Size(182, 83);
            this.odaBtn.TabIndex = 1;
            this.odaBtn.Text = "Odalar";
            this.odaBtn.UseVisualStyleBackColor = false;
            this.odaBtn.Click += new System.EventHandler(this.odaBtn_Click);
            // 
            // musteriBtn
            // 
            this.musteriBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.musteriBtn.Location = new System.Drawing.Point(6, 229);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(182, 83);
            this.musteriBtn.TabIndex = 3;
            this.musteriBtn.Text = "Müşteriler";
            this.musteriBtn.UseVisualStyleBackColor = false;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // islemLbl
            // 
            this.islemLbl.AutoSize = true;
            this.islemLbl.BackColor = System.Drawing.Color.Transparent;
            this.islemLbl.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.islemLbl.Location = new System.Drawing.Point(457, 307);
            this.islemLbl.Name = "islemLbl";
            this.islemLbl.Size = new System.Drawing.Size(363, 18);
            this.islemLbl.TabIndex = 10;
            this.islemLbl.Text = "Lütfen yapmak istediğiniz işlemi soldan seçiniz.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.faturaBtn);
            this.groupBox1.Controls.Add(this.rezervBtn);
            this.groupBox1.Controls.Add(this.cikis);
            this.groupBox1.Controls.Add(this.odaBtn);
            this.groupBox1.Controls.Add(this.musteriBtn);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(20, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 465);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // faturaBtn
            // 
            this.faturaBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.faturaBtn.Location = new System.Drawing.Point(6, 318);
            this.faturaBtn.Name = "faturaBtn";
            this.faturaBtn.Size = new System.Drawing.Size(182, 83);
            this.faturaBtn.TabIndex = 5;
            this.faturaBtn.Text = "Fatura Bilgileri";
            this.faturaBtn.UseVisualStyleBackColor = false;
            this.faturaBtn.Click += new System.EventHandler(this.faturaBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(227, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 465);
            this.panel2.TabIndex = 11;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1055, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.islemLbl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.islemlerGrpbx.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anaMenuLbl;
        private System.Windows.Forms.Button rezervasyonIslemleriBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Button odalarBtn;
        private System.Windows.Forms.Button faturaBilgileriBtn;
        private System.Windows.Forms.Label yapilacakIslemLbl;
        private System.Windows.Forms.GroupBox islemlerGrpbx;
        private System.Windows.Forms.Button musterilerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rezervBtn;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button odaBtn;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Label islemLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button faturaBtn;
        private System.Windows.Forms.Panel panel2;
    }
}