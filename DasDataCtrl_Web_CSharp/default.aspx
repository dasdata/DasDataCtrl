<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DasDataCtrl_Web_CSharp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:TextBox ID="txtAKey" runat="server"></asp:TextBox>
    </div>
        <asp:TextBox ID="txtDSKey" runat="server"></asp:TextBox>
        <asp:Button ID="btnTest" runat="server" Text="Test" /> 
        <br />
        <br /> 
        <asp:TextBox ID="txtLine" runat="server"></asp:TextBox><asp:Button ID="btnSend" runat="server" Text="Send data" /> 
    </form>
</body>
</html>
