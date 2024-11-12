﻿namespace WinFormsControls
{
    partial class CheckBoxRadioButtonControls
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
            this.cb_secim = new System.Windows.Forms.CheckBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.cb_ingilizce = new System.Windows.Forms.CheckBox();
            this.cb_almanca = new System.Windows.Forms.CheckBox();
            this.cb_lehce = new System.Windows.Forms.CheckBox();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.gb_cinsiyet = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran2 = new System.Windows.Forms.Label();
            this.lbl_ekran3 = new System.Windows.Forms.Label();
            this.gb_cinsiyet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_secim
            // 
            this.cb_secim.AutoSize = true;
            this.cb_secim.Location = new System.Drawing.Point(35, 42);
            this.cb_secim.Name = "cb_secim";
            this.cb_secim.Size = new System.Drawing.Size(197, 20);
            this.cb_secim.TabIndex = 0;
            this.cb_secim.Text = "Sözleşmeyi kabul ediyorum.";
            this.cb_secim.UseVisualStyleBackColor = true;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(35, 69);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder.TabIndex = 1;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(35, 108);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(0, 16);
            this.lbl_ekran.TabIndex = 2;
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(17, 34);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(50, 20);
            this.rb_evli.TabIndex = 3;
            this.rb_evli.TabStop = true;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Location = new System.Drawing.Point(116, 35);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(64, 20);
            this.rb_bekar.TabIndex = 4;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            // 
            // cb_ingilizce
            // 
            this.cb_ingilizce.AutoSize = true;
            this.cb_ingilizce.Location = new System.Drawing.Point(6, 21);
            this.cb_ingilizce.Name = "cb_ingilizce";
            this.cb_ingilizce.Size = new System.Drawing.Size(77, 20);
            this.cb_ingilizce.TabIndex = 5;
            this.cb_ingilizce.Text = "İngilizce";
            this.cb_ingilizce.UseVisualStyleBackColor = true;
            // 
            // cb_almanca
            // 
            this.cb_almanca.AutoSize = true;
            this.cb_almanca.Location = new System.Drawing.Point(6, 57);
            this.cb_almanca.Name = "cb_almanca";
            this.cb_almanca.Size = new System.Drawing.Size(82, 20);
            this.cb_almanca.TabIndex = 5;
            this.cb_almanca.Text = "Almanca";
            this.cb_almanca.UseVisualStyleBackColor = true;
            // 
            // cb_lehce
            // 
            this.cb_lehce.AutoSize = true;
            this.cb_lehce.Location = new System.Drawing.Point(6, 93);
            this.cb_lehce.Name = "cb_lehce";
            this.cb_lehce.Size = new System.Drawing.Size(66, 20);
            this.cb_lehce.TabIndex = 5;
            this.cb_lehce.Text = "Lehçe";
            this.cb_lehce.UseVisualStyleBackColor = true;
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(17, 30);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(63, 20);
            this.rb_erkek.TabIndex = 3;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.Location = new System.Drawing.Point(116, 30);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(62, 20);
            this.rb_kadin.TabIndex = 4;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın";
            this.rb_kadin.UseVisualStyleBackColor = true;
            // 
            // gb_cinsiyet
            // 
            this.gb_cinsiyet.Controls.Add(this.rb_erkek);
            this.gb_cinsiyet.Controls.Add(this.rb_kadin);
            this.gb_cinsiyet.Location = new System.Drawing.Point(277, 42);
            this.gb_cinsiyet.Name = "gb_cinsiyet";
            this.gb_cinsiyet.Size = new System.Drawing.Size(216, 82);
            this.gb_cinsiyet.TabIndex = 6;
            this.gb_cinsiyet.TabStop = false;
            this.gb_cinsiyet.Text = "Cinsiyet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_evli);
            this.groupBox1.Controls.Add(this.rb_bekar);
            this.groupBox1.Location = new System.Drawing.Point(277, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medeni Durum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_ingilizce);
            this.groupBox2.Controls.Add(this.cb_almanca);
            this.groupBox2.Controls.Add(this.cb_lehce);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(35, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diller";
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(514, 42);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(101, 37);
            this.btn_getir.TabIndex = 9;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran2
            // 
            this.lbl_ekran2.AutoSize = true;
            this.lbl_ekran2.Location = new System.Drawing.Point(511, 108);
            this.lbl_ekran2.Name = "lbl_ekran2";
            this.lbl_ekran2.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran2.TabIndex = 10;
            this.lbl_ekran2.Text = "label1";
            // 
            // lbl_ekran3
            // 
            this.lbl_ekran3.AutoSize = true;
            this.lbl_ekran3.Location = new System.Drawing.Point(511, 165);
            this.lbl_ekran3.Name = "lbl_ekran3";
            this.lbl_ekran3.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran3.TabIndex = 11;
            this.lbl_ekran3.Text = "label1";
            // 
            // CheckBoxRadioButtonControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ekran3);
            this.Controls.Add(this.lbl_ekran2);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_cinsiyet);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.cb_secim);
            this.Name = "CheckBoxRadioButtonControls";
            this.Text = "CheckBoxRadioButtonControls";
            this.gb_cinsiyet.ResumeLayout(false);
            this.gb_cinsiyet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_secim;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.CheckBox cb_ingilizce;
        private System.Windows.Forms.CheckBox cb_almanca;
        private System.Windows.Forms.CheckBox cb_lehce;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.RadioButton rb_kadin;
        private System.Windows.Forms.GroupBox gb_cinsiyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran2;
        private System.Windows.Forms.Label lbl_ekran3;
    }
}