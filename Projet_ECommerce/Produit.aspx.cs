using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projet_ECommerce.classes;

namespace Projet_ECommerce
{
    public partial class Produit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Boolean Results = false;
            Results = ClassePersonneDB.Validate_Login(TextBoxLogin.Text.Trim(), TextBoxPassword.Text.Trim());
            if (Session["Log"].Equals(true))
            {
                TextBoxLogin.Visible = false;
                TextBoxPassword.Visible = false;
                Button1.Visible = false;
                Login1.Visible = false;
                Password.Visible = false;
                Deconnexion.Visible = true;
            }
            else
            {
                TextBoxLogin.Visible = true;
                TextBoxPassword.Visible = true;
                Button1.Visible = true;
                Login1.Visible = true;
                Password.Visible = true;
                Deconnexion.Visible = false;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Boolean Results = false;

            if (TextBoxLogin.Text != String.Empty && TextBoxPassword.Text != String.Empty)
            {
                Results = ClassePersonneDB.Validate_Login(TextBoxLogin.Text.Trim(), TextBoxPassword.Text.Trim());
                if (Results == true)
                {
                    Session["Log"] = true;
                    ErreurLogin.Text = "Vous êtes connecté";
                    TextBoxLogin.Visible = false;
                    TextBoxPassword.Visible = false;
                    Button1.Visible = false;
                    Login1.Visible = false;
                    Password.Visible = false;
                    Deconnexion.Visible = true;
                }
                else
                {
                    ErreurLogin.Text = "Connection impossible";
                }
            }
            else
            {
                ErreurLogin.Text = "Please make sure that the username and the password is Correct";
            }
        }

        protected void Deconnexion_Click(object sender, EventArgs e)
        {
            Boolean Results = false;
            if (Results == false)
            {
                Session["Log"] = false;
                TextBoxLogin.Visible = true;
                TextBoxPassword.Visible = true;
                Button1.Visible = true;
                Login1.Visible = true;
                Password.Visible = true;
                Deconnexion.Visible = false;
                Response.Redirect("Produit.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<ClassePanier> Lt;
            bool trouve = false;
            if (Session["Log"].Equals(true))
            {
               if (Session["Panier"] != null)
               {
                    Lt = (List<ClassePanier>)Session["Panier"];
                    ClassePanier Panier = new ClassePanier();
                    foreach (ClassePanier panier in Lt)
                    {
                        if (panier.NomProduit.Equals("Hoegaarden"))
                        {
                            Panier = panier;
                            trouve = true;
                        }
                    }

                    Panier.NomProduit = "Hoegaarden";
                    Panier.Prix = 34.00;
                    Panier.Quantite = Panier.Quantite + Convert.ToInt16(this.TextBoxAjouterProduit1.Text);
                    Panier.PrixTotal = Panier.Prix * Panier.Quantite;
                    if (trouve == false) Lt.Add(Panier);
                    Session["Session"] = Lt;
                    Response.Redirect("Produit.aspx");
                } 
            }
            else
            {
                ErreurConnection.Text = "Vous devez être connecté !";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<ClassePanier> Lt;
            bool trouve = false;
            if (Session["Log"].Equals(true))
            {
                if (Session["Panier"] != null)
                {
                    Lt = (List<ClassePanier>)Session["Panier"];
                    ClassePanier Panier = new ClassePanier();
                    foreach (ClassePanier panier in Lt)
                    {
                        if (panier.NomProduit.Equals("Weed"))
                        {
                            Panier = panier;
                            trouve = true;
                        }
                    }

                    Panier.NomProduit = "Weed";
                    Panier.Prix = 19.50;
                    Panier.Quantite = Panier.Quantite + Convert.ToInt16(this.TextBoxAjouterProduit2.Text);
                    Panier.PrixTotal = Panier.Prix * Panier.Quantite;
                    if (trouve == false) Lt.Add(Panier);
                    Session["Session"] = Lt;
                    Response.Redirect("Produit.aspx");
                }
            }
            else
            {
                ErreurConnection.Text = "Vous devez être connecté !";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            List<ClassePanier> Lt;
            bool trouve = false;
            if (Session["Log"].Equals(true))
            {
                if (Session["Panier"] != null)
                {
                    Lt = (List<ClassePanier>)Session["Panier"];
                    ClassePanier Panier = new ClassePanier();
                    foreach (ClassePanier panier in Lt)
                    {
                        if (panier.NomProduit.Equals("Leffe"))
                        {
                            Panier = panier;
                            trouve = true;
                        }
                    }

                    Panier.NomProduit = "Leffe";
                    Panier.Prix = 33.40;
                    Panier.Quantite = Panier.Quantite + Convert.ToInt16(this.TextBoxAjouterProduit3.Text);
                    Panier.PrixTotal = Panier.Prix * Panier.Quantite;
                    if (trouve == false) Lt.Add(Panier);
                    Session["Session"] = Lt;
                    Response.Redirect("Produit.aspx");
                }
            }
            else
            {
                ErreurConnection.Text = "Vous devez être connecté !";
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            List<ClassePanier> Lt;
            bool trouve = false;
            if (Session["Log"].Equals(true))
            {
               if (Session["Panier"] != null)
               {
                    Lt = (List<ClassePanier>)Session["Panier"];
                    ClassePanier Panier = new ClassePanier();
                    foreach (ClassePanier panier in Lt)
                    {
                        if (panier.NomProduit.Equals("Kronenbourg"))
                        {
                            Panier = panier;
                            trouve = true;
                        }
                    }

                    Panier.NomProduit = "Kronenbourg";
                    Panier.Prix = 17.00;
                    Panier.Quantite = Panier.Quantite + Convert.ToInt16(this.TextBoxAjouterProduit4.Text);
                    Panier.PrixTotal = Panier.Prix * Panier.Quantite;
                    if (trouve == false) Lt.Add(Panier);
                    Session["Session"] = Lt;
                    Response.Redirect("Produit.aspx");
                } 
            }
            else
            {
                ErreurConnection.Text = "Vous devez être connecté !";
            }
            
        }
    }
}