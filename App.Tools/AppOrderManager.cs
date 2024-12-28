using System;
using System.Collections.Generic;
using System.Text;

namespace App.Tools
{
    public class AppOrderManager
    {
        public static string GetOrder(int nbRecord)
        {
            string order = "";            

            if (nbRecord < 10)
            {
                order = "000" + nbRecord.ToString();
            }

            if ((nbRecord >= 10) && (nbRecord < 100))
            {
                order = "00" + nbRecord.ToString();
            }

            if ((nbRecord >= 100) && (nbRecord < 1000))
            {
                order = "0" + nbRecord.ToString();
            }

            if ((nbRecord >= 1000))
            {
                order = nbRecord.ToString();
            }

            return order;
        }
    }
}
