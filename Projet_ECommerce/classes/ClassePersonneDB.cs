using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Text;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing; 

namespace Projet_ECommerce.classes
{
    public class ClassePersonneDB
    {
        public static List<ClassePersonne> List()
        {
            //Récupération de la chaine de connexion
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EcommerceConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = "SELECT Identifiant, Libelle FROM Personne";
            connection.Open();
            SqlCommand commande = new SqlCommand(requete, connection);
            //execution

            SqlDataReader dataReader = commande.ExecuteReader();

            List<ClassePersonne> list = new List<ClassePersonne>();
            while (dataReader.Read())
            {
                //1 - Créer un groupe à partir des donner de la ligne du dataReader
                ClassePersonne Personne = new ClassePersonne();
                Personne.Identifiant = dataReader.GetInt64(0);

                Personne.Login = dataReader.GetString(1);
                Personne.Password = dataReader.GetString(1);

                //2 - Ajouter cette civilité à la list de civilité
                list.Add(Personne);
            }
            dataReader.Close();
            connection.Close();
            return list;
        }

        /// <summary>
        /// Récupère un groupe à partir d'un identifiant de groupe
        /// </summary>
        /// <param name="Identifiant">Identifant de groupe</param>
        /// <returns>Une groupe</returns>
        public static ClassePersonne Get(Int64 identifiant)
        {
            //Connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EcommerceConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            //Commande
            String requete = @"SELECT Identifiant, Login, Password FROM Personne
                                WHERE Identifiant = @Identifiant";
            SqlCommand commande = new SqlCommand(requete, connection);

            //Paramètres
            commande.Parameters.AddWithValue("Identifiant", identifiant);

            //Execution
            connection.Open();
            SqlDataReader dataReader = commande.ExecuteReader();

            dataReader.Read();

            //1 - Création de la civilite
            ClassePersonne Personne = new ClassePersonne();


            Personne.Identifiant = dataReader.GetInt64(0);
            Personne.Login = dataReader.GetString(1);
            Personne.Password = dataReader.GetString(1);
            dataReader.Close();
            connection.Close();
            return Personne;
        }

        public static ClassePersonne AjouterUser(ClassePersonne Personne)
        {
            
              
            //connection
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EcommerceConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());
            try
            {
            //commande
            SqlCommand commande = new SqlCommand();
            commande.Connection = connection;
            commande.CommandText = @"INSERT INTO dbo.Personne(Login, Password) VALUES(@Login, @Password); 
                                    SELECT SCOPE_IDENTITY();";
            //paramètre
            commande.Parameters.AddWithValue("Login", Personne.Login);
            commande.Parameters.AddWithValue("Password", Personne.Password);
              //execution
                connection.Open();
                Decimal IdentifiantDernierAjout = (Decimal)commande.ExecuteScalar();
                return ClassePersonneDB.Get((Int64)IdentifiantDernierAjout);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Boolean Validate_Login(String Login, String Password)
        {
            //connection
            ClassePersonne Personne = new ClassePersonne();
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EcommerceConnectionString"];
            SqlConnection connection = new SqlConnection(connectionStringSettings.ToString());

            SqlCommand commande = new SqlCommand();
            //commande
            commande.Connection = connection;
            commande.CommandText = @"SELECT count(*) AS Retour FROM Personne
                                    WHERE Login = @Login And Password = @Password;";
            //paramètre
            commande.Parameters.AddWithValue("Login", Login);
            commande.Parameters.AddWithValue("Password", Password);

            try
            {
                //execution
                connection.Open();

                SqlDataReader Rd = commande.ExecuteReader();

                Rd.Read();

                if (Rd.GetInt32(0) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception)
            {

                throw;
            }

            finally
            {
                commande.Dispose();

                if (connection != null)
                {
                    connection.Close();
                }
            }

        } 
    }
}