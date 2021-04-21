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
    public partial class frm_Doctor : Form
    {
        string doctorNo,Name,IndicationNo;
        public frm_Doctor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出", "退出", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        public frm_Doctor(string no):this()
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
        }
        private void 锁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enabled = false;
            frm_Lock frm_Lock = new frm_Lock(doctorNo,Name);
            if (frm_Lock.ShowDialog() == DialogResult.OK)
            {
                Enabled = true;
            }
            else
            {
                Close();
            }
        }
    }
}
