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
    public partial class frm_Settlement : Form
    {
        string No;
        decimal balance,usebalance;
        public frm_Settlement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_Settlement(string No):this()
        {
            this.No = No;
            refreshForm();

        }

        private void refreshForm()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=HospitalBase;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@" SELECT D.MedicalName,DrugFrequency,DrugUsage,MedicineNumber,M.Price,D.MedicineNumber*M.Price AS S FROM dbo.tb_DoctorOrder AS D JOIN dbo.tb_Medicines AS M ON M.MedicalName = D.MedicalName WHERE UserID={No} AND D.Stage=0; ";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            sqlCommand1.CommandText =
                    "SELECT Balance FROM tb_User WHERE ID=@ID;";
            sqlCommand1.Parameters.AddWithValue("@ID", No);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable OrderTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(OrderTable);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            if (sqlDataReader.Read())
            {
                balance = (decimal)sqlDataReader["Balance"];
                lbl_CurrentAmount.Text = "当前余额：" + sqlDataReader["Balance"].ToString() + "元";
            }
            sqlConnection.Close();
            dgv_AmountPayable.DataSource = OrderTable;
            dgv_AmountPayable.Columns[0].HeaderText = "药品名称";
            dgv_AmountPayable.Columns[2].HeaderText = "用量";
            dgv_AmountPayable.Columns[3].HeaderText = "数量";
            dgv_AmountPayable.Columns[1].HeaderText = "用药频次";
            dgv_AmountPayable.Columns[4].HeaderText = "价格";
            dgv_AmountPayable.Columns[5].HeaderText = "合计";
            if (dgv_AmountPayable.Rows.Count!=0)
            {
                usebalance = Convert.ToDecimal(OrderTable.Compute("Sum(S)", ""));
            }
            else
            {
                usebalance = 0;
            }
            lbl_AmountPayable.Text = "需付款：" + $@"{usebalance}" + "元";
        }

        private void 充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Charge frm_Charge = new frm_Charge(No);
            frm_Charge.FormClosed += Frm_Charge_FormClosed;
            Hide();
            frm_Charge.Show();
        }

        private void Frm_Charge_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshForm();
            this.Show();
        }

        private void btn_Settlement_Click(object sender, EventArgs e)
        {
            if (balance<usebalance)
            {
                MessageBox.Show("余额不足！请充值！");
                return;
            }
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "UPDATE dbo.tb_User SET Balance=@Balance WHERE ID=@ID";
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.Connection = sqlConnection;
            sqlCommand1.CommandText =
                $@"UPDATE dbo.tb_DoctorOrder SET Stage='1' WHERE UserID={No}";
            sqlCommand.Parameters.AddWithValue("@ID", No);
            balance = balance - usebalance;
            sqlCommand.Parameters.AddWithValue("@Balance", balance);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("结算成功!请前往取药窗口取药");
            refreshForm();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
