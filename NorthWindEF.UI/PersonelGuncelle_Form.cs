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
    public partial class PersonelGuncelle_Form : Form
    {
        public PersonelGuncelle_Form()
        {
            InitializeComponent();
        }

        public int employeeId;
        private void PersonelGuncelle_Form_Load(object sender, EventArgs e)
        {
            cb_titleguncelle.DataSource = PersonelBLL.GetEmployeeTitles();
            cb_titleguncelle.DisplayMember = "Title";
            cb_titleguncelle.ValueMember = "Title";


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            PersonelBLL.UpdateEmployee(employeeId,tb_isimguncelle.Text, tb_soyisimguncelle.Text);

        }
    }
}
