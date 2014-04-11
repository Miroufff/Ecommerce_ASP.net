using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projet_ECommerce.classes;

namespace Projet_ECommerce
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Log"].Equals(true))
             {
                TextBoxLogin.Visible = false;
                TextBoxPassword.Visible = false;
                BoutonValiderConnexion.Visible = false;
                Login1.Visible = false;
                Password.Visible = false;
                Deconnexion.Visible = true;
            }
            else
            {
                TextBoxLogin.Visible = true;
                TextBoxPassword.Visible = true;
                BoutonValiderConnexion.Visible = true;
                Login1.Visible = true;
                Password.Visible = true;
                Deconnexion.Visible = false;
            }
        }

        protected void BoutonValiderRegister_Click(object sender, EventArgs e)
        {
            Session["Log"] = true;
            ClassePersonne Personne = new ClassePersonne();
            if (TextBoxPasswordRegister1.Text.Equals(TextBoxPasswordConfirmationRegister1.Text))
            {
                Personne.Login = this.TextBoxLoginRegister1.Text;
                Personne.Password = this.TextBoxPasswordConfirmationRegister1.Text;
                ClassePersonneDB.AjouterUser(Personne);
                Erreur.Text = "Inscription Terminé !";
            }
            else
            {
                Erreur.Text = "Essayez encore !";
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
                BoutonValiderConnexion.Visible = true;
                Login1.Visible = true;
                Password.Visible = true;
                Deconnexion.Visible = false;
            }
        }

        protected void BoutonValiderConnexion_Click(object sender, EventArgs e)
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
                    BoutonValiderConnexion.Visible = false;
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
    }
}