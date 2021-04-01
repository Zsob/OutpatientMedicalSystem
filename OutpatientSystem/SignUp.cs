using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OutpatientSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (this.txb_ID.Text.Trim() == "")                                                      
            {
                MessageBox.Show("身份证不能为空！");														
                this.txb_ID.Focus();                                                                
                return;                                                                                 
            }
            if (this.txb_Password.Text.Trim() == "")                                                   
            {
                MessageBox.Show("密码不能为空！");														
                this.txb_Password.Focus();                                                             
                return;                                                                                 
            }
            if (txb_Name.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空！");
                this.txb_Name.Focus();
                return;
            }
            if (rdb_Female.Checked == false && rdb_Male.Checked == false)
            {
                MessageBox.Show("性别还未选择！");
                return;
            }
            if (txb_Phone.Text.Trim()=="")
            {
                MessageBox.Show("电话不能为空！");
                this.txb_Phone.Focus();
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText=
                "INSERT tb_User(ID,Password,Name,Gender,Phone) VALUES(@ID, HASHBYTES('MD5',@Password), @Name, @Gender , @Phone)";
            sqlCommand.Parameters.AddWithValue("@ID", this.txb_ID.Text.Trim());                    
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlCommand.Parameters.AddWithValue("@Name", txb_Name.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", txb_Phone.Text);
            if (rdb_Female.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", '女');
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Gender", '男');
            }

            int rowAffected = 0;                                                                        
            try                                                                                         
            {
                sqlConnection.Open();                                                                  
                rowAffected = sqlCommand.ExecuteNonQuery();                                             
            }
            catch (SqlException sqlEx)                                                                 
            {
                if (sqlEx.Number == 2627)                                                              
                {
                    MessageBox.Show("您注册的用户号已存在，请重新输入！\n");									
                }
            }
            finally                                                                                    
            {
                sqlConnection.Close();                                                                  
            }
            if (rowAffected == 1)                                                                      
            {
                MessageBox.Show("注册成功。");
                Close();
            }
            else                                                                                       
            {
                MessageBox.Show("注册失败！");															
            }

        }
    }
}
