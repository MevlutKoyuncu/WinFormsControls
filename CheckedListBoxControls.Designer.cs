namespace WinFormsControls
{
    partial class CheckedListBoxControls
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
            this.clb_diller = new System.Windows.Forms.CheckedListBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clb_diller
            // 
            this.clb_diller.FormattingEnabled = true;
            this.clb_diller.Items.AddRange(new object[] {
            "İngilizce",
            "Almanca",
            "Rusça",
            "Korece",
            "Japonca",
            "Doçdili"});
            this.clb_diller.Location = new System.Drawing.Point(6, 24);
            this.clb_diller.Name = "clb_diller";
            this.clb_diller.Size = new System.Drawing.Size(129, 140);
            this.clb_diller.TabIndex = 0;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(166, 24);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(75, 23);
            this.btn_getir.TabIndex = 1;
            this.btn_getir.Text = "button1";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(163, 73);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(44, 16);
            this.lbl_ekran.TabIndex = 2;
            this.lbl_ekran.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clb_diller);
            this.groupBox1.Controls.Add(this.lbl_ekran);
            this.groupBox1.Controls.Add(this.btn_getir);
            this.groupBox1.Location = new System.Drawing.Point(50, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CheckedListBoxControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckedListBoxControls";
            this.Text = "CheckedListBoxControls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_diller;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}