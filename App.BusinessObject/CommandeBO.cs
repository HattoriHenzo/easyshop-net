using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table Commande
    /// </summary>
    public class CommandeBO
    {
        /// <summary>
        /// Id de la commande
        /// </summary>
        private int idCom;

        public int IdCom
        {
            get { return idCom; }
            set { idCom = value; }
        }

        /// <summary>
        /// Numéro de la commande
        /// </summary>
        private int numCom;

        public int NumCom
        {
            get { return numCom; }
            set { numCom = value; }
        }

        /// <summary>
        /// Numéro de la commande
        /// </summary>
        private string numComText;

        public string NumComText
        {
            get { return numComText; }
            set { numComText = value; }
        }

        /// <summary>
        /// Date à laquelle la commande est passée
        /// </summary>
        private DateTime dateCom;

        public DateTime DateCom
        {
            get { return dateCom; }
            set { dateCom = value; }
        }

        /// <summary>
        /// Heure à laquelle la commande est passée
        /// </summary>
        private string heureCom;

        public string HeureCom
        {
            get { return heureCom; }
            set { heureCom = value; }
        }

        /// <summary>
        /// Description de la commande
        /// </summary>
        private string descCom;

        public string DescCom
        {
            get { return descCom; }
            set { descCom = value; }
        }

        /// <summary>
        /// Indique si une commande est annulée ou non
        /// </summary>
        private bool annulerCom;

        public bool AnnulerCom
        {
            get { return annulerCom; }
            set { annulerCom = value; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public CommandeBO()
        {
        }
    }

    /// <summary>
    /// Liste des commandes 
    /// </summary>
    public class CommandeBOListView : BusinessObjectListView<CommandeBO>
    {
    }
}
