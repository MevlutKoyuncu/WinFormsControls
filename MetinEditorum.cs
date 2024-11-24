using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class MetinEditorum : Form
    {
        string yol = "";
        public MetinEditorum()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            openFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            FontFamily[] fontlar = FontFamily.Families;
            foreach (FontFamily item in fontlar)
            {
                TSCB_Font.Items.Add(item.Name);
            }
            //TSCB_Font.SelectedItem = richTextBox1.Font.Name;
            TSCB_Size.SelectedItem = "11";
            //Font ff = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);

        }

        private void TSMI_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_Kaydet_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                yol = saveFileDialog1.FileName;
                richTextBox1.SaveFile(yol);
                MessageBox.Show("Kayıt Başarılı", "İşlem");

            }
        }

        private void TSMI_Ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.LoadFile(openFileDialog1.FileName);//Load File bizim rtf dosyalarımızı getirecek.
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                if (fi.Extension == ".txt")
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string metin = sr.ReadToEnd();
                    richTextBox1.Text = metin;

                }
                else if (fi.Extension == ".rtf")
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Seçilen Dosya Formatı Uygun Değil", "Hata");
                }
            }
            else//Dosya seçilmemiş ise

            {
                MessageBox.Show("Dosya Açma İşlemi İptal Edildi.");
            }
        }

        private void TSCB_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily ff = new FontFamily(TSCB_Font.Text);
            float FontSize = 11;
            if (TSCB_Size.SelectedItem != null)
            {
                FontSize = Convert.ToSingle(TSCB_Size.SelectedItem.ToString());
            }
            Font secilifont = new Font(ff, FontSize);
            richTextBox1.Font = secilifont;

        }

        private void TSCB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TSCB_Font.SelectedItem != null)
            {
                FontFamily ff = new FontFamily(TSCB_Font.Text);
                Font secilifont = new Font(ff, Convert.ToSingle(TSCB_Size.SelectedItem.ToString()));
                richTextBox1.Font = secilifont;
            }

        }

        private void TSB_Bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Bold == false)
            {
                Font kalinfont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
                richTextBox1.Font = kalinfont;
            }
            else if (richTextBox1.Font.Bold == true)
            {
                Font normalfont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                richTextBox1.Font= normalfont;
            }
        }

        private void TSB_Underline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Underline == false)
            {
                Font kalinfont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
                richTextBox1.Font = kalinfont;
            }
            else if (richTextBox1.Font.Underline == true)
            {
                Font normalfont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
                richTextBox1.Font = normalfont;
            }
        }
    }
}
