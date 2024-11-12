using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsControls
{
    public partial class ListBoxControl : Form
    {
        public ListBoxControl()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            //string secilen = lb_sehirliste.SelectedItem.ToString();
            //lbl_ekran.Text = secilen;

            string secilenler = "";
            foreach (var item in lb_sehirliste.SelectedItems)
            {
                secilenler += item.ToString() + ", ";
            }
            lbl_ekran.Text = secilenler;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_eklenecek.Text))
            {
                lb_sehirliste.Items.Add(tb_eklenecek.Text);
                tb_eklenecek.Text = "";
            }
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            var liste = lb_sehirliste.SelectedItems;
            foreach (var item in liste)
            {
                lb_sehirliste2.Items.Add(item);
            }

            //for (int i = lb_sehirliste.SelectedIndices.Count - 1; i >= 0; i--)
            //{
            //    int item = lb_sehirliste.SelectedIndices[i];
            //    lb_sehirliste.Items.RemoveAt(item);
            //} 

            //var liste2 = lb_sehirliste2.Items;
            //for (int i = 0; i < liste2.Count; i++)
            //{
            //    lb_sehirliste.Items.Remove(liste2[i]);
            //}
        }
    }
}
