<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_Login.ascx.cs" Inherits="esigelec_work.admin.uc.uc_Login" %>
<div class="container">
<div class="panel panel-default" style="width:400px;margin-left:200px;margin-top:50px;margin-bottom:50px;">
  <div class="panel-heading">
    <h3 class="panel-title">Login</h3>
  </div>
  <div class="panel-body">
   <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txt_username" runat="server" class="form-control" 
                    TextMode="Email" placeholder="Enter email" Text="admin@admin.com" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                class="alert-warning" ControlToValidate="txt_username" 
                ErrorMessage="UserName is Required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txt_password" runat="server" class="form-control" 
                TextMode="Password" placeholder="Enter Password" Text="admin" Width="250px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                class="alert-warning" ControlToValidate="txt_password" 
                ErrorMessage=" Password is Required !!"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btn_login" runat="server" class="btn btn-default" 
                 Text="Login" onclick="btn_login_Click" style="height: 26px" />
            <asp:Label ID="lblerrormsg" runat="server" class="alert-warning"></asp:Label>
            <br />
    </form>
  </div>
</div>
</div>