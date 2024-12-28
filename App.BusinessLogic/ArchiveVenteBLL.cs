using System;
using System.Collections.Generic;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    /// <summary>
    /// Fonction qui implémente les règles de gestion de ArchiveVente
    /// </summary>
    public class ArchiveVenteBLL
    {
        private ArchiveVenteDAL dataAccess;

        public ArchiveVenteBLL()
        {
           this.dataAccess = new ArchiveVenteDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des ArchivesVente
        /// </summary>
        /// <param name="dateDu">Date début</param>
        /// <param name="dateAu">Date fin</param>
        /// <returns>Renvoie un ArchiveVenteBOListView</returns>
        public ArchiveVenteBOListView GetVentesByPeriod(DateTime dateDu, DateTime dateAu)
        {
            return this.dataAccess.GetVentesByPeriodFromDB(dateDu, dateAu);
        }

        /// <summary>
        /// Fonction qui renvoi la liste des ventes par id
        /// </summary>
        /// <param name="numeroVente">Numero de la vente</param>
        /// <returns>Renvoie une liste de ventes</returns>
        public ArchiveVenteBOListView GetVentesById(string numeroVente)
        {
            return this.dataAccess.GetVentesByIdFromDB(numeroVente);
        }

        /// <summary>
        /// Fonction qui renvoie le total vendu dans la journée
        /// </summary>
        /// <param name="liste">Liste des ventes</param>
        /// <returns>Renvoie un entier</returns>
        public int GetTotalVente(ArchiveVenteBOListView liste)
        {
            int totalVente = 0;

            foreach (ArchiveVenteBO a in liste)
            {
                totalVente += a.TotalVente;
            }

            return totalVente;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="liste"></param>
        /// <returns></returns>
        public int GetTotalBenefice(ArchiveVenteBOListView liste)
        {
            int totalBenef = 0;

            foreach (ArchiveVenteBO a in liste)
            {
                totalBenef += (a.PrixVente - a.PrixAchat) * a.QteVente;
            }

            return Math.Abs(totalBenef);
        }

        /// <summary>
        /// Fonction qui renvoie le total vendu dans la journée
        /// </summary>
        /// <param name="liste">Liste des ventes</param>
        /// <returns>Renvoie un entier</returns>
        public int GetTotalVentesByPeriod(DateTime dateDu, DateTime dateAu)
        {
            int totalVente = 0;

            foreach (ArchiveVenteBO a in this.dataAccess.GetVentesByPeriodFromDB(dateDu, dateAu))
            {
                totalVente += (a.QteVente * a.PrixVente);
            }

            return totalVente;
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "ArchiveVente";
            string idName = "IdArch";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int GetRemisePourcentage(ArchiveVenteBO a)
        {
            return (((a.PrixVente * a.QteVente) * a.RemisePourcentage) / 100);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int GetMontantTotal(ArchiveVenteBO a)
        {
            return (a.PrixVente * a.QteVente);
        }

        /// <summary>
        /// Fonction qui renvoi la remise en pourcentage
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        /// <returns>Renvoi la remise en pourcentage</returns>
        public int GetAllRemisePourcentage(List<ArchiveVenteBO> ventes)
        {
            int remisePourcentage = 0;
            foreach (ArchiveVenteBO av in ventes)
            {
                remisePourcentage += ((av.PrixVente * av.QteVente) * av.RemisePourcentage) / 100;
            }
            return remisePourcentage;
        }

        /// <summary>
        /// Fonction qui renvoi la remise en montant
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        /// <returns>Renvoi la remise en montant</returns>
        public int GetAllRemiseMontant(List<ArchiveVenteBO> ventes)
        {
            int remiseMontant = 0;
            foreach (ArchiveVenteBO av in ventes)
            {
                remiseMontant += av.RemiseMontant;
            }
            return remiseMontant;
        }

        /// <summary>
        /// Fonction qui renvoi le benefice total
        /// </summary>
        /// <param name="ventes">Liste des ventes effectuees</param>
        /// <returns>Renvoi le benefice total</returns>
        public int GetAllBeneficeMontant(List<ArchiveVenteBO> ventes)
        {
            int benefice = 0;
            foreach(ArchiveVenteBO av in ventes)
            {
                benefice += ((av.PrixVente - av.PrixAchat) * av.QteVente);
            }
            return benefice;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="a">Archive à insérer</param>
        /// <returns>Renvoie un entier</returns>
        public int Insert(ArchiveVenteBO a)
        {
            //On vérifie que la date de la vente n'est pas supérieure à la date du jour
            if (DateTime.Compare(a.DateVente, DateTime.Today) > 0)
            {
                throw new AppException("Impossible de valider une vente dont la date est supérieure à la date du jour !");
            }

            //On vérifie que à la date ou on fait la vente, aucun arrêté de caisse n'a été validé
            if (new ArreteDeCaisseBLL().ArreteExist(a.DateVente) != false)
            {
                throw new AppException("Impossible de valider la vente. Un arrêté de caisse a été fait pour cette date !");
            }            

            return this.dataAccess.InsertArchiveVente(a.DateVente, a.HeureVente, a.IdArt, a.PrixAchat, a.PrixVente, a.QteVente, a.NumeroVente, a.TypeVente, a.RemisePourcentage, a.RemiseMontant, a.IdUser);
        }

        /// <summary>
        /// Fonction qui effectue la mise à jour dans la base de données
        /// </summary>
        /// <param name="a">Archive à modifier</param>
        /// <returns>Renvoie un entier</returns>
        public int Update(ArchiveVenteBO a)
        {
            //On vérifie que la date de la vente n'est pas supérieure à la date du jour
            if (DateTime.Compare(a.DateVente, DateTime.Today) > 0)
            {
                throw new AppException("Impossible de valider une vente dont la date est supérieure à la date du jour !");
            }

            //On vérifie que à la date ou on fait la vente, aucun arrêté de caisse n'a été validé
            if (new ArreteDeCaisseBLL().ArreteExist(a.DateVente) != false)
            {
                throw new AppException("Impossible de modifier la vente. Un arrêté de caisse a été fait pour cette date !");
            }            

            return this.dataAccess.UpdateArchiveVente(a.IdArch, a.DateVente, a.HeureVente, a.IdArt, a.PrixAchat, a.PrixVente, a.QteVente, a.TypeVente, a.RemisePourcentage, a.RemiseMontant);
        }

        /// <summary>
        /// Fonction qui effectue la suppression dans la base de données
        /// </summary>
        /// <param name="a">Archive à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        public int Delete(ArchiveVenteBO a)
        {
            //On vérifie que à la date ou on fait la vente, aucun arrêté de caisse n'a été validé
            if (new ArreteDeCaisseBLL().ArreteExist(a.DateVente) != false)
            {
                throw new AppException("Impossible de supprimer la vente. Un arrêté de caisse a été fait pour cette date !");
            }

            return this.dataAccess.DeleteArchiveVente(a.IdArch);
        }
    }
}
