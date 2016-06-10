using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementSystem.Class
{
    public class guest
    {
        private int Guestid;
        private string Firstname;
        private string Lastname;
        private string Passportno;
        private string Gender;
        private string Phonenumber;
        private string Emailaddress;
        private string Country;
        private string Nationality;
        private string Streetname;
        private string Block;
        private string Unitno;
        private int Postalcode;

        public guest()
        {

        }

        public guest(int Guestid, string Firstname, string Lastname, string Passportno, string Gender, string Phonenumber, string Emailaddress, string Country, string Nationality, string Streetname, string Block, string Unitno, int Postalcode)
        {
            this.Guestid = Guestid;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Passportno = Passportno;
            this.Gender = Gender;
            this.Phonenumber = Phonenumber;
            this.Emailaddress = Emailaddress;
            this.Country = Country;
            this.Nationality = Nationality;
            this.Streetname = Streetname;
            this.Block = Block;
            this.Unitno = Unitno;
            this.Postalcode = Postalcode;

        }

        public int guestid
        {
            get {return Guestid;}
            set {Guestid = value;}
        }

        public string firstname
        {
            get { return Firstname; }
            set { Firstname = value; }
        }

        public string lastname
        {
            get { return Lastname; }
            set { Lastname = value; }
        }

        public string passportno
        {
            get { return Passportno; }
            set { Passportno = value; }
        }

        public string gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public string phonenumber
        {
            get { return Phonenumber; }
            set { Phonenumber = value; }
        }

        public string emailaddress
        {
            get { return Emailaddress; }
            set { Emailaddress = value; }
        }

        public string country
        {
            get { return Country; }
            set { Country = value; }
        }

        public string nationality
        {
            get { return Nationality; }
            set { Nationality = value; }
        }

        public string streetname
        {
            get { return Streetname; }
            set { Streetname = value; }
        }

        public string block
        {
            get { return Block; }
            set { Block = value; }
        }

        public string unitno
        {
            get { return Unitno; }
            set { Unitno = value; }
        }

        public int postalcode        
        {
            get { return Postalcode; }
            set { Postalcode = value; }
        }

        
    }
}