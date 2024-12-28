using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table ArreteDeCaisse
    /// </summary>
    public class ArreteDeCaisseBO
    {
        /// <summary>
        /// Id de l'arrêté de caisse
        /// </summary>
        private int idAC;

        public int IdAC
        {
            get { return idAC; }
            set { idAC = value; }
        }

        /// <summary>
        /// Date à laquelle l'arrêté de caisse a été effectué
        /// </summary>
        private DateTime dateAC;

        public DateTime DateAC
        {
            get { return dateAC; }
            set { dateAC = value; }
        }

        /// <summary>
        /// Heure à laquelle l'arrêté de la caisse a été effectué
        /// </summary>
        private string heureAC;

        public string HeureAC
        {
            get { return heureAC; }
            set { heureAC = value; }
        }

        /// <summary>
        /// Montant en caisse
        /// </summary>
        private int montantEnCaisse;

        public int MontantEnCaisse
        {
            get { return montantEnCaisse; }
            set { montantEnCaisse = value; }
        }

        /// <summary>
        /// Montant dans la base
        /// </summary>
        private int montantBase;

        public int MontantBase
        {
            get { return montantBase; }
            set { montantBase = value; }
        }

        /// <summary>
        /// Vérifie si l'arrêté de caisse est conforme
        /// </summary>
        private bool conformeAC;

        public bool ConformeAC
        {
            get { return conformeAC; }
            set { conformeAC = value; }
        }

        /// <summary>
        /// Représente l'observation faite à l'issue d'un arrêté de caisse
        /// </summary>
        private string observationAC;

        public string ObservationAC
        {
            get { return observationAC; }
            set { observationAC = value; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public ArreteDeCaisseBO()
        {
        }
    }

    /// <summary>
    /// Représente la liste des arrêtés de caisse
    /// </summary>
    public class ArreteDeCaisseBOListView : BusinessObjectListView<ArreteDeCaisseBO>
    {

    }
}
