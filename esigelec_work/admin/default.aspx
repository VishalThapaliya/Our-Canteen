<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="esigelec_work.admin._default" %>

<%@ Register src="uc/uc_Login.ascx" tagname="uc_Login" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admim-LogIn</title>
    <link href="../css/main.css" rel="stylesheet" type="text/css" />
     <link href="../ext/bootstrap/3.2.2/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="../ext/bootstrap/3.2.2/js/bootstrap.min.js" type="text/javascript"></script>
</head>
<body>
   
        <div class="header" style="float:left" >
            <div class="logo"> <a href="#" /> </div>
            <div> <a href="#"> <h1 style="color:#E14A39;">OUR CANTEEN</h1> </a></div>
            <div class="subtitle">.....hunger??? no longer!!!</div>
        </div>

        <div id="mainContent">
              <uc1:uc_Login ID="uc_Login1" runat="server" />
        </div>
    
        <div id="footer">
        <div class="copyright">Copyrights &copy; JV - Joint Venture</div>
        <div class="designed">Design &amp; Developed by : Adhikari Jyoti &amp; Thapaliya Bishal</div>
    </div>


   
 
</body>
</html>
