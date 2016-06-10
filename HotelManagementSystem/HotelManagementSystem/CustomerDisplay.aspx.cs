using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using HotelManagementSystem.Class;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;



namespace HotelManagementSystem
{
    public partial class CustomerDisplay : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["SWENConnectionString2"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGrid();
                Bind();
                

            }
        }

        protected void Search(object sender, EventArgs e)
        {

        }

        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["SWENConnectionString2"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM CustomerDetails WHERE Firstname LIKE '%' + @Firstname + '%' AND Lastname LIKE '%' + @Lastname + '%'";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Firstname", tbxSearchbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Lastname", tbxSearchbox.Text.Trim());
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }


            }
        }

        private void Bind()
        {
            SqlConnection sql = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter("select * from CustomerDetails", sql);
            DataSet ds = new DataSet();
            sql.Open();
            da.Fill(ds);
            sql.Close();
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }
    

        protected void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }


        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Gridview2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblGuestid = (Label)GridView2.Rows[e.RowIndex].FindControl("lblGuestid");
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM CustomerDetails WHERE Guestid=@1";
            cmd.Parameters.Add("@1", SqlDbType.Int, 12).Value = lblGuestid.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Bind();


        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            Bind();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox tbxGuestid = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeGuestid");
            TextBox tbxFirstName = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeFirstname");
            TextBox tbxLastName = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeLastname");
            TextBox tbxPassportNo = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxePassportno");
            TextBox tbxGender = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeGender");
            TextBox tbxPhoneNumber = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxePhonenumber");
            TextBox tbxEmailaddress = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeEmailaddress");
            TextBox tbxCountry = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeCountry");
            TextBox tbxNationality = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeNationality");
            TextBox tbxStreetName = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeStreetname");
            TextBox tbxBlock = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeBlock");
            TextBox tbxUnitNo = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxeUnitno");
            TextBox tbxPostalCode = (TextBox)GridView2.Rows[e.RowIndex].FindControl("tbxePostalcode");
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE CustomerDetails SET Firstname=@1, Lastname=@2, Passportno=@3, Gender=@4, Phonenumber=@5, Emailaddress=@6, Country=@7, Nationality=@8, Streetname=@9, Block=@10, Unitno=@11, Postalcode=@12 WHERE Guestid=@13";
            cmd.Parameters.Add("@1", SqlDbType.VarChar, 23).Value = tbxFirstName.Text;
            cmd.Parameters.Add("@2", SqlDbType.VarChar, 23).Value = tbxLastName.Text;
            cmd.Parameters.Add("@3", SqlDbType.VarChar, 23).Value = tbxPassportNo.Text;
            cmd.Parameters.Add("@4", SqlDbType.VarChar, 23).Value = tbxGender.Text;
            cmd.Parameters.Add("@5", SqlDbType.VarChar, 23).Value = tbxPhoneNumber.Text;
            cmd.Parameters.Add("@6", SqlDbType.VarChar, 23).Value = tbxEmailaddress.Text;
            cmd.Parameters.Add("@7", SqlDbType.VarChar, 23).Value = tbxCountry.Text;
            cmd.Parameters.Add("@8", SqlDbType.VarChar, 23).Value = tbxNationality.Text;
            cmd.Parameters.Add("@9", SqlDbType.VarChar, 23).Value = tbxStreetName.Text;
            cmd.Parameters.Add("@10", SqlDbType.VarChar, 23).Value = tbxBlock.Text;
            cmd.Parameters.Add("@11", SqlDbType.VarChar, 23).Value = tbxUnitNo.Text;
            cmd.Parameters.Add("@12", SqlDbType.Int, 12).Value = tbxPostalCode.Text;
            cmd.Parameters.Add("@13", SqlDbType.Int, 12).Value = tbxGuestid.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridView2.EditIndex = -1;
            Bind();
            string display = "Details updated";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "PrintOperation", "printing()", true);
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.DataRow)
            //{
            //    e.Row.Cells[3].Text = Regex.Replace(e.Row.Cells[1].Text, tbxSearchbox.Text.Trim(), delegate(Match match)
            //    {
            //        return string.Format("<span style = 'background-color:#D9EDF7'>{0}</span>", match.Value);
            //    }, RegexOptions.IgnoreCase);

            //}
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void tbxSearchbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition",
             "attachment;filename=CustomerDetails.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";

            GridView2.AllowPaging = false;
            GridView2.DataBind();

            StringBuilder sb = new StringBuilder();
            //StreamWriter sw = new StreamWriter(@"C:\Web_Order\Order_W.csv");
            //DataTable dt = (DataTable)Session["table"];
            //int iColCount = dt.Columns.Count;
            //for (int i = 0; i < iColCount; i++)
            //{
            //    sw.Write(dt.Columns[i]);
            //    if (i < iColCount - 1)
            //    {
            //        sw.Write(",");
            //    }
            //}
            //sw.Write(sw.NewLine);
            //// Now write all the rows.
            //foreach (DataRow dr in dt.Rows)
            //{
            //    for (int i = 0; i < iColCount; i++)
            //    {
            //        if (!Convert.IsDBNull(dr[i]))
            //        {
            //            sw.Write(dr[i].ToString());
            //        }
            //        if (i < iColCount - 1)
            //        {
            //            sw.Write(",");
            //        }
            //    }
            //    sw.Write(sw.NewLine);
            //}
            //sw.Close();
            for (int k = 0; k < GridView2.Columns.Count; k++)
            {
                //add separator
                sb.Append(GridView2.Columns[k].HeaderText + ',');
            }
            //append new line
            sb.Append("\r\n");
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {
                for (int k = 0; k < GridView2.Columns.Count; k++)
                {
                    //add separator
                    sb.Append(GridView2.Rows[i].Cells[k].Text + ',');
                }
                //append new line
                sb.Append("\r\n");
            }
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
          
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //SqlDataSource1.DataBind();
            //GridView2.DataBind();
        }
    }
}



     
