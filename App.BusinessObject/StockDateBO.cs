using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    public class StockDateBO : ArticleBO
    {
        private DateTime dateStock;

        public DateTime DateStock
        {
            get { return dateStock; }
            set { dateStock = value; }
        }

        public StockDateBO()
        {

        }
    }

    /// <summary>
    /// Représente la liste des Stocks a date
    /// </summary>
    public class StockDateBOListView : BusinessObjectListView<StockDateBO>
    {

    }
}
