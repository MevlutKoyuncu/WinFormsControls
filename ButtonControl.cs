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
    public partial class ButtonControl : Form
    {
        public ButtonControl()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(btn_tikla.Text);
            sayi += 1;
            btn_tikla.Text = Convert.ToString(sayi);
        }
    }
}
