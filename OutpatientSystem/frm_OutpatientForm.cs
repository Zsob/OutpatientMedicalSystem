using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientSystem
{
    public partial class frm_OutpatientForm : Form
    {
        public frm_OutpatientForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frm_OutpatientForm(string No):this()
        {
            txb_Message.Text = No;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            frm_Appointment appointment = new frm_Appointment(txb_Message.Text);
            appointment.FormClosed += formClosed;
            Hide();
            appointment.Show();
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            frm_MyImformation imformation = new frm_MyImformation(txb_Message.Text);
            imformation.FormClosed += formClosed;
            Hide();
            imformation.Show();
        }
    }
}
