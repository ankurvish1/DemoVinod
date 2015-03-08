using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = GetFinancialYear(Convert.ToInt32(txtMonth.Text), Convert.ToInt32(txtYear.Text));
    }

    private string PrintFinancialYear(int m,int month, int year, int sign)
    {
        string result = "";

        while (m < month)
        {
            result = result + "'" + m + "-" + (year + sign) + "',";
            m++;
        }
        return result;
    }

    private string GetFinancialYear(int month, int year)
    {
        string result = "";

        if (month > 3)
            result = result + PrintFinancialYear(4, month, year, 0);

        else if (month >= 1 && month <= 3)
        {
            result = result + PrintFinancialYear(4, 13, year, -1);

            if (month > 1)
                result = result + PrintFinancialYear(1, month, year, 0);
        }

        return result.TrimEnd(',');
    }
}