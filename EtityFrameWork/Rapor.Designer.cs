namespace EtityFrameWork
{
    partial class Rapor
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
            this.dgv_rapor = new System.Windows.Forms.DataGridView();
            this.but_urunsatısraporu = new System.Windows.Forms.Button();
            this.but_2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rapor
            // 
            this.dgv_rapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rapor.Location = new System.Drawing.Point(12, 104);
            this.dgv_rapor.Name = "dgv_rapor";
            this.dgv_rapor.RowHeadersWidth = 51;
            this.dgv_rapor.RowTemplate.Height = 24;
            this.dgv_rapor.Size = new System.Drawing.Size(776, 334);
            this.dgv_rapor.TabIndex = 0;
            // 
            // but_urunsatısraporu
            // 
            this.but_urunsatısraporu.Location = new System.Drawing.Point(12, 12);
            this.but_urunsatısraporu.Name = "but_urunsatısraporu";
            this.but_urunsatısraporu.Size = new System.Drawing.Size(140, 33);
            this.but_urunsatısraporu.TabIndex = 1;
            this.but_urunsatısraporu.Text = "Ürün Satış Raporu";
            this.but_urunsatısraporu.UseVisualStyleBackColor = true;
            this.but_urunsatısraporu.Click += new System.EventHandler(this.but_urunsatısraporu_Click);
            // 
            // but_2
            // 
            this.but_2.Location = new System.Drawing.Point(231, 21);
            this.but_2.Name = "but_2";
            this.but_2.Size = new System.Drawing.Size(199, 23);
            this.but_2.TabIndex = 2;
            this.but_2.Text = "Tedarikçi Kategori Raporu";
            this.but_2.UseVisualStyleBackColor = true;
            this.but_2.Click += new System.EventHandler(this.but_2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Satış Detay Raporu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_2);
            this.Controls.Add(this.but_urunsatısraporu);
            this.Controls.Add(this.dgv_rapor);
            this.Name = "Rapor";
            this.Text = "Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rapor;
        private System.Windows.Forms.Button but_urunsatısraporu;
        private System.Windows.Forms.Button but_2;
        private System.Windows.Forms.Button button1;
    }
}