namespace Login
{
    partial class KullanıcıEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXTkullnıcı = new DevExpress.XtraEditors.TextEdit();
            this.TXTsifre = new DevExpress.XtraEditors.TextEdit();
            this.BTNekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TXTkullnıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // TXTkullnıcı
            // 
            this.TXTkullnıcı.Location = new System.Drawing.Point(28, 55);
            this.TXTkullnıcı.Name = "TXTkullnıcı";
            this.TXTkullnıcı.Size = new System.Drawing.Size(238, 20);
            this.TXTkullnıcı.TabIndex = 2;
            // 
            // TXTsifre
            // 
            this.TXTsifre.Location = new System.Drawing.Point(28, 136);
            this.TXTsifre.Name = "TXTsifre";
            this.TXTsifre.Size = new System.Drawing.Size(238, 20);
            this.TXTsifre.TabIndex = 3;
            // 
            // BTNekle
            // 
            this.BTNekle.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNekle.Appearance.Options.UseFont = true;
            this.BTNekle.Location = new System.Drawing.Point(96, 187);
            this.BTNekle.Name = "BTNekle";
            this.BTNekle.Size = new System.Drawing.Size(103, 24);
            this.BTNekle.TabIndex = 4;
            this.BTNekle.Text = "Ekle";
            this.BTNekle.Click += new System.EventHandler(this.BTNekle_Click);
            // 
            // KullanıcıEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 258);
            this.Controls.Add(this.BTNekle);
            this.Controls.Add(this.TXTsifre);
            this.Controls.Add(this.TXTkullnıcı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullanıcıEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıEkle";
            ((System.ComponentModel.ISupportInitialize)(this.TXTkullnıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TXTkullnıcı;
        private DevExpress.XtraEditors.TextEdit TXTsifre;
        private DevExpress.XtraEditors.SimpleButton BTNekle;
    }
}