using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;


namespace App.BusinessLogic
{
    /// <summary>
    /// Classe qui implémente les règles de gestion de la table Article
    /// </summary>
    [DataObject]
    public class ArticleBLL
    {
       
        private ArticleDAL dataAccess;

        public ArticleBLL()
        {
            this.dataAccess = new ArticleDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des articles
        /// </summary>
        /// <returns>Renvoie un ArticleDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ArticleBOListView GetArticles(string libelleArt)
        {
            return this.dataAccess.GetArticlesFromDB(libelleArt);
        }

        public ArticleBOListView GetArticlesWithPrice(string libelleArt)
        {
            return this.dataAccess.GetArticlesWithPriceFromDB(libelleArt);
        }

        /// <summary>
        /// Fonction qui renvoie un article donné
        /// </summary>
        /// <param name="idArt">Id de l'article</param>
        /// <returns>Renvoie un article</returns>
        public ArticleBO GetArticleById(int idArt)
        {
            return this.dataAccess.GetArticleByIdFromDB(idArt);
        }

        /// <summary>
        /// Fonction qui renvoie la liste des articles en fonction de la catégorie
        /// </summary>
        /// <param name="idcat"></param>
        /// <returns>Renvoie un CategorieDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select,true)]
        public ArticleBOListView GetArticlesByCategorieId(ArticleBO a)
        {
            return this.dataAccess.GetArticlesByCategorieIdFromDB(a.Categorie.IdCat);
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Article";
            string idName = "IdArt";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui renvoie la disponibilité d'un produit donné
        /// </summary>
        /// <param name="id">Id du produit à rechercher</param>
        /// <returns>Renvoie un entier</returns>
        public int IsAvailable(int id)
        {           
            int res = 0, seuil = 0, qte = 0;

            seuil = this.dataAccess.GetArticleByIdFromDB(id).SeuilArt;
            qte = this.dataAccess.GetArticleByIdFromDB(id).QteStockArt;

            //Cas ou la produit disponible
            if (qte > seuil)
            {
                res = 1;
            }

            //Cas ou le seuil est atteint
            if (qte <= seuil)
            {
                res = 2;
            }

            //Cas ou le produit n'est plus disponible
            if (qte <= 0)
            {
                res = 3;
            }

            return res;
        }

        /// <summary>
        /// Fonction qui effectue une insertion dans la base de données
        /// </summary>
        /// <param name="a">Représente l'article à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(ArticleBO a)
        {           
            if ((a.PrixAchatArt <= 0) && (a.PrixVenteArt <= 0) && (a.SeuilArt <= 0) && (a.QteStockArt <= 0))
            {
                throw new AppException("Impossible de valider l'article. Veuillez saisir des valeurs !");
            }            

            if (a.SeuilArt <= 0)
            {
                throw new AppException("Impossible de valider un seuil inférieur ou égal à 0 !");
            }

            /*if (a.QteStockArt <= 0)
            {
                throw new AppException("Impossible de saisir une quantité de stock inférieure à 0");
            }*/
          
            foreach (ArticleBO art in this.dataAccess.GetArticlesFromDB(string.Empty))
            {
                if (art.LibelleArt == a.LibelleArt)
                {
                    throw new AppException("Un article avec la désignation '" + a.LibelleArt + "' existe déjà !");
                }
            }

            return this.dataAccess.InsertArticle(a.LibelleArt, a.PrixAchatArt, a.PrixVenteArt, a.PrixEnGros, a.PrixEnDemiGros, a.QteEnGros, a.CoutSortie, a.SeuilArt, a.QteStockArt, a.IdUser, a.DateEnreg, a.CodeValidite, a.Categorie.IdCat);            
        }

        /// <summary>
        /// Fonction qui effectue la modification d'un article
        /// </summary>
        /// <param name="a">Représente l'article à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(ArticleBO a)
        {
            if ((a.PrixAchatArt <= 0) && (a.PrixVenteArt <= 0) && (a.SeuilArt <= 0) && (a.QteStockArt <= 0))
            {
                throw new AppException("Impossible de valider l'article. Veuillez saisir des valeurs !");
            }

            /*if ((a.PrixAchatArt <= 0) || (a.PrixVenteArt <= 0))
            {
                throw new AppException("Impossible de valider un montant égal à 0 !");
            }*/

            if (a.SeuilArt <= 0)
            {
                throw new AppException("Impossible de valider un seuil inférieur ou égal à 0 !");
            }

            if (a.QteStockArt <= 0)
            {
                throw new AppException("Impossible de saisir une quantité inférieure à 0");
            }

            foreach (ArticleBO art in this.dataAccess.GetArticlesFromDB(string.Empty))
            {
                if (art.LibelleArt == a.LibelleArt)
                {
                    if (art.IdArt != a.IdArt)
                    {
                        throw new AppException("Un article avec la désignation '" + a.LibelleArt + "' existe déjà !");
                    }                    
                }
            }
  
            return this.dataAccess.UpdateArticle(a.IdArt, a.LibelleArt, a.PrixAchatArt, a.PrixVenteArt, a.PrixEnGros, a.PrixEnDemiGros, a.QteEnGros,  a.CoutSortie, a.SeuilArt, a.QteStockArt, a.IdUser, a.DateEnreg, a.CodeValidite, a.Categorie.IdCat);
        }

        /// <summary>
        /// Fonction qui effectue la modification de la quantité
        /// </summary>
        /// <param name="qteart">Quantité de l'article</param>
        /// <param name="idart">Id de l'article</param>
        /// <returns>Renvoie une entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int UpdateQuantite(int qteArt, int idArt)
        {
            return this.dataAccess.UpdateQuantiteArticle(qteArt, idArt);
        }    
        
        public int Delete(int idArt)
        {
            return this.dataAccess.DeleteArticle(idArt);
        }    
    }
}
