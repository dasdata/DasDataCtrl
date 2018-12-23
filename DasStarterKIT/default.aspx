<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="DasStarterKIT._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  
      <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title></title> 
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
     <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server"> 
          <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">DasStarter Kit</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
        
        </div><!--/.navbar-collapse -->
      </div>
    </nav>

    <!-- Main jumbotron for a primary marketing message or call to action -->
    <div class="jumbotron">
      <div class="container">
        <h1>Hello, tasks!</h1>
        <p>This is a template for a simple started website using DasData channel.  </p>
        <p><a class="btn btn-primary btn-lg" href="https://dasdata.co/tutorials.aspx" role="button">Learn from tutorials &raquo;</a></p>
      </div>
    </div>

    

    <div class="container">
      <!-- Example row of columns -->   
         <asp:Literal ID="lblTaskResult" runat="server" ></asp:Literal>
      <div class="row">
        <div class="col-md-4">
          <h2>Add new task</h2>
          <p>
              Task name: <br />
              <asp:TextBox ID="txtTask" runat="server"></asp:TextBox> <br /> 
              Task details: <br />
               <asp:TextBox ID="txtTaskDetail" runat="server" TextMode="MultiLine"></asp:TextBox> <br /> 

              Task status: <br />
               <asp:DropDownList ID="ddlTaskStatus" runat="server">
                     <asp:ListItem Value="Not started"></asp:ListItem>
                   <asp:ListItem Value="In progress"></asp:ListItem>
                   <asp:ListItem Value="Finished"></asp:ListItem>
               </asp:DropDownList>
               <br /> 
                 Due date: <br />
               <asp:TextBox ID="txtDateDue" runat="server"></asp:TextBox>
               <p>  <asp:Button ID="btnSendTask" class="btn btn-default" runat="server" Text="Send task" />   </p>
          
        </div>
        <div class="col-md-8">
          <h2>myTasks</h2>
           <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            
       </div>
      
      </div> 
    </div> <!-- /container -->
         
    </form> 
    
    
    <footer style="text-align:center">
        <p>&copy; 2016 Company, Inc.</p>
      </footer>


     <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>

 