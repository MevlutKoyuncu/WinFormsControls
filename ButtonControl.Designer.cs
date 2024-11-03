namespace WinFormsControls
{
    partial class ButtonControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_tikla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(51, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "BUTTON BU GARDEŞ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(240, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "ŞİŞKO BUTTON";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(51, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 58);
            this.button3.TabIndex = 0;
            this.button3.Text = "RESİMLİ BUTTON";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackgroundImage = global::WinFormsControls.Properties.Resources.herhangi_bir_adam_v0_8up58kxgtr3c1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.CausesValidation = false;
            this.button4.Location = new System.Drawing.Point(320, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 165);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // btn_tikla
            // 
            this.btn_tikla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_tikla.AutoSize = true;
            this.btn_tikla.Location = new System.Drawing.Point(380, 337);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(75, 42);
            this.btn_tikla.TabIndex = 1;
            this.btn_tikla.Text = "0";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 501);
            this.Controls.Add(this.btn_tikla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ButtonControl";
            this.Text = "ButtonControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_tikla;
    }
}