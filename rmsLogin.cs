using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class rmsLogin : Form
    {
        public rmsLogin()
        {
            InitializeComponent();
        }

        private void rmsLogin_Load(object sender, EventArgs e)
        {
            grpRFIDLogin.Visible = false;
            grpPassLogin.Visible = true;
            tboxUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelRFID_Click(object sender, EventArgs e)
        {
            grpRFIDLogin.Visible = true;
            grpPassLogin.Visible = false;
            tboxPassword.Clear();
            tboxUsername.Clear();
            tboxRFID.Focus();
        }

        private void labelPass_Click(object sender, EventArgs e)
        {
            grpRFIDLogin.Visible = false;
            grpPassLogin.Visible = true;
            tboxRFID.Clear();
            tboxUsername.Focus();
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked == true)
            {
                tboxPassword.UseSystemPasswordChar = false;
                tboxPassword.Focus();
            }
            else
            {
                tboxPassword.UseSystemPasswordChar = true;
                tboxPassword.Focus();
            }
        }

    }
}
