using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YC_College_Student_Management_System
{
    public partial class frm_Search_Student_List : Form
    {
        public frm_Search_Student_List()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=YC_College_Student_Managment_System_Database.db;Integrated Security=True");
        
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
            cmb_Course.Text = "";
        }

        private void frm_Search_Student_List_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = Shared_Class.Username;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student Obj = new frm_Add_New_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_List Obj = new frm_View_Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From YC_Student_Details Where Roll_No = @Rno", Con);

            cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                dtp_DOB.Text = (Dr["DOB"].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("No Recored Found ", "Invaild Roll No ");
                tb_Roll_No.Clear();
            }

            Con_Close();
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
