<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignupForm.aspx.cs" Inherits="OurWebsite.Forms.SignupForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="SignupForm" runat="server">
        <div>
            <p>Name: </p> <asp:TextBox ID="NameBox" runat="server"></asp:TextBox> <br />
            <p>Email: </p> <asp:TextBox ID="MailBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="SignupBtn" runat="server" Text="Sign up" OnClick="SignupBtn_Click" />
        </div>
        
    </form>
</body>
</html>
