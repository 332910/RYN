using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;


namespace HotelManagementSystem.Class
{
    public class GuestDBManager
    {
        public static ArrayList GetGuestByName(string Firstname, string Lastname)
        {
            ArrayList guestlist = new ArrayList();

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM CustomerDetails WHERE Firstname=@Firstname and Lastname=@Lastname";
                comm.Parameters.AddWithValue("@Firstname", Firstname);
                comm.Parameters.AddWithValue("@Lastname", Lastname);
                SqlDataReader dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    guest y =  new guest();
                    y.firstname = (string)dr["Firstname"];
                    y.lastname = (string)dr["Lastname"];
                    guestlist.Add(y);                    
                }

                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }

            return guestlist;

        }

        public static int InsertGuest(guest i)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString2"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO CustomerDetails(Firstname, Lastname, Passportno, Gender, Phonenumber, Emailaddress, Country, Nationality, Streetname, Block, Unitno, Postalcode)" + "VALUES(@Firstname, @Lastname, @Passportno, @Gender, @Phonenumber, @Emailaddress, @Country, @Nationality, @Streetname, @Block, @Unitno, @Postalcode)";
                comm.Parameters.AddWithValue("@Firstname", i.firstname);
                comm.Parameters.AddWithValue("@Lastname", i.lastname);
                comm.Parameters.AddWithValue("@Passportno", i.passportno);
                comm.Parameters.AddWithValue("@Gender", i.gender);
                comm.Parameters.AddWithValue("@Phonenumber", i.phonenumber);
                comm.Parameters.AddWithValue("@Emailaddress", i.emailaddress);
                comm.Parameters.AddWithValue("@Country", i.country);
                comm.Parameters.AddWithValue("@Nationality", i.nationality);
                comm.Parameters.AddWithValue("@Streetname", i.streetname);
                comm.Parameters.AddWithValue("@Block", i.block);
                comm.Parameters.AddWithValue("@Unitno", i.unitno);
                comm.Parameters.AddWithValue("@Postalcode", i.postalcode);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static int UpdateGuest (guest o)
        {
            int rowsupdated = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString2"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE CustomerDetails SET firstname=@Firstname, lastname=@Lastname, passportno=@Passportno, gender=@Gender, phonenumber=@Phonenumber, emailaddress=@Emailaddress, country=@Country, nationality=@Nationality, streetname=@Streetname, block=@Block, unitno=@Unitno, postalcode=@Postalcode";
                comm.Parameters.AddWithValue("@Firstname", o.firstname);
                comm.Parameters.AddWithValue("@Lastname", o.lastname);
                comm.Parameters.AddWithValue("@Passportno", o.passportno);
                comm.Parameters.AddWithValue("@Gender", o.gender);
                comm.Parameters.AddWithValue("@Phonenumber", o.phonenumber);
                comm.Parameters.AddWithValue("@Emailaddress", o.emailaddress);
                comm.Parameters.AddWithValue("@Country", o.country);
                comm.Parameters.AddWithValue("@Nationality", o.nationality);
                comm.Parameters.AddWithValue("@Streetname", o.streetname);
                comm.Parameters.AddWithValue("@Block", o.block);
                comm.Parameters.AddWithValue("@Unitno", o.unitno);
                comm.Parameters.AddWithValue("@Postalcode", o.postalcode);
                rowsupdated = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsupdated;
        }

        public static int DeleteGuest(string Firstname, string Lastname)
        {
            int rowsdeleted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString2"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE CustomerDetails where Firstname=@Firstname and Lastname=@Lastname";
                comm.Parameters.AddWithValue("@Firstname", Firstname);
                comm.Parameters.AddWithValue("@Lastname", Lastname);
                rowsdeleted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsdeleted;

        }
    }
}