using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    /// <summary>
    /// Classe qui implémente les règles de gestion de la table DateInventaire
    /// </summary>
    [DataObject]
    public class DateInventaireBLL
    {

        private DateInventaireDAL dataAccess;

        public DateInventaireBLL()
        {
            this.dataAccess = new DateInventaireDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des dates d'inventaires
        /// </summary>
        /// <returns>Renvoie un DateInventaireDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public DateInventaireBOListView GetDatesInventaires()
        {
            return this.dataAccess.GetDateInventairesFromDB();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des dates d'inventaires par période
        /// </summary>
        /// <param name="dateDu">Date de début</param>
        /// <param name="dateAu">Date de fin</param>
        /// <returns>Renvoie un DateInventaireDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public DateInventaireBOListView GetDatesInventairesByDate(DateTime dateDu, DateTime dateAu)
        {
            return this.dataAccess.GetDateInventairesByDateFromDB(DateTime.Parse(dateDu.ToShortDateString()), DateTime.Parse(dateAu.ToShortDateString()));
        }

        /// <summary>
        /// Fonction qui renvoie l'id max de la table
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "DateInventaire";
            string idName = "IdDateInv";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui vérifie si un inventaire a déjà été fait à une date donnée
        /// </summary>
        /// <param name="date">Date à laquelle l'inventaire est fait</param>
        /// <returns>Renvoie un booléen</returns>
        public bool DateInventaireExist(DateTime date)
        {
            bool exist = false;

            foreach (DateInventaireBO d in this.dataAccess.GetDateInventairesFromDB())
            {
                if (d.DateInv == date)
                {
                    exist = true;
                }
            }

            return exist;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'une nouvelle date d'inventaire
        /// </summary>
        /// <param name="d">Date d'inventaire à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(DateInventaireBO d)
        {      
            //On vérifie si la date n'a pas fait objet d'inventaire
            if (this.DateInventaireExist(d.DateInv) != false)
            {
                throw new AppException("Cette date est déjà saisie pour un inventaire !");
            }

            //On vérifie si la date saisie est supérieur à la date du jour
            if (DateTime.Compare(d.DateInv, DateTime.Today) > 0)
            {
                throw new AppException("Cette date est supérieure à la date du jour. Veuillez saisir une autre date !");
            }

            return this.dataAccess.InsertDateInventaire(d.ObservationInv, d.DateInv, DateTime.Parse(d.HeureInv));
        }

        /// <summary>
        /// Fonction qui effectue la modification d'une date
        /// </summary>
        /// <param name="d">DateInventaire à modifier</param>
        /// <returns>Renvoie un entier</returns>
        public int Update(DateInventaireBO d)
        {
            return this.dataAccess.UpdateDateInventaire(d.IdDateInv, d.ObservationInv, d.DateInv, DateTime.Parse(d.HeureInv));
        }

        /// <summary>
        /// Fonction qui effectue la modification d'un inventaire
        /// </summary>
        /// <param name="idinv"></param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int UpdateValide(DateInventaireBO d)
        {
            return this.dataAccess.UpdateDateInventaireValide(d.IdDateInv);
        }

        /// <summary>
        /// Fonction qui effectue la suppression d'un inventaire
        /// </summary>
        /// <param name="id">Id de la date d'inventaire à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(DateInventaireBO d)
        {
            new InventaireDAL().DeleteInventaireByDateId(d.IdDateInv);
            return this.dataAccess.DeleteDateInventaire(d.IdDateInv);
        }
    }
}
