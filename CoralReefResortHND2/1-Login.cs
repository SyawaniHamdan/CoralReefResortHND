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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassWord.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = "123"; //password that must user input to get access

            if (txtUserName.Text != "")
            {
                if (txtPassWord.Text == pass)
                {
                    frmMainMenu open = new frmMainMenu();
                    open.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("THE PASSWORD YOU ENTERED DON'T MATCH, PLEASE TRY AGAIN", "ALERT!");     //error handling when user input wrong password
                    txtPassWord.Text = null;
                    txtUserName.Text = null;
                }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER YOUR USERNAME", "ALERT");
                txtPassWord.Text = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
