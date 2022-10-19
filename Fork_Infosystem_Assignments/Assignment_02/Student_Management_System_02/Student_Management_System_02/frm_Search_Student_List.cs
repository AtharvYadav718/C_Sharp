using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System_02
{
    public partial class frm_Search_Student_List : Form
    {
        public frm_Search_Student_List()
        {
            InitializeComponent();

        }
          SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System02.db;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }  
         void Clear_Controls()
            {
                tb_Roll_No.Clear();
                tb_Name.Clear();
                tb_Mobile_No.Clear();
                dtp_DOB.Text = "";
                cmb_Course.SelectedIndex = -1;
            }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            this.Hide();
            obj.Show();
        }

            private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details obj = new frm_View_Student_Details();
            this.Hide();
            obj.Show();
        }

            private void btn_Refersh_Click(object sender, EventArgs e)
            {
                Clear_Controls();
            }

            private void btn_Logout_Click(object sender, EventArgs e)
            {
                DialogResult Res = MessageBox.Show("Are You Sure To Quit","Log Out",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                if (Res == DialogResult.Yes)
                {
                    frm_SGM_Login Obj = new frm_SGM_Login();
                    this.Hide();
                    Obj.Show();

                }
            }

            private void btn_Search_Click(object sender, EventArgs e)
            {
                Con_Open();

                SqlCommand cmd = new SqlCommand("Select * From Student_Details Where Roll_No = @RNo", Con);
                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                SqlDataReader Or = cmd.ExecuteReader();

                if (Or.Read())
                {
                    tb_Name.Text = Or.GetString(Or.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (Or["Mobile_No"].ToString());
                    cmb_Course.Text = Or.GetString(Or.GetOrdinal("Course"));
                    dtp_DOB.Text = (Or["DOB"].ToString());
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll No");
                    tb_Roll_No.Clear();
                }
                Con_Close();
            }

           

       
    }
}
