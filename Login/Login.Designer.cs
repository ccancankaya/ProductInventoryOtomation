namespace Login
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNgiris = new System.Windows.Forms.Button();
            this.BTNcikis = new System.Windows.Forms.Button();
            this.TXTpass = new System.Windows.Forms.TextBox();
            this.TXTuser = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 98);
            this.panel1.TabIndex = 0;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(174, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.BTNgiris);
            this.panel2.Controls.Add(this.BTNcikis);
            this.panel2.Controls.Add(this.TXTpass);
            this.panel2.Controls.Add(this.TXTuser);
            this.panel2.Location = new System.Drawing.Point(-2, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 268);
            this.panel2.TabIndex = 1;
            // 
            // BTNgiris
            // 
            this.BTNgiris.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNgiris.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNgiris.Location = new System.Drawing.Point(261, 175);
            this.BTNgiris.Name = "BTNgiris";
            this.BTNgiris.Size = new System.Drawing.Size(105, 42);
            this.BTNgiris.TabIndex = 3;
            this.BTNgiris.Text = "Giriş";
            this.BTNgiris.UseVisualStyleBackColor = true;
            this.BTNgiris.Click += new System.EventHandler(this.BTNgiris_Click);
            // 
            // BTNcikis
            // 
            this.BTNcikis.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNcikis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNcikis.Location = new System.Drawing.Point(95, 175);
            this.BTNcikis.Name = "BTNcikis";
            this.BTNcikis.Size = new System.Drawing.Size(113, 42);
            this.BTNcikis.TabIndex = 2;
            this.BTNcikis.Text = "Çıkış";
            this.BTNcikis.UseVisualStyleBackColor = true;
            this.BTNcikis.Click += new System.EventHandler(this.BTNcikis_Click);
            // 
            // TXTpass
            // 
            this.TXTpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTpass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TXTpass.Location = new System.Drawing.Point(0, 98);
            this.TXTpass.Name = "TXTpass";
            this.TXTpass.Size = new System.Drawing.Size(486, 29);
            this.TXTpass.TabIndex = 1;
            this.TXTpass.Text = "Şifre";
            this.TXTpass.UseSystemPasswordChar = true;
            this.TXTpass.Click += new System.EventHandler(this.TXTpass_Click);
            // 
            // TXTuser
            // 
            this.TXTuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTuser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TXTuser.Location = new System.Drawing.Point(0, 30);
            this.TXTuser.Name = "TXTuser";
            this.TXTuser.Size = new System.Drawing.Size(486, 29);
            this.TXTuser.TabIndex = 0;
            this.TXTuser.Text = "Kullanıcı adı";
            this.TXTuser.Click += new System.EventHandler(this.TXTuser_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(2, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 96);
            this.panel3.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXTpass;
        private System.Windows.Forms.TextBox TXTuser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTNgiris;
        private System.Windows.Forms.Button BTNcikis;
    }
}

