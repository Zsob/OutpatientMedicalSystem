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
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            gpb_User.Visible = true;
            gpb_Docter.Visible = !gpb_User.Visible;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (this.txb_No.Text.Trim() == "")
            {
                MessageBox.Show("用户号不能为空！");
                this.txb_No.Focus();
                return;
            }
            if (this.txb_Password.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！");
                this.txb_Password.Focus();
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $"SELECT COUNT(1) FROM tb_User"
                + $" WHERE ID='{this.txb_No.Text.Trim()}'"
                + $" AND Password=HASHBYTES('MD5','{this.txb_Password.Text.Trim()}');";
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();

            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("登录成功。");
                frm_OutpatientForm outpatientForm = new frm_OutpatientForm(txb_No.Text);
                outpatientForm.FormClosed += OutpatientForm_FormClosed;
                outpatientForm.Show();
                txb_No.Text = txb_Password.Text = null;
                Hide();
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }

        }

        private void OutpatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.FormClosed += SignUp_FormClosed;
            this.Hide();
            signUp.Show();

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_Docter_Click(object sender, EventArgs e)
        {
            gpb_Docter.Visible = true;
            gpb_User.Visible = !gpb_Docter.Visible;

        }
    }
}
