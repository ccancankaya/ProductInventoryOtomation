namespace Login
{
    partial class Müşteriler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNana = new DevExpress.XtraEditors.SimpleButton();
            this.TXTfirma = new DevExpress.XtraEditors.TextEdit();
            this.BTNbul = new DevExpress.XtraEditors.SimpleButton();
            this.BTNsil = new DevExpress.XtraEditors.SimpleButton();
            this.BTNekle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTfirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BTNana);
            this.panel1.Controls.Add(this.TXTfirma);
            this.panel1.Controls.Add(this.BTNbul);
            this.panel1.Controls.Add(this.BTNsil);
            this.panel1.Controls.Add(this.BTNekle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 609);
            this.panel1.TabIndex = 0;
            // 
            // BTNana
            // 
            this.BTNana.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNana.Appearance.Options.UseFont = true;
            this.BTNana.Location = new System.Drawing.Point(93, 457);
            this.BTNana.Name = "BTNana";
            this.BTNana.Size = new System.Drawing.Size(192, 83);
            this.BTNana.TabIndex = 5;
            this.BTNana.Text = "Ana Sayfa";
            this.BTNana.Click += new System.EventHandler(this.BTNana_Click);
            // 
            // TXTfirma
            // 
            this.TXTfirma.Location = new System.Drawing.Point(115, 73);
            this.TXTfirma.Name = "TXTfirma";
            this.TXTfirma.Size = new System.Drawing.Size(248, 20);
            this.TXTfirma.TabIndex = 4;
            // 
            // BTNbul
            // 
            this.BTNbul.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNbul.Appearance.Options.UseFont = true;
            this.BTNbul.Location = new System.Drawing.Point(93, 237);
            this.BTNbul.Name = "BTNbul";
            this.BTNbul.Size = new System.Drawing.Size(192, 81);
            this.BTNbul.TabIndex = 3;
            this.BTNbul.Text = "Firma Bul";
            this.BTNbul.Click += new System.EventHandler(this.BTNbul_Click);
            // 
            // BTNsil
            // 
            this.BTNsil.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNsil.Appearance.Options.UseFont = true;
            this.BTNsil.Location = new System.Drawing.Point(93, 344);
            this.BTNsil.Name = "BTNsil";
            this.BTNsil.Size = new System.Drawing.Size(192, 83);
            this.BTNsil.TabIndex = 2;
            this.BTNsil.Text = "Firma Sil";
            this.BTNsil.Click += new System.EventHandler(this.BTNsil_Click);
            // 
            // BTNekle
            // 
            this.BTNekle.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNekle.Appearance.Options.UseFont = true;
            this.BTNekle.Location = new System.Drawing.Point(93, 129);
            this.BTNekle.Name = "BTNekle";
            this.BTNekle.Size = new System.Drawing.Size(192, 79);
            this.BTNekle.TabIndex = 1;
            this.BTNekle.Text = "Firma Ekle";
            this.BTNekle.Click += new System.EventHandler(this.BTNekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 609);
            this.dataGridView1.TabIndex = 1;
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Müşteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTfirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BTNekle;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TXTfirma;
        private DevExpress.XtraEditors.SimpleButton BTNbul;
        private DevExpress.XtraEditors.SimpleButton BTNsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton BTNana;
    }
}