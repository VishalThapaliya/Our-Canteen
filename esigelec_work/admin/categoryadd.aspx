<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categoryadd.aspx.cs" 
Inherits="esigelec_work.admin.categoryadd" MasterPageFile="~/admin/adminMaster.Master"%>


<%@ Register src="uc/uc_categoryadd.ascx" tagname="uc_categoryadd" tagprefix="uc1" %>



<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <uc1:uc_categoryadd ID="uc_categoryadd1" runat="server" />
</asp:Content>



