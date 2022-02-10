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
    public partial class frmReportDiv : Form
    {
        int count = 0;
        int countDay = 0;
        int countNight = 0;
        public frmReportDiv()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string diver;
            string divepath = (@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingCount.txt");   //path textfile for count dive

            listReport.Items.Add("\t\t\t\t\t\t           WELCOME TO          ");
            listReport.Items.Add("\t\t\t\t\t\t     CORAL REEF RESORT          ");
            listReport.Items.Add("\t\t\t\t\t   HAVE A GLORIUS DAY IN REDANG ISLAND          ");
            listReport.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            string custinfo = "Name \t\t\tMyKad/(IC) \t\tAddress \t\t\tEmail \t\t\t\tPhone Number";
            string divingpack = "Package \t\tQuantity of day \t\tQuantity of night \t\t             Rental \t\t     Total price (RM)";
           
            listReport.Items.Add(custinfo);

            string div = "";
            string cust = "";            
            int loop = 0;

            string[] customer = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingCust.txt");

            foreach (string line in customer)
            {
                loop++;
                cust = line;
                listReport.Items.Add(cust);
            }
            listReport.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            listReport.Items.Add(divingpack);
            string[] dive = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingBook.txt");

            foreach (string line in dive)
            {
                loop++;
                div = line;
                listReport.Items.Add(div);
            }

            if (System.IO.File.Exists(divepath) == true)
            {
                using (StreamReader reader = new StreamReader(divepath))
                {
                    while (!reader.EndOfStream)
                    {
                        diver = reader.ReadLine();

                        int noDay = 0;
                        int noNight = 0;

                        Parsediver(diver, ref noDay, ref noNight);

                    }
                    listReport.Items.Add("\n");
                    listReport.Items.Add("Total for day divers is : " + countDay);
                    listReport.Items.Add("Total for night divers is : " + countNight);
                    listReport.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listReport.Items.Add("\t\t\t\t\t\t    Thank you for your business          ");
                    listReport.Items.Add("\t\t\t\t\t\t           Have a nice day :)          ");

                }
            }
            else
            {
                MessageBox.Show("File" + divepath + "doesn't exist");
            }

    }
        bool Parsediver(string Text, ref int noDay, ref int noNight)//utk splitkan data by ,
        {

            string[] arr = Text.Split(',');
            if (arr.Length != 2)
                return false;

            noDay = int.Parse(arr[0]);
            noNight = int.Parse(arr[1]);

            countDay = countDay + noDay;
            countNight = countNight + noNight;

            return true;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }
    }  
}
