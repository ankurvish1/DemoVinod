<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="ID,Status">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:TemplateField HeaderText="Payment">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkPayment" runat="server" Checked='<%# Eval("Payment") %>' Enabled='<%# Eval("Status") == "11" ? false : true%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CForm">
                    <ItemTemplate>
                        <asp:CheckBox ID="CForm" runat="server" Checked='<%# Eval("CForm") %>' Enabled='<%# Eval("Status")  == "11" ? false : true%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
