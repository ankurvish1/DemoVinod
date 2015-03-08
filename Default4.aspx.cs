using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DateCompare(TextBox1.Text, TextBox2.Text) > 0)
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "alert", "Date1 is greater", false);
        else if (DateCompare(TextBox1.Text, TextBox2.Text) < 0)
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "alert", "Date2 is greater", false);
    }

    private int DateCompare(string date1,string date2)
    {
        //DateTime rdate1 = DateTime.ParseExact(date1.Replace("/","-"), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        DateTime rdate1 = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy").Replace("/", "-"), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        DateTime rdate2 = DateTime.ParseExact(date2.Replace("/", "-"), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        
        return DateTime.Compare(rdate1, rdate2);
    }
}