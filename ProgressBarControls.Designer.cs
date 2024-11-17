namespace WinFormsControls
{
    partial class ProgressBarControls
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
            this.pb_ilerleme = new System.Windows.Forms.ProgressBar();
            this.btn_ilerle = new System.Windows.Forms.Button();
            this.pb_saat = new System.Windows.Forms.ProgressBar();
            this.pb_dakika = new System.Windows.Forms.ProgressBar();
            this.pb_saniye = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_saat = new System.Windows.Forms.Label();
            this.lb_dakika = new System.Windows.Forms.Label();
            this.lb_saniye = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pb_ilerleme
            // 
            this.pb_ilerleme.Location = new System.Drawing.Point(49, 52);
            this.pb_ilerleme.Name = "pb_ilerleme";
            this.pb_ilerleme.Size = new System.Drawing.Size(316, 23);
            this.pb_ilerleme.TabIndex = 0;
            // 
            // btn_ilerle
            // 
            this.btn_ilerle.Location = new System.Drawing.Point(394, 52);
            this.btn_ilerle.Name = "btn_ilerle";
            this.btn_ilerle.Size = new System.Drawing.Size(132, 23);
            this.btn_ilerle.TabIndex = 1;
            this.btn_ilerle.Text = "-->";
            this.btn_ilerle.UseVisualStyleBackColor = true;
            this.btn_ilerle.Click += new System.EventHandler(this.btn_ilerle_Click);
            // 
            // pb_saat
            // 
            this.pb_saat.Location = new System.Drawing.Point(132, 125);
            this.pb_saat.Maximum = 24;
            this.pb_saat.Name = "pb_saat";
            this.pb_saat.Size = new System.Drawing.Size(495, 52);
            this.pb_saat.Step = 1;
            this.pb_saat.TabIndex = 2;
            // 
            // pb_dakika
            // 
            this.pb_dakika.Location = new System.Drawing.Point(132, 200);
            this.pb_dakika.Maximum = 59;
            this.pb_dakika.Name = "pb_dakika";
            this.pb_dakika.Size = new System.Drawing.Size(495, 52);
            this.pb_dakika.Step = 1;
            this.pb_dakika.TabIndex = 2;
            // 
            // pb_saniye
            // 
            this.pb_saniye.Location = new System.Drawing.Point(132, 277);
            this.pb_saniye.Maximum = 59;
            this.pb_saniye.Name = "pb_saniye";
            this.pb_saniye.Size = new System.Drawing.Size(495, 52);
            this.pb_saniye.Step = 1;
            this.pb_saniye.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dakika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saniye";
            // 
            // lb_saat
            // 
            this.lb_saat.AutoSize = true;
            this.lb_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_saat.Location = new System.Drawing.Point(652, 136);
            this.lb_saat.Name = "lb_saat";
            this.lb_saat.Size = new System.Drawing.Size(0, 29);
            this.lb_saat.TabIndex = 3;
            // 
            // lb_dakika
            // 
            this.lb_dakika.AutoSize = true;
            this.lb_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_dakika.Location = new System.Drawing.Point(652, 213);
            this.lb_dakika.Name = "lb_dakika";
            this.lb_dakika.Size = new System.Drawing.Size(0, 29);
            this.lb_dakika.TabIndex = 3;
            // 
            // lb_saniye
            // 
            this.lb_saniye.AutoSize = true;
            this.lb_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_saniye.Location = new System.Drawing.Point(652, 290);
            this.lb_saniye.Name = "lb_saniye";
            this.lb_saniye.Size = new System.Drawing.Size(0, 29);
            this.lb_saniye.TabIndex = 3;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(44, 78);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(79, 29);
            this.lbl_tarih.TabIndex = 4;
            this.lbl_tarih.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBarControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lb_saniye);
            this.Controls.Add(this.lb_dakika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_saat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_saniye);
            this.Controls.Add(this.pb_dakika);
            this.Controls.Add(this.pb_saat);
            this.Controls.Add(this.btn_ilerle);
            this.Controls.Add(this.pb_ilerleme);
            this.Name = "ProgressBarControls";
            this.Text = "ProgressBarControls";
            this.Load += new System.EventHandler(this.ProgressBarControls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_ilerleme;
        private System.Windows.Forms.Button btn_ilerle;
        private System.Windows.Forms.ProgressBar pb_saat;
        private System.Windows.Forms.ProgressBar pb_dakika;
        private System.Windows.Forms.ProgressBar pb_saniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_saat;
        private System.Windows.Forms.Label lb_dakika;
        private System.Windows.Forms.Label lb_saniye;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Timer timer1;
    }
}