using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projet_ECommerce.classes;

namespace Projet_ECommerce
{
    public partial class Panier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Log"].Equals(true))
            {
                TextBoxLogin.Visible = false;
                TextBoxPassword.Visible = false;
                Button1.Visible = false;
                Login1.Visible = false;
                Password.Visible = false;
                Deconnexion.Visible = true;
                double Total;
                Total = 0;

                PrixTotalCalcule.Visible = false;
                PrixTotalLabel.Visible = false;
                if (Session["Panier"] != null)
                {
                    GridView1.DataSource = Session["Panier"];
                    GridView1.DataBind();
                    List<ClassePanier> Lt;
                    Lt = (List<ClassePanier>)Session["Panier"];
                    if (Lt.Count > 0)
                    {
                        PrixTotalCalcule.Visible = true;
                        PrixTotalLabel.Visible = true;
                    }

                    foreach (TableRow PrixTotal in GridView1.Rows)
                    {
                        Total = Total + Convert.ToDouble(PrixTotal.Cells[4].Text);
                    }
                    PrixTotalCalcule.Text = Total + "€";
                }
                else
                {
                    Response.Redirect("default.aspx");
                }
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
                Response.Redirect("Panier.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ClassePanier> Lt;
            if (Session["Panier"] != null)
            {
                Lt = (List<ClassePanier>)Session["Panier"];
                ClassePanier Panier = new ClassePanier();
                foreach (ClassePanier panier in Lt)
                {
                    if (panier.NomProduit.Equals("Hoegaarden"))
                    {
                        panier.Quantite = panier.Quantite - 1;
                        panier.PrixTotal = panier.Prix * panier.Quantite;
                        if (panier.Quantite == 0)
                        {
                            Lt.RemoveAt(0);
                            Session["Session"] = Lt;
                            Response.Redirect("Panier.aspx");
                        }
                    }
                    if (panier.NomProduit.Equals("Weed"))
                    {
                        panier.Quantite = panier.Quantite - 1;
                        panier.PrixTotal = panier.Prix * panier.Quantite;
                        if (panier.Quantite == 0)
                        {
                            Lt.RemoveAt(1);
                            Session["Session"] = Lt;
                            Response.Redirect("Panier.aspx");
                        }
                    }
                    if (panier.NomProduit.Equals("Leffe"))
                    {
                        panier.Quantite = panier.Quantite - 1;
                        panier.PrixTotal = panier.Prix * panier.Quantite;
                        if (panier.Quantite == 0)
                        {
                            Lt.RemoveAt(2);
                            Session["Session"] = Lt;
                            Response.Redirect("Panier.aspx");
                        }
                    }
                    if (panier.NomProduit.Equals("Kronenbourg"))
                    {
                        panier.Quantite = panier.Quantite - 1;
                        panier.PrixTotal = panier.Prix * panier.Quantite;
                        if (panier.Quantite == 0)
                        {
                            Lt.RemoveAt(3);
                            Session["Session"] = Lt;
                            Response.Redirect("Panier.aspx");
                        }
                    }
                }

                Session["Session"] = Lt;
                Response.Redirect("Panier.aspx");
            }
        }
    }
}