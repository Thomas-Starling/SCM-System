using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Main
{
    public partial class frmMain : Form
    {
        public string uname;
        public frmMain(string username)
        {
            InitializeComponent();

            bunifuTileButton1.LabelText = username;
            uname = username;

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\database.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Staff WHERE username=@uname and manager=1", Connection);
                cmd.Parameters.AddWithValue("@uname", uname);
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    Connection.Close();
                    button9.Visible = true;
                    button8.Visible = true;
                    button6.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }

            home home = new home();
            home.Dock = DockStyle.Fill;
            userControl1.Controls.Add(home);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            home home = new home();
            home.Dock = DockStyle.Fill;
            userControl1.Controls.Add(home);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;

            Staff_Tools.status status = new Staff_Tools.status();
            status.Dock = DockStyle.Fill;
            userControl1.Controls.Add(status);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button3.Top;

            Staff_Tools.collection collection = new Staff_Tools.collection();
            collection.Dock = DockStyle.Fill;
            userControl1.Controls.Add(collection);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button4.Top;

            Staff_Tools.delivery delivery = new Staff_Tools.delivery();
            delivery.Dock = DockStyle.Fill;
            userControl1.Controls.Add(delivery);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button5.Top;

            Staff_Tools.stockControl stockControl = new Staff_Tools.stockControl();
            stockControl.Dock = DockStyle.Fill;
            userControl1.Controls.Add(stockControl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button7.Top;

            Account.account account = new Account.account();
            account.Dock = DockStyle.Fill;
            userControl1.Controls.Add(account);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button7.Top;

            Account.account account = new Account.account();
            account.Dock = DockStyle.Fill;
            userControl1.Controls.Add(account);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Staff_Login.frmLogin login = new Staff_Login.frmLogin();
                this.Hide();
                login.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button9.Top;

            Manager_Tools.stock stock = new Manager_Tools.stock();
            stock.Dock = DockStyle.Fill;
            userControl1.Controls.Add(stock);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button8.Top;

            Manager_Tools.report report = new Manager_Tools.report();
            report.Dock = DockStyle.Fill;
            userControl1.Controls.Add(report);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl1.Controls.Clear();
            SidePanel.Height = button2.Height;
            SidePanel.Top = button6.Top;

            Manager_Tools.staff staff = new Manager_Tools.staff();
            staff.Dock = DockStyle.Fill;
            userControl1.Controls.Add(staff);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Dock = DockStyle.Fill;
            userControl1.Controls.Add(settings);
        }
    }
}
