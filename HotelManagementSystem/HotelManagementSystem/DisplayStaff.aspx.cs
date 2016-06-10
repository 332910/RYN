using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace HotelManagementSystem
{
    public partial class DisplayStaff : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["SWENConnectionString2"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            SqlConnection sql = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Staff", sql);
            DataSet ds = new DataSet();
            sql.Open();
            da.Fill(ds);
            sql.Close();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblstaffid = (Label)GridView1.Rows[e.RowIndex].FindControl("lblstaffid");
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Staff WHERE staffid=@1";
            cmd.Parameters.Add("@1", SqlDbType.Int, 12).Value = lblstaffid.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Bind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtStaffid = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtestaffid");
            TextBox txtFirstname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteFirstname");
            TextBox txtLastname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteLastname");
            TextBox txtDateofbirth = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteDateofbirth");
            TextBox txtAddress = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteAddress");
            TextBox txtPhonenumber = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtePhonenumber");
            TextBox txtBankaccount = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txteBankaccountno");
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Staff SET firstname=@1, lastname=@2, dateofbirth=@3, address=@4, phonenumber=@5, bankaccountno=@6  WHERE staffid=@7";
            cmd.Parameters.Add("@1", SqlDbType.VarChar, 23).Value = txtFirstname.Text;
            cmd.Parameters.Add("@2", SqlDbType.VarChar, 23).Value = txtLastname.Text;
            cmd.Parameters.Add("@3", SqlDbType.VarChar, 23).Value = txtDateofbirth.Text;
            cmd.Parameters.Add("@4", SqlDbType.VarChar, 23).Value = txtAddress.Text;
            cmd.Parameters.Add("@5", SqlDbType.Int, 12).Value = txtPhonenumber.Text;
            cmd.Parameters.Add("@6", SqlDbType.Int, 12).Value = txtBankaccount.Text;
            cmd.Parameters.Add("@7", SqlDbType.Int, 12).Value = txtStaffid.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            Bind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        
    }
}