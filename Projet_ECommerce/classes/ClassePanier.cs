using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Projet_ECommerce.classes
{
    public class ClassePanier
    {
        
        #region Attribut

        private String _NomProduit;
        private double _Prix;
        private int _Quantite;
        private double _PrixTotal;
        private int _Stock;
        
        #endregion

        #region Propriété

        public String NomProduit
        {
            get { return _NomProduit; }
            set { _NomProduit = value; }
        }

        public double Prix
        {
            get { return _Prix; }
            set { _Prix = value; }
        }

        public int Quantite
        {
            get { return _Quantite; }
            set { _Quantite = value; }
        }

        public double PrixTotal
        {
            get { return _PrixTotal; }
            set { _PrixTotal = value; }
        }

        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }
        
        #endregion
    }
}