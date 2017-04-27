<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aja.aspx.cs" Inherits="esigelec_work.aja" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button3" runat="server"  PostBackUrl="~/wb1.aspx" Text="Button" 
      />
    </form>
</body>
</html>
