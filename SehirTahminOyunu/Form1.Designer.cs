
namespace SehirTahminOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_SoruAlani = new System.Windows.Forms.GroupBox();
            this.gb_CevapAlani = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_HarfGir = new System.Windows.Forms.Button();
            this.bt_TahminEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_GirilenHarfler = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_YeniOyunBaslat = new System.Windows.Forms.Button();
            this.gb_CevapAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SoruAlani
            // 
            this.gb_SoruAlani.Location = new System.Drawing.Point(51, 84);
            this.gb_SoruAlani.Name = "gb_SoruAlani";
            this.gb_SoruAlani.Size = new System.Drawing.Size(496, 174);
            this.gb_SoruAlani.TabIndex = 0;
            this.gb_SoruAlani.TabStop = false;
            this.gb_SoruAlani.Text = "Soru Alanı";
            // 
            // gb_CevapAlani
            // 
            this.gb_CevapAlani.Controls.Add(this.label4);
            this.gb_CevapAlani.Controls.Add(this.label3);
            this.gb_CevapAlani.Controls.Add(this.lbl_GirilenHarfler);
            this.gb_CevapAlani.Controls.Add(this.label1);
            this.gb_CevapAlani.Controls.Add(this.bt_TahminEt);
            this.gb_CevapAlani.Controls.Add(this.btn_HarfGir);
            this.gb_CevapAlani.Controls.Add(this.textBox2);
            this.gb_CevapAlani.Controls.Add(this.textBox1);
            this.gb_CevapAlani.Location = new System.Drawing.Point(51, 274);
            this.gb_CevapAlani.Name = "gb_CevapAlani";
            this.gb_CevapAlani.Size = new System.Drawing.Size(496, 162);
            this.gb_CevapAlani.TabIndex = 1;
            this.gb_CevapAlani.TabStop = false;
            this.gb_CevapAlani.Text = "Cevap Alanı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 27);
            this.textBox2.TabIndex = 1;
            // 
            // btn_HarfGir
            // 
            this.btn_HarfGir.Location = new System.Drawing.Point(91, 35);
            this.btn_HarfGir.Name = "btn_HarfGir";
            this.btn_HarfGir.Size = new System.Drawing.Size(94, 29);
            this.btn_HarfGir.TabIndex = 2;
            this.btn_HarfGir.Text = "Harf Gir";
            this.btn_HarfGir.UseVisualStyleBackColor = true;
            // 
            // bt_TahminEt
            // 
            this.bt_TahminEt.Location = new System.Drawing.Point(386, 38);
            this.bt_TahminEt.Name = "bt_TahminEt";
            this.bt_TahminEt.Size = new System.Drawing.Size(94, 29);
            this.bt_TahminEt.TabIndex = 3;
            this.bt_TahminEt.Text = "Tahmin Et";
            this.bt_TahminEt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler: ";
            // 
            // lbl_GirilenHarfler
            // 
            this.lbl_GirilenHarfler.AutoSize = true;
            this.lbl_GirilenHarfler.Location = new System.Drawing.Point(119, 82);
            this.lbl_GirilenHarfler.Name = "lbl_GirilenHarfler";
            this.lbl_GirilenHarfler.Size = new System.Drawing.Size(0, 20);
            this.lbl_GirilenHarfler.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kalan Hak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "4";
            // 
            // btn_YeniOyunBaslat
            // 
            this.btn_YeniOyunBaslat.Location = new System.Drawing.Point(51, 41);
            this.btn_YeniOyunBaslat.Name = "btn_YeniOyunBaslat";
            this.btn_YeniOyunBaslat.Size = new System.Drawing.Size(496, 35);
            this.btn_YeniOyunBaslat.TabIndex = 2;
            this.btn_YeniOyunBaslat.Text = "Yeni Oyun Başlat";
            this.btn_YeniOyunBaslat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 466);
            this.Controls.Add(this.btn_YeniOyunBaslat);
            this.Controls.Add(this.gb_CevapAlani);
            this.Controls.Add(this.gb_SoruAlani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şehir Tahmin Oyunu";
            this.gb_CevapAlani.ResumeLayout(false);
            this.gb_CevapAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SoruAlani;
        private System.Windows.Forms.GroupBox gb_CevapAlani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_GirilenHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_TahminEt;
        private System.Windows.Forms.Button btn_HarfGir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_YeniOyunBaslat;
    }
}

