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
    public partial class frm_Appointment : Form
    {
        string no;
        public frm_Appointment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dtp_AppointmentTime.MinDate = DateTime.Now;
            dtp_AppointmentTime.MaxDate = DateTime.Now.AddDays(7);
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
            this.cmb_DepartmentSelection.DisplayMember = "Indication";
            cmb_DepartmentSelection.ValueMember = "No";
            this.cmb_DepartmentSelection.DataSource = indicationTable;
            cmb_DepartmentSelection.SelectedIndex = 0;
            sqlConnection.Close();
        }
        public frm_Appointment(string no) : this()
        {
            this.no = no;
            updateAppointment();
        }

        public void updateAppointment()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable appointTable = new DataTable();

            sqlCommand.CommandText
                = "SELECT I.Indication,D.Name,O.OrderTime FROM dbo.tb_Order AS O JOIN dbo.tb_Doctor AS D ON D.DoctorNo = O.DoctorNo JOIN dbo.tb_Indications AS I ON I.No=D.IndicationNo WHERE O.UserID=@UserID";

            sqlCommand.Parameters.AddWithValue("@UserID", no);
            sqlConnection.Open();
            sqlDataAdapter.Fill(appointTable);
            sqlConnection.Close();
            dgv_Appointment.DataSource = appointTable;
            dgv_Appointment.Columns["Indication"].HeaderText = "科室";
            dgv_Appointment.Columns["Name"].HeaderText = "医生姓名";
            dgv_Appointment.Columns["OrderTime"].HeaderText = "预约时间";
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "SELECT * FROM dbo.tb_Order WHERE UserID=@UserID AND DoctorNo=@DoctorNo";
            sqlCommand.Parameters.AddWithValue("@UserID", no);
            sqlCommand.Parameters.AddWithValue("@DoctorNo", cmb_DoctorSelection.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@OrderTime", dtp_AppointmentTime.Value.ToShortDateString());
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                MessageBox.Show("已存在预约记录");
                return;
            }
            sqlConnection.Close();
            sqlCommand.CommandText =
                "INSERT dbo.tb_Order (DoctorNo,UserID,OrderTime) VALUES (@DoctorNo,@UserID,@OrderTime )";
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBox.Show("预约成功！");
                updateAppointment();
            }
            else
            {
                MessageBox.Show("预约失败！");
            }
            sqlConnection.Close();
        }

        private void cmb_DepartmentSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM tb_Doctor WHERE IndicationNo=@Indications;";
            sqlCommand.Parameters.AddWithValue("@Indications", (int)cmb_DepartmentSelection.SelectedValue);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable indicationTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(indicationTable);
            this.cmb_DoctorSelection.DisplayMember = "Name";
            cmb_DoctorSelection.ValueMember = "DoctorNo";
            this.cmb_DoctorSelection.DataSource = indicationTable;
            sqlConnection.Close();



        }

    }
}

