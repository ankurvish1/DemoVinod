using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string parameter = Request["__EVENTARGUMENT"];
        if (parameter == "")
            TextBox1_TextChanged(sender, e);
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox2.Text = "855";
    }
}
