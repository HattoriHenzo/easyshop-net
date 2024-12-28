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
    /// <summary>
    /// Classe qui implémente les règles de gestion de la table inventaire
    /// </summary>
    [DataObject]
    public class InventaireBLL
    {        
        private InventaireDAL dataAccess;

        public InventaireBLL()
        {
            this.dataAccess = new InventaireDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des inventaires en fonction de la date
        /// </summary>
        /// <param name="iddate">ID de la date</param>
        /// <returns>Renvoie un InventaireDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public InventaireBOListView GetInventaireByDateId(int iddate)
        {
            return this.dataAccess.GetInventairesByDateIdFromDB(iddate);
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Inventaire";
            string idName = "IdInv";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Vérifie si l'article existe déjà pour un inventaire donné
        /// </summary>
        /// <param name="idart">Représente l'id de l'article</param>
        /// <param name="iddateinv">Représente la date de l'inventaire</param>
        /// <returns>Renvoie un booléen</returns>
        private bool ArticleExist(int idart, int iddateinv)
        {
            bool res = false;

            //LINQ
            var art = from a in this.dataAccess.GetInventairesByDateIdFromDB(iddateinv)
                      where a.IdArt == idart
                      select a;

            foreach(var v in art)
            {
                if (v.IdArt == idart)
                {
                    res = true;
                }
            }

            return res;
        }

        /// <summary>
        /// Vérifie si l'article existe déjà pour un inventaire donné après une modification
        /// </summary>
        /// <param name="idart">Représente l'id de l'article</param>
        /// <param name="iddateinv">Représente la date de l'inventaire</param>
        /// <returns>Renvoie un booléen</returns>
        private bool ArticleExistUpdate(int idart, int iddateinv, int idinv)
        {
            bool res = false;

            //LINQ
            var art = from a in new InventaireDAL().GetInventairesByDateIdFromDB(iddateinv)
                      where a.IdArt == idart
                      select a;

            foreach (var v in art)
            {
                if (v.IdArt == idart)
                {
                    if (v.IdInv != idinv)
                    {
                        res = true;
                    }                    
                }
            }

            return res;
        }


        /// <summary>
        /// Fonction qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="i">Inventaire à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(InventaireBO i)
        {            
            if (this.ArticleExist(i.IdArt, i.IdDateInv) != false)
            {
                throw new AppException("Impossible de valider cet article car il a déjà fait objet d'inventaire !");
            }

            return this.dataAccess.InsertInventaire(i.QtePhysInv, i.QteStockInv, i.EcartInv, i.ObservationInv, i.IdDateInv, i.IdArt);
        }

        /// <summary>
        /// Fonction qui effectue une modification
        /// </summary>
        /// <param name="i">Inventaire à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(InventaireBO i)
        {
            if (this.ArticleExistUpdate(i.IdArt, i.IdDateInv, i.IdInv) != false)
            {
                throw new AppException("Impossible de valider cet article car il a déjà fait objet d'inventaire !");
            }

            return this.dataAccess.UpdateInventaire(i.IdInv, i.QtePhysInv, i.QteStockInv, i.EcartInv, i.ObservationInv, i.IdDateInv, i.IdArt);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'une qté physique
        /// </summary>
        /// <param name="i">Inventaire à modifier</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateQtePhysique(InventaireBO i)
        {
            return this.dataAccess.UpdateInventaireQtePhysique(i.IdInv, i.QtePhysInv);
        }

        /// <summary>
        /// Fonction qui effectue la suppression dans la base 
        /// </summary>
        /// <param name="idinv">Inventaire à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(InventaireBO i)
        {
            return this.dataAccess.DeleteInventaire(i.IdInv);
        }

        /// <summary>
        /// Fonction qui effectue la suppression dans la base 
        /// de données en fonction de la date d'inventaire
        /// </summary>
        /// <param name="idinv">Inventaire à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteByDateId(DateInventaireBO d)
        {
            return this.dataAccess.DeleteInventaireByDateId(d.IdDateInv);
        }
    }
}
