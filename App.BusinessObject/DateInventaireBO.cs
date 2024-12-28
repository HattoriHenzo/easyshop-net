using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table DateInventaire
    /// </summary>
    public class DateInventaireBO
    {
        /// <summary>
        /// Id de la date d'inventaire
        /// </summary>
        private int idDateInv;

        public int IdDateInv
        {
            get { return idDateInv; }
            set { idDateInv = value; }
        }

        /// <summary>
        /// Observation pour la date d'inventaire
        /// </summary>
        private string observationInv;

        public string ObservationInv
        {
            get { return observationInv; }
            set { observationInv = value; }
        }

        /// <summary>
        /// Date à laquelle se passe l'inventaire
        /// </summary>
        private DateTime dateInv;

        public DateTime DateInv
        {
            get { return dateInv; }
            set { dateInv = value; }
        }

        /// <summary>
        /// Heure à laquelle se passe l'inventaire
        /// </summary>
        private string heureInv;

        public string HeureInv
        {
            get { return heureInv; }
            set { heureInv = value; }
        }

        /// <summary>
        /// Détermine si un inventaire est déjà validé ou pas
        /// </summary>
        private bool valideInv;

        public bool ValideInv
        {
            get { return valideInv; }
            set { valideInv = value; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public DateInventaireBO()
        {
        }
    }

    /// <summary>
    /// Liste des date inventaires
    /// </summary>
    public class DateInventaireBOListView : BusinessObjectListView<DateInventaireBO>
    {
    }
}
