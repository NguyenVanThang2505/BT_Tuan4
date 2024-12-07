using System;
using System.Windows.Forms;

namespace BT_Buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                dtgvNV.Rows.Add(form2.MSNV, form2.Name, form2.Luong);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dtgvNV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtgvNV.Rows.RemoveAt(dtgvNV.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dtgvNV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvNV.SelectedRows[0];
                Form2 form2 = new Form2();

                form2.MSNV = selectedRow.Cells["colMSNV"].Value.ToString();
                form2.Name = selectedRow.Cells["colName"].Value.ToString();
                form2.Luong = selectedRow.Cells["colLuong"].Value.ToString();

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["colMSNV"].Value = form2.MSNV;
                    selectedRow.Cells["colName"].Value = form2.Name;
                    selectedRow.Cells["colLuong"].Value = form2.Luong;
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

