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
using System.IO;

namespace OutpatientSystem
{
    public partial class frm_Doctor : Form
    {
        string doctorNo, Name, IndicationNo;
        public frm_Doctor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_Doctor(string no) : this()
        {
            doctorNo = no;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=HospitalBase;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT * FROM dbo.tb_Doctor WHERE DoctorNo={doctorNo}";
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Name = sqlDataReader["Name"].ToString();
                IndicationNo = sqlDataReader["IndicationNo"].ToString();
            }
            sqlConnection.Close();
            refreshData();
            
            fillInformation();
        }

        public void refreshData()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=(local);Database=HospitalBase;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlCommand.CommandText = 
                $@"SELECT O.OrderNo,O.UserID,U.Name,U.Gender,YEAR(GETDATE())-YEAR(U.Birthday) AS Age,U.Phone,O.OrderTime,O.Noon,O.DoctorNo,U.Photo FROM dbo.tb_Order AS O JOIN dbo.tb_User AS U ON O.UserID=U.ID WHERE DoctorNo={doctorNo} ORDER BY O.Noon ASC";
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_Patient.DataSource = dataTable;
            dgv_Patient.Columns["OrderNo"].HeaderText = "订单编号";
            dgv_Patient.Columns["UserID"].HeaderText = "患者编号";
            dgv_Patient.Columns["Name"].HeaderText ="姓名";
            dgv_Patient.Columns["Gender"].Visible = false;
            dgv_Patient.Columns["Phone"].Visible = false;
            dgv_Patient.Columns["OrderTime"].HeaderText = "预约时间";
            dgv_Patient.Columns["Age"].Visible = false;
            dgv_Patient.Columns["Noon"].HeaderText = "午别";
            dgv_Patient.Columns["DoctorNo"].Visible = false;
            dgv_Patient.Columns["Photo"].Visible = false;
            this.dgv_Patient.Columns[this.dgv_Patient.Columns.Count - 3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void fillInformation()
        {
            if (dgv_Patient.CurrentRow==null)
            {
                return;
            }
            txb_Gender.Text = dgv_Patient.CurrentRow.Cells["Gender"].Value.ToString();
            txb_Phone.Text= dgv_Patient.CurrentRow.Cells["Phone"].Value.ToString();
            txb_Age.Text = dgv_Patient.CurrentRow.Cells["Age"].Value.ToString();
            txb_PatientName.Text= dgv_Patient.CurrentRow.Cells["Name"].Value.ToString();
            if (dgv_Patient.CurrentRow.Cells["Photo"].Value != DBNull.Value)
            {
                byte[] photoBytes = (byte[])dgv_Patient.CurrentRow.Cells["Photo"].Value;
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.ptb_Photo.Image = Image.FromStream(memoryStream);
            }
            else
            {
                ptb_Photo.Image = null;
            }
        }

        private void 更改操作员口令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChangePassword frm_ChangePassword = new frm_ChangePassword(doctorNo,1);
            frm_ChangePassword.FormClosed += FormClose;
            Hide();
            frm_ChangePassword.Show();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void dgv_Patient_Click(object sender, EventArgs e)
        {
            fillInformation();
        }

        private void btn_Admission_Click(object sender, EventArgs e)
        {
            tabC_Diagnosis.SelectedTab = tabC_Diagnosis.TabPages[1];
        }

        private void 锁定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Enabled = false;
            frm_Lock frm_Lock = new frm_Lock(doctorNo, Name);
            if (frm_Lock.ShowDialog() == DialogResult.OK)
            {
                Enabled = true;
            }
            else
            {
                Close();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出工作台吗？", "医生门诊工作站", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }


    }
}
