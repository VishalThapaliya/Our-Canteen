<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="userlist.aspx.cs" Inherits="esigelec_work.admin.userlist" %>
<%@ Register src="uc/uc_userlist.ascx" tagname="uc_userlist" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <uc1:uc_userlist ID="uc_userlist1" runat="server" />
</asp:Content>

