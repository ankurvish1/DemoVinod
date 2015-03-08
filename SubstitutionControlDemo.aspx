<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubstitutionControlDemo.aspx.cs" Inherits="SubstitutionControlDemo" %>
<%@ OutputCache Duration="60" VaryByParam="None" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head id="Head1" runat="server">
<title></title></head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
    <asp:Label runat="server" ID="Label1" />
    </p>
    <p>
    <asp:Substitution runat="server" ID="Substitution1" MethodName="GetTime" />
    </p>
    <p>
    <asp:Button runat="server" ID="Button1" Text="Submit" onclick="Button1_Click"/>
    </p>
    <asp:Label runat="server" ID="Label2" />
    </div>
    </form>
</body>
</html>