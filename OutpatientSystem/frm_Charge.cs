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
    public partial class frm_Charge : Form
    {
        private string no;
        private decimal balance=0;
        public frm_Charge()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frm_Charge(string no):this()
        {
            this.no = no;
            updateBalance();
        }


        public void updateBalance()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                    "SELECT Balance FROM tb_User WHERE ID=@ID;";
            sqlCommand.Parameters.AddWithValue("@ID", no);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                balance = (decimal)sqlDataReader["Balance"];
                lbl_CurrentBalance.Text = sqlDataReader["Balance"].ToString() + "元";
            }
            sqlConnection.Close();
        }

        private void btn_OneHundred_Click(object sender, EventArgs e)
        {
            txb_Money.Text = "100";
        }

        private void btn_TwoHundred_Click(object sender, EventArgs e)
        {
            txb_Money.Text = "200";
        }

        private void btn_FiveHundred_Click(object sender, EventArgs e)
        {
            txb_Money.Text = "500";
        }

        private void btn_Recharge_Click(object sender, EventArgs e)
        {
            if (txb_Money.Text == "")
            {
                MessageBox.Show("请输入金额");
                txb_Money.Focus();
                return;
            }
            if (rdb_Alipay.Checked == false && rdb_BankCard.Checked == false && rdb_WeChat.Checked == false)
            {
                MessageBox.Show("请选择支付方式");
                return;
            }
            if (txb_Money.Text=="0")
            {
                MessageBox.Show("未输入充值金额");
                txb_Money.Focus();
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "UPDATE dbo.tb_User SET Balance=@Balance WHERE ID=@ID";
            sqlCommand.Parameters.AddWithValue("@ID", no);
            balance = balance + Convert.ToDecimal(txb_Money.Text);
            sqlCommand.Parameters.AddWithValue("@Balance", balance);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show("充值成功");
                lbl_CurrentBalance.Text = balance.ToString();
                txb_Money.Text = "";
            }
        }

        private void tbr_Money_Scroll(object sender, EventArgs e)
        {
            txb_Money.Text=tbr_Money.Value.ToString();
        }

        private void txb_Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char result = e.KeyChar;
            if (char.IsDigit(result) || result == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txb_Money_TextChanged(object sender, EventArgs e)
        {
            if (txb_Money.Text == "")
            {
                txb_Money.Text = "0";
            }
            if (Convert.ToInt32(txb_Money.Text)>1000)
            {
                tbr_Money.Value = 1000;
                return;
            }
            tbr_Money.Value = Convert.ToInt32(txb_Money.Text);
        }
    }
}
