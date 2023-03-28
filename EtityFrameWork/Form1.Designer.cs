namespace EtityFrameWork
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgv_Urunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tedarikciler = new System.Windows.Forms.ComboBox();
            this.textBox_urunadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_ekle = new System.Windows.Forms.Button();
            this.but_guncelle = new System.Windows.Forms.Button();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.text_ara = new System.Windows.Forms.TextBox();
            this.radioBut_artan = new System.Windows.Forms.RadioButton();
            this.radioBut_azalan = new System.Windows.Forms.RadioButton();
            this.radioBut_varsayılan = new System.Windows.Forms.RadioButton();
            this.but_ilk10 = new System.Windows.Forms.Button();
            this.but_son10 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_rapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Urunler
            // 
            this.dgv_Urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Urunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Urunler.Location = new System.Drawing.Point(13, 80);
            this.dgv_Urunler.Name = "dgv_Urunler";
            this.dgv_Urunler.RowHeadersWidth = 51;
            this.dgv_Urunler.RowTemplate.Height = 24;
            this.dgv_Urunler.Size = new System.Drawing.Size(1224, 377);
            this.dgv_Urunler.TabIndex = 0;
            this.dgv_Urunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Urunler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoriler";
            // 
            // cmb_kategoriler
            // 
            this.cmb_kategoriler.FormattingEnabled = true;
            this.cmb_kategoriler.Location = new System.Drawing.Point(556, 28);
            this.cmb_kategoriler.Name = "cmb_kategoriler";
            this.cmb_kategoriler.Size = new System.Drawing.Size(182, 24);
            this.cmb_kategoriler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçiler";
            // 
            // cmb_tedarikciler
            // 
            this.cmb_tedarikciler.FormattingEnabled = true;
            this.cmb_tedarikciler.Location = new System.Drawing.Point(759, 30);
            this.cmb_tedarikciler.Name = "cmb_tedarikciler";
            this.cmb_tedarikciler.Size = new System.Drawing.Size(184, 24);
            this.cmb_tedarikciler.TabIndex = 2;
            // 
            // textBox_urunadi
            // 
            this.textBox_urunadi.Location = new System.Drawing.Point(77, 30);
            this.textBox_urunadi.Name = "textBox_urunadi";
            this.textBox_urunadi.Size = new System.Drawing.Size(141, 22);
            this.textBox_urunadi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adı";
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(425, 32);
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(83, 22);
            this.nud_stok.TabIndex = 5;
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.Location = new System.Drawing.Point(249, 30);
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(98, 22);
            this.nud_fiyat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok";
            // 
            // but_ekle
            // 
            this.but_ekle.Location = new System.Drawing.Point(971, 12);
            this.but_ekle.Name = "but_ekle";
            this.but_ekle.Size = new System.Drawing.Size(75, 44);
            this.but_ekle.TabIndex = 9;
            this.but_ekle.Text = "EKLE";
            this.but_ekle.UseVisualStyleBackColor = true;
            this.but_ekle.Click += new System.EventHandler(this.but_ekle_Click);
            // 
            // but_guncelle
            // 
            this.but_guncelle.Location = new System.Drawing.Point(1052, 12);
            this.but_guncelle.Name = "but_guncelle";
            this.but_guncelle.Size = new System.Drawing.Size(96, 44);
            this.but_guncelle.TabIndex = 10;
            this.but_guncelle.Text = "GÜNCELLE";
            this.but_guncelle.UseVisualStyleBackColor = true;
            this.but_guncelle.Click += new System.EventHandler(this.but_guncelle_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(16, 483);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(130, 16);
            this.lbl_ad.TabIndex = 11;
            this.lbl_ad.Text = "Ürün Adına Göre Ara";
            // 
            // text_ara
            // 
            this.text_ara.Location = new System.Drawing.Point(150, 483);
            this.text_ara.Name = "text_ara";
            this.text_ara.Size = new System.Drawing.Size(197, 22);
            this.text_ara.TabIndex = 12;
            this.text_ara.TextChanged += new System.EventHandler(this.text_ara_TextChanged);
            // 
            // radioBut_artan
            // 
            this.radioBut_artan.AutoSize = true;
            this.radioBut_artan.Location = new System.Drawing.Point(712, 485);
            this.radioBut_artan.Name = "radioBut_artan";
            this.radioBut_artan.Size = new System.Drawing.Size(132, 20);
            this.radioBut_artan.TabIndex = 13;
            this.radioBut_artan.TabStop = true;
            this.radioBut_artan.Text = "Fiyata Göre Artan";
            this.radioBut_artan.UseVisualStyleBackColor = true;
            this.radioBut_artan.CheckedChanged += new System.EventHandler(this.radioBut_artan_CheckedChanged);
            // 
            // radioBut_azalan
            // 
            this.radioBut_azalan.AutoSize = true;
            this.radioBut_azalan.Location = new System.Drawing.Point(531, 485);
            this.radioBut_azalan.Name = "radioBut_azalan";
            this.radioBut_azalan.Size = new System.Drawing.Size(142, 20);
            this.radioBut_azalan.TabIndex = 14;
            this.radioBut_azalan.TabStop = true;
            this.radioBut_azalan.Text = "Fiyata Göre Azalan";
            this.radioBut_azalan.UseVisualStyleBackColor = true;
            this.radioBut_azalan.CheckedChanged += new System.EventHandler(this.radioBut_azalan_CheckedChanged);
            // 
            // radioBut_varsayılan
            // 
            this.radioBut_varsayılan.AutoSize = true;
            this.radioBut_varsayılan.Location = new System.Drawing.Point(398, 485);
            this.radioBut_varsayılan.Name = "radioBut_varsayılan";
            this.radioBut_varsayılan.Size = new System.Drawing.Size(92, 20);
            this.radioBut_varsayılan.TabIndex = 15;
            this.radioBut_varsayılan.TabStop = true;
            this.radioBut_varsayılan.Text = "Varsayılan";
            this.radioBut_varsayılan.UseVisualStyleBackColor = true;
            this.radioBut_varsayılan.CheckedChanged += new System.EventHandler(this.radioBut_varsayılan_CheckedChanged);
            // 
            // but_ilk10
            // 
            this.but_ilk10.Location = new System.Drawing.Point(850, 475);
            this.but_ilk10.Name = "but_ilk10";
            this.but_ilk10.Size = new System.Drawing.Size(121, 53);
            this.but_ilk10.TabIndex = 16;
            this.but_ilk10.Text = "İlk 10 Kayıt";
            this.but_ilk10.UseVisualStyleBackColor = true;
            this.but_ilk10.Click += new System.EventHandler(this.but_ilk10_Click);
            // 
            // but_son10
            // 
            this.but_son10.Location = new System.Drawing.Point(993, 475);
            this.but_son10.Name = "but_son10";
            this.but_son10.Size = new System.Drawing.Size(128, 49);
            this.but_son10.TabIndex = 17;
            this.but_son10.Text = "Son 10 Kayıt";
            this.but_son10.UseVisualStyleBackColor = true;
            this.but_son10.Click += new System.EventHandler(this.but_son10_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 28);
            // 
            // sİLToolStripMenuItem
            // 
            this.sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            this.sİLToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.sİLToolStripMenuItem.Text = "SİL";
            this.sİLToolStripMenuItem.Click += new System.EventHandler(this.sİLToolStripMenuItem_Click);
            // 
            // but_rapor
            // 
            this.but_rapor.Location = new System.Drawing.Point(1154, 12);
            this.but_rapor.Name = "but_rapor";
            this.but_rapor.Size = new System.Drawing.Size(75, 44);
            this.but_rapor.TabIndex = 19;
            this.but_rapor.Text = "RAPORLAR";
            this.but_rapor.UseVisualStyleBackColor = true;
            this.but_rapor.Click += new System.EventHandler(this.but_rapor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 540);
            this.Controls.Add(this.but_rapor);
            this.Controls.Add(this.but_son10);
            this.Controls.Add(this.but_ilk10);
            this.Controls.Add(this.radioBut_varsayılan);
            this.Controls.Add(this.radioBut_azalan);
            this.Controls.Add(this.radioBut_artan);
            this.Controls.Add(this.text_ara);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.but_guncelle);
            this.Controls.Add(this.but_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_fiyat);
            this.Controls.Add(this.nud_stok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_urunadi);
            this.Controls.Add(this.cmb_tedarikciler);
            this.Controls.Add(this.cmb_kategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Urunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_kategoriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tedarikciler;
        private System.Windows.Forms.TextBox textBox_urunadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_ekle;
        private System.Windows.Forms.Button but_guncelle;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox text_ara;
        private System.Windows.Forms.RadioButton radioBut_artan;
        private System.Windows.Forms.RadioButton radioBut_azalan;
        private System.Windows.Forms.RadioButton radioBut_varsayılan;
        private System.Windows.Forms.Button but_ilk10;
        private System.Windows.Forms.Button but_son10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİLToolStripMenuItem;
        private System.Windows.Forms.Button but_rapor;
    }
}

