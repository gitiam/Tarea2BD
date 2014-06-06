<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10-EditarPerfil.aspx.cs" Inherits="WebApplication1.WebForm10_EditarPerfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        EDITAR PERFIL<br />
        <br />
        Id_Grupo:
        <asp:TextBox ID="TextBoxIdGrupo" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña: <asp:TextBox ID="TextBoxContraseña" runat="server" Width="155px"></asp:TextBox>
        <br />
        <br />
        Repetir Contraseña:
        <asp:TextBox ID="TextBoxRepetirContraseña" runat="server"></asp:TextBox>
        <br />
        <br />
        Fecha Nacimiento:<asp:TextBox ID="TextBoxFecha" runat="server" OnTextChanged="TextBox3_TextChanged" style="margin-left: 0px"></asp:TextBox>
        <br />
        <br />
        Avatar:
        <asp:TextBox ID="TextBoxAvatar" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Editar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" />
        <br />
        <br />
    </form>
</body>
</html>
