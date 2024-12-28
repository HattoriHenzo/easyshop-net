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
    public class EntreeSortieBLL
    {
        private EntreeSortieDAL dataAccess;       

        //Singleton
        public EntreeSortieBLL()
        {
            this.dataAccess = new EntreeSortieDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des entrées / sorties
        /// </summary>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public EntreeSortieBOListView GetEntreeSorties()
        {
            return this.dataAccess.GetEntreeSortiesFromDB();
        }

        /// <summary>
        /// Fonction qui renvoie un etat alerte de peremption pour une entree
        /// </summary>
        /// <returns>Renvoie un Boolean</returns> 
        public Boolean EstPerime(int IdES, int IdArt, DateTime DateEs, DateTime DateEnCours)
        {
            return this.dataAccess.EstPerime(IdES, IdArt, DateEs, DateEnCours);
        }

        /// <summary>
        /// Fonction qui renvoie la liste des entrées / sorties en fonction d'un article donné
        /// </summary>
        /// <param name="idArt">Id de l'article</param>
        /// <param name="typeES">Type de l'entrée / sortie</param>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public EntreeSortieBOListView GetEntreeSortieByArticleId(int idArt, string typeES, string motifS)
        {
            return this.dataAccess.GetEntreeSortiesByArticleIdFromDB(idArt, typeES, motifS);
        }


        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "EntreeSortie";
            string idName = "IdES";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui renvoie le total vendu dans la journée
        /// </summary>
        /// <param name="date">Date du jour</param>
        /// <returns>Renvoie un entier</returns>
        public int GetTotalVenteByDay(DateTime date)
        {
            return this.dataAccess.GetTotalVenteByDayFromDB(date);
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'une entrée/sortie
        /// </summary>
        /// <param name="es">Entree/Sortie à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(EntreeSortieBO es)
        {
            if (es.QteES <= 0)
            {
                throw new AppException("Veuillez saisir une quantité valide ! (Supérieur à 0)");
            }

            return this.dataAccess.InsertEntreeSortie(es.QteES, es.DateES, DateTime.Parse(es.HeureES), es.TypeES, es.MotifS, es.ObservationES, es.IdUser, es.IdArt, es.DatePeremption, es.DelaiAlerte);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'une entrée
        /// </summary>
        /// <param name="es">Entree/Sortie à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(EntreeSortieBO es)
        {
            if (es.QteES <= 0)
            {
                throw new AppException("Veuillez saisir une quantité valide ! (Supérieur à 0)");
            }

            return this.dataAccess.UpdateEntreeSortie(es.IdES, es.QteES, es.DateES, DateTime.Parse(es.HeureES), es.TypeES, es.MotifS, es.ObservationES, es.IdUser, es.IdArt, es.DatePeremption, es.DelaiAlerte);
        }
        
        /// <summary>
        /// Fonction qui effectue la suppression
        /// </summary>
        /// <param name="idES"></param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public int Delete(EntreeSortieBO es)
        {
            if (es.IdES == 0)
            {
                throw new AppException("Veuillez choisir une ligne à supprimer !");
            }

            return this.dataAccess.DeleteEntreeSortie(es.IdES);
        }        
    }
}
