<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
          <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <title>Login</title>
</head>
<body>
    <form id="form1" class="" runat="server">
        <h1 class="col-sm-10">Login</h1>
        <asp:Label ID="Label3" runat="server" CssClass="alert alert-danger" Text=""></asp:Label>
       <div class="form-group col-sm-10">
        <asp:Label ID="Label2"  runat="server" Text="User"></asp:Label>

          <div class="col-sm-10">
              <asp:TextBox ID="TxtUser" runat="server" Height="31px" Width="224px" CssClass="form-control"></asp:TextBox>
          </div>
        </div>


        <div class="form-group col-sm-10">
            <asp:Label ID="Label1" runat="server" Text="Passwort"></asp:Label>
          <div class=" col-sm-10">
              <asp:TextBox ID="txtpass" runat="server" Height="31px" Width="224px" CssClass="form-control"></asp:TextBox>
          </div>
        </div>
        <asp:Button CssClass="btn btn-primary col-sm-10" ID="Button1" runat="server" Text="Login" Height="36px" Width="133px" OnClick="Button1_Click" />
    </form>
</body>

</html>
