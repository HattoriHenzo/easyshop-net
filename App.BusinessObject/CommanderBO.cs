using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table commander
    /// </summary>
    public class CommanderBO
    {
        /// <summary>
        /// Id de la table commander
        /// </summary>
        private int idComder;

        public int IdComder
        {
            get { return idComder; }
            set { idComder = value; }
        }

        private string libelleArt;

        /// <summary>
        /// Libelle de l'article
        /// </summary>
        public string LibelleArt
        {
            get { return libelleArt; }
            set { libelleArt = value; }
        }

        /// <summary>
        /// Qte de la commande
        /// </summary>
        private int qteCom;

        public int QteCom
        {
            get { return qteCom; }
            set 
            { 
                qteCom = value;

                if (qteCom <= 0)
                {
                    throw new AppValidationException("Impossible de valider une quantité égale à 0 !");
                }
            }
        }

        /// <summary>
        /// Prix de la commande
        /// </summary>
        private int prixCom;

        public int PrixCom
        {
            get { return prixCom; }
            set 
            { 
                prixCom = value;

                if (prixCom <= 0)
                {
                    throw new AppValidationException("Impossible de valider un prix égale à 0 !");
                }
            }
        }

        /// <summary>
        /// Total de la commande
        /// </summary>
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        /// <summary>
        /// Id de l'article
        /// </summary>
        private int idArt;

        public int IdArt
        {
            get { return idArt; }
            set { idArt = value; }
        }

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
        /// Id du fournisseur
        /// </summary>
        private int idFour;

        public int IdFour
        {
            get { return idFour; }
            set { idFour = value; }
        }

        /// <summary>
        /// Raison sociale du fournisseur
        /// </summary>
        private string raisonSocialeFour;

        public string RaisonSocialeFour
        {
            get { return raisonSocialeFour; }
            set { raisonSocialeFour = value; }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public CommanderBO()
        {
        }
    }
    
    /// <summary>
    /// Liste des commandes
    /// </summary>
    public class CommanderBOListView : BusinessObjectListView<CommanderBO>
    {
    	
    }
}
