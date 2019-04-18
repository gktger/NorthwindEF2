using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindEF.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesi_Form frm = new PersonelListesi_Form();
            frm.MdiParent = this;
            frm.Show();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniPersonelEkle_Form frm = new YeniPersonelEkle_Form();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
