using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BusTicketManagement.Forms;

namespace BusTicketManagement
{
    public partial class frmLogIN : Form
    {


        public frmLogIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIN_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter cmd = new SqlDataAdapter("SELECT* FROM king.AppUser WHERE Email = '" + txtUserName.Text + "' AND [Password] = '" + txtPassword.Text + "' AND IsActive = 1", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    Information ti = new Information(dt);
                    ti.Show();
                }
                else
                {
                    MessageBox.Show("Enter Valid Email and Password.");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}
