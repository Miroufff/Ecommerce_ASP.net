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
                Paniervide.Visible = true;
                Viderlepanier.Visible = false;
                TextBoxLogin.Visible = false;
                TextBoxPassword.Visible = false;
                Button1.Visible = false;
                Login1.Visible = false;
                Password.Visible = false;
                Deconnexion.Visible = true;
                Viderlepanier.Visible = false;
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
                        Paniervide.Visible = false;
                        PrixTotalCalcule.Visible = true;
                        PrixTotalLabel.Visible = true;
                        Viderlepanier.Visible = true;

                    }

                    foreach (TableRow PrixTotal in GridView1.Rows)
                    {
                        Total = Total + Convert.ToDouble(PrixTotal.Cells[3].Text);
                    }
                    PrixTotalCalcule.Text = Total + "€";
                }
                else
                {
                    Response.Redirect("Panier.aspx");
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

        protected void Viderlepanier_Click(object sender, EventArgs e)
        {
            Session["Panier"] = null;
            GridView1.DataSource = Session["Panier"];
            GridView1.DataBind();
            Session["Panier"] = new List<ClassePanier>();
            Response.Redirect("Panier.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}