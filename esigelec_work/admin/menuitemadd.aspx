<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menuitemadd.aspx.cs" Inherits="esigelec_work.admin.menuitemadd"
MasterPageFile = "~/admin/adminMaster.Master"
 %>


<%@ Register src="uc/uc_menuitemadd.ascx" tagname="uc_menuitemadd" tagprefix="uc1" %>



<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <uc1:uc_menuitemadd ID="uc_menuitemadd1" runat="server" />
</asp:Content>



