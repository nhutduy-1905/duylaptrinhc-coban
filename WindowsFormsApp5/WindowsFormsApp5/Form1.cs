using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmBaiTap : Form
    {
        public frmBaiTap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          string Name = txtName.Text;
            int Age;
            // Kiem tra
            if (int.TryParse(txtAge.Text, out Age) )
            {
                int tuoi = DateTime.Now.Year - Age;
            }
            else
            {
                MessageBox.Show("Vui long nhap lai","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl = new DialogResult();
            tl = MessageBox.Show("Ban muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                {
                    this.Close();
                }
            }
        }
    }
}
