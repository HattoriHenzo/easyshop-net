using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    public class DepenseBO
    {
        private int idDep;

        public int IdDep
        {
            get { return idDep; }
            set { idDep = value; }
        }

        private DateTime date = new DateTime();

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private String objet;

        public String Objet
        {
            get { return objet; }
            set { objet = value; }
        }

        private int montant;

        public int Montant
        {
            get { return montant; }
            set { montant = value; }
        }

        public DepenseBO()
        {

        }
    }

    /// <summary>
    /// Représente la liste des depenses
    /// </summary>
    public class DepenseBOListView : BusinessObjectListView<DepenseBO>
    {

    }
}
