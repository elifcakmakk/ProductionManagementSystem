namespace ProductionManagementSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunGiris = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunAdi = new System.Windows.Forms.TextBox();
            this.makineAdiTxt = new System.Windows.Forms.Label();
            this.makineAdi = new System.Windows.Forms.TextBox();
            this.personelAditxt = new System.Windows.Forms.Label();
            this.personelAdi = new System.Windows.Forms.TextBox();
            this.urunEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.urunGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(415, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // urunGiris
            // 
            this.urunGiris.Controls.Add(this.urunEkle);
            this.urunGiris.Controls.Add(this.personelAdi);
            this.urunGiris.Controls.Add(this.personelAditxt);
            this.urunGiris.Controls.Add(this.makineAdi);
            this.urunGiris.Controls.Add(this.makineAdiTxt);
            this.urunGiris.Controls.Add(this.urunAdi);
            this.urunGiris.Controls.Add(this.label1);
            this.urunGiris.Location = new System.Drawing.Point(461, 24);
            this.urunGiris.Name = "urunGiris";
            this.urunGiris.Size = new System.Drawing.Size(327, 384);
            this.urunGiris.TabIndex = 1;
            this.urunGiris.TabStop = false;
            this.urunGiris.Text = "ÜRÜN GİRİŞİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // urunAdi
            // 
            this.urunAdi.Location = new System.Drawing.Point(92, 34);
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Size = new System.Drawing.Size(218, 22);
            this.urunAdi.TabIndex = 1;
            // 
            // makineAdiTxt
            // 
            this.makineAdiTxt.AutoSize = true;
            this.makineAdiTxt.Location = new System.Drawing.Point(-3, 80);
            this.makineAdiTxt.Name = "makineAdiTxt";
            this.makineAdiTxt.Size = new System.Drawing.Size(77, 17);
            this.makineAdiTxt.TabIndex = 2;
            this.makineAdiTxt.Text = "Makine Adı";
            // 
            // makineAdi
            // 
            this.makineAdi.Location = new System.Drawing.Point(92, 75);
            this.makineAdi.Name = "makineAdi";
            this.makineAdi.Size = new System.Drawing.Size(218, 22);
            this.makineAdi.TabIndex = 3;
            // 
            // personelAditxt
            // 
            this.personelAditxt.AutoSize = true;
            this.personelAditxt.Location = new System.Drawing.Point(-3, 119);
            this.personelAditxt.Name = "personelAditxt";
            this.personelAditxt.Size = new System.Drawing.Size(88, 17);
            this.personelAditxt.TabIndex = 4;
            this.personelAditxt.Text = "Personel Adı";
            // 
            // personelAdi
            // 
            this.personelAdi.Location = new System.Drawing.Point(92, 116);
            this.personelAdi.Name = "personelAdi";
            this.personelAdi.Size = new System.Drawing.Size(218, 22);
            this.personelAdi.TabIndex = 5;
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(235, 179);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(75, 23);
            this.urunEkle.TabIndex = 6;
            this.urunEkle.Text = "EKLE";
            this.urunEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.urunGiris);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.urunGiris.ResumeLayout(false);
            this.urunGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox urunGiris;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.TextBox personelAdi;
        private System.Windows.Forms.Label personelAditxt;
        private System.Windows.Forms.TextBox makineAdi;
        private System.Windows.Forms.Label makineAdiTxt;
        private System.Windows.Forms.TextBox urunAdi;
        private System.Windows.Forms.Label label1;
    }
}

