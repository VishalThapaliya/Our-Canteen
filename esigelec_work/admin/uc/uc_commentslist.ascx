<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_commentslist.ascx.cs" Inherits="esigelec_work.admin.uc.uc_commentslist" %>

  <div class="panel panel-default" style="width:400px;margin-left:200px;">
  <div class="panel-heading">
    <h3 class="panel-title">Comments Lists</h3>
  </div>
  <div class="panel-body">

<div style="margin-top:10px">
    
       <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
            class="form-control" placeHolder="Enter Email for Searching........."></asp:TextBox>
      
   </div>
   <div style="margin-top:10px">
   <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" class="table">
        <Columns>
            <asp:BoundField DataField="commentid" HeaderText="commentid" Visible="False" />
            <asp:BoundField DataField="commentby" HeaderText="CommentBy" />
            <asp:BoundField DataField="comments" HeaderText="Comments" />
            
            <asp:HyperLinkField DataNavigateUrlFields="userid" 
                DataNavigateUrlFormatString="~/admin/commentlist.aspx?catid={0}" 
                HeaderText="Delete" Text="Delete" />
        </Columns>
    </asp:GridView>
  </div>

  </div>
  </div>