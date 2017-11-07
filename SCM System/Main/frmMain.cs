using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Main
{
    public partial class frmMain : Form
    {
        public frmMain(string username)
        {
            InitializeComponent();

            bunifuTileButton1.LabelText = username;

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button5.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button7.Top;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
