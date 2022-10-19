using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System_02
{
    public partial class frm_SGM_Login : Form
    {
        public frm_SGM_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "Admin") && (tb_Password.Text == "23746"))
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Text = "Invalid Username or Password";
                lbl_error.ForeColor = Color.OrangeRed;

            }

            tb_Username.Clear();
            tb_Password.Clear();
        }
       
    }
}
