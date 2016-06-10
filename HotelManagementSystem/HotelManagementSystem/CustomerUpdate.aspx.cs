using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HotelManagementSystem
{
    
    public partial class CustomerUpdate : System.Web.UI.Page
    {
        string cnn = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           // SqlDataAdapter ada = new SqlDataAdapter("UPDATE CustomerDetails SET Guestid='"+tbxGuestidUpdate.Text+"',Firstname='"+tbxFirstNameUpdate.Text+"',Lastname='"+tbxLastNameUpdate.Text+"',Passportno='"+tbxPassportNoUpdate.Text+"',Gender='"+tbxGenderUpdate.Text+"',Phoneno='"+tbxPhoneNoUpdate.Text"',Emailaddress='"+tbxEmailaddressUpdate.Text"',Country='"+tbxCountryUpdate.Text"',Nationality='"+tbxNationalityUpdate.Text+"',Streetname='"+tbxStreetNameUpdate.Text+"',Block='"+tbxBlockUpdate.Text+"',Unitno='"+tbxUnitNoUpdate.Text+"',Postalcode='"+tbxPostalCodeUpdate.Text+"'", cnn);
           // DataSet ds = new DataSet();
           // ada.Fill(ds);
        }
    }
}