using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTuoi
{
    public partial class frmTinhTuoi : Form
    {
        public frmTinhTuoi()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            int namSinh;

            // Kiểm tra nguoiwfi dùng nhập năm sinh có hợp lệ hay không
            if (int.TryParse(txtNamSinh.Text, out namSinh))
            {
                int tuoi = DateTime.Now.Year - namSinh;

                // Hiển thị thông báo
                MessageBox.Show($"Họ và tên: {hoTen}\n Tuổi: {tuoi}", "Thông tin tuổi");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm sinh hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl = new DialogResult();
            tl = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
