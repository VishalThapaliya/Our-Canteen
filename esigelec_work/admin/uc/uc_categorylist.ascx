<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_categorylist.ascx.cs" Inherits="esigelec_work.admin.uc.uc_categorylist" %>
<div class="panel panel-default" style="width:400px;margin-left:200px;">
  <div class="panel-heading">
    <h3 class="panel-title">ItemsCategory Lists</h3>
  </div>
  <div class="panel-body">

<div style="margin-top:10px">
    
       <asp:TextBox ID="txt_Search" runat="server" AutoPostBack="True" 
            class="form-control" placeHolder="Enter Email for Searching........."></asp:TextBox>
      
   </div>
   <div style="margin-top:10px">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" class="table">
        <Columns>
            <asp:BoundField DataField="catid" HeaderText="Catid" Visible="False" />
            <asp:BoundField DataField="categoryname" HeaderText="Food Category" />
            
            <asp:HyperLinkField DataNavigateUrlFields="catid" 
                DataNavigateUrlFormatString="~/admin/categoryadd.aspx?catid={0}" HeaderText="Update" 
                Text="Update" />
            <asp:HyperLinkField DataNavigateUrlFields="catid" 
                DataNavigateUrlFormatString="~/admin/categorylist.aspx?catid={0}" 
                HeaderText="Delete" Text="Delete" />
        </Columns>
    </asp:GridView>
  </div>

  </div>
  </div>