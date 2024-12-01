﻿using System;
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
    public partial class MDIIcinAnaForm : Form
    {
        public MDIIcinAnaForm()
        {
            InitializeComponent();
        }

        private void TSMI_metinAraclariForm_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if(form.GetType() == typeof(MetinAraclari))
                {
                    acikMi = true;
                    form.Activate();//Form açılmışsın en öne getir.
                }
                
            }
            if (acikMi == false)
            {
                MetinAraclari frm = new MetinAraclari();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void metinEditörüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(MetinEditorum))
                {
                    acikMi = true;
                    form.Activate();//Form açılmışsın en öne getir.
                }

            }
            if (acikMi == false)
            {
                MetinEditorum frm = new MetinEditorum();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
