namespace nypdeniz.UI.Forms
{
    partial class GirisEkrani
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
            this.girisYapBtn = new System.Windows.Forms.Button();
            this.kayitOlusturBtn = new System.Windows.Forms.Button();
            this.kayitYokLbl = new System.Windows.Forms.Label();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.tcNoTxtbox = new System.Windows.Forms.TextBox();
            this.tcNoLbl = new System.Windows.Forms.Label();
            this.hosgeldinizLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girisYapBtn
            // 
            this.girisYapBtn.BackColor = System.Drawing.Color.MintCream;
            this.girisYapBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.girisYapBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.girisYapBtn.FlatAppearance.BorderSize = 0;
            this.girisYapBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.girisYapBtn.Location = new System.Drawing.Point(221, 369);
            this.girisYapBtn.Name = "girisYapBtn";
            this.girisYapBtn.Size = new System.Drawing.Size(95, 36);
            this.girisYapBtn.TabIndex = 20;
            this.girisYapBtn.Text = "Giriş Yap";
            this.girisYapBtn.UseVisualStyleBackColor = false;
            this.girisYapBtn.Click += new System.EventHandler(this.girisYapBtn_Click);
            // 
            // kayitOlusturBtn
            // 
            this.kayitOlusturBtn.BackColor = System.Drawing.Color.Transparent;
            this.kayitOlusturBtn.FlatAppearance.BorderSize = 0;
            this.kayitOlusturBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitOlusturBtn.Font = new System.Drawing.Font("Tahoma", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitOlusturBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.kayitOlusturBtn.Location = new System.Drawing.Point(194, 317);
            this.kayitOlusturBtn.Name = "kayitOlusturBtn";
            this.kayitOlusturBtn.Size = new System.Drawing.Size(107, 34);
            this.kayitOlusturBtn.TabIndex = 19;
            this.kayitOlusturBtn.Text = "Kayıt Oluştur";
            this.kayitOlusturBtn.UseVisualStyleBackColor = false;
            this.kayitOlusturBtn.Click += new System.EventHandler(this.kayitOlusturBtn_Click);
            // 
            // kayitYokLbl
            // 
            this.kayitYokLbl.AutoSize = true;
            this.kayitYokLbl.BackColor = System.Drawing.Color.Transparent;
            this.kayitYokLbl.Font = new System.Drawing.Font("Tahoma", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitYokLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.kayitYokLbl.Location = new System.Drawing.Point(75, 327);
            this.kayitYokLbl.Name = "kayitYokLbl";
            this.kayitYokLbl.Size = new System.Drawing.Size(113, 14);
            this.kayitYokLbl.TabIndex = 18;
            this.kayitYokLbl.Text = "Kaydınız yok mu?";
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifreTxtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxtbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sifreTxtbox.Location = new System.Drawing.Point(78, 274);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.PasswordChar = '●';
            this.sifreTxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sifreTxtbox.Size = new System.Drawing.Size(238, 26);
            this.sifreTxtbox.TabIndex = 17;
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.BackColor = System.Drawing.Color.Transparent;
            this.sifreLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.sifreLbl.Location = new System.Drawing.Point(74, 250);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(56, 21);
            this.sifreLbl.TabIndex = 16;
            this.sifreLbl.Text = "Şifre:";
            // 
            // tcNoTxtbox
            // 
            this.tcNoTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcNoTxtbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcNoTxtbox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tcNoTxtbox.Location = new System.Drawing.Point(78, 197);
            this.tcNoTxtbox.Name = "tcNoTxtbox";
            this.tcNoTxtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcNoTxtbox.Size = new System.Drawing.Size(238, 26);
            this.tcNoTxtbox.TabIndex = 15;
            // 
            // tcNoLbl
            // 
            this.tcNoLbl.AutoSize = true;
            this.tcNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.tcNoLbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcNoLbl.ForeColor = System.Drawing.Color.CadetBlue;
            this.tcNoLbl.Location = new System.Drawing.Point(74, 173);
            this.tcNoLbl.Name = "tcNoLbl";
            this.tcNoLbl.Size = new System.Drawing.Size(181, 21);
            this.tcNoLbl.TabIndex = 14;
            this.tcNoLbl.Text = "TC Kimlik Numarası:";
            // 
            // hosgeldinizLbl
            // 
            this.hosgeldinizLbl.AutoSize = true;
            this.hosgeldinizLbl.BackColor = System.Drawing.Color.Transparent;
            this.hosgeldinizLbl.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosgeldinizLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.hosgeldinizLbl.Location = new System.Drawing.Point(99, 94);
            this.hosgeldinizLbl.Name = "hosgeldinizLbl";
            this.hosgeldinizLbl.Size = new System.Drawing.Size(194, 45);
            this.hosgeldinizLbl.TabIndex = 13;
            this.hosgeldinizLbl.Text = "Hoşgeldiniz";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nypdeniz.Properties.Resources.unfocussed_winter_background_with_snowflakes_1393_271;
            this.ClientSize = new System.Drawing.Size(404, 490);
            this.Controls.Add(this.girisYapBtn);
            this.Controls.Add(this.kayitOlusturBtn);
            this.Controls.Add(this.kayitYokLbl);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.tcNoTxtbox);
            this.Controls.Add(this.tcNoLbl);
            this.Controls.Add(this.hosgeldinizLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisYapBtn;
        private System.Windows.Forms.Button kayitOlusturBtn;
        private System.Windows.Forms.Label kayitYokLbl;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.TextBox tcNoTxtbox;
        private System.Windows.Forms.Label tcNoLbl;
        private System.Windows.Forms.Label hosgeldinizLbl;
    }
}