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
using static System.Environment;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace OutpatientSystem
{
    public partial class frm_MyImformation : Form
    {
        public frm_MyImformation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_MyImformation(string no) :this()
        {
            txb_No.Text = no;
            FormLoad();
            dtp_Birthday.MaxDate = DateTime.Now;
        }

        private void FormLoad()
        {//连接数据库
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_User WHERE ID=@ID;";
            sqlCommand.Parameters.AddWithValue("@ID", txb_No.Text);
            sqlConnection.Open();
            byte[] photoBytes = null;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                if (sqlDataReader["Birthday"]!=DBNull.Value)
                {
                    this.dtp_Birthday.Value = (DateTime)sqlDataReader["Birthday"];
                }
                this.txb_No.Text = sqlDataReader["ID"].ToString();
                this.txb_Name.Text = sqlDataReader["Name"].ToString();
                this.rdb_Male.Checked = (sqlDataReader["Gender"].ToString() == "男");
                this.rdb_Female.Checked = !rdb_Male.Checked;
                this.txb_Phone.Text = sqlDataReader["Phone"].ToString();
                photoBytes =
                    (sqlDataReader["Photo"] == DBNull.Value ? null : (byte[])sqlDataReader["Photo"]);

            }
            sqlDataReader.Close();
            if (photoBytes != null)
            {
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.ptb_Photo.Image = Image.FromStream(memoryStream);
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            this.ptb_Photo.Image.Save(memoryStream, ImageFormat.Bmp);
            byte[] photoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.Read(photoBytes, 0, photoBytes.Length);
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "UPDATE tb_User"
                + " SET Name=@Name,Gender=@Gender,Phone=@Phone,Birthday=@Birthday,Photo=@Photo"
                + " WHERE ID=@ID;";
            if (rdb_Female.Checked)
            {
                sqlCommand.Parameters.AddWithValue("@Gender", '女');
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Gender", '男');
            }
            sqlCommand.Parameters.AddWithValue("@Name", txb_Name.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Phone", txb_Phone.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@ID", txb_No.Text);
            sqlCommand.Parameters.AddWithValue("@Birthday", this.dtp_Birthday.Value);
            sqlCommand.Parameters.AddWithValue("@Photo", photoBytes);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowAffected>0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("未进行任何修改");
            }
        }

        private void btn_OpenPhoto_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog openPhotoDialog = new OpenFileDialog()
                {
                    Title = "打开照片文件"
                ,
                    Filter = "图像文件|*.bmp;*.jpg"
                ,
                    InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
                };
                if (openPhotoDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openPhotoDialog.FileName;
                    this.ptb_Photo.Image = Image.FromFile(fileName);
                }

            }
                ));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
