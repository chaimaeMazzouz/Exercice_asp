<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestionnaire.aspx.cs" Inherits="Controle_Asp_Mazzouz.Gestionnaire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Inscription" ></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Pseudo"></asp:Label>
            <asp:TextBox ID="TextBoxPseudo" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxPseudo" ErrorMessage="Champ Obligatoire" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBoxPseudo" ErrorMessage="Le pseudo doit etre unique" OnServerValidate="CustomValidator1_ServerValidate" ForeColor="#FF3300"></asp:CustomValidator>
            <br />
            <br />
             <asp:Label ID="Label4" runat="server" Text="Nom et Prénom"></asp:Label>
            <asp:TextBox ID="TextBox_NomPrenom" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_NomPrenom" ErrorMessage="Champ Obligatoire" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="PassWord"></asp:Label>
            <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Champ Obligatoire" ForeColor="Red"></asp:RequiredFieldValidator>
             <br />
             <br />
             <br />
            <asp:Label ID="Label5" runat="server" Text="Confirmation PassWord"></asp:Label>
            <asp:TextBox ID="TextBoxConfPass" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxConfPass" ErrorMessage="Champ Obligatoire" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxConfPass" ErrorMessage="Confirmation ne correspond pas" ForeColor="#FF3300"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="BtnIns" runat="server" Text="Inscrire" Width="189px"  OnClick="BtnIns_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
