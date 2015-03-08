<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtMonth" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="144px" TextMode="MultiLine" 
            Width="333px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
