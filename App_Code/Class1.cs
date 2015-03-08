using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    static DataTable dt = null;

	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void CreateDataTable(string ColName)
    {
        dt = new DataTable();
        dt.Columns.Add(ColName);

        dt.Rows.Add("Ankur");
        dt.Rows.Add("Vishwakarma");
        dt.AcceptChanges();
        //return dt;
    }

    public static DataTable GetDataTable()
    {
        return dt;
    }
}