using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table Article
    /// </summary>
    public class ArticleBO
    {
        
        private int idArt;

        /// <summary>
        /// Identifiant de l'article
        /// </summary>
        public int IdArt
        {
            get { return idArt; }
            set { idArt = value; }
        }
             
        private string libelleArt;

        /// <summary>
        /// Libellé de l'article
        /// </summary>
        public string LibelleArt
        {
            get { return libelleArt; }
            set 
            {                
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un article dont le libellé n'est pas saisi !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider un article dont le libellé dépasse 50 caractères!");
                }

                libelleArt = value; 
            }
        }
        
        private int prixAchatArt;

        /// <summary>
        /// Prix d'achat de l'article
        /// </summary>
        public int PrixAchatArt
        {
            get { return prixAchatArt; }
            set 
            {
                int tmp = value;

                if(tmp <= 0)
                {
                    throw new AppValidationException("Impossible de valider un article dont le prix d'achat est inferieur ou egal a 0 !");
                }

                prixAchatArt = value; 
            }
        }
        
        private int prixVenteArt;

        /// <summary>
        /// Prix de vente de l'article
        /// </summary>
        public int PrixVenteArt
        {
            get { return prixVenteArt; }
            set 
            {
                int tmp = value;

                if (tmp <= 0)
                {
                    throw new AppValidationException("Impossible de valider un article dont le prix de vente est inferieur ou egal a 0 !");
                }

                prixVenteArt = value; 
            }
        }

        private int prixEnGros;

        public int PrixEnGros
        {
            get { return prixEnGros; }
            set 
            {   /*
                int tmp = value;

                if (tmp <= 0)
                {
                    throw new AppValidationException("Impossible de valider un article dont le prix de vente en gros est inferieur ou egal a 0 !");
                }
                */
                prixEnGros = value; 
            }
        }


        private int prixEnDemiGros;

        public int PrixEnDemiGros
        {
            get { return prixEnDemiGros; }
            set { prixEnDemiGros = value; }
        }

        private int qteEnGros;

        public int QteEnGros
        {
            get { return qteEnGros; }
            set 
            {  /*
                int tmp = value;

                if (tmp <= 0)
                {
                    throw new AppValidationException("Impossible de valider un article dont la quantite en gros est inferieure ou egale a 0 !");
                }
                */
                qteEnGros = value; 
            }
        } 

        private int coutSortie;

        /// <summary>
        /// Coût de sortie de l'article
        /// </summary>
        public int CoutSortie
        {
            get { return coutSortie; }
            set { coutSortie = value; }
        }
        
        private int seuilArt;

        /// <summary>
        /// Seuil de sortie de l'article
        /// </summary>
        public int SeuilArt
        {
            get { return seuilArt; }
            set { seuilArt = value; }
        }
       
        private int qteStockArt;

        /// <summary>
        /// Quantité du stock
        /// </summary>
        public int QteStockArt
        {
            get { return qteStockArt; }
            set { qteStockArt = value; }
        }
        
        private CategorieBO categorie = new CategorieBO();

        /// <summary>
        /// Catégorie de l'article
        /// </summary>
        public CategorieBO Categorie
        {
            get { return categorie; }
            set 
            { 
                categorie = value;

                if (categorie.IdCat <= 0)
                {
                    throw new AppValidationException("Impossible de valider cet article! Veuillez sélectionner une catégorie !");
                }
            }
        }

        /// <summary>
        /// Id de l'utilisateur 
        /// </summary>
        private int idUser;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }


        /// <summary>
        /// Date à laquelle l'entrée/sortie s'est effectuée
        /// </summary>
        private DateTime dateEnreg;

        public DateTime DateEnreg
        {
            get { return dateEnreg; }
            set { dateEnreg = value; }
        }

        /// <summary>
        /// Id de l'utilisateur 
        /// </summary>
        private int codeValidite;

        public int CodeValidite
        {
            get { return codeValidite; }
            set { codeValidite = value; }
        }


        /// <summary>
        /// La valeur ToString renvoyée est le libellé du produit
        /// </summary>
        /// <returns>Renvoie un string</returns>
        public override string ToString()
        {
            return this.libelleArt;
        }


        
 
        /// <summary>
        /// Constructeur de l'article
        /// </summary>
        public ArticleBO()
        {
            
        }
    }

    /// <summary>
    /// Liste des Articles
    /// </summary>
    public class ArticleBOListView : BusinessObjectListView<ArticleBO>
    {

    }
}
