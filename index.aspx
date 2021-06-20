<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Controle_Asp_Mazzouz.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login" ></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Pseudo"></asp:Label>
            <asp:TextBox ID="TextBoxPseudo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="PassWord"></asp:Label>
            <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnLogin" runat="server" Text="Login" Width="189px"  OnClick="BtnLogin_Click"/>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" Text="S'inscrire" NavigateUrl="~/Gestionnaire.aspx">HyperLink</asp:HyperLink>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
