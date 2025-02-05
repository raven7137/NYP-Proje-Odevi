namespace nypdeniz.UI.UserControls
{
    partial class FaturaBilgileri
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
            this.faturaBilgileriGrpbx = new System.Windows.Forms.GroupBox();
            this.gorBtn = new System.Windows.Forms.Button();
            this.dataGridFatura = new System.Windows.Forms.DataGridView();
            this.faturaBilgileriGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // faturaBilgileriGrpbx
            // 
            this.faturaBilgileriGrpbx.Controls.Add(this.gorBtn);
            this.faturaBilgileriGrpbx.Controls.Add(this.dataGridFatura);
            this.faturaBilgileriGrpbx.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.faturaBilgileriGrpbx.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.faturaBilgileriGrpbx.Location = new System.Drawing.Point(21, 18);
            this.faturaBilgileriGrpbx.Name = "faturaBilgileriGrpbx";
            this.faturaBilgileriGrpbx.Size = new System.Drawing.Size(781, 429);
            this.faturaBilgileriGrpbx.TabIndex = 3;
            this.faturaBilgileriGrpbx.TabStop = false;
            this.faturaBilgileriGrpbx.Text = "Fatura Bilgileri";
            // 
            // gorBtn
            // 
            this.gorBtn.Location = new System.Drawing.Point(338, 370);
            this.gorBtn.Name = "gorBtn";
            this.gorBtn.Size = new System.Drawing.Size(99, 29);
            this.gorBtn.TabIndex = 8;
            this.gorBtn.Text = "Görüntüle";
            this.gorBtn.UseVisualStyleBackColor = true;
            this.gorBtn.Click += new System.EventHandler(this.gorBtn_Click);
            // 
            // dataGridFatura
            // 
            this.dataGridFatura.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFatura.Location = new System.Drawing.Point(73, 92);
            this.dataGridFatura.Name = "dataGridFatura";
            this.dataGridFatura.RowHeadersWidth = 51;
            this.dataGridFatura.RowTemplate.Height = 24;
            this.dataGridFatura.Size = new System.Drawing.Size(633, 205);
            this.dataGridFatura.TabIndex = 2;
            this.dataGridFatura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFatura_CellContentClick);
            // 
            // FaturaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.faturaBilgileriGrpbx);
            this.Name = "FaturaBilgileri";
            this.Size = new System.Drawing.Size(823, 465);
            this.faturaBilgileriGrpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox faturaBilgileriGrpbx;
        private System.Windows.Forms.DataGridView dataGridFatura;
        private System.Windows.Forms.Button gorBtn;
    }
}
