using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace HotelManagementSystem
{
    
    public partial class Booking : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RAYMOND\SQLEXPRESS;Initial Catalog=SWEN;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string Date = DateTime.Now.ToShortDateString(); //Show current date
            tbxBookingdate.Text = Date;



        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int adult = Convert.ToInt32(tbxnumadult.Text);
            int children = Convert.ToInt32(tbxnumchildren.Text);
            int days = Convert.ToInt32(tbxnumdays.Text);
            cmd.CommandText = ("INSERT INTO Booking(Bookingdate, Checkindate, Checkoutdate, Noofadult, Noofchildren, Noofdays) VALUES ('" + tbxBookingdate + "','" + tbxCheckindate + "','" + tbxCheckoutdate + "','" + adult + "','" + children + "','" + days + "')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string Checkin = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            tbxCheckindate.Text = Checkin;//display selected date
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
           
            DateTime dtOne = Calendar1.SelectedDate;
            DateTime dtTwo = Calendar2.SelectedDate;
            string Checkout = Calendar2.SelectedDate.ToString("yyyy/MM/dd");
           
            tbxCheckoutdate.Text = Checkout;//display selected date


            double answer = (dtTwo - dtOne).TotalDays;
            tbxnumdays.Text = answer.ToString();//display total days

            //tbxnumdays.Text = Calendar2.Subtract(Calendar1).Days.ToString();
            //DateTime d1 = DateTime.MinValue;
            //DateTime d2 = DateTime.MaxValue;
            //TimeSpan span = d2 - d1;
            //tbxnumdays.Text = span(int);
            

            //if (Calendar2.SelectedDate != null && Calendar1.SelectedDate != null)
            //{
            //   // TimeSpan Value;
            //    if (Calendar2.SelectedDate >= Calendar1.SelectedDate)
            //        Value = (Calendar2.SelectedDate - Calendar1.SelectedDate).TotalDays;

            //    tbxnumdays = Value;

                
            //}
            
        }


        
    }
}