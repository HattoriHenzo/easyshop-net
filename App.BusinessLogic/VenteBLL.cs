using System;

using App.BusinessObject;
using App.DataAccess;
using System.ComponentModel;

namespace App.BusinessLogic
{
    [DataObject]
    public class VenteBLL
    {
        private VenteDAL dataAccess;

        public VenteBLL()
        {
            this.dataAccess = new VenteDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste 
        /// </summary>
        /// <param name="dateDu"></param>
        /// <param name="dateAu"></param>
        /// <returns></returns>
        public VenteBOListView GetVentesByPeriod(DateTime dateDu, DateTime dateAu)
        {
            return this.dataAccess.GetVentesByPeriodFromDB(dateDu, dateAu); 
        }

        /// <summary>
        /// Fonction qui insert une vente
        /// </summary>
        /// <param name="v">Vente a inserer</param>
        /// <returns>Renvoi un entier</returns>
        public int Insert(VenteBO v)
        {
            return this.dataAccess.InsertVente(v.NumeroVente, v.DateVente);
        }
        
    }
}
