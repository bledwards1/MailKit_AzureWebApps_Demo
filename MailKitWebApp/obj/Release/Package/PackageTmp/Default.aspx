<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MailKitWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="SendButton" runat="server" Text="Send Mail" OnClick="SendButton_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="435px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
