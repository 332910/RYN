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

    public partial class RoomManagement : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RAYMOND\SQLEXPRESS;Initial Catalog=SWEN;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
        try
        {
            if (tbxFirstName.Text == "")
                Response.Write("<script>alert('Please key fill in your First Name');</script>");
            if (tbxLastName.Text == "")
                Response.Write("<script>alert('Please key fill in your Last Name');</script>");
            if (tbxPassportNo.Text == "")
                Response.Write("<script>alert('Please key fill in your Passport no');</script>");
            if (tbxGender.Text == "")
                Response.Write("<script>alert('Please key fill in your Gender');</script>");
            if (tbxGender.Text == "Male" || tbxGender.Text == "Female")
                Response.Write("<script>alert('OK');</script>");
            else     
                Response.Write("<script>alert('Invalid Gender');</script>");
            if (tbxPhoneNumber.Text == "")
                Response.Write("<script>alert('Please key fill in your Phone no');</script>");
            if (tbxEmailAddress.Text == "")
                Response.Write("<script>alert('Please key fill in your Emailaddress');</script>");
            if (tbxCountry.Text == "")
                Response.Write("<script>alert('Please key fill in your Country');</script>");
            if (tbxNationality.Text == "")
                Response.Write("<script>alert('Please key fill in your Nationality');</script>");
            if (tbxStreetName.Text == "")
                Response.Write("<script>alert('Please key fill in your Streetname');</script>");
            if (tbxBlock.Text == "")
                Response.Write("<script>alert('Please key fill in your Block');</script>");
            if (tbxUnitNo.Text == "")
                Response.Write("<script>alert('Please key fill in your Postalcode');</script>");
                }
            catch (Exception)
                {


                }
            
                cmd.CommandText = ("INSERT INTO CustomerDetails(FirstName, Lastname, Passportno, Gender, Phonenumber, Emailaddress, Country, Nationality, Streetname, Block, Unitno, Postalcode) VALUES ('" + tbxFirstName.Text + "', '" + tbxLastName.Text + "', '" + tbxPassportNo.Text + "', '" + tbxGender.Text + "', '" + tbxPhoneNumber.Text + "','" + tbxEmailAddress.Text + "','" + tbxCountry.Text + "','" + tbxNationality.Text + "','" + tbxStreetName.Text + "','" + tbxBlock.Text + "','" + tbxUnitNo.Text + "','" + tbxPostalCode.Text + "')");
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Customer details accepted');</script>");

                //tbxFirstName.Text = ("");
                //tbxLastName.Text = ("");
                //tbxPassportNo.Text = ("");
                //tbxGender.Text = ("");
                //tbxPhoneNumber.Text = ("");
                //tbxEmailAddress.Text = ("");
                //tbxCountry.Text = ("");
                //tbxNationality.Text = ("");
                //tbxStreetName.Text = ("");
                //tbxBlock.Text = ("");
                //tbxUnitNo.Text = ("");
                //tbxPostalCode.Text = ("");

           Response.Redirect("Booking.aspx", true);
            
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}