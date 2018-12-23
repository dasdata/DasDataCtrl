<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="DasDataCtrl_Web._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  
    <div>     <br />AKey: <asp:TextBox ID="txtAKey" runat="server" Width="367px"></asp:TextBox>
   <br />
      DSKey:  <asp:TextBox ID="txtDSKey" runat="server" Width="363px"></asp:TextBox>   <br />
     <h2>Get data</h2>
        <asp:Button ID="btnTest" runat="server" Text="List data" />
       <br />
        <asp:GridView ID="GridView1" CssClass="table" runat="server"></asp:GridView>
        <hr size="1" />

           <h2>Send data</h2>
        <asp:TextBox ID="txtLine" runat="server" Text="1|33|44" Width="364px"></asp:TextBox><asp:Button ID="btnSend" runat="server" Text="Send data" />
        <br /> <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
     
   
      
 </div>
 
        <br />
        <br />
    
 
    </form>
</body>
</html>
