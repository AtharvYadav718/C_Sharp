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
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            this.Hide();
            obj.Show();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_List obj = new frm_Search_Student_List();
            this.Hide();
            obj.Show();

        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student_Management_System02_dbDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Student_Management_System02_dbDataSet.Student_Details);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_SGM_Login obj = new frm_SGM_Login();
            this.Hide();
            obj.Show();
        }    
    }
}
