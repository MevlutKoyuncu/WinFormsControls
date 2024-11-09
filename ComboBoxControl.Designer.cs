namespace WinFormsControls
{
    partial class ComboBoxControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxControl));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.btn_departmanSec = new System.Windows.Forms.Button();
            this.lbl_secilenDepartman = new System.Windows.Forms.Label();
            this.lbl_adsadsads = new System.Windows.Forms.Label();
            this.cb_egitim = new System.Windows.Forms.ComboBox();
            this.lbl_egitim = new System.Windows.Forms.Label();
            this.cb_markalar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_markaSec = new System.Windows.Forms.Button();
            this.lbl_markaSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seçiniz";
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "Satış",
            "Muhasebe",
            "Levazım",
            "İnsan Kaynakları"});
            this.cb_departman.Location = new System.Drawing.Point(55, 52);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(196, 24);
            this.cb_departman.TabIndex = 1;
            this.cb_departman.Text = "Seçiniz...";
            // 
            // btn_departmanSec
            // 
            this.btn_departmanSec.Location = new System.Drawing.Point(267, 52);
            this.btn_departmanSec.Name = "btn_departmanSec";
            this.btn_departmanSec.Size = new System.Drawing.Size(75, 23);
            this.btn_departmanSec.TabIndex = 2;
            this.btn_departmanSec.Text = "Seç";
            this.btn_departmanSec.UseVisualStyleBackColor = true;
            this.btn_departmanSec.Click += new System.EventHandler(this.btn_departmanSec_Click);
            // 
            // lbl_secilenDepartman
            // 
            this.lbl_secilenDepartman.AutoSize = true;
            this.lbl_secilenDepartman.Location = new System.Drawing.Point(361, 52);
            this.lbl_secilenDepartman.Name = "lbl_secilenDepartman";
            this.lbl_secilenDepartman.Size = new System.Drawing.Size(0, 16);
            this.lbl_secilenDepartman.TabIndex = 3;
            // 
            // lbl_adsadsads
            // 
            this.lbl_adsadsads.AutoSize = true;
            this.lbl_adsadsads.Location = new System.Drawing.Point(52, 118);
            this.lbl_adsadsads.Name = "lbl_adsadsads";
            this.lbl_adsadsads.Size = new System.Drawing.Size(117, 16);
            this.lbl_adsadsads.TabIndex = 4;
            this.lbl_adsadsads.Text = "Katılanacak Eğitim";
            // 
            // cb_egitim
            // 
            this.cb_egitim.FormattingEnabled = true;
            this.cb_egitim.Items.AddRange(new object[] {
            "Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı",
            "İleri Sürüş Eğitimi",
            "Domates Yetiştiriciliği"});
            this.cb_egitim.Location = new System.Drawing.Point(55, 147);
            this.cb_egitim.Name = "cb_egitim";
            this.cb_egitim.Size = new System.Drawing.Size(196, 24);
            this.cb_egitim.TabIndex = 5;
            this.cb_egitim.SelectedIndexChanged += new System.EventHandler(this.cb_egitim_SelectedIndexChanged);
            // 
            // lbl_egitim
            // 
            this.lbl_egitim.AutoSize = true;
            this.lbl_egitim.Location = new System.Drawing.Point(267, 147);
            this.lbl_egitim.Name = "lbl_egitim";
            this.lbl_egitim.Size = new System.Drawing.Size(44, 16);
            this.lbl_egitim.TabIndex = 6;
            this.lbl_egitim.Text = "label2";
            // 
            // cb_markalar
            // 
            this.cb_markalar.FormattingEnabled = true;
            this.cb_markalar.Location = new System.Drawing.Point(55, 257);
            this.cb_markalar.Name = "cb_markalar";
            this.cb_markalar.Size = new System.Drawing.Size(196, 24);
            this.cb_markalar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marka Seçiniz...";
            // 
            // btn_markaSec
            // 
            this.btn_markaSec.Location = new System.Drawing.Point(270, 257);
            this.btn_markaSec.Name = "btn_markaSec";
            this.btn_markaSec.Size = new System.Drawing.Size(75, 23);
            this.btn_markaSec.TabIndex = 9;
            this.btn_markaSec.Text = "Sec";
            this.btn_markaSec.UseVisualStyleBackColor = true;
            this.btn_markaSec.Click += new System.EventHandler(this.btn_markaSec_Click);
            // 
            // lbl_markaSec
            // 
            this.lbl_markaSec.AutoSize = true;
            this.lbl_markaSec.Location = new System.Drawing.Point(361, 260);
            this.lbl_markaSec.Name = "lbl_markaSec";
            this.lbl_markaSec.Size = new System.Drawing.Size(31, 16);
            this.lbl_markaSec.TabIndex = 10;
            this.lbl_markaSec.Text = "Seç";
            // 
            // ComboBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_markaSec);
            this.Controls.Add(this.btn_markaSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_markalar);
            this.Controls.Add(this.lbl_egitim);
            this.Controls.Add(this.cb_egitim);
            this.Controls.Add(this.lbl_adsadsads);
            this.Controls.Add(this.lbl_secilenDepartman);
            this.Controls.Add(this.btn_departmanSec);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComboBoxControl";
            this.Text = "ComboBoxControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Button btn_departmanSec;
        private System.Windows.Forms.Label lbl_secilenDepartman;
        private System.Windows.Forms.Label lbl_adsadsads;
        private System.Windows.Forms.ComboBox cb_egitim;
        private System.Windows.Forms.Label lbl_egitim;
        private System.Windows.Forms.ComboBox cb_markalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_markaSec;
        private System.Windows.Forms.Label lbl_markaSec;
    }
}