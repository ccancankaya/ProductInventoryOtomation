namespace Login
{
    partial class Ürünler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTkod = new DevExpress.XtraEditors.TextEdit();
            this.TXTad = new DevExpress.XtraEditors.TextEdit();
            this.TXTmrk = new DevExpress.XtraEditors.TextEdit();
            this.TXTmdl = new DevExpress.XtraEditors.TextEdit();
            this.TXTbirim = new DevExpress.XtraEditors.TextEdit();
            this.TXTsatis = new DevExpress.XtraEditors.TextEdit();
            this.BTNsil = new DevExpress.XtraEditors.SimpleButton();
            this.BTNekle = new DevExpress.XtraEditors.SimpleButton();
            this.BTNguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.TXTadt = new DevExpress.XtraEditors.SpinEdit();
            this.BTNana = new DevExpress.XtraEditors.SimpleButton();
            this.ComboKategori = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTmrk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTmdl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTbirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTsatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTadt.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 567);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(279, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(279, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(530, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(530, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(780, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birim Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(783, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Satış Fiyatı:";
            // 
            // TXTkod
            // 
            this.TXTkod.Location = new System.Drawing.Point(100, 26);
            this.TXTkod.Name = "TXTkod";
            this.TXTkod.Size = new System.Drawing.Size(133, 20);
            this.TXTkod.TabIndex = 9;
            // 
            // TXTad
            // 
            this.TXTad.Location = new System.Drawing.Point(100, 112);
            this.TXTad.Name = "TXTad";
            this.TXTad.Size = new System.Drawing.Size(133, 20);
            this.TXTad.TabIndex = 10;
            // 
            // TXTmrk
            // 
            this.TXTmrk.Location = new System.Drawing.Point(336, 26);
            this.TXTmrk.Name = "TXTmrk";
            this.TXTmrk.Size = new System.Drawing.Size(154, 20);
            this.TXTmrk.TabIndex = 11;
            // 
            // TXTmdl
            // 
            this.TXTmdl.Location = new System.Drawing.Point(336, 112);
            this.TXTmdl.Name = "TXTmdl";
            this.TXTmdl.Size = new System.Drawing.Size(154, 20);
            this.TXTmdl.TabIndex = 12;
            // 
            // TXTbirim
            // 
            this.TXTbirim.Location = new System.Drawing.Point(871, 25);
            this.TXTbirim.Name = "TXTbirim";
            this.TXTbirim.Properties.Mask.EditMask = "c";
            this.TXTbirim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXTbirim.Size = new System.Drawing.Size(115, 20);
            this.TXTbirim.TabIndex = 15;
            // 
            // TXTsatis
            // 
            this.TXTsatis.Location = new System.Drawing.Point(871, 108);
            this.TXTsatis.Name = "TXTsatis";
            this.TXTsatis.Properties.Mask.EditMask = "c";
            this.TXTsatis.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXTsatis.Size = new System.Drawing.Size(115, 20);
            this.TXTsatis.TabIndex = 16;
            // 
            // BTNsil
            // 
            this.BTNsil.Location = new System.Drawing.Point(1079, 17);
            this.BTNsil.Name = "BTNsil";
            this.BTNsil.Size = new System.Drawing.Size(110, 25);
            this.BTNsil.TabIndex = 17;
            this.BTNsil.Text = "Sil";
            this.BTNsil.Click += new System.EventHandler(this.BTNsil_Click);
            // 
            // BTNekle
            // 
            this.BTNekle.Location = new System.Drawing.Point(1079, 59);
            this.BTNekle.Name = "BTNekle";
            this.BTNekle.Size = new System.Drawing.Size(110, 26);
            this.BTNekle.TabIndex = 18;
            this.BTNekle.Text = "Ekle";
            this.BTNekle.Click += new System.EventHandler(this.BTNekle_Click);
            // 
            // BTNguncelle
            // 
            this.BTNguncelle.Location = new System.Drawing.Point(1079, 99);
            this.BTNguncelle.Name = "BTNguncelle";
            this.BTNguncelle.Size = new System.Drawing.Size(110, 29);
            this.BTNguncelle.TabIndex = 19;
            this.BTNguncelle.Text = "Güncelle";
            this.BTNguncelle.Click += new System.EventHandler(this.BTNguncelle_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(632, 50);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "Kategori Ekle";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // TXTadt
            // 
            this.TXTadt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TXTadt.Location = new System.Drawing.Point(577, 112);
            this.TXTadt.Name = "TXTadt";
            this.TXTadt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TXTadt.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.TXTadt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TXTadt.Size = new System.Drawing.Size(173, 20);
            this.TXTadt.TabIndex = 22;
            // 
            // BTNana
            // 
            this.BTNana.Location = new System.Drawing.Point(1079, 151);
            this.BTNana.Name = "BTNana";
            this.BTNana.Size = new System.Drawing.Size(110, 26);
            this.BTNana.TabIndex = 23;
            this.BTNana.Text = "Ana Sayfa";
            this.BTNana.Click += new System.EventHandler(this.BTNana_Click);
            // 
            // ComboKategori
            // 
            this.ComboKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboKategori.FormattingEnabled = true;
            this.ComboKategori.Location = new System.Drawing.Point(602, 24);
            this.ComboKategori.Name = "ComboKategori";
            this.ComboKategori.Size = new System.Drawing.Size(138, 21);
            this.ComboKategori.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TXTbirim);
            this.panel1.Controls.Add(this.ComboKategori);
            this.panel1.Controls.Add(this.TXTadt);
            this.panel1.Controls.Add(this.BTNana);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BTNguncelle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BTNekle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BTNsil);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TXTsatis);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TXTmdl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TXTmrk);
            this.panel1.Controls.Add(this.TXTkod);
            this.panel1.Controls.Add(this.TXTad);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 190);
            this.panel1.TabIndex = 25;
            // 
            // Ürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 763);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ürünler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Ürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTmrk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTmdl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTbirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTsatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTadt.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit TXTkod;
        private DevExpress.XtraEditors.TextEdit TXTad;
        private DevExpress.XtraEditors.TextEdit TXTmrk;
        private DevExpress.XtraEditors.TextEdit TXTmdl;
        private DevExpress.XtraEditors.TextEdit TXTbirim;
        private DevExpress.XtraEditors.TextEdit TXTsatis;
        private DevExpress.XtraEditors.SimpleButton BTNsil;
        private DevExpress.XtraEditors.SimpleButton BTNekle;
        private DevExpress.XtraEditors.SimpleButton BTNguncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SpinEdit TXTadt;
        private DevExpress.XtraEditors.SimpleButton BTNana;
        private System.Windows.Forms.ComboBox ComboKategori;
        private System.Windows.Forms.Panel panel1;
    }
}