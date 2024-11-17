namespace WinFormsControls
{
    partial class DateTimeControls
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_uretilen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_dakika = new System.Windows.Forms.NumericUpDown();
            this.nud_saat = new System.Windows.Forms.NumericUpDown();
            this.lbl_uzuntarih = new System.Windows.Forms.Label();
            this.btn_tarihgetir = new System.Windows.Forms.Button();
            this.lbl_kisatarih = new System.Windows.Forms.Label();
            this.dtp_dogum = new System.Windows.Forms.DateTimePicker();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_tarihfark = new System.Windows.Forms.Label();
            this.lbl_aralik = new System.Windows.Forms.Label();
            this.btn_aralikgetir = new System.Windows.Forms.Button();
            this.mc_takvim = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_uretilen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_dakika);
            this.groupBox1.Controls.Add(this.nud_saat);
            this.groupBox1.Controls.Add(this.lbl_uzuntarih);
            this.groupBox1.Controls.Add(this.btn_tarihgetir);
            this.groupBox1.Controls.Add(this.lbl_kisatarih);
            this.groupBox1.Controls.Add(this.dtp_dogum);
            this.groupBox1.Controls.Add(this.lbl_ekran);
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğum Tarihi";
            // 
            // lbl_uretilen
            // 
            this.lbl_uretilen.AutoSize = true;
            this.lbl_uretilen.Location = new System.Drawing.Point(6, 179);
            this.lbl_uretilen.Name = "lbl_uretilen";
            this.lbl_uretilen.Size = new System.Drawing.Size(44, 16);
            this.lbl_uretilen.TabIndex = 7;
            this.lbl_uretilen.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // nud_dakika
            // 
            this.nud_dakika.Location = new System.Drawing.Point(140, 51);
            this.nud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_dakika.Name = "nud_dakika";
            this.nud_dakika.Size = new System.Drawing.Size(65, 22);
            this.nud_dakika.TabIndex = 5;
            // 
            // nud_saat
            // 
            this.nud_saat.Location = new System.Drawing.Point(9, 51);
            this.nud_saat.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nud_saat.Name = "nud_saat";
            this.nud_saat.Size = new System.Drawing.Size(77, 22);
            this.nud_saat.TabIndex = 4;
            // 
            // lbl_uzuntarih
            // 
            this.lbl_uzuntarih.AutoSize = true;
            this.lbl_uzuntarih.Location = new System.Drawing.Point(6, 149);
            this.lbl_uzuntarih.Name = "lbl_uzuntarih";
            this.lbl_uzuntarih.Size = new System.Drawing.Size(80, 16);
            this.lbl_uzuntarih.TabIndex = 3;
            this.lbl_uzuntarih.Text = "lbl_uzuntarih";
            // 
            // btn_tarihgetir
            // 
            this.btn_tarihgetir.Location = new System.Drawing.Point(274, 22);
            this.btn_tarihgetir.Name = "btn_tarihgetir";
            this.btn_tarihgetir.Size = new System.Drawing.Size(75, 23);
            this.btn_tarihgetir.TabIndex = 1;
            this.btn_tarihgetir.Text = "Getir";
            this.btn_tarihgetir.UseVisualStyleBackColor = true;
            this.btn_tarihgetir.Click += new System.EventHandler(this.btn_tarihgetir_Click);
            // 
            // lbl_kisatarih
            // 
            this.lbl_kisatarih.AutoSize = true;
            this.lbl_kisatarih.Location = new System.Drawing.Point(6, 117);
            this.lbl_kisatarih.Name = "lbl_kisatarih";
            this.lbl_kisatarih.Size = new System.Drawing.Size(78, 16);
            this.lbl_kisatarih.TabIndex = 2;
            this.lbl_kisatarih.Text = "lbl_kisatarih";
            // 
            // dtp_dogum
            // 
            this.dtp_dogum.Location = new System.Drawing.Point(7, 22);
            this.dtp_dogum.Name = "dtp_dogum";
            this.dtp_dogum.Size = new System.Drawing.Size(244, 22);
            this.dtp_dogum.TabIndex = 0;
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(6, 86);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(53, 16);
            this.lbl_ekran.TabIndex = 1;
            this.lbl_ekran.Text = "lbl_tarih";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_tarihfark);
            this.groupBox2.Controls.Add(this.lbl_aralik);
            this.groupBox2.Controls.Add(this.btn_aralikgetir);
            this.groupBox2.Controls.Add(this.mc_takvim);
            this.groupBox2.Location = new System.Drawing.Point(436, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralama";
            // 
            // lbl_tarihfark
            // 
            this.lbl_tarihfark.AutoSize = true;
            this.lbl_tarihfark.Location = new System.Drawing.Point(323, 99);
            this.lbl_tarihfark.Name = "lbl_tarihfark";
            this.lbl_tarihfark.Size = new System.Drawing.Size(75, 16);
            this.lbl_tarihfark.TabIndex = 3;
            this.lbl_tarihfark.Text = "lbl_tarihfark";
            // 
            // lbl_aralik
            // 
            this.lbl_aralik.AutoSize = true;
            this.lbl_aralik.Location = new System.Drawing.Point(320, 55);
            this.lbl_aralik.Name = "lbl_aralik";
            this.lbl_aralik.Size = new System.Drawing.Size(61, 16);
            this.lbl_aralik.TabIndex = 2;
            this.lbl_aralik.Text = "lbl_aralik";
            // 
            // btn_aralikgetir
            // 
            this.btn_aralikgetir.Location = new System.Drawing.Point(323, 19);
            this.btn_aralikgetir.Name = "btn_aralikgetir";
            this.btn_aralikgetir.Size = new System.Drawing.Size(112, 23);
            this.btn_aralikgetir.TabIndex = 1;
            this.btn_aralikgetir.Text = "Aralık Getir";
            this.btn_aralikgetir.UseVisualStyleBackColor = true;
            this.btn_aralikgetir.Click += new System.EventHandler(this.btn_aralikgetir_Click);
            // 
            // mc_takvim
            // 
            this.mc_takvim.Location = new System.Drawing.Point(7, 20);
            this.mc_takvim.Name = "mc_takvim";
            this.mc_takvim.TabIndex = 0;
            this.mc_takvim.TitleForeColor = System.Drawing.Color.Turquoise;
            // 
            // DateTimeControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateTimeControls";
            this.Text = "DateTimeControls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_dogum;
        private System.Windows.Forms.Button btn_tarihgetir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.Label lbl_kisatarih;
        private System.Windows.Forms.Label lbl_uzuntarih;
        private System.Windows.Forms.NumericUpDown nud_dakika;
        private System.Windows.Forms.NumericUpDown nud_saat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_uretilen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar mc_takvim;
        private System.Windows.Forms.Button btn_aralikgetir;
        private System.Windows.Forms.Label lbl_aralik;
        private System.Windows.Forms.Label lbl_tarihfark;
    }
}