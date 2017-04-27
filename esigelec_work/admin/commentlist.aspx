<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="commentlist.aspx.cs" 
Inherits="esigelec_work.admin.commentlist" MasterPageFile="~/admin/adminMaster.Master" %>

<%@ Register src="uc/uc_commentslist.ascx" tagname="uc_commentslist" tagprefix="uc1" %>


<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <uc1:uc_commentslist ID="uc_commentslist1" runat="server" />
</asp:Content>


