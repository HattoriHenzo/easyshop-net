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
    public class LivraisonBLL
    {      
        private LivraisonDAL dataAccess;

        public LivraisonBLL()
        {
            this.dataAccess = new LivraisonDAL();
        }     

        /// <summary>
        /// Fonction qui renvoie la liste des livraisons en fonction de la commande
        /// </summary>
        /// <param name="id">Id de la commande</param>
        /// <returns>Renvoie un objet de type LivraisonDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public LivraisonBOListView GetLivraisonsByCommandeId(int idCom)
        {
            return this.dataAccess.GetLivraisonsByCommandeIdFromDB(idCom);
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Livraison";
            string idName = "IdLiv";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui effectue une insertion
        /// </summary>  
        /// <param name="l">Livraison à insérer</param>
        /// <returns>Renvoie le nombre de lignes affectées par la requête</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(LivraisonBO l)
        {
            return this.dataAccess.InsertLivraison(l.NumFactLiv, string.Empty, l.DateLiv, DateTime.Parse(l.HeureLiv), l.IdCom, l.ValideLiv);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'une mise à jour
        /// </summary>
        /// <param name="l">Livraison à modifier</param>
        /// <returns>Renvoie le nombre de lignes affectées par la requête</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(LivraisonBO l)
        {
            return this.dataAccess.UpdateLivraison(l.IdLiv, l.NumFactLiv, string.Empty, l.DateLiv, DateTime.Parse(l.HeureLiv), l.IdCom, l.ValideLiv);
        }

        /// <summary>
        /// Fonction qui effectue la mise à jour du champs valide
        /// </summary>
        /// <param name="valide">Valide la livraison ou non</param>
        /// <param name="idLiv">Id de la livraison</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateValide(bool valide, int idLiv)
        {
            return this.dataAccess.UpdateLivraisonValide(idLiv, valide);
        }

        /// <summary>
        /// Fonction qui effectue la suppression
        /// </summary>
        /// <param name="l">Livraison à supprimer</param>
        /// <returns>Renvoie le nombre de lignes affectées par la requête</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(LivraisonBO l)
        {
            return this.dataAccess.DeleteLivraison(l.IdLiv);
        }
    }
}
