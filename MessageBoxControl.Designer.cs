namespace WinFormsControls
{
    partial class MessageBoxControl
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
            this.btn_standart = new System.Windows.Forms.Button();
            this.btn_evethayir = new System.Windows.Forms.Button();
            this.btn_kaydetcik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_warning = new System.Windows.Forms.Button();
            this.btn_error = new System.Windows.Forms.Button();
            this.btn_question = new System.Windows.Forms.Button();
            this.btn_formAc = new System.Windows.Forms.Button();
            this.btn_sistemprog = new System.Windows.Forms.Button();
            this.btn_formAc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_standart
            // 
            this.btn_standart.Location = new System.Drawing.Point(42, 47);
            this.btn_standart.Name = "btn_standart";
            this.btn_standart.Size = new System.Drawing.Size(186, 23);
            this.btn_standart.TabIndex = 0;
            this.btn_standart.Text = "Standart Message Box";
            this.btn_standart.UseVisualStyleBackColor = true;
            this.btn_standart.Click += new System.EventHandler(this.btn_standart_Click);
            // 
            // btn_evethayir
            // 
            this.btn_evethayir.Location = new System.Drawing.Point(42, 76);
            this.btn_evethayir.Name = "btn_evethayir";
            this.btn_evethayir.Size = new System.Drawing.Size(186, 23);
            this.btn_evethayir.TabIndex = 1;
            this.btn_evethayir.Text = "Sana bir sorum var";
            this.btn_evethayir.UseVisualStyleBackColor = true;
            this.btn_evethayir.Click += new System.EventHandler(this.btn_evethayir_Click);
            // 
            // btn_kaydetcik
            // 
            this.btn_kaydetcik.Location = new System.Drawing.Point(42, 105);
            this.btn_kaydetcik.Name = "btn_kaydetcik";
            this.btn_kaydetcik.Size = new System.Drawing.Size(186, 23);
            this.btn_kaydetcik.TabIndex = 2;
            this.btn_kaydetcik.Text = "Çıkış";
            this.btn_kaydetcik.UseVisualStyleBackColor = true;
            this.btn_kaydetcik.Click += new System.EventHandler(this.btn_kaydetcik_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dene";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(42, 164);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(186, 23);
            this.btn_abort.TabIndex = 4;
            this.btn_abort.Text = "Görev Başarısı";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(259, 47);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(176, 23);
            this.btn_info.TabIndex = 5;
            this.btn_info.Text = "Info";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_warning
            // 
            this.btn_warning.Location = new System.Drawing.Point(259, 75);
            this.btn_warning.Name = "btn_warning";
            this.btn_warning.Size = new System.Drawing.Size(176, 23);
            this.btn_warning.TabIndex = 6;
            this.btn_warning.Text = "Warning";
            this.btn_warning.UseVisualStyleBackColor = true;
            this.btn_warning.Click += new System.EventHandler(this.btn_warning_Click);
            // 
            // btn_error
            // 
            this.btn_error.Location = new System.Drawing.Point(259, 105);
            this.btn_error.Name = "btn_error";
            this.btn_error.Size = new System.Drawing.Size(176, 23);
            this.btn_error.TabIndex = 7;
            this.btn_error.Text = "Error";
            this.btn_error.UseVisualStyleBackColor = true;
            this.btn_error.Click += new System.EventHandler(this.btn_error_Click);
            // 
            // btn_question
            // 
            this.btn_question.Location = new System.Drawing.Point(259, 133);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(176, 23);
            this.btn_question.TabIndex = 8;
            this.btn_question.Text = "Question";
            this.btn_question.UseVisualStyleBackColor = true;
            this.btn_question.Click += new System.EventHandler(this.btn_question_Click);
            // 
            // btn_formAc
            // 
            this.btn_formAc.Location = new System.Drawing.Point(468, 47);
            this.btn_formAc.Name = "btn_formAc";
            this.btn_formAc.Size = new System.Drawing.Size(175, 23);
            this.btn_formAc.TabIndex = 9;
            this.btn_formAc.Text = "Metin Araçları Formunu Aç";
            this.btn_formAc.UseVisualStyleBackColor = true;
            this.btn_formAc.Click += new System.EventHandler(this.btn_formAc_Click);
            // 
            // btn_sistemprog
            // 
            this.btn_sistemprog.Location = new System.Drawing.Point(468, 75);
            this.btn_sistemprog.Name = "btn_sistemprog";
            this.btn_sistemprog.Size = new System.Drawing.Size(175, 23);
            this.btn_sistemprog.TabIndex = 10;
            this.btn_sistemprog.Text = "Sistem Programlarını Aç";
            this.btn_sistemprog.UseVisualStyleBackColor = true;
            this.btn_sistemprog.Click += new System.EventHandler(this.btn_sistemprog_Click);
            // 
            // btn_formAc2
            // 
            this.btn_formAc2.Location = new System.Drawing.Point(468, 105);
            this.btn_formAc2.Name = "btn_formAc2";
            this.btn_formAc2.Size = new System.Drawing.Size(175, 23);
            this.btn_formAc2.TabIndex = 11;
            this.btn_formAc2.Text = "Metin Formunu Aç-Dialog";
            this.btn_formAc2.UseVisualStyleBackColor = true;
            this.btn_formAc2.Click += new System.EventHandler(this.btn_formAc2_Click);
            // 
            // MessageBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_formAc2);
            this.Controls.Add(this.btn_sistemprog);
            this.Controls.Add(this.btn_formAc);
            this.Controls.Add(this.btn_question);
            this.Controls.Add(this.btn_error);
            this.Controls.Add(this.btn_warning);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kaydetcik);
            this.Controls.Add(this.btn_evethayir);
            this.Controls.Add(this.btn_standart);
            this.Name = "MessageBoxControl";
            this.Text = "MessageBoxControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_standart;
        private System.Windows.Forms.Button btn_evethayir;
        private System.Windows.Forms.Button btn_kaydetcik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_warning;
        private System.Windows.Forms.Button btn_error;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Button btn_formAc;
        private System.Windows.Forms.Button btn_sistemprog;
        private System.Windows.Forms.Button btn_formAc2;
    }
}