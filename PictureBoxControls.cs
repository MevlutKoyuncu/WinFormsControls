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
    public partial class PictureBoxControls : Form
    {
        public PictureBoxControls()
        {
            InitializeComponent();
            pb_resim1.ImageLocation = "../../images/Adsız.jpg";
            pb_resim1.SizeMode = PictureBoxSizeMode.StretchImage;
            cb_sizemode.SelectedIndex = 1;
        }

        private void cb_sizemode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string secilen = cb_sizemode.SelectedItem.ToString();
            switch (secilen)
            {
                case "Normal":
                    pb_resim1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Zoom":
                    pb_resim1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "Strech Image":
                    pb_resim1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Center":
                    pb_resim1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                default:
                    break;
            }
        }
    }
}
