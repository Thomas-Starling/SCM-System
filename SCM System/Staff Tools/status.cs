using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SCM_System.Staff_Tools
{
    public partial class status : UserControl
    {
        public status()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Visible = false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                lblItem.Text = row.Cells[1].Value.ToString();
                lblArrival.Text = row.Cells[4].Value.ToString();
                lblPrice.Text = "£" + row.Cells[2].Value.ToString();
                lblMinimum.Text = row.Cells[5].Value.ToString();
                lblMax.Text = row.Cells[6].Value.ToString();
                lblQuantity.Text = row.Cells[3].Value.ToString();
                lblStaff.Text = row.Cells[7].Value.ToString();
                lblStatus.Text = row.Cells[8].Value.ToString();

                if (lblStatus.Text == "In Stock")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
                else if (lblStatus.Text == "Low Stock")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Orange;
                }
                else if (lblStatus.Text == "Out of Stock")
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                }

                groupBoxResult.Visible = true;
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            groupBoxResult.Visible = false;
            Mediator.statusMediator m = new Mediator.statusMediator(txtID.Text, txtName.Text, dataGridView1);
        }
    }
}
