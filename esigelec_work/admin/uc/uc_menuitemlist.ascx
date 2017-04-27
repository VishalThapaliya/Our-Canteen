<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_menuitemlist.ascx.cs" Inherits="esigelec_work.admin.uc.uc_menuitemlist" %>

<div class="panel panel-default" style="width:800px;margin-left:50px;">
  <div class="panel-heading">
    <h3 class="panel-title">ItemMenu Lists</h3>
  </div>
  <div class="panel-body">

<div style="margin-top:10px">
    
       <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
            class="form-control" placeHolder="Enter Email for Searching........."></asp:TextBox>
      
   </div>
   <div style="margin-top:10px">
     <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" class="table" CellPadding="4" ForeColor="#333333" 
           GridLines="None">
         <AlternatingRowStyle BackColor="White" />
        <Columns>
            
            <asp:BoundField DataField="recipeid" HeaderText="recipeid" Visible="False" />
            <asp:ImageField DataImageUrlField="image" 
                DataImageUrlFormatString="~/images/{0}" ControlStyle-Width="40" ControlStyle-Height = "40">
<ControlStyle Height="40px" Width="40px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField DataField="category.categoryname" HeaderText="Items Category" />
            <asp:BoundField DataField="recipename" HeaderText="MenuItems Name" />
            <asp:BoundField DataField="recipedesc" HeaderText="MenuItems Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            

            <asp:HyperLinkField DataNavigateUrlFields="recipeid" 
                DataNavigateUrlFormatString="~/admin/menuitemadd.aspx?recipeid={0}" HeaderText="Update" 
                Text="Update" />
            <asp:HyperLinkField DataNavigateUrlFields="recipeid" 
                DataNavigateUrlFormatString="~/admin/menuitemlist.aspx?recipeid={0}" 
                HeaderText="Delete" Text="Delete" />
            
             <asp:HyperLinkField DataNavigateUrlFields="recipeid" 
                DataNavigateUrlFormatString="~/admin/commentlist.aspx?recipeid={0}" 
                HeaderText="comments" Text="comments" />

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

<p>
    &nbsp;</p>
<p>
    &nbsp;</p>


