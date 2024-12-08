namespace TaoFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // Mở Form2 để thêm mới
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Lấy dữ liệu từ Form2 và thêm vào ListView
                string msnv = form2.Controls["txtMSNV"].Text;
                string tenNV = form2.Controls["txtTenNV"].Text;
                string luongCB = form2.Controls["txtLuongCB"].Text;

                var item = new ListViewItem(new[] { msnv, tenNV, luongCB });
                lvDS.Items.Add(item);
            }
        }

        // Xử lý khi nhấn nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                var selectedItem = lvDS.SelectedItems[0];
                string msnv = selectedItem.SubItems[0].Text;
                string tenNV = selectedItem.SubItems[1].Text;
                decimal luongCB = decimal.Parse(selectedItem.SubItems[2].Text);

                Form2 form2 = new Form2(msnv, tenNV, luongCB);  // Mở Form2 để sửa thông tin
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    selectedItem.SubItems[0].Text = form2.Controls["txtMSNV"].Text;
                    selectedItem.SubItems[1].Text = form2.Controls["txtTenNV"].Text;
                    selectedItem.SubItems[2].Text = form2.Controls["txtLuongCB"].Text;
                }
            }
        }

        // Xử lý khi nhấn nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDS.SelectedItems.Count > 0)
            {
                lvDS.Items.Remove(lvDS.SelectedItems[0]);
            }
        }

        // Xử lý khi nhấn nút "Đóng"
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvDS.View = View.Details;
            lvDS.Columns.Add("MSNV", 100);
            lvDS.Columns.Add("Tên NV", 150);
            lvDS.Columns.Add("Lương CB", 100);
        }

        private void lvDS_DoubleClick(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }


    }
}
