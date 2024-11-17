namespace WinFormsControls
{
    partial class PictureBoxControls
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
            this.pb_resim1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_sizemode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_resim1
            // 
            this.pb_resim1.Location = new System.Drawing.Point(6, 21);
            this.pb_resim1.Name = "pb_resim1";
            this.pb_resim1.Size = new System.Drawing.Size(357, 234);
            this.pb_resim1.TabIndex = 0;
            this.pb_resim1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sizemode);
            this.groupBox1.Controls.Add(this.pb_resim1);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // cb_sizemode
            // 
            this.cb_sizemode.FormattingEnabled = true;
            this.cb_sizemode.Items.AddRange(new object[] {
            "Normal",
            "Zoom",
            "Strech Image",
            "Center"});
            this.cb_sizemode.Location = new System.Drawing.Point(6, 262);
            this.cb_sizemode.Name = "cb_sizemode";
            this.cb_sizemode.Size = new System.Drawing.Size(357, 24);
            this.cb_sizemode.TabIndex = 1;
            this.cb_sizemode.SelectedIndexChanged += new System.EventHandler(this.cb_sizemode_SelectedIndexChanged);
            // 
            // PictureBoxControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PictureBoxControls";
            this.Text = "PictureBoxControls";
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_sizemode;
        private System.Windows.Forms.PictureBox pb_resim1;
    }
}