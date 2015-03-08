using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Class1.CreateDataTable(TextBox1.Text);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = Class1.GetDataTable();
        GridView1.DataBind();
    }
}