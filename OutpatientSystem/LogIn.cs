using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace OutpatientSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;                                        
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
            sqlConnection.ConnectionString=ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
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
            }
            else                                                                            
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");								
                this.txb_Password.Focus();                                                  
                this.txb_Password.SelectAll();                                              
            }

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
