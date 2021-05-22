﻿using System;
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
        List<TreeNode> searchtreeNodes;
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

            LoadTreeView();
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
            dgv_Patient.Columns["OrderNo"].HeaderText = "就诊编号";
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
            txb_Age.Text = dgv_Patient.CurrentRow.Cells["Age"].Value.ToString()+"岁";
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
            txb_tab1_Name.Text = txb_PatientName.Text;
            txb_tab1_Gender.Text = txb_Gender.Text;
            txb_tab1_Age.Text = txb_Age.Text;
        }

        private void btn_Admission_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txb_tab1_Name.Text))
            //{
            //    MessageBox.Show("还未选择就诊患者！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadTreeView();
            if (string.IsNullOrEmpty(txb_Search.Text))
            {
                MessageBox.Show("请输入搜索内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            searchtreeNodes = new List<TreeNode>();
            foreach (TreeNode node in tvw_Diseases.Nodes)    
            {
                SearchLayer(node, this.txb_Search.Text);
            }
            for (int i = 0; i < searchtreeNodes.Count; i++)
            {
                TreeNode temp = searchtreeNodes[i];
                ExpandNode(temp);
                if (i == 0 && temp.Parent != null)
                {
                    tvw_Diseases.SelectedNode = temp.Parent;
                }
                temp.BackColor = Color.Yellow;
            }
        }

        private void SearchLayer(TreeNode node, string name)
        {
            if (node.Nodes.Count != 0)
            {
                for (int i = 0; i < node.Nodes.Count; i++)
                {
                    SearchLayer(node.Nodes[i], name);
                }
            }
            else if (string.Equals(node.Text, name) || node.Text.Contains(name))
            {
                searchtreeNodes.Add(node);
            }
        }

        private void ExpandNode(TreeNode node)
        {
            if (node.Parent != null)
            {
                node.Parent.Expand();
                ExpandNode(node.Parent);
            }
        }

        private void tabC_Diagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabC_Diagnosis.SelectedTab != tabC_Diagnosis.TabPages[0] && string.IsNullOrEmpty(txb_tab1_Name.Text))
            {
                MessageBox.Show("还未选择就诊患者！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabC_Diagnosis.SelectedTab = tabC_Diagnosis.TabPages[0];
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

        public void LoadTreeView()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
            ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "SELECT * FROM dbo.tb_Indications;"
                + "SELECT * FROM dbo.tb_Diseases;";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            DataTable indicationsTable = dataSet.Tables[0];
            DataTable diseasesTable = dataSet.Tables[1];
            DataRelation dataRelation = 
                new DataRelation("Indication_Disease", indicationsTable.Columns["No"], diseasesTable.Columns["IndicationNo"], false);
            dataSet.Relations.Add(dataRelation);
            //↑有点浪费
            tvw_Diseases.Nodes.Clear();
            foreach (DataRow indicationRow in indicationsTable.Rows)
            {
                TreeNode indicationNode = new TreeNode();
                indicationNode.Text = indicationRow["Indication"].ToString();
                tvw_Diseases.Nodes.Add(indicationNode);
                foreach (DataRow diseaseRow in indicationRow.GetChildRows("Indication_Disease"))
                {
                    TreeNode diseaseNode = new TreeNode();
                    diseaseNode.Text = diseaseRow["DiseaseName"].ToString();
                    indicationNode.Nodes.Add(diseaseNode);
                }
            }
        }
    }
}
