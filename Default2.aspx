<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<%@ Import Namespace="System.Web" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var result = document.getElementById("<%= txt1.ClientID %>");
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload"
                    OnClick="btnUpload_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Has Header ?" />
        <asp:RadioButtonList ID="rbHDR" runat="server">
            <asp:ListItem Text = "Yes" Value = "Yes" Selected = "True" >
            </asp:ListItem>
            <asp:ListItem Text = "No" Value = "No"></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        
        <asp:GridView ID="GridView1" runat="server" AllowPaging = "True" 
            AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Amount" HeaderText="Amount" DataFormatString="{0:f3}"/>
                <asp:CheckBoxField DataField="Select" HeaderText="Select" ReadOnly="false"/>
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="txt1" runat="server" Text="Hi Ankur"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Text='<% txt1.ClientID;%>'></asp:TextBox>

    </div>
    </form>
</body>
</html>
