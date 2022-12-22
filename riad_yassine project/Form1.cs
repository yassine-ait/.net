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
            string cs = @"Data Source=LAPTOP-TFT5TQV8\SQLEXPRESS02;Integrated Security=True ; Initial Catalog=GestionDB";
            SqlConnection cn = new SqlConnection(cs);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Mostaamil where Username='" + username.Text + "' and Password='" + password.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                if (i == 1)
                {
                    SqlDataReader read = cmd.ExecuteReader();
                    read.Read();
                    if (read[4].ToString() == "admin")
                    {
                        Log.type = "A";
                    }
                    else if (read[4].ToString() == "user")
                    {
                        Log.type = "U";
                    }
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or Passeword incorrect,try again");
                    username.Clear();
                    password.Clear();
                    username.Focus();
                }
            }catch (Exception E) { MessageBox.Show(E.Message); }
                    cn.Close();    
        }

        private void connecter_Load(object sender, EventArgs e)
        {

        }
    }
}
