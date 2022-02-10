using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoralReefResortHND2
{
    public partial class frmReportSnor : Form
    {
        public frmReportSnor()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listReport.Items.Add("\t\t\t\t\t\t           WELCOME TO          ");
            listReport.Items.Add("\t\t\t\t\t\t     CORAL REEF RESORT          ");
            listReport.Items.Add("\t\t\t\t\t   HAVE A GLORIUS DAY IN REDANG ISLAND          ");
            listReport.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            string custinfo = "Name \t\t\tMyKad/(IC) \t\tAddress \t\t\tEmail \t\t\t\tPhone Number";
            string snorkelingpack = "Package \t\t\tQuantity of weekday \tQuantity of weekend \t\tTotal price (RM)";
            listReport.Items.Add(custinfo);
            string snorbook = "";
            string cust = "";
            int loop = 0;
            int totalcharge = 0;

            string[] customer = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingCust.txt");

            foreach (string line in customer)
            {
                loop++;
                cust = line;
                listReport.Items.Add(cust);
            }

            listReport.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");


            listReport.Items.Add(snorkelingpack);
            string[] snor = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingBook.txt");

            foreach (string line in snor)
            {
                loop++;
                snorbook = line;
                listReport.Items.Add(snorbook);
            }
            string[] price = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingPrice.txt");

            foreach (string line in price)
            {
                loop++;
                totalcharge = totalcharge + int.Parse(line);
                
            }
            listReport.Items.Add("\n");
            listReport.Items.Add("Total Charge : RM " + Convert.ToString(totalcharge));
            listReport.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listReport.Items.Add("\t\t\t\t\t\t    Thank you for your business          ");
            listReport.Items.Add("\t\t\t\t\t\t           Have a nice day :)          ");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

    }
}

