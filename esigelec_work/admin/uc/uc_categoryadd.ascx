<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_categoryadd.ascx.cs" Inherits="esigelec_work.admin.uc.uc_categoryadd" %>

<div class="panel panel-default" style="width:400px;margin-left:200px;">
  <div class="panel-heading">
    <h3 class="panel-title">ItemsCategory Added</h3>
  </div>
  <div class="panel-body">
            <asp:Label ID="Label3" runat="server" Text="CategoryName"></asp:Label>
            <asp:TextBox ID="txt_categoryname" runat="server" class="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                class="alert-warning" ControlToValidate="txt_categoryname" 
                ErrorMessage="CategoryName is Required !!"></asp:RequiredFieldValidator>
            <br />    
            <asp:Label ID="Label5" runat="server" Text="Picture"></asp:Label>
            <asp:FileUpload ID="fu_picture" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                class="alert-warning" ControlToValidate="fu_picture" 
                ErrorMessage="Image is Required !!"></asp:RequiredFieldValidator>
            <br />   
            <asp:Button ID="btn_login" runat="server" class="btn btn-primary" 
                Text="Save" onclick="btn_login_Click" />
            <br />

  </div>
  </div>