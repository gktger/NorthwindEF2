using NorthWindEF.BLL;
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
    public partial class PersonelListesi_Form : Form
    {
        public PersonelListesi_Form()
        {
            InitializeComponent();
        }

        private void PersonelListesi_Form_Load(object sender, EventArgs e)
        {
            dgw_PersonelListesi.DataSource= PersonelBLL.GetEmployees();

        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelBLL.DeleteEmployee((int)dgw_PersonelListesi.SelectedRows[0].Cells[0].Value);
            dgw_PersonelListesi.DataSource = PersonelBLL.GetEmployees();

        }

        private void kaydıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGuncelle_Form frm = new PersonelGuncelle_Form();
            frm.employeeId = (int)this.dgw_PersonelListesi.SelectedRows[0].Cells[0].Value;
            ShowDialog();
        }
    }
}
