<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10-IngTema.aspx.cs" Inherits="WebApplication1.WebForm10_IngTema" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        INGRESAR TEMA<br />
        <br />
        Nombre:<asp:TextBox ID="TextBoxNombreTema" runat="server"></asp:TextBox>
        <br />
        Descripcion:<asp:TextBox ID="TextBoxDescTema" runat="server"></asp:TextBox>
        <br />
        Publico <asp:CheckBox ID="CheckBox1" runat="server" />
        <br />
        Mensaje:
        <asp:TextBox ID="TextBoxMensTema" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" Width="70px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Volver" Width="72px" />
    
    </div>
    </form>
</body>
</html>
