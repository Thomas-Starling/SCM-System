using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCM_System.Manager_Tools
{
    public partial class stock : UserControl
    {
        public stock()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\v11.0; AttachDbFilename =| DataDirectory |\database.mdf; Integrated Security = True; Connect Timeout = 30"))
            {

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\v11.0; AttachDbFilename =| DataDirectory |\database.mdf; Integrated Security = True; Connect Timeout = 30"))
            {

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\v11.0; AttachDbFilename =| DataDirectory |\database.mdf; Integrated Security = True; Connect Timeout = 30"))
            {

            }
        }
    }
}
