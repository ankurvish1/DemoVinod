using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ID");
        dt.Columns.Add("Name");
        dt.Columns.Add("Payment",typeof(bool));
        dt.Columns.Add("CForm", typeof(bool));
        dt.Columns.Add("Status");

        dt.Rows.Add(1, "Ankur1", 0, 0, "00");
        dt.Rows.Add(2, "Ankur2", 1, 0, "10");
        dt.Rows.Add(3, "Ankur3", 1, 0, "10");
        dt.Rows.Add(4, "Ankur4", 1, 1, "11");
        dt.Rows.Add(5, "Ankur5", 0, 0, "00");
        dt.Rows.Add(6, "Ankur6", 1, 1, "11");
        dt.Rows.Add(7, "Ankur7", 0, 0, "00");
        dt.Rows.Add(8, "Ankur8", 1, 0, "10");
        dt.Rows.Add(9, "Ankur9", 0, 0, "00");
        dt.Rows.Add(10, "Ankur10", 1, 1, "11");
        dt.Rows.Add(11, "Ankur11", 1, 1, "11");
        dt.AcceptChanges();

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
}