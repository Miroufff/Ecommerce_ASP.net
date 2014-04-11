<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Projet_ECommerce.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style/Style.css" rel="stylesheet" />
    <style type="text/css">

        .auto-style2 {
            top: 299px;
            left: 522px;
        }
        .auto-style3 {
            top: 39px;
            left: 140px;
            width: 120px;
        }

        .auto-style4 {
            width: 302px;
            height: 271px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
        <img alt="" class="image1" src="Image/Logo-Honeycomb.png" aria-busy="False" id="Image" /><asp:Label ID="Connexion" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Connexion" Font-Bold="False" Font-Overline="False"></asp:Label>
            <asp:TextBox ID="TextBoxLogin" runat="server" CssClass="TextBoxLogin auto-style3"></asp:TextBox>
            <asp:Label ID="Password" runat="server" CssClass="Password" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="TextBoxPassword auto-style5" TextMode="Password"></asp:TextBox>
            <asp:Button ID="BoutonValiderConnexion" runat="server" CssClass="BoutonValiderConnexion auto-style6" OnClick="BoutonValiderConnexion_Click" Text="Ok" />
            <asp:Label ID="Titre" runat="server" Text="Abeillons nous !!" CssClass="Titre1" Font-Bold="True" Font-Italic="False" Font-Names="Juice ITC" Font-Size="XX-Large"></asp:Label>
        </p>
        <a href="Default.aspx">
        <asp:Label ID="LienAcceuil" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien1" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="Accueil"></asp:Label>
        </a> 
        <a href="Produit.aspx">
        <asp:Label ID="LienProduit" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien2" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="Nos produits"></asp:Label>
        </a> 
        <p>
            <asp:Label ID="Login1" runat="server" CssClass="Login" Text="Login"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p><a href="Register.aspx">
        <asp:Label ID="LienInscription" runat="server" BackColor="#99CCFF" BorderColor="#663300" BorderStyle="Outset" CssClass="Lien4" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="S'inscrire"></asp:Label>
        </a> 
        </p>
        <p>
        <a href="Panier.aspx">
        <asp:Label ID="LienPanier" runat="server" BackColor="#99CCFF" BorderStyle="Outset" CssClass="Lien3" Font-Bold="True" Font-Names="Century Schoolbook" Font-Overline="False" Font-Strikeout="False" ForeColor="Black" Text="Mon panier"></asp:Label>
        </a>
        </p>
        <img alt="" class="Fond" src="Image/beige_leather_1024.jpg" style="background-image: url('Image/beige_leather_1024.jpg'); background-attachment: fixed;" />
        <asp:Label ID="LoginRegister1" runat="server" CssClass="LoginRegister auto-style2" Text="Login"></asp:Label>
        <asp:Label ID="PasswordConfirmationRegister1" runat="server" CssClass="PasswordConfirmationRegister" Text="Confirm Password"></asp:Label>
        <asp:Label ID="monFormulaire1" runat="server" BorderColor="#663300" BorderStyle="Outset" CssClass="Formulaire" Font-Size="X-Large" Font-Strikeout="False" Text="Formulaire d'inscription"></asp:Label>
        <asp:Label ID="PasswordRegister1" runat="server" CssClass="PasswordRegister" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxLoginRegister1" runat="server" CssClass="TextBoxLoginRegister" ></asp:TextBox>
        <asp:TextBox ID="TextBoxPasswordRegister1" runat="server" CssClass="TextBoxPasswordRegister" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="TextBoxPasswordConfirmationRegister1" runat="server" CssClass="TextBoxPasswordConfirmationRegister" TextMode="Password"></asp:TextBox>       
        <asp:Button ID="BoutonValiderRegister" runat="server" CssClass="BoutonValiderRegister" OnClick="BoutonValiderRegister_Click" Text="Ok" />
        <p>

        </p>
        <asp:Label ID="Erreur" runat="server" CssClass="ErreurRegister" Font-Bold="True" ForeColor="#CC3300"></asp:Label>
        <asp:Label ID="ErreurLogin" runat="server" CssClass="ErreurLogin"></asp:Label>
        <asp:Button ID="Deconnexion" runat="server" CssClass="BoutonDeconnexion" Text="Deconnexion" OnClick="Deconnexion_Click" />
    </form>
    <p>
        <img id="Pub1" alt="" class="Pub1" src="Image/Pub1.PNG" /></p>
    <img id="Pub2" alt="" class="Pub2" src="Image/Pub2.PNG" />
    </body>
</html>
