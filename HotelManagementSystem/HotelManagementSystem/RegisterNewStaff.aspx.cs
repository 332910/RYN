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
    public partial class RegisterNewStaff : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RAYMOND\SQLEXPRESS;Initial Catalog=SWEN;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                if (txtFirstname.Text == "")
                    Response.Write("<script>alert('Please key fill in your First Name');</script>");
                if (txtLastname.Text == "")
                    Response.Write("<script>alert('Please key fill in your Last Name');</script>");
                if (txtDateofbirth.Text == "")
                    Response.Write("<script>alert('Please key fill in your Date of Birth');</script>");
                if (txtAddress.Text == "")
                    Response.Write("<script>alert('Please key fill in your Address');</script>");
                if (txtPhonenumber.Text == "")
                    Response.Write("<script>alert('Please key fill in your Phone number');</script>");
                if (txtBankaccount.Text == "")
                    Response.Write("<script>alert('Please key fill in your Bank Account Number');</script>");
            }
            catch (Exception)
            {


            }
            cmd.CommandText = ("INSERT INTO Staff(firstname, lastname, dateofbirth, address, phonenumber, bankaccountno) VALUES ( '" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtDateofbirth.Text + "', '" + txtAddress.Text + "', '" + txtPhonenumber.Text + "', '" + txtBankaccount.Text + "')");
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script>alert('New Staff Created!');</script>");
        }
    }
}