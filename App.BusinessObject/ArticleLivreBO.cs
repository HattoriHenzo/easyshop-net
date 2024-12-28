using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table ArticleLivre
    /// </summary>
    public class ArticleLivreBO
    {
        /// <summary>
        /// Id de la table ArticleLivre
        /// </summary>
        private int idArtLiv;

        public int IdArtLiv
        {
            get { return idArtLiv; }
            set { idArtLiv = value; }
        }

        /// <summary>
        /// Libellé de l'article
        /// </summary>
        private string libelleArt;

        public string LibelleArt
        {
            get { return libelleArt; }
            set { libelleArt = value; }
        }

        /// <summary>
        /// Qté de l'article livré
        /// </summary>
        private int qteArtLiv;

        public int QteArtLiv
        {
            get { return qteArtLiv; }
            set { qteArtLiv = value; }
        }

        /// <summary>
        /// Prix de la livraison
        /// </summary>
        private int prixLiv;

        public int PrixLiv
        {
            get { return prixLiv; }
            set { prixLiv = value; }
        }

        /// <summary>
        /// Id de l'article
        /// </summary>
        private int idArt;

        public int IdArt
        {
            get { return idArt; }
            set 
            { 
                idArt = value;               
            }
        }

        /// <summary>
        /// Id de la livraison
        /// </summary>
        private int idLiv;

        public int IdLiv
        {
            get { return idLiv; }
            set 
            { 
                idLiv = value;               
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public ArticleLivreBO()
        {
        }
    }

    /// <summary>
    /// Liste des ArticleLivre
    /// </summary>
    public class ArticleLivreBOListView : BusinessObjectListView<ArticleLivreBO>
    {
    }
}
