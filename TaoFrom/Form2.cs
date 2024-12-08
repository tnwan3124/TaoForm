using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoFrom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtMSNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Nếu dữ liệu hợp lệ, trả thông tin ngược lại
            if (!decimal.TryParse(txtLuongCB.Text, out decimal luongCb))
            {
                MessageBox.Show("Lương cơ bản phải là số hợp lệ.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Form2(string msnv, string tenNV, decimal luongCB) : this()
        {
            txtMSNV.Text = msnv;
            txtTenNV.Text = tenNV;
            txtLuongCB.Text = luongCB.ToString();
        }

    }
}
