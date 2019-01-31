<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Log4NetSampleWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="Form1" method="post" runat="server">
    <asp:Button id="Refresh" runat="server" Text="Refresh..." OnClick="Refresh_Click" Width="112px"></asp:Button>
    <asp:Button id="ThrowError" runat="server" Text="Throw Error..." OnClick="ThrowError_Click" Width="112px"></asp:Button>
</form>
</body>
</html>