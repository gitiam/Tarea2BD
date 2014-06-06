<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10-Bandeja.aspx.cs" Inherits="WebApplication1.WebForm10_Bandeja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Mensajes Recividos<br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <br />
        Mensajes No leidos<br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
