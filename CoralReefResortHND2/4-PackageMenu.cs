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
    public partial class frmPackageMenu : Form
    {
        public frmPackageMenu()
        {
            InitializeComponent();
        }

        //user need to selct one of the option offered to open prefer form
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (rdbSnorPack.Checked == true)
            {
                frmSnorkeling open = new frmSnorkeling();
                open.Show();
                this.Hide();
            }
            else if (rdbDivPack.Checked == true)
            {
                frmDiving open = new frmDiving();
                open.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Please Choose Either Snorkeling Package or Diving Package", "ALERT!");  //error handing occur for user directly click here button but did not select one of the option given 
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
