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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
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
        void Clear_Controls()
        {
             tb_Roll_No.Text = Convert.ToString(Auto_Incr());
             tb_Name.Clear();
             tb_Mobile_No.Clear();
             dtp_DOB.Text = "";
             cmb_Course.SelectedIndex = -1;
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "Select Count(*) From Student_Details";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                cmd.CommandText = "Select Max(Roll_No) From Student_Details";
                Cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_SGM_Login obj=new frm_SGM_Login();
            this.Hide();
            obj.Show();
        }

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details obj = new frm_View_Student_Details();
            this.Hide();
            obj.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Name,DOB,Mobile_No,Course) Values(@RollNo,@Nm,@DOB,@MNo,@Course)";


                Cmd.Parameters.Add("RollNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();

            }
            else
            {
                MessageBox.Show("Fill All Field Compulsary", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();

        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_List Obj = new frm_Search_Student_List();
            this.Hide();
            Obj.Show();

        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
        }
      
    }
}
