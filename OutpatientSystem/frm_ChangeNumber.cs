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
    public partial class frm_ChangeNumber : Form
    {
        string OrderNo;
        public frm_ChangeNumber()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM dbo.tb_Indications;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable indicationTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(indicationTable);
            this.cmb_Indication.DisplayMember = "Indication";
            cmb_Indication.ValueMember = "No";
            this.cmb_Indication.DataSource = indicationTable;
            cmb_Indication.SelectedIndex = 0;
            sqlConnection.Close();
            //int findID = combobox1.FindString(string1);
            //if (findID > 0)
            //    combobox1.SelectedItem = combobox1.Items[findID];
        }
        public frm_ChangeNumber(string IndicationName, string doctorName ,DateTime time,string noon,string ID,string name,string gender,string  age,string orderNo):this()
        {
            cmb_OldIndication.Items.Add(IndicationName);
            cmb_OldIndication.SelectedIndex = 0;
            cmb_OldDoctor.Items.Add(doctorName);
            cmb_OldDoctor.SelectedIndex = 0;
            dtp_OldDate.Value = time;
            cmb_OldNoon.Items.Add(noon);
            cmb_OldNoon.SelectedIndex = 0;
            cmb_Noon.SelectedIndex = 0;
            txb_Account.Text = ID;
            txb_Age.Text = age;
            txb_Gender.Text = gender;
            txb_Name.Text = name;
            this.OrderNo = orderNo;
            dtp_Date.MinDate = DateTime.Now;
            dtp_Date.MaxDate = DateTime.Now.AddDays(7);

        }

        private void cmb_Indication_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Doctor WHERE IndicationNo=@Indications;";
            sqlCommand.Parameters.AddWithValue("@Indications", (int)cmb_Indication.SelectedValue);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable indicationTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(indicationTable);
            this.cmb_Doctor.DisplayMember = "Name";
            cmb_Doctor.ValueMember = "DoctorNo";
            this.cmb_Doctor.DataSource = indicationTable;
            sqlConnection.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"UPDATE dbo.tb_Order SET DoctorNo=@DoctorNo,OrderTime=@OrderTime,Noon=@Noon WHERE OrderNo={OrderNo}";
            sqlCommand.Parameters.AddWithValue("@DoctorNo", cmb_Doctor.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@OrderTime", dtp_Date.Value.ToShortDateString());
            sqlCommand.Parameters.AddWithValue("@Noon", cmb_Noon.SelectedItem.ToString());
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            sqlConnection.Close();

        }
    }
}
