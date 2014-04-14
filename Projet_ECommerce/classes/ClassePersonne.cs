using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Projet_ECommerce.classes
{
    public class ClassePersonne
    {
        #region Attribut

        private Int64 _Identifiant;
        private String _Login;
        private String _Password;

        #endregion

        #region Propriété

        public Int64 Identifiant
        {
            get { return _Identifiant; }
            set { _Identifiant = value; }
        }

        public String Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    
        #endregion

        #region Constructeur
            
        #endregion
    }
}