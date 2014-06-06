<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10-Perfil.aspx.cs" Inherits="WebApplication1.WebForm10_Perfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Buscar Perfil mediante nombre de usuario:<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:HyperLinkField DataNavigateUrlFields="nombre" DataNavigateUrlFormatString="WebForm10-Perfil2.aspx?nombre={0}" DataTextField="nombre" NavigateUrl="~/WebForm10-Perfil2.aspx" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TareaBDConnectionString %>" SelectCommand="SELECT [nombre] FROM [Usuario]"></asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
