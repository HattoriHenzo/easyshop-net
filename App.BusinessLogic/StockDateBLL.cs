using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    public class StockDateBLL
    {
        private StockDateDAL dataAccess;

        public StockDateBLL()
        {
            this.dataAccess = new StockDateDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des Stock a date
        /// </summary>
        /// <param name="dateDu">Date debut</param>
        /// <param name="dateAu">Date fin</param>
        /// <param name="article">Article</param>
        /// <returns>Renvoie une liste de StockDateBOListView</returns>
        public StockDateBOListView GetStockDateByPeriod(DateTime dateDu, DateTime dateAu, string article)
        {
            if(DateTime.Compare(dateDu, dateAu) > 0)
            {
                throw new AppException("Impossible d'effectuer la recherche ! Veuillez saisir des dates valides.");
            }

            return this.dataAccess.GetStockDateByPeriodFromDB(dateDu, dateAu, article);
        }

        /// <summary>
        /// Fonction qui insert un Stock a date
        /// </summary>        
        /// <returns>Renvoie un entier</returns>
        public int Insert()
        {
            return this.dataAccess.InsertStockDate();
        }

        /// <summary>
        /// Fonction qui supprime le stock d'une date donnee
        /// </summary>
        /// <param name="dateStock">Date du stock</param>
        /// <returns>Renvoie un entier</returns>
        public int Delete(DateTime dateStock)
        {
            return this.dataAccess.DeleteStockDate(DateTime.Parse(dateStock.ToShortDateString()));
        }
    }
}
