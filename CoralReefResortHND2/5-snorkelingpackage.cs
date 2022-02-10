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
    public partial class frmSnorkeling : Form
    {
        string Customerpath = @"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingCust.txt";         //path for textfile customer in snorkeling
        string Snorkelingpath = @"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingBook.txt";       //path for textfile booking package snorkeling
        string Pricepath = @"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingPrice.txt";           //path for textfile total priice all customer
        

        Customer myCustomer;       //class object
        Snorkeling mySnorkeling;   //class object
        
        public frmSnorkeling()
        {
            InitializeComponent();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" && txtLName.Text != "" && txtMyKad.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPhoneNo.Text != "") 
            {
                //object         class
                myCustomer = new Customer();

                myCustomer.FName = txtFName.Text;
                myCustomer.LName = txtLName.Text;
                myCustomer.MyKad = txtMyKad.Text;
                myCustomer.Address = txtAddress.Text;
                myCustomer.Email = txtEmail.Text;
                myCustomer.PhoneNo = txtPhoneNo.Text;

                SaveToCustomer(Customerpath);  //the data input will save at customer path that have been set
            }
            else if (txtFName.Text == "" || txtLName.Text == "" || txtMyKad.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please Fill In All The Information Needed", "ALERT");    // error hadling occur for user that did not fill in all the information needed
            }
        }
        bool SaveToCustomer(string Customerpath)
        {
            if (!File.Exists(Customerpath))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(Customerpath))
                {
                    string Line = CustomerToLine(myCustomer);
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(Customerpath))
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

            MessageBox.Show("Your Pesonal Information Is Successfully Saved", "Dear Customer");      // error handling occur for user that did not fill in all the information needed

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
                MessageBox.Show("Please Fill In All The Information Needed", "ALERT"); // error handling occur for user that did not fill in all the information needed
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            mySnorkeling = new Snorkeling();
            mySnorkeling.Package = "";

            try
            {
                if (txtFName.Text != "" && txtLName.Text != "" && txtMyKad.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPhoneNo.Text != "")
                {
                    //when user select the checkbox this if else statement will execute one by one to check which one have been tick by user

                    if (chkTwinDay.Checked == true || chkTripleDay.Checked == true || chkQuadDay.Checked == true)
                    {

                        if (chkTwinDay.Checked == true)
                        {
                            mySnorkeling.RoomType = "Twin";
                            mySnorkeling.Quantity = int.Parse(cboTwinDay.Text);
                            mySnorkeling.SetRoomPriceWeekday(); //invoke method of weekday calculation
                        }
                        if (chkTripleDay.Checked == true)
                        {
                            mySnorkeling.RoomType = "Triple";
                            mySnorkeling.Quantity = int.Parse(cboTripleDay.Text);
                            mySnorkeling.SetRoomPriceWeekday(); //invoke method of weekday calculation
                        }
                        if (chkQuadDay.Checked == true)
                        {
                            mySnorkeling.RoomType = "Quad";
                            mySnorkeling.Quantity = int.Parse(cboQuadDay.Text);
                            mySnorkeling.SetRoomPriceWeekday(); //invoke method of weekday calculation
                        }

                        mySnorkeling.Package = "Weekday                "; 
                    }

                    if (chkTwinEnd.Checked == true || chkTripleEnd.Checked == true || chkQuadEnd.Checked == true)
                    {
                        if (chkTwinEnd.Checked == true)
                        {
                            mySnorkeling.RoomType = "Twin";
                            mySnorkeling.Quantity = int.Parse(cboTwinEnd.Text);
                            mySnorkeling.SetRoomPriceWeekend(); //invoke method of weekend calculation
                        }
                        if (chkTripleEnd.Checked == true)
                        {
                            mySnorkeling.RoomType = "Triple";
                            mySnorkeling.Quantity = int.Parse(cboTripleEnd.Text);
                            mySnorkeling.SetRoomPriceWeekend(); //invoke method of weekend calculation
                        }
                        if (chkQuadEnd.Checked == true)
                        {
                            mySnorkeling.RoomType = "Quad";
                            mySnorkeling.Quantity = int.Parse(cboQuadEnd.Text);
                            mySnorkeling.SetRoomPriceWeekend(); //invoke method of weekend calculation
                        }
                        if (mySnorkeling.Package != "")
                        {
                            mySnorkeling.Package = "Weekday and Weekend";
                        }
                        else if (mySnorkeling.Package == "")
                        {
                            mySnorkeling.Package = "Weekend                    ";
                        }
                    }                   
                        txtPrice.Text = Convert.ToString(mySnorkeling.Totalprice) + (".00"); //display price in textbox price
                }
                else if (txtFName.Text == "" || txtLName.Text == "" || txtMyKad.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNo.Text == "")
                {
                    MessageBox.Show("Please Fill In All The Information Needed Before Making Any Booking", "ALERT"); //error handling occur for user that did not fill in the information needed but directly make the booking section
                }
                }

                catch (Exception)
                {
                    MessageBox.Show("Please enter your quantity", "ALERT");  //error handling occur for user that did not input quantity but already tick the package
                }
            
        }
        private void btnNBook_Click_1(object sender, EventArgs e)
        {
            chkTwinDay.CheckState = CheckState.Unchecked;
            cboTwinDay.SelectedIndex = -1;
            chkTripleDay.CheckState = CheckState.Unchecked;
            cboTripleDay.SelectedIndex = -1;
            chkQuadDay.CheckState = CheckState.Unchecked;
            cboQuadDay.SelectedIndex = -1;
            chkTwinEnd.CheckState = CheckState.Unchecked;
            cboTwinEnd.SelectedIndex = -1;
            chkTripleEnd.CheckState = CheckState.Unchecked;
            cboTripleEnd.SelectedIndex = -1;
            chkQuadEnd.CheckState = CheckState.Unchecked;
            cboQuadEnd.SelectedIndex = -1;
            txtPrice.Text = null;
            listDetailBooking.Items.Clear();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

        private void btnSaveBook_Click_1(object sender, EventArgs e)
        {
            SaveToSnorkeling(Snorkelingpath);
            SaveToPrice(Pricepath);

        }
        bool SaveToSnorkeling(string Snorkelingpath)
        {
            if (!File.Exists(Snorkelingpath))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(Snorkelingpath))
                {
                    string Line = SnorkelingToLine(mySnorkeling);
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(Snorkelingpath))
                {
                    string Line = SnorkelingToLine(mySnorkeling);
                    file.WriteLine(Line);
                }

            

            return true;
        }
        string SnorkelingToLine(Snorkeling mySnorkeling)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(mySnorkeling.Package);
            sb.Append("\t\t\t");
            sb.Append(mySnorkeling.TotalQuantityWeekday);
            sb.Append("\t\t\t");
            sb.Append(mySnorkeling.TotalQuantityWeekend);
            sb.Append("\t\t\t");
            sb.Append(mySnorkeling.Totalprice);
            
            Debug.WriteLine(sb.ToString());

            MessageBox.Show("The booking have been successfully saved", "Dear Customer");

            return sb.ToString();
        }
        bool SaveToPrice(string Pricepath)
        {
            if (!File.Exists(Pricepath))
            {
                // Create a file to write to. 
                using (StreamWriter file = File.CreateText(Pricepath))
                {
                    string Line = PriceToLine(mySnorkeling);
                    file.WriteLine(Line);
                }
            }
            else
                // This text is always added, making the file longer over time 
                // if it is not deleted. 
                using (StreamWriter file = File.AppendText(Pricepath))
                {
                    string Line = PriceToLine(mySnorkeling);
                    file.WriteLine(Line);
                }

            

            return true;
        }
        string PriceToLine(Snorkeling mySnorkeling)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(mySnorkeling.Totalprice);


            Debug.WriteLine(sb.ToString());


            return sb.ToString();
        }
        private void btnReceipt_Click_2(object sender, EventArgs e)
        {
            listDetailBooking.Items.Add("\t\t\t\t\t\t           WELCOME TO          ");
            listDetailBooking.Items.Add("\t\t\t\t\t\t     CORAL REEF RESORT          ");
            listDetailBooking.Items.Add("\t\t\t\t\t   HAVE A GLORIUS DAY IN REDANG ISLAND          ");
            listDetailBooking.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            string custinfo = "Name \t\t\tMyKad/(IC) \t\tAddress \t\t\tEmail \t\t\t\tPhone Number";
            string snorkelingpack = "Package \t\t\tQuantity of weekday \tQuantity of weekend \t\tTotal price (RM)";
            listDetailBooking.Items.Add(custinfo);
            string snorbook = "";
            string cust = "";
            int loop = 0;

            string[] customer = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingCust.txt");

            foreach (string line in customer)
            {
                loop++;
                cust = line;
            }
            listDetailBooking.Items.Add(cust);
            listDetailBooking.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            listDetailBooking.Items.Add(snorkelingpack);
            string[] snor = File.ReadAllLines(@"C:\\Users\\amie\\Desktop\\oop saya\\Coral Reef Resort\\SnorkelingBook.txt");

            foreach (string line in snor)
            {
                loop++;
                snorbook = line;
            }
            listDetailBooking.Items.Add(snorbook);
            listDetailBooking.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            listDetailBooking.Items.Add("\t\t\t\t\t\t    Thank you for your business          ");
            listDetailBooking.Items.Add("\t\t\t\t\t\t           Have a nice day :)          ");
        }   
    }
}
