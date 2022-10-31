using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YC_College_Student_Management_System
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Search_Student_List_Click(object sender, EventArgs e)
        {
            frm_Search_Student_List Obj = new frm_Search_Student_List();
            this.Hide();
            Obj.Show();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();
            this.Hide();
            Obj.Show();
        }

        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_YC_College_Student_Managment_System_Database_dbDataSet2.YC_Student_Details' table. You can move, or remove it, as needed.
            this.yC_Student_DetailsTableAdapter1.Fill(this._YC_College_Student_Managment_System_Database_dbDataSet2.YC_Student_Details);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You sure to Quit", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_YC_App_Login Obj = new frm_YC_App_Login();
                this.Hide();
                Obj.Show();
            }
        }
    }
}
