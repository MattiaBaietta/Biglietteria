<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Biglietteria.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="lblNome" runat="server" OnTextChanged="lblNome_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cognome"></asp:Label>
            <asp:TextBox ID="lblCognome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nome Sala"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Sala Nord</asp:ListItem>
                <asp:ListItem>Sala Est</asp:ListItem>
                <asp:ListItem>Sala Sud</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="Label4" runat="server" Text="Tipo Biglietto"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                <asp:ListItem>Intero</asp:ListItem>
                <asp:ListItem>Ridotto</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="lblPosti" runat="server" Text="Posti Disponibili:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
            <br />
        </div>
    </form>
</body>
</html>
