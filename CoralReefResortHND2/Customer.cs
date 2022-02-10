using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralReefResortHND2
{
    class Customer
    {
        //declaration variable
        private string _fName;
        private string _lName;
        private string _myKad;
        private string _address;
        private string _email;
        private string _phoneNo;

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }
        public string MyKad
        {
            get { return _myKad; }
            set { _myKad = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        public Customer()
        { }
        public Customer(string newFName, string newLName, string newMyKad, string newAddress, string newEmail, string newPhoneNo)
        {
            _fName = newFName;
            _lName = newLName;
            _myKad = newMyKad;
            _address = newAddress;
            _email = newEmail;
            _phoneNo = newPhoneNo;
        }
    }
}
