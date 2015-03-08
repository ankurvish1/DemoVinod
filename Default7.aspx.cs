using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           
        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("FName");
        dt.Columns.Add("MName");
        dt.Columns.Add("LName");
        dt.Columns.Add("A");
        dt.Columns.Add("B");

        dt.Rows.Add("Ankur", "Kanhiayalal", "Vishwakarma","AA");
        dt.Rows.Add("Nutan", "Kanhiayalal", "Vishwakarma");
        dt.Rows.Add("Indu", "Kanhiayalal", "Vishwakarma");
        dt.Rows.Add("Seema", "Ankur", "Vishwakarma");
        dt.Rows.Add("", "", "");
        dt.Rows.Add("Indu", "Kanhiayalal", "Vishwakarma");
        dt.Rows.Add("Seema", "Ankur", "Vishwakarma"); 
        dt.Rows.Add("Indu", "Kanhiayalal", "Vishwakarma");
        dt.Rows.Add("Seema", "Ankur", "Vishwakarma");
        dt.Rows.Add("", "", "");
        dt.Rows.Add("", "", "");
        dt.AcceptChanges();

        string str = "   ";
        DataRow[] rows = dt.Select("FName is null");

        RemoveEmptyRows(dt);
        RemoveEmptyColumns(dt);
    }

    private void RemoveEmptyRows(DataTable dt)
    {
        for (int i = dt.Rows.Count - 1; i > 0; i--)
        {
            DataRow row = dt.Rows[i];
            int count = 0;

            foreach (object obj in row.ItemArray)
            {
                if (obj.ToString().Trim() == "")
                    count++;
                else
                    return;
            }

            if (count == dt.Columns.Count)
                dt.Rows.RemoveAt(i);
            else
                return;
        }
    }

    private void RemoveEmptyColumns(DataTable dt)
    {
        for (int i = dt.Columns.Count - 1; i > 0; i--)
        {
            DataColumn column = dt.Columns[i];
            int count = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row[column].ToString().Trim() == "")
                    count++;
                else
                    return;
            }

            if (count == dt.Rows.Count)
                dt.Columns.RemoveAt(i);
            else
                return;
        }
    }
}