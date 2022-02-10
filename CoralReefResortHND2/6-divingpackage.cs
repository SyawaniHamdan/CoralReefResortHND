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
using System.Diagnostics;

namespace CoralReefResortHND2
{
    public partial class frmDiving : Form
    {
        string filepath = @"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingCust.txt";       //path textfile for customer
        string Divingpath = @"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingBook.txt";     // path textfile for booking
        string divepath = (@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingCount.txt");    //path textfile for count

        Customer myCustomer;  //class object
        Diving myDiving;      //class object
        public frmDiving()
        {
            InitializeComponent();
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "" && txtMyKad.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPhoneNo.Text != "")
            {   //object          class
                myCustomer = new Customer();

                myCustomer.FName = txtFName.Text;
                myCustomer.LName = txtLName.Text;
                myCustomer.MyKad = txtMyKad.Text;
                myCustomer.Address = txtAddress.Text;
                myCustomer.Email = txtEmail.Text;
                myCustomer.PhoneNo = txtPhoneNo.Text;



                SaveToFile(filepath);//the data input will save at customer path that have been set
            }
            else if (txtFName.Text == "" || txtLName.Text == "" || txtMyKad.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please Fill In All The Information Needed", "Alert");//error handling occur for user that did not fill in all the information needed
            }
        }
        bool SaveToFile(string Filepath)
        {
            if (!File.Exists(filepath))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = CustomerToLine(myCustomer);
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = CustomerToLine(myCustomer);
                    file.WriteLine(Line);
                }

           

            return true;
        }
        string CustomerToLine(Customer myCustomer)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(myCustomer.FName);
            sb.Append(" ");
            sb.Append(myCustomer.LName);
            sb.Append("\t\t");
            sb.Append(myCustomer.MyKad);
            sb.Append("\t\t");
            sb.Append(myCustomer.Address);
            sb.Append("\t\t");
            sb.Append(myCustomer.Email);
            sb.Append("\t\t");
            sb.Append(myCustomer.PhoneNo);

            Debug.WriteLine(sb.ToString());

            MessageBox.Show("Your Personal Information Is Successfully Saved", "Dear Customer");//error handling occur for user that did not fill in all the information needed

            return sb.ToString();
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            txtFName.Text = null;
            txtLName.Text = null;
            txtMyKad.Text = null;
            txtAddress.Text = null;
            txtEmail.Text = null;
            txtPhoneNo.Text = null;
            listCustomerDetail.Items.Clear();
        }

        private void btnLoadCust_Click(object sender, EventArgs e)
        {
            myCustomer = new Customer();

            if (txtFName.Text != "" && txtLName.Text != "" && txtMyKad.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPhoneNo.Text != "")
            {
                listCustomerDetail.Items.Add("\t           WELCOME TO          ");
                listCustomerDetail.Items.Add("\t     CORAL REEF RESORT          ");
                listCustomerDetail.Items.Add("    HAVE A GLORIUS DAY IN REDANG ISLAND          ");
                listCustomerDetail.Items.Add("--------------------------------------------------------------------------------------------------");
                listCustomerDetail.Items.Add("First Name : " + txtFName.Text);
                listCustomerDetail.Items.Add("Last Name : " + txtLName.Text);
                listCustomerDetail.Items.Add("MyKad (I/C) : " + txtMyKad.Text);
                listCustomerDetail.Items.Add("Address : " + txtAddress.Text);
                listCustomerDetail.Items.Add("Email : " + txtEmail.Text);
                listCustomerDetail.Items.Add("Phone Number : " + txtPhoneNo.Text);
            }
            else if (txtFName.Text == "" || txtLName.Text == "" || txtMyKad.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please Fill In All The Information Needed ", "Alert");//error handling occur for user that did not fill in all the information needed
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            myDiving = new Diving();
            myDiving.Package = "";
            

            try
            {
                if (txtFName.Text != "" && txtLName.Text != "" && txtMyKad.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPhoneNo.Text != "")
                {
                    //when user select the checkbox this if else statement will execute one by one to check which one have been tick by user

                    if (chkShoreDay.Checked == true || chkBoatDay.Checked == true)
                    {
                        if (chkShoreDay.Checked == true)
                        {
                            myDiving.DivType = "Shore";
                            myDiving.Quantity = int.Parse(cboShoreDay.Text);
                            myDiving.SetDivPriceDay(); //invoke method of day calculation
                        }
                        if (chkBoatDay.Checked == true)
                        {
                            myDiving.DivType = "Boat";
                            myDiving.Quantity = int.Parse(cboBoatDay.Text);
                            myDiving.SetDivPriceDay(); //invoke method of day calculation
                        }
                        myDiving.Package = "Day                     ";
                    }
                    if (chkShoreNight.Checked == true || chkBoatNight.Checked == true)
                    {
                        if (chkShoreNight.Checked == true)
                        {
                            myDiving.DivType = "Shore";
                            myDiving.Quantity = int.Parse(cboShoreNight.Text);
                            myDiving.SetDivPriceNight(); //invoke method of night calculation
                        }
                        if (chkBoatNight.Checked == true)
                        {
                            myDiving.DivType = "Boat";
                            myDiving.Quantity = int.Parse(cboBoatNight.Text);
                            myDiving.SetDivPriceNight(); //invoke method of night calculation
                        }
                        if (myDiving.Package != "")
                        {
                            myDiving.Package = "Day and Night";
                        }
                        else if (myDiving.Package == "")
                        {
                            myDiving.Package = "Night                   ";
                        }
                    }

                    if (rdbYes.Checked == true)
                    {
                        myDiving.Equipment = "Yes";
                        myDiving.GetEquipment(); //invoke method of equipment calculation
                        
                    }
                    else if (rdbNo.Checked == true)
                    {
                        myDiving.Equipment = "No";
                        myDiving.GetEquipment(); //invoke method of equipment calculation
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Select Either Yes or No for Equipment Rental", "Alert"); //error handling for user that did not select one of the option for equipment rental
                    }

                    txtPrice.Text = Convert.ToString(myDiving.Totalprice); //display price in textbox price
                    
                }
                else if (txtFName.Text == "" || txtLName.Text == "" || txtMyKad.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNo.Text == "")
                {
                    MessageBox.Show("Please Fill In All The Information Needed Before Making Any Booking", "Alert");//error handling occur for user that did not input quantity but already tick the package
                }
                            
            }
            catch (Exception)

            { MessageBox.Show("Please enter your quantity", "Alert"); } //error handling occur for user that did not input quantity of the selected package
        }

        private void btnNBook_Click_1(object sender, EventArgs e)
        {
            chkShoreDay.CheckState = CheckState.Unchecked;
            cboShoreDay.SelectedIndex = -1;
            chkBoatDay.CheckState = CheckState.Unchecked;
            cboBoatDay.SelectedIndex = -1;
            chkShoreNight.CheckState = CheckState.Unchecked;
            cboShoreNight.SelectedIndex = -1;
            chkBoatNight.CheckState = CheckState.Unchecked;
            cboBoatNight.SelectedIndex = -1;
            txtPrice.Text = null;
            listDetailBooking.Items.Clear();
            rdbYes.Checked = false;
            rdbNo.Checked = false;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

        private void btnReceipt_Click_1(object sender, EventArgs e)
        {
            listDetailBooking.Items.Add("\t\t\t\t\t\t           WELCOME TO          ");
            listDetailBooking.Items.Add("\t\t\t\t\t\t     CORAL REEF RESORT          ");
            listDetailBooking.Items.Add("\t\t\t\t\t   HAVE A GLORIUS DAY IN REDANG ISLAND          ");
            listDetailBooking.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            string custinfo = "Name \t\t\tMyKad/(IC) \t\tAddress \t\t\tEmail \t\t\t\tPhone Number";
            string divingpack = "Package \t\t\tQuantity of day \t\tQuantity of night \t\t             Rental \t\t     Total price (RM)";
            listDetailBooking.Items.Add(custinfo);
            string div = "";
            string cust = "";
            int loop = 0;

            string[] customer = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingCust.txt");

            foreach (string line in customer)
            {
                loop++;
                cust = line;
            }
            listDetailBooking.Items.Add(cust);
            listDetailBooking.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listDetailBooking.Items.Add(divingpack);
            string[] dive = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\DivingBook.txt");

            foreach (string line in dive)
            {
                loop++;
                div = line;
            }
            listDetailBooking.Items.Add(div);
            
            listDetailBooking.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listDetailBooking.Items.Add("\t\t\t\t\t\t    Thank you for your business          ");
            listDetailBooking.Items.Add("\t\t\t\t\t\t           Have a nice day :)          ");
        }


        private void btnSaveBook_Click_1(object sender, EventArgs e)
        {
            SaveToDiving(Divingpath);
            SaveToCount(divepath);
        }
        bool SaveToDiving(string Divingpath)
        {
            if (!File.Exists(Divingpath))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(Divingpath))
                {
                    string Line = DivingToLine(myDiving);
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(Divingpath))
                {
                    string Line = DivingToLine(myDiving);
                    file.WriteLine(Line);
                }

            return true;
        }
        string DivingToLine(Diving myDiving)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(myDiving.Package);
            sb.Append("\t\t\t");           
            sb.Append(myDiving.QuantityDay);
            sb.Append("\t\t\t");
            sb.Append(myDiving.QuantityNight);
            sb.Append("\t\t\t");
            sb.Append(myDiving.Equipment);
            sb.Append("\t\t\t");
            sb.Append(myDiving.Totalprice);

            Debug.WriteLine(sb.ToString());

            MessageBox.Show("The booking have been successfully saved", "Dear Customer");

            return sb.ToString();
        }

        bool SaveToCount(string divepath)
        {
            if (!File.Exists(divepath))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(divepath))
                {
                    string Line = DiverToCount(myDiving);
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(divepath))
                {
                    string Line = DiverToCount(myDiving);
                    file.WriteLine(Line);
                }
            return true;
        }
        string DiverToCount(Diving myDiving)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(myDiving.QuantityDay);
            sb.Append(",");
            sb.Append(myDiving.QuantityNight);
         

            Debug.WriteLine(sb.ToString());

            return sb.ToString();
        }
    }
}
