<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="State Name : "></asp:Label>
        <asp:TextBox ID="txtStateName" runat="server" ReadOnly="true" 
            ViewStateMode="Enabled"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="City Name : "></asp:Label>
        <asp:TextBox ID="txtCityName" runat="server" Enabled="false" 
            ViewStateMode="Enabled"></asp:TextBox><br />
        <asp:TextBox ID="txtNormal" runat="server" onblur="SetTextBox();"></asp:TextBox>
        <asp:Button ID="btnServerCLick" runat="server" Text="Server Click" 
            OnClick="btnServerCLick_Click" UseSubmitBehavior="False" 
            ViewStateMode="Enabled"/>
        <asp:Button ID="btnClientClick" runat="server" Text="Client Click" OnClientClick="SetTextBox(); return false;" UseSubmitBehavior="False" 
            ViewStateMode="Disabled"/>
        <input type="button" id="btnHTML"name="btnHTML" value="HTML Client Click" onclick="SetTextBox()"/>
    </div>
    <br /><br />

    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
    </div>
    </form>

    <script type="text/javascript">
        function SetTextBox() {

            txtCityName.value = "251";
            txtStateName.removeAttribute("readonly");
            txtStateName.value = "345";
            //txtStateName.readonly = true;
            txtNormal.value = "4343";
        }
    </script>
</body>
</html>
