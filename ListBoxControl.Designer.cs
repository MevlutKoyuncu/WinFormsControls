namespace WinFormsControls
{
    partial class ListBoxControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxControl));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_sehirliste = new System.Windows.Forms.ListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.tb_eklenecek = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_ekleneceksehir = new System.Windows.Forms.Label();
            this.lb_sehirliste2 = new System.Windows.Forms.ListBox();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birden çok seçenek arasından bir veya birden çok seçeneği seçmemizi sağlayan yapı" +
    "dır.";
            // 
            // lb_sehirliste
            // 
            this.lb_sehirliste.FormattingEnabled = true;
            this.lb_sehirliste.ItemHeight = 16;
            this.lb_sehirliste.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Eskişehir",
            "Bursa",
            "Adana",
            "Trabzon",
            "Bilecik ",
            "Aksaray"});
            this.lb_sehirliste.Location = new System.Drawing.Point(35, 177);
            this.lb_sehirliste.Name = "lb_sehirliste";
            this.lb_sehirliste.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_sehirliste.Size = new System.Drawing.Size(238, 148);
            this.lb_sehirliste.TabIndex = 1;
            // 
            // btn_getir
            // 
            this.btn_getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_getir.Location = new System.Drawing.Point(35, 331);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(238, 28);
            this.btn_getir.TabIndex = 2;
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(32, 380);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(0, 16);
            this.lbl_ekran.TabIndex = 3;
            // 
            // tb_eklenecek
            // 
            this.tb_eklenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_eklenecek.Location = new System.Drawing.Point(35, 132);
            this.tb_eklenecek.Name = "tb_eklenecek";
            this.tb_eklenecek.Size = new System.Drawing.Size(238, 24);
            this.tb_eklenecek.TabIndex = 4;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(279, 127);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(118, 35);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_ekleneceksehir
            // 
            this.lbl_ekleneceksehir.AutoSize = true;
            this.lbl_ekleneceksehir.Location = new System.Drawing.Point(35, 110);
            this.lbl_ekleneceksehir.Name = "lbl_ekleneceksehir";
            this.lbl_ekleneceksehir.Size = new System.Drawing.Size(86, 16);
            this.lbl_ekleneceksehir.TabIndex = 6;
            this.lbl_ekleneceksehir.Text = "Şehir Yazınız.";
            // 
            // lb_sehirliste2
            // 
            this.lb_sehirliste2.FormattingEnabled = true;
            this.lb_sehirliste2.ItemHeight = 16;
            this.lb_sehirliste2.Location = new System.Drawing.Point(363, 177);
            this.lb_sehirliste2.Name = "lb_sehirliste2";
            this.lb_sehirliste2.Size = new System.Drawing.Size(238, 148);
            this.lb_sehirliste2.TabIndex = 7;
            // 
            // btn_aktar
            // 
            this.btn_aktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aktar.Location = new System.Drawing.Point(279, 221);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(75, 51);
            this.btn_aktar.TabIndex = 8;
            this.btn_aktar.Text = ">";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // ListBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.lb_sehirliste2);
            this.Controls.Add(this.lbl_ekleneceksehir);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_eklenecek);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.lb_sehirliste);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListBoxControl";
            this.Text = "ListBoxControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_sehirliste;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.TextBox tb_eklenecek;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_ekleneceksehir;
        private System.Windows.Forms.ListBox lb_sehirliste2;
        private System.Windows.Forms.Button btn_aktar;
    }
}