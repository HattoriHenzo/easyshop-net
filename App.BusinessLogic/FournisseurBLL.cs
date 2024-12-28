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
    /// Classe qui implémente les règles de gestion de la table Fournisseur
    /// </summary>
    public class FournisseurBLL
    {        
        private FournisseurDAL dataAccess;

        public FournisseurBLL()
        {
            this.dataAccess = new FournisseurDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des fournisseurs
        /// </summary>
        /// <returns>Renvoie un objet de type FournisseurDataTable</returns>
        //[DataObjectMethod(DataObjectMethodType.Select, true)]
        public FournisseurBOListView GetFournisseurs()
        {
            return this.dataAccess.GetFournisseursFromDB();
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Fournisseur";
            string idName = "IdFour";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'un fournisseur dans la base de données
        /// </summary>
        /// <param name="f">Fournisseur à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(FournisseurBO f)
        {
            return this.dataAccess.InsertFournisseur(f.RaisonSocialeFour, f.AdresseFour, f.TelFour, f.CelFour, f.FaxFour, f.EmailFour, f.SiteInternetFour);
        }

        /// <summary>
        /// Fonction qui effectue la mmodification d'un fournisseur
        /// </summary>
        /// <param name="f">Fournisseur à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(FournisseurBO f)
        {
            return this.dataAccess.UpdateFournisseur(f.IdFour, f.RaisonSocialeFour, f.AdresseFour, f.TelFour, f.CelFour, f.FaxFour, f.EmailFour, f.SiteInternetFour);
        }

        /// <summary>
        /// Fonction qui vérifie si un fournisseur existe ou pas
        /// </summary>
        /// <param name="idFour">Id du fournisseur</param>
        /// <returns>Renvoie un booléen</returns>
        private bool FournisseurExist(int idFour)
        {
            bool exist = false;

            var listeFour = from f in new CommanderBLL().GetCommander()
                            where f.IdFour == idFour
                            select f;

            foreach (var v in listeFour)
            {
                if (v.IdFour == idFour)
                {
                    exist = true;
                }
            }

            return exist;
        }

        /// <summary>
        /// Fonction qui effectue la suppression d'un fournisseur
        /// </summary>
        /// <param name="id">Fournisseur à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(FournisseurBO f)
        {
            if (this.FournisseurExist(f.IdFour) == true)
            {
                throw new AppException("Impossible de supprimer ce fournisseur! Il a fait objet d'une commande !");
            }

            return this.dataAccess.DeleteFournisseur(f.IdFour);
        }
    }
}
