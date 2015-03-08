<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default10.aspx.cs" Inherits="Default10" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
                    ontextchanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" Text="1"></asp:TextBox>
            </ContentTemplate>
            <Triggers><asp:AsyncPostBackTrigger ControlID="TextBox1" EventName="TextChanged" /></Triggers>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
