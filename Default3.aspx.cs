using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string CreateDataTable(string val)
    {
        DataTable dt = new DataTable("Student");

        dt.Columns.Add("ID",typeof(int));
        dt.Columns.Add("Name");
        dt.Columns.Add("RollNo");

        dt.Rows.Add(new object[] { "1", "Ankur", "104" });
        dt.Rows.Add(new object[] { "2", "Kamlesh", "110" });
        dt.Rows.Add(new object[] { "3", "Ashish", "108" });
        dt.AcceptChanges();

        //////////////////////////////////////////////////////////////
        var results1 = from s in dt.AsEnumerable()
                     where s.Field<int>("ID") > 1
                     select s.Field<string>("Name");

        foreach (var result in results1)
        {
            TextBox4.Text = TextBox4.Text + result + ",";
        }
        TextBox4.Text = TextBox4.Text.TrimEnd(',');
        ///////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////
        var results3 = (from DataRow row in dt.Rows
                      where (string)row["Name"] == val
                      select row).First();
        TextBox3.Text = results3["Name"].ToString();
        //////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////
        var results2 = from s in dt.AsEnumerable()
                       where s.Field<string>("Name") == val
                       select s.Field<string>("Name");

        return results2.First().ToString();
        //////////////////////////////////////////////////////////////
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Textbox1.Text = CreateDataTable(TextBox2.Text);
    }
}