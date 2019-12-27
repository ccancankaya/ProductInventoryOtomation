namespace Login
{
    partial class SatışYap
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTürün = new DevExpress.XtraEditors.TextEdit();
            this.TXTfirma = new DevExpress.XtraEditors.TextEdit();
            this.TXTfiyat = new DevExpress.XtraEditors.TextEdit();
            this.TXTadet = new DevExpress.XtraEditors.SpinEdit();
            this.BTNsat = new System.Windows.Forms.Button();
            this.BTNiptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TXTürün.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTfirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTadet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // TXTürün
            // 
            this.TXTürün.Location = new System.Drawing.Point(102, 43);
            this.TXTürün.Name = "TXTürün";
            this.TXTürün.Size = new System.Drawing.Size(223, 20);
            this.TXTürün.TabIndex = 4;
            // 
            // TXTfirma
            // 
            this.TXTfirma.Location = new System.Drawing.Point(102, 111);
            this.TXTfirma.Name = "TXTfirma";
            this.TXTfirma.Size = new System.Drawing.Size(223, 20);
            this.TXTfirma.TabIndex = 6;
            // 
            // TXTfiyat
            // 
            this.TXTfiyat.Location = new System.Drawing.Point(102, 145);
            this.TXTfiyat.Name = "TXTfiyat";
            this.TXTfiyat.Properties.Mask.EditMask = "c";
            this.TXTfiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXTfiyat.Size = new System.Drawing.Size(223, 20);
            this.TXTfiyat.TabIndex = 7;
            // 
            // TXTadet
            // 
            this.TXTadet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TXTadet.Location = new System.Drawing.Point(102, 74);
            this.TXTadet.Name = "TXTadet";
            this.TXTadet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TXTadet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TXTadet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TXTadet.Size = new System.Drawing.Size(223, 20);
            this.TXTadet.TabIndex = 8;
            // 
            // BTNsat
            // 
            this.BTNsat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNsat.Location = new System.Drawing.Point(116, 186);
            this.BTNsat.Name = "BTNsat";
            this.BTNsat.Size = new System.Drawing.Size(108, 39);
            this.BTNsat.TabIndex = 9;
            this.BTNsat.Text = "Sat";
            this.BTNsat.UseVisualStyleBackColor = true;
            this.BTNsat.Click += new System.EventHandler(this.BTNsat_Click);
            // 
            // BTNiptal
            // 
            this.BTNiptal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNiptal.Location = new System.Drawing.Point(272, 186);
            this.BTNiptal.Name = "BTNiptal";
            this.BTNiptal.Size = new System.Drawing.Size(105, 39);
            this.BTNiptal.TabIndex = 10;
            this.BTNiptal.Text = "İptal";
            this.BTNiptal.UseVisualStyleBackColor = true;
            this.BTNiptal.Click += new System.EventHandler(this.BTNiptal_Click);
            // 
            // SatışYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 268);
            this.Controls.Add(this.BTNiptal);
            this.Controls.Add(this.BTNsat);
            this.Controls.Add(this.TXTfiyat);
            this.Controls.Add(this.TXTfirma);
            this.Controls.Add(this.TXTürün);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTadet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SatışYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatışYap";
            ((System.ComponentModel.ISupportInitialize)(this.TXTürün.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTfirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTadet.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit TXTürün;
        private DevExpress.XtraEditors.TextEdit TXTfirma;
        private DevExpress.XtraEditors.TextEdit TXTfiyat;
        private DevExpress.XtraEditors.SpinEdit TXTadet;
        private System.Windows.Forms.Button BTNsat;
        private System.Windows.Forms.Button BTNiptal;
    }
}