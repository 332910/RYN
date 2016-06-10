using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSystem.Class
{
    public class StaffInfo
    {
        private int Staffid;
        private string Firstname;
        private string Lastname;
        private string Dateofbirth;
        private string Address;
        private int Phonenumber;
        private int Bankaccountno;

        public StaffInfo()
        {
        }

        public StaffInfo(int Staffid, string Firstname, string Lastname, string Dateofbirth, string Address, int Phonenumber, int Bankaccountno)
        {
            this.Staffid = Staffid;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Dateofbirth = Dateofbirth;
            this.Address = Address;
            this.Phonenumber = Phonenumber;
            this.Bankaccountno = Bankaccountno;
        }

        public int staffid
        {
            get { return staffid; }
            set { staffid = value; }

        }

        public string firstname
        {
            get { return firstname; }
            set { firstname = value; }

        }

        public string lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }

        public string address
        {
            get { return address; }
            set { address = value; }
        }

        public int phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

        public int bankaccountno
        {
            get { return bankaccountno; }
            set { bankaccountno = value; }
        }

    }
}