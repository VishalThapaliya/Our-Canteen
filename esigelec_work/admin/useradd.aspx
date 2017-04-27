<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminMaster.Master" AutoEventWireup="true" CodeBehind="useradd.aspx.cs" Inherits="esigelec_work.admin.useradd" %>
<%@ Register src="uc/uc_useradd.ascx" tagname="uc_useradd" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:uc_useradd ID="uc_useradd1" runat="server" />
</asp:Content>
