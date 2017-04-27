<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuitemlist.aspx.cs"
 Inherits="esigelec_work.admin.menuitemlist" MasterPageFile="~/admin/adminMaster.Master" %>

<%@ Register src="uc/uc_menuitemlist.ascx" tagname="uc_menuitemlist" tagprefix="uc1" %>


<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <uc1:uc_menuitemlist ID="uc_menuitemlist1" runat="server" />
</asp:Content>


