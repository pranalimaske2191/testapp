using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for Class1
/// </summary>
public class dataservice
{
    SqlDataAdapter adp;
    SqlCommand cmd;
    SqlConnection con;
    DataTable dt;


	public dataservice()
	{
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

	}
    public DataTable getdata()
    {
        adp = new SqlDataAdapter("select * from info ", con);
        dt = new DataTable();
        adp.Fill(dt);
        return dt;
    }
    public void insertdata(propertyservice p)
    {
        cmd = new SqlCommand("insert into info  values(@fname, @lname)", con);
        cmd.Parameters.AddWithValue(@"fname", p.fname);
        cmd.Parameters.AddWithValue(@"lname", p.lname);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public void deletedata(propertyservice p)
    {
        cmd = new SqlCommand("delete from info where id=@id", con);
        cmd.Parameters.AddWithValue(@"id",p.id);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public void updatedata(propertyservice p)
    {
        cmd = new SqlCommand("update info set fname=@fname,lname=@lname where id=@id", con);
        cmd.Parameters.AddWithValue(@"id", p.id);       
        cmd.Parameters.AddWithValue(@"fname", p.fname);
        cmd.Parameters.AddWithValue(@"lname", p.lname);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}