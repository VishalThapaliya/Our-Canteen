<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_userlist.ascx.cs" Inherits="esigelec_work.admin.uc.uc_userlist" %>

<div class="panel panel-default" style="width:550px;margin-left:200px;">
  <div class="panel-heading">
    <h3 class="panel-title">User-Lists</h3>
  </div>
  <div class="panel-body">
   <div style="margin-top:10px">
      
       <asp:TextBox ID="txt_Search" runat="server" AutoPostBack="True" 
           ontextchanged="txt_Search_TextChanged" class="form-control" placeHolder="Enter Email for Searching........."></asp:TextBox>
      
   </div>
   <div style="margin-top:10px">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
           GridLines="None" class="table">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="userid" HeaderText="Userid" Visible="False" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="fullname" HeaderText="Full Name" />
            <asp:HyperLinkField DataNavigateUrlFields="userid" 
                DataNavigateUrlFormatString="~/admin/useradd.aspx?userid={0}"  
                Text="Update" />
            <asp:HyperLinkField DataNavigateUrlFields="userid" 
                DataNavigateUrlFormatString="~/admin/userlist.aspx?userid={0}" 
                 Text="Delete" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
  </div>

  </div>
  </div>
