<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPersonas.aspx.cs" Inherits="OurWebsite.Forms.EditPersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit</title>
</head>
    <body>  
    @Html.ActionLink("Admin", "Index", "Admin")
    <form id="form1" runat="server">  
        <asp:Repeater ID="Repeater1" runat="server">  
            <ItemTemplate>  
                <div>
                    <asp:TextBox ID='NameBox' runat="server" Text ='<%# Eval("Name") %>' />
                    <asp:TextBox ID='DescBox' runat="server" Text ='<%# Eval("Description") %>' />
                    <asp:TextBox ID='AgeBox' runat="server" Text ='<%# Eval("Age") %>' />
                    <asp:TextBox ID='EduBox' runat="server" Text ='<%# Eval("Education") %>' />
                </div>  
            </ItemTemplate>  
        </asp:Repeater>  
        <div><asp:Button ID="SaveBtn" runat="server" Text='Save Changes.' OnClick="SaveBtn_Click" /></div>
    </form>  
</body> 
</html>
