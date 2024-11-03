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
    public partial class LabelControl : Form
    {
        public LabelControl()
        {
            InitializeComponent();
            label3.TextAlign = ContentAlignment.TopRight;
        }
    }
}
