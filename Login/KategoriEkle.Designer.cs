namespace Login
{
    partial class KategoriEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTkategori = new DevExpress.XtraEditors.TextEdit();
            this.BTNekle = new DevExpress.XtraEditors.SimpleButton();
            this.BTNcik = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TXTkategori.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // TXTkategori
            // 
            this.TXTkategori.Location = new System.Drawing.Point(113, 33);
            this.TXTkategori.Name = "TXTkategori";
            this.TXTkategori.Size = new System.Drawing.Size(201, 20);
            this.TXTkategori.TabIndex = 1;
            // 
            // BTNekle
            // 
            this.BTNekle.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNekle.Appearance.Options.UseFont = true;
            this.BTNekle.Location = new System.Drawing.Point(73, 83);
            this.BTNekle.Name = "BTNekle";
            this.BTNekle.Size = new System.Drawing.Size(86, 34);
            this.BTNekle.TabIndex = 2;
            this.BTNekle.Text = "Ekle";
            this.BTNekle.Click += new System.EventHandler(this.BTNekle_Click);
            // 
            // BTNcik
            // 
            this.BTNcik.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNcik.Appearance.Options.UseFont = true;
            this.BTNcik.Location = new System.Drawing.Point(203, 83);
            this.BTNcik.Name = "BTNcik";
            this.BTNcik.Size = new System.Drawing.Size(89, 34);
            this.BTNcik.TabIndex = 3;
            this.BTNcik.Text = "Çık";
            this.BTNcik.Click += new System.EventHandler(this.BTNcik_Click);
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 156);
            this.Controls.Add(this.BTNcik);
            this.Controls.Add(this.BTNekle);
            this.Controls.Add(this.TXTkategori);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriEkle";
            ((System.ComponentModel.ISupportInitialize)(this.TXTkategori.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TXTkategori;
        private DevExpress.XtraEditors.SimpleButton BTNekle;
        private DevExpress.XtraEditors.SimpleButton BTNcik;
    }
}