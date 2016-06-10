using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HotelManagementSystem.Class
{
    public class Booking
    {
        private int Bookingid;
        private int Guestid;
        private string Bookingdate;
        private string Checkindate;
        private string Checkoutdate;
        private int Noofadult;
        private int Noofchildren;
        private int Noofdays;

        public Booking()
        {

        }

        public Booking(int Bookingid, int Guestid, string Bookingdate, string Checkindate, string Checkoutdate, int Noofadult, int Noofchildren, int Noofdays)
        {
            this.Bookingid = Bookingid;
            this.Guestid = Guestid;
            this.Bookingdate = Bookingdate;
            this.Checkindate = Checkindate;
            this.Checkoutdate = Checkoutdate;
            this.Noofadult = Noofadult;
            this.Noofchildren = Noofchildren;
            this.Noofdays = Noofdays;
        }
            public int bookingid
            {
                get {return Bookingid;}
                set {Bookingid = value;}
            }

            public int guestid
            {
                get {return Guestid;}
                set {Guestid = value;}
            }

            public string bookingdate
            {
                get {return Bookingdate;}
                set {Bookingdate = value;}
            }

            public string checkindate
            {
                get {return Checkindate;}
                set {Checkindate = value;}
            }

            public string checkoutdate
            {
                get {return Checkoutdate;}
                set {Checkoutdate = value;}
            }

            public int noofadult
            {
                get {return Noofadult;}
                set {Noofadult = value;}
            }

            public int noofchildren
            {
                get {return Noofchildren;}
                set {Noofchildren = value;}
            }

            public int noofdays
            {
                get {return Noofdays;}
                set {Noofdays = value;}
            }

           
        }
    }


