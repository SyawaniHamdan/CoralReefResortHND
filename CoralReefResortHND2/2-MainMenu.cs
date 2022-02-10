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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //user need to select one of the option offer to open the prefer form
        private void btnClick_Click(object sender, EventArgs e)  
        {
            if (rdbBookPack.Checked == true)
            {
                frmInfo open = new frmInfo();
                open.Show();
                this.Hide();
            }
            else if (rdbViewReport.Checked == true)
            {
                frmReportMenu open = new frmReportMenu();
                open.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Choose Either Booking Package or View Report", "ALERT!");    //error handling occur when user directly click here aand did not select one of the option given 
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

        private void lblResort_Click(object sender, EventArgs e)
        {

        }

        private void lblQuote_Click(object sender, EventArgs e)
        {

        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {

        }
    }
}
