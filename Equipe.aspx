<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipe.aspx.cs" Inherits="Controle_Asp_Mazzouz.Equipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Gestoion Equipe" ></asp:Label>
            <br />
           
            <br />
            <asp:GridView ID="gv_Gest" runat="server" AutoGenerateColumns="False"
                DataKeyNames="Pseudo" OnRowCancelingEdit="gv_Gest_RowCancelingEdit" CssClass="table table-striped table-hover"
                OnRowDeleting="gv_Gest_RowDeleting" OnRowUpdating="gv_Gest_RowUpdating" OnRowEditing="gv_Gest_RowEditing" >
                <Columns>
                    <asp:TemplateField HeaderText="Pseudo">
                      
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBoxPseudo" runat="server" Text='<%# Eval("Pseudo") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("Pseudo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nom_prenom">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBoxNom_prenom" runat="server" Text='<%# Eval("Nom_prenom") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Nom_prenom") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PassWord">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBoxPassWord" runat="server" Text='<%# Eval("PassWord") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("PassWord") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
