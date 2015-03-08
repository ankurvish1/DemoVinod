using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateDataTable();
    }

    protected void btnServerCLick_Click(object sender, EventArgs e)
    {
        string statename = txtStateName.Text;
        string cityname = txtCityName.Text;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    private void CreateDataTable()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Name");
        dt.Columns.Add("RollNo");
        dt.Columns.Add("ID");

        dt.Rows.Add(new object[] {"Ankur","104","1"});
        dt.Rows.Add(new object[] { "Kamlesh", "110", "2" });
        dt.Rows.Add(new object[] { "Ashish", "108", "3" });

        GenerateGridViewColumns();

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    private void GenerateGridViewColumns()
    {
        foreach (string col in "Name,RollNo,ID".Split(','))
        {
            BoundField bf = new BoundField();
            bf.DataField = col;
            bf.HeaderText = col;
            if (col == "ID")
                bf.Visible = false;
            GridView1.Columns.Add(bf);

        }
    }
}