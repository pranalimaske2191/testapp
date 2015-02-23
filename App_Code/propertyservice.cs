using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for propertyservice
/// </summary>
public class propertyservice
{
    public int id { get; set; }
    public string fname { get; set; }
    public string lname { get; set; }
	
    public propertyservice()
	{
		
	}
}