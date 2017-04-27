<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="esigelec_work._default"
MasterPageFile="~/Site1.Master" %>


<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <div>
          <asp:ScriptManager ID="ScriptManager1" runat="server">
          </asp:ScriptManager>
          <asp:UpdatePanel ID="BannerImagePanel" runat="server">
              <ContentTemplate>
                  <asp:Timer ID="Timer" runat="server" Interval="10000" ontick="Timer_Tick">
                  </asp:Timer>
                  <asp:Literal ID="Literal1" runat="server"></asp:Literal>
              </ContentTemplate>
          </asp:UpdatePanel>
          
      </div>
      <div>
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
       </div> 
</asp:Content>



