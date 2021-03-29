<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page21.aspx.cs" Inherits="Partie_4_Exemple_1.Page21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1>Page 1</h1>
        <asp:Label ID="Label1" runat="server" Text="Nom"></asp:Label>
        <asp:TextBox ID="Nom" runat="server"></asp:TextBox>
        <br />
        <br />
         <asp:Label ID="Label2" runat="server" Text="Prenom"></asp:Label>
        <asp:TextBox ID="Prenom" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Envoyer" runat="server" Text="Envoyer" OnClick="Envoyer_Click" />
        </p>
    </form>
</body>
</html>
