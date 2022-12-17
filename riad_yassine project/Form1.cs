using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riad_yassine_project
{
    public partial class connecter : Form
    {
        public connecter()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=LAPTOP-TFT5TQV8\SQLEXPRESS02;Integrated Security=True ; Initial Catalog=GestionCentreDB";
            SqlConnection cn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Mosta", cn);
                cn.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    if (username.Text == read["username"].ToString() && password.Text == read["Password"].ToString())
                    {
                        new Form2().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Passeword incorrect,try again");
                        username.Clear();
                        password.Clear();
                        username.Focus();
                    }

                }
            }
            cn.Close();
        }

        private void connecter_Load(object sender, EventArgs e)
        {

        }
    }
}
