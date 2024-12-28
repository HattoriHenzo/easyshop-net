using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    public class VenteBO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String numeroVente;

        public String NumeroVente
        {
            get { return numeroVente; }
            set { numeroVente = value; }
        }

        private DateTime dateVente;

        public DateTime DateVente
        {
            get { return dateVente; }
            set { dateVente = value; }
        }

        public VenteBO()
        {

        }
    }

    /// <summary>
    /// Représente la liste des Ventes
    /// </summary>
    public class VenteBOListView : BusinessObjectListView<VenteBO>
    {

    }
}
