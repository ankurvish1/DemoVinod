using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.OleDb;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //TextBox2.DataBind();
  
           // TextBox1.Text = "{0:f5}";
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string Extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

            string FilePath = Server.MapPath(FolderPath + "Vinod.xlsx");
            FileUpload1.SaveAs(FilePath);
            Import_To_Grid(FilePath, Extension, rbHDR.SelectedItem.Text);
        }
    }

    private void Import_To_Grid(string FilePath, string Extension, string isHDR)
    {
        string conStr = "";
        switch (Extension)
        {
            case ".xls": //Excel 97-03
                conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]
                         .ConnectionString;
                break;
            case ".xlsx": //Excel 07
                conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]
                          .ConnectionString;
                break;
        }
        conStr = String.Format(conStr, FilePath, isHDR);
        OleDbConnection connExcel = new OleDbConnection(conStr);
        OleDbCommand cmdExcel = new OleDbCommand();
        OleDbDataAdapter oda = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        cmdExcel.Connection = connExcel;

        //Get the name of First Sheet
        connExcel.Open();
        DataTable dtExcelSchema;
        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
        string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
        connExcel.Close();

        //Read Data from First Sheet
        connExcel.Open();
        cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
        oda.SelectCommand = cmdExcel;
        oda.Fill(dt);
        connExcel.Close();

        



        //string dropI = "";
        //string getRowNumbers = "";
        ////Compare rows
        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    if (dropI.Contains(i.ToString()))
        //        continue;

        //    object[] obji = dt.Rows[i].ItemArray;
        //    string getInnerRowNumbers = "";

        //    for (int j = i+1; j < dt.Rows.Count; j++)
        //    {
        //        object[] objj = dt.Rows[j].ItemArray;
        //        int count = 0;

        //        for (int k = 0; k < objj.Length; k++)
        //        {
        //            if (obji[k].Equals(objj[k]))
        //            {
        //                count++;
        //            }
        //        }

        //        if (count == objj.Length)
        //        {
        //            getInnerRowNumbers = getInnerRowNumbers + "," + (j + 1);
        //            dropI = dropI + "," + j;
        //        }
        //    }

        //    if (getInnerRowNumbers != "")
        //    {
        //        getRowNumbers = getRowNumbers + "\n" + obji[0].ToString() + " at : " + (i + 1) + getInnerRowNumbers + "\n";
        //        getInnerRowNumbers = "";
        //    }
        //}

        ////Bind Data to GridView
        //TextBox1.Text = "Duplicate Rows found for :\n " + getRowNumbers;

        Session["Format"] = "{0:f5}";
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    public string GetFormat()
    {
        return "{0:f3}";
    }
}