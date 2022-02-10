using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoralReefResortHND2
{
    public partial class frmReportMenu : Form
    {
        public frmReportMenu()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbReportSnor.Checked == true)
            {
                frmReportSnor open = new frmReportSnor();
                open.Show();
                this.Hide();
            }
            else if (rdbReportDiv.Checked == true)
            {
                frmReportDiv open = new frmReportDiv();
                open.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Choose Either Booking Package or View Report", "ALERT!"); //error handling occur for user that did not choose either package but directly click on button click
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }
    }
}
