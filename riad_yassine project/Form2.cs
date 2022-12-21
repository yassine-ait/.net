using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riad_yassine_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Log.type == "A")
            {
                user_simple.Visible = true;
                etudiant.Visible = true; 
                professeur.Visible = true;
            }else if (Log.type == "U")
            {
                user_simple.Visible=false;
                etudiant.Visible=true;
                professeur.Visible=true;
            }
        }
    }
}
