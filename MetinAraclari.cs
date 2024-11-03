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
    public partial class MetinAraclari : Form
    {
        public MetinAraclari()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int count = textBox7.Text.Length;
            lbl_count.Text = Convert.ToString(20 - count);
            Random rnd = new Random();
            int sayi = rnd.Next(7,14);

            textBox7.PasswordChar = (char)sayi;
        }
    }
}
