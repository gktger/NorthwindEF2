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
    public partial class YeniPersonelEkle_Form : Form
    {
        public YeniPersonelEkle_Form()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            int _personelId = PersonelBLL.AddEmployee(tb_isim.Text, tb_soyisim.Text,(string)cb_title.SelectedValue);
            MessageBox.Show("Yeni Kayıt Eklendi!");
           
        }

      

        private void YeniPersonelEkle_Form_Load(object sender, EventArgs e)
        {
            cb_title.DataSource = PersonelBLL.GetEmployeeTitles();
            cb_title.DisplayMember = "Title";
            cb_title.ValueMember = "Title";

        }
    }
}
