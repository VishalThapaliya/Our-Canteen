<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_useradd.ascx.cs" Inherits="esigelec_work.admin.uc.uc_useradd" %>

<div class="panel panel-default" style="width:400px;margin-left:200px;">
  <div class="panel-heading">
    <h3 class="panel-title">User-Registration</h3>
  </div>
  <div class="panel-body">
<asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txt_email" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                class="alert-warning" ControlToValidate="txt_email" 
                ErrorMessage="Email is Required !!"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label1" runat="server" Text="FullName"></asp:Label>
            <asp:TextBox ID="txt_fullname" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                class="alert-warning" ControlToValidate="txt_fullname" 
                ErrorMessage="UserName is Required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txt_passwords" runat="server" class="form-control" 
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                class="alert-warning" ControlToValidate="txt_passwords" 
                ErrorMessage=" Password is Required !!"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Confirmed Password"></asp:Label>
            <asp:TextBox ID="txt_conformedpasssword" runat="server" class="form-control" 
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                class="alert-warning" ControlToValidate="txt_conformedpasssword" 
                ErrorMessage=" Password is Required !!"></asp:RequiredFieldValidator>
             <asp:CompareValidator ID="CompareValidator1" runat="server" 
                 ControlToCompare="txt_passwords" ControlToValidate="txt_conformedpasssword" 
                 ErrorMessage="Password doesnot match !!" class="alert-warning"></asp:CompareValidator>
            <br />     
            <asp:Button ID="btn_login" runat="server" class="btn btn-primary" 
                Text="Save" onclick="btn_login_Click" />
            <br />
</div>
</div>