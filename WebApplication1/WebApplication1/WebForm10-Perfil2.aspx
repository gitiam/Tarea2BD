<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10-Perfil2.aspx.cs" Inherits="WebApplication1.WebForm10_Perfil2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_usuario" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id_usuario" HeaderText="id_usuario" InsertVisible="False" ReadOnly="True" SortExpression="id_usuario" />
                <asp:BoundField DataField="id_grupo" HeaderText="id_grupo" SortExpression="id_grupo" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
                <asp:BoundField DataField="contidad_comentarios" HeaderText="contidad_comentarios" SortExpression="contidad_comentarios" />
                <asp:BoundField DataField="avatar_url" HeaderText="avatar_url" SortExpression="avatar_url" />
                <asp:BoundField DataField="fecha_nacimiento" HeaderText="fecha_nacimiento" SortExpression="fecha_nacimiento" />
                <asp:BoundField DataField="sexo" HeaderText="sexo" SortExpression="sexo" />
                <asp:BoundField DataField="fecha_registro" HeaderText="fecha_registro" SortExpression="fecha_registro" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TareaBDConnectionString %>" SelectCommand="SELECT * FROM [Usuario] WHERE ([nombre] = @nombre)">
            <SelectParameters>
                <asp:QueryStringParameter Name="nombre" QueryStringField="nombre" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Editar Perfil" />
        <br />
    
    </div>
    </form>
</body>
</html>
