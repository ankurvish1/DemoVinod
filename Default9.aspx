<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default9.aspx.cs" Inherits="Default9" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged" onblur="__doPostBack('<%=TextBox1.ClientID %>', '');"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Text="123"></asp:TextBox>
        <asp:button ID="Button1" runat="server" text="Button" OnClientClick="callOnChange();"/>
    </div>
    </form>
</body>
</html>
