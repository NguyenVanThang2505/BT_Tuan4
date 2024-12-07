using System;
using System.Windows.Forms;

namespace BT_Buoi4
{
    public partial class Form2 : Form
    {
        public string MSNV { get; set; }
        public string Name { get; set; }
        public string Luong { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnYes_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSNV.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtLuong.Text, out decimal luong) || luong <= 0)
            {
                MessageBox.Show("Lương phải là một số dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MSNV = txtMSNV.Text;
            Name = txtName.Text;
            Luong = txtLuong.Text;

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnRefuse_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }
    }
}
