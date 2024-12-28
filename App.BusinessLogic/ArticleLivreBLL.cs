using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    [DataObject]
    public class ArticleLivreBLL
    {
        private ArticleLivreDAL dataAccess;

        public ArticleLivreBLL()
        {
            this.dataAccess = new ArticleLivreDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des Articles Livr�s en fonction de la livraison
        /// </summary>
        /// <param name="idLiv">Id de la livraison</param>
        /// <returns>Renvoie un ArticleLivreBOListView</returns>
        public ArticleLivreBOListView GetArticleLivresByLivraisonId(int idLiv)
        {
            return this.dataAccess.GetArticleLivresByLivraisonIdFromDB(idLiv);
        }

        /// <summary>
        /// Renvoie le dernier Id ins�r� dans la base de donn�es
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "ArticleLivre";
            string idName = "IdArtLiv";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui effectue l'insertion dans la base de donn�es
        /// </summary>
        /// <param name="a">Article livr�</param>
        /// <param name="c">Article command�</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(ArticleLivreBO a, CommanderBO c)
        {
            foreach (ArticleLivreBO art in this.dataAccess.GetArticleLivresByLivraisonIdFromDB(a.IdLiv))
            {
                if (a.IdArt == art.IdArt)
                {
                    throw new AppException("Impossible de valider cet article ! Il a d�j� fait objet de livraison !");
                }
            }

            if (a.QteArtLiv > c.QteCom)
            {
                throw new AppException("Impossible de valider une quantit� livr�e sup�rieure � la quantit� command�e !");
            }

            return this.dataAccess.InsertArticleLivre(a.QteArtLiv, a.PrixLiv, a.IdArt, a.IdLiv);
        }

        /// <summary>
        /// Fonction qui effectue la modifcation
        /// </summary>
        /// <param name="a">Article � modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(ArticleLivreBO a)
        {            
            return this.dataAccess.UpdateArticleLivre(a.IdArtLiv, a.QteArtLiv, a.PrixLiv, a.IdArt, a.IdLiv);
        }

        /// <summary>
        /// Fonction qui effectue la modifcation
        /// </summary>
        /// <param name="a">Article � modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int UpdateQuantite(ArticleLivreBO a)
        {
            return this.dataAccess.UpdateQuantiteArticleLivre(a.QteArtLiv, a.IdArtLiv);
        }

        /// <summary>
        /// Fonction qui effectue la suppression
        /// </summary>
        /// <param name="idartliv">Id de l'enreg. � supprimer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(int idArtLiv)
        {
            return this.dataAccess.DeleteArticleLivre(idArtLiv);
        }
    }
}
