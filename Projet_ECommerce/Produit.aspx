<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produit.aspx.cs" Inherits="Projet_ECommerce.Produit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style/Style.css" rel="stylesheet" />
    <style type="text/css">

        .auto-style1 {
            top: 742px;
            left: 237px;
        }
        .auto-style2 {
            top: 422px;
            left: 189px;
            width: 34px;
            height: 26px;
        }
        .auto-style3 {
            top: 425px;
            left: 711px;
            height: 24px;
            width: 38px;
        }
        .auto-style4 {
            top: 744px;
            left: 89px;
            right: 787px;
        }
        .auto-style5 {
            top: 744px;
            left: 697px;
            width: 33px;
        }

        .auto-style6 {
            height: 72px;
            margin-top: 0px;
            width: 64px;
        }

        .auto-style10 {
            width: 170px;
            height: 118px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <img id="Pub2" alt="" class="Pub2" src="Image/Pub2.PNG" /><img alt="" class="image1" src="Image/Logo-Honeycomb.png" aria-busy="False" /><asp:Label ID="Connexion" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Connexion" Font-Bold="False" Font-Overline="False"></asp:Label>
            <asp:TextBox ID="TextBoxLogin" runat="server" CssClass="TextBoxLogin"></asp:TextBox>
            <asp:Label ID="Password" runat="server" CssClass="Password" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="TextBoxPassword" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="BoutonValiderConnexion" OnClick="Button1_Click1" Text="Ok" />
            <asp:Label ID="Label1" runat="server" Text="Abeillons nous !!" CssClass="Titre1" Font-Bold="True" Font-Italic="False" Font-Names="Juice ITC" Font-Size="XX-Large"></asp:Label>
        </p>
        <a href="Default.aspx">
        <asp:Label ID="Label3" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien1" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="Accueil"></asp:Label>
        </a> 
        <a href="Produit.aspx">
        <asp:Label ID="Label4" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien2" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="Nos produits"></asp:Label>
        </a> 
        <p>
            <asp:Label ID="Login1" runat="server" CssClass="Login" Text="Login"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p><a href="Register.aspx">
        <asp:Label ID="Label5" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien4" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="S'inscrire"></asp:Label>
        </a> 
        </p>
        <p>
        <a href="Panier.aspx">
        <asp:Label ID="Label7" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien3" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="Mon panier"></asp:Label>
        </a>
        </p>
    &nbsp;<img alt="" class="Fond" src="Image/beige_leather_1024.jpg" style="background-image: url('Image/beige_leather_1024.jpg'); background-attachment: fixed;" /><asp:Label ID="Label8" runat="server" CssClass="Connexion" Text="Label"></asp:Label>
        <asp:Label ID="ErreurLogin" runat="server" CssClass="ErreurLogin"></asp:Label>
        <asp:Button ID="Deconnexion" runat="server" CssClass="BoutonDeconnexion" Text="Deconnexion" OnClick="Deconnexion_Click" Visible="False" />
    <img alt="" class="Fond" src="Image/beige_leather_1024.jpg" style="background-image: url('Image/beige_leather_1024.jpg'); background-attachment: fixed;" />
        <asp:TextBox ID="TextBoxAjouterProduit1" runat="server" CssClass="TextBoxAjouterProduit1 auto-style2"></asp:TextBox>
        <asp:TextBox ID="TextBoxAjouterProduit3" runat="server" CssClass="TextBoxAjouterProduit3"></asp:TextBox>
        <asp:TextBox ID="TextBoxAjouterProduit4" runat="server" CssClass="TextBoxAjouterProduit4 auto-style5"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" CssClass="BoutonAjouterProduit3 auto-style1" OnClick="Button4_Click" Text="Valider" />
        <asp:Button ID="Button5" runat="server" CssClass="BoutonAjouterProduit4" OnClick="Button5_Click" Text="Valider" />
        <p>
            <asp:Button ID="Button3" runat="server" CssClass="BoutonAjouterProduit2" OnClick="Button3_Click" Text="Valider" />
            <asp:Label ID="ErreurConnection" runat="server" CssClass="ErreurConnection"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxAjouterProduit2" runat="server" CssClass="TextBoxAjouterProduit2 auto-style3"></asp:TextBox>
        <p>
            <img alt="" class="Leffe" src="Image/Bière3.jpg" /></p>
        <asp:Label ID="PrixLeffe" runat="server" CssClass="PrixLeffe">33.40 € TTC</asp:Label>
        <p>
            <img alt="" class="Kronenbourg" src="Image/Bière4.jpg" /></p>
        <p class="auto-style6">
        <asp:Button ID="Button2" runat="server" CssClass="BoutonAjouterProduit1" OnClick="Button2_Click" Text="Valider" />
            <img alt="" class="Hoegaarden" src="Image/Bière1.jpg" /><img alt="" class="Weed" src="Image/Bière2.png" /><asp:Label ID="PrixHoegaarden" runat="server" CssClass="PrixHoegaarden">34.00 € TTC</asp:Label>
            <asp:Label ID="PrixWeed" runat="server" CssClass="PrixWeed" Text="19.50 € TTC"></asp:Label>
            <asp:Label ID="LabelHoegaarden" runat="server" CssClass="LabelHoegaarden" Text="Hoegaarden 5L"></asp:Label>
            <asp:Label ID="LabelWeed" runat="server" CssClass="LabelWeed" Text="Weed 5L"></asp:Label>
            <asp:Label ID="LabelLeffe" runat="server" CssClass="LabelLeffe" Text="Leffe 5L"></asp:Label>
            <asp:Label ID="LabelKro" runat="server" CssClass="LabelKronenbourg" Text="Kronenbourg 5L"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="PrixKronenbourg" Text="17.00 € TTC"></asp:Label>
        </p>
    </form>
    </body>
</html>
