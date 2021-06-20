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
    public partial class frm_Lock : Form
    {
        string no;
        int time = 3;
        public frm_Lock()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_Lock(string no,string name):this()
        {
            lbl_LandingPerson.Text = name;
            this.no = no;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Verification_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $"SELECT COUNT(1) FROM tb_Doctor"
                + $" WHERE DoctorNo='{no}'"
                + $" AND Password=HASHBYTES('MD5','{this.txb_Password.Text.Trim()}');";
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowCount > 0)
            {
                MessageBox.Show("验证成功！请点击解锁");
                btn_Confirm.DialogResult = DialogResult.OK;
                btn_Confirm.Enabled = true;
            }
            else
            {
                time--;
                if (time==0)
                {
                    lbl_Verification.Enabled = false;
                    MessageBox.Show("错误次数过多，请点击退出按钮！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"密码错误！还可以尝试{time}次！");
                return;
            }

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            //DialogResult result=MessageBox.Show("确定退出", "退出", MessageBoxButtons.YesNo);
            MessageBox.Show("退出成功");
        }
    }
}
