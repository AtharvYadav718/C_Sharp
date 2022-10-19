using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_App_Login_dbDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.sGM_App_Login_dbDataSet1.Student_Details);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult res=    MessageBox.Show("are you want to quiet","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                frm_SGM_Login Obj = new frm_SGM_Login();
                Obj.Show();
                this.Hide();

            }
        }

        private void dgv_View_Student_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {

            frm_Add_New_Student obj = new frm_Add_New_Student();
            this.Hide();
            obj.Show();
        }

        

       
    }
}
