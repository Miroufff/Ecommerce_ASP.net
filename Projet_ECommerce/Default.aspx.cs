using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projet_ECommerce.classes;
using System.Data;
using System.Drawing; 

namespace Projet_ECommerce
{
    public partial class Default : System.Web.UI.Page
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
            }
        }
    }
}