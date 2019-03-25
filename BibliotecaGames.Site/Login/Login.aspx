<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaGames.Site.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                Usuario: <br />
                <asp:TextBox id="TxtUsuario" runat="server"></asp:TextBox>
            </div>
            <div>
                Senha: 
                <br />
                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button ID="btnLogin" text="Entrar" runat="server" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
