<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gate.aspx.cs" Inherits="Gate.Views.Gate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div class="jumbotron">
              <h1>Turnierverwaltung</h1>
                <asp:Button ID="Button1" class="btn btn-primary btn-lg btn-block"  runat="server" Text="Login" Height="45px" Width="170px" />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
