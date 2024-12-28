using System;
using System.ComponentModel;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    /// <summary>
    /// Classe qui implémente les règles de gestion propres à la table ArreteDeCaisse
    /// </summary>
    [DataObject]
    public class ArreteDeCaisseBLL
    {
        private ArreteDeCaisseDAL dataAccess;

        public ArreteDeCaisseBLL()
        {
            this.dataAccess = new ArreteDeCaisseDAL();
        }

        /// <summary>
        /// Fonction qui renvoie liste des arretés de caisse
        /// </summary>
        /// <returns>Renvoie un ArreteDeCaisseBOListView</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ArreteDeCaisseBOListView GetArreteDeCaisses()
        {
            return this.dataAccess.GetArreteDeCaissesFromDB();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des arrêté de caisse en fonction d'une période
        /// </summary>
        /// <param name="dateDu">Date début</param>
        /// <param name="dateAu">Date fin</param>
        /// <returns>Renvoie une liste de ArreteDeCaisseBOListView</returns>
        public ArreteDeCaisseBOListView GetArreteDeCaissesByPeriod(DateTime dateDu, DateTime dateAu)
        {
            if (DateTime.Compare(dateDu, dateAu) > 0)
            {
                throw new AppException("Impossible d'effectuer la recherche ! La date de début doit être inférieur ou égale à la date de fin !");
            }

            return this.dataAccess.GetArreteDeCaissesByPeriodFromDB(dateDu, dateAu);
        }

        /// <summary>
        /// Fonction qui renvoie l'id max
        /// </summary>
        /// <param name="tableName">Nom de la table</param>
        /// <param name="idName">Nom de l'id</param>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "ArreteDeCaisse";
            string idName = "IdAC";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui vérifie la conformité de l'arrêté de caisse
        /// </summary>
        /// <param name="montantCaisse">Montant en caisse</param>
        /// <param name="montantBase">Montant de la base</param>
        /// <returns>Renvoie un booléen</returns>
        private bool ArreteConforme(int montantCaisse, int montantBase)
        {
            bool res = false;

            if (montantCaisse == montantBase)
            {
                res = true;
            }

            return res;
        }

        /// <summary>
        /// Fonction qui vérifie si un arrêté de caisse existe déjà dans la base; la vérification se fait par rapport à la date
        /// </summary>
        /// <param name="date">Date par rapport à laquelle on fait la recherche</param>
        /// <returns>Renvoie un booléen</returns>
        public bool ArreteExist(DateTime date)
        {
            bool exist = false;

            //On vérifie si un arrêté de caisse n'a pas été validé à cette date données
            foreach (ArreteDeCaisseBO a in this.dataAccess.GetArreteDeCaissesFromDB())
            {
                if (a.DateAC == date)
                {
                    exist = true;
                    break;
                }
            }

            return exist;
        }


        /// <summary>
        /// Fonction qui effectue l'insertion d'un arrêté de caisse
        /// </summary>
        /// <param name="a">Arreté de caisse</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(ArreteDeCaisseBO a)
        {
            //On vérifie que la date de l'arrêté de caisse n'est pas supérieure à la date du jour
            if (DateTime.Compare(a.DateAC, DateTime.Today) > 0)
            {
                throw new AppException("Impossible de valider une vente dont la date est supérieure à la date du jour !");
            }

            //On vérifie si un arrêté de caisse a été fait à cette date
            if (ArreteExist(a.DateAC) == true)
            {
                throw new AppException("Un arrêté de caisse a été déjà saisie pour cette date !");
            }

            //On vérifie si les montants sont conformes
            if (ArreteConforme(a.MontantEnCaisse, a.MontantBase) != true)
            {
                a.ConformeAC = false;
            }
            else
            {
                a.ConformeAC = true;
            }

            return this.dataAccess.InsertArreteDeCaisse(a.DateAC, DateTime.Parse(a.HeureAC), a.MontantEnCaisse, a.MontantBase, a.ConformeAC, a.ObservationAC);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'un arreté de caisse
        /// </summary>
        /// <param name="a">Arreté de caisse</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(ArreteDeCaisseBO a)
        {
            //On vérifie que la date de l'arrêté de caisse n'est pas supérieure à la date du jour
            if (DateTime.Compare(a.DateAC, DateTime.Today) > 0)
            {
                throw new AppException("Impossible de valider une vente dont la date est supérieure à la date du jour !");
            }

            if (ArreteConforme(a.MontantEnCaisse, a.MontantBase) != true)
            {
                a.ConformeAC = false;
            }
            else
            {
                a.ConformeAC = true;
            }

            return this.dataAccess.UpdateArreteDeCaisse(a.IdAC, a.DateAC, DateTime.Parse(a.HeureAC), a.MontantEnCaisse, a.MontantBase, a.ConformeAC, a.ObservationAC);
        }

        /// <summary>
        /// Fonction qui effectue la suppression d'un arreté de caisse
        /// </summary>
        /// <param name="a">Arreté de caisse</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(ArreteDeCaisseBO a)
        {
            return this.dataAccess.DeleteArreteDeCaisse(a.IdAC);
        }

    }
}
