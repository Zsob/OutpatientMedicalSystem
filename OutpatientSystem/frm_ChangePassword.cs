using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientSystem
{
    public partial class frm_ChangePassword : Form
    {
        string No;
        int State;
        public frm_ChangePassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public frm_ChangePassword(string no,int state):this()
        {
            No = no;
            State = state;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (txb_OldPassword.Text == "" )
            {
                MessageBox.Show("旧密码为空");
                txb_OldPassword.Focus();
                return;
            }
            if (txb_NewPassword.Text == "")
            {
                MessageBox.Show("新密码为空");
                txb_NewPassword.Focus();
                return;
            }
            if (txb_ComfirmPassword.Text == "")
            {
                MessageBox.Show("确认密码为空");
                txb_ComfirmPassword.Focus();
                return;
            }
            if (txb_NewPassword.Text!=txb_ComfirmPassword.Text)
            {
                MessageBox.Show("新密码和确认密码不相同");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            if (State == 1)
            {
                sqlCommand.CommandText = $@"SELECT COUNT(1) FROM tb_Doctor"
                + $" WHERE DoctorNo='{No}'"
                + $" AND Password=HASHBYTES('MD5',@Password);";
            }
            else
            {
                sqlCommand.CommandText = $@"SELECT COUNT(1) FROM tb_User"
                + $" WHERE ID='{No}'"
                + $" AND Password=HASHBYTES('MD5',@Password);";
            }
            sqlCommand.Parameters.AddWithValue("@Password", txb_OldPassword.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            if (rowCount==0)
            {
                MessageBox.Show("旧密码错误!");
                return;
            }
            if (State == 1)
            {
                sqlCommand.CommandText = $@"UPDATE dbo.tb_Doctor SET Password=HASHBYTES('MD5',@NewPassword) WHERE DoctorNo={No}";
            }
            else
            {
                sqlCommand.CommandText = $@"UPDATE dbo.tb_User SET Password=HASHBYTES('MD5',@NewPassword) WHERE ID={No}";
            }
            sqlCommand.Parameters.AddWithValue("@NewPassword", txb_ComfirmPassword.Text.Trim());
            sqlCommand.Parameters["@NewPassword"].SqlDbType = SqlDbType.VarChar;
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show("修改成功");
            }
        }
    }
}
