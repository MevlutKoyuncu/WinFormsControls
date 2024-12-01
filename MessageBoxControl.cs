using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class MessageBoxControl : Form
    {
        public MessageBoxControl()
        {
            InitializeComponent();
        }

        private void btn_standart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("İçerik", "Başlık");
            if (MessageBox.Show("İçerik", "Başlık") == DialogResult.OK)
            {
                MessageBox.Show("Onaylandı");
            }
        }

        private void btn_evethayir_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Benimle evlenir misin?", "Evlen", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Evet seçildi");
            }
            else
            {
                MessageBox.Show("Hayır seçildi");
            }
        }

        private void btn_kaydetcik_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydetmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt Edildi");
                Application.Exit();
            }
            if (sonuc == DialogResult.No)
            {
                Application.Exit();
            }
            if (sonuc == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Tekrar denemek istiyor musunuz?", "Uyarı", MessageBoxButtons.RetryCancel);
            if (sonuc == DialogResult.Retry)
            {
                MessageBox.Show("Retry seçildi.");
            }
            else
            {
                MessageBox.Show("Niye bırakıyorsun kalk dene");
            }
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Görev Başarılamadı", "Başarısız", MessageBoxButtons.AbortRetryIgnore);
            if (sonuc == DialogResult.Abort)
            {
                MessageBox.Show("Abort seçildi.");
            }
            if (sonuc == DialogResult.Retry)
            {
                MessageBox.Show("Retry seçildi.");
            }
            if (sonuc == DialogResult.Ignore)
            {
                MessageBox.Show("Ignore seçildi.");
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgilendirme", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_warning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uyarı", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soru", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_formAc_Click(object sender, EventArgs e)
        {
            MetinAraclari frm_metin = new MetinAraclari();
            frm_metin.Show();
        }

        private void btn_sistemprog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btn_formAc2_Click(object sender, EventArgs e)
        {
            MetinAraclari frm_metin = new MetinAraclari();
            frm_metin.ShowDialog();
        }
    }
}
