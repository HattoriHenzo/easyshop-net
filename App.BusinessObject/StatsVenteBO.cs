using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    public class StatsVenteBO : ArchiveVenteBO
    {
        private int prixEnGros;

        public int PrixEnGros
        {
            get { return prixEnGros; }
            set { prixEnGros = value; }
        }

        private int qteEnGros;

        public int QteEnGros
        {
            get { return qteEnGros; }
            set { qteEnGros = value; }
        }
    }
}
