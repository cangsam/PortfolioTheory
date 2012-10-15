<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="portfolioServices.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="loginForm" onsubmit="onSubmit();" runat="server">
    <div>
        username: <asp:TextBox ID="usernameTxt" runat="server" Width="215px"></asp:TextBox><br />
        password: <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="loginBtn" runat="server" Text="login" onclick="loginBtn_Click" />
    </div>
    
    </form>
</body>
</html>
