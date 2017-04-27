<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categorylist.aspx.cs" 
Inherits="esigelec_work.admin.categorylist" MasterPageFile="~/admin/adminMaster.Master" %>


<%@ Register src="uc/uc_categorylist.ascx" tagname="uc_categorylist" tagprefix="uc1" %>



<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <uc1:uc_categorylist ID="uc_categorylist1" runat="server" />
</asp:Content>



