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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        private void btn_Search_Student_List_Click(object sender, EventArgs e)
        {
            frm_Search_Student_List obj = new frm_Search_Student_List();
            this.Hide();
            obj.Show();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_List obj = new frm_View_Student_List();
            this.Hide();
            obj.Show();
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

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = Shared_Class.Username;
            Clear_Controls();
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
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "";
            cmb_Course.SelectedIndex = -1;
        }
        
        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Roll_No) from YC_Student_Details ", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());


            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Roll_No) from YC_Student_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into YC_Student_Details (Roll_No,Name,DOB,Mobile_No,Course) Values(@RollNo,@Nm,@DOB,@MNo,@Course)";

                Cmd.Parameters.Add("RollNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Fill All Field Compulsary", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con.Close();
        }

    }
}
