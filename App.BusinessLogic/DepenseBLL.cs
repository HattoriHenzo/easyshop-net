using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    public class DepenseBLL
    {
        private DepenseDAL dataAccess;

        public DepenseBLL()
        {
            this.dataAccess = new DepenseDAL();
        }

        /// <summary>
        /// Fonction qui renvoi la liste des depenses
        /// </summary>      
        /// <returns>Renvoi une liste de Depenses</returns>
        public DepenseBOListView GetDepenses()
        {
            return this.dataAccess.GetDepensesFromDB();
        }

        /// <summary>
        /// Fonction qui renvoi la liste des depenses par periode
        /// </summary>
        /// <param name="dateDu">Date de debut</param>
        /// <param name="dateAu">Date de fin</param>
        /// <returns>Renvoi une liste de Depenses</returns>
        public DepenseBOListView GetDepensesByPeriod(DateTime dateDu, DateTime dateAu)
        {
            return this.dataAccess.GetDepensesByPeriodFromDB(dateDu, dateAu);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="depense"></param>
        /// <returns></returns>
        public int Insert(DepenseBO depense)
        {
            return this.dataAccess.InsertDepense(depense.Date, depense.Objet, depense.Montant);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="depense"></param>
        /// <returns></returns>
        public int Delete(DepenseBO depense)
        {
            return this.dataAccess.DeleteDepense(depense.IdDep);
        }
    }
}
