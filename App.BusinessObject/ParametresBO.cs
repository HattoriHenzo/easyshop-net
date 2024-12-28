using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    public class ParametresBO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String raisonSociale;

        public String RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value; }
        }

        private String adresse;

        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private String boitePostale;

        public String BoitePostale
        {
            get { return boitePostale; }
            set { boitePostale = value; }
        }

        private String telephone;

        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private String mobile;

        public String Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private String messageBienvenue;

        public String MessageBienvenue
        {
            get { return messageBienvenue; }
            set { messageBienvenue = value; }
        }

        private String messageAuRevoir;

        public String MessageAuRevoir
        {
            get { return messageAuRevoir; }
            set { messageAuRevoir = value; }
        }

        public ParametresBO()
        { 
                                                                                            
        }
    }

    /// <summary>
    /// Represente la liste des parametres
    /// </summary>
    public class ParametresBOListView : BusinessObjectListView<ParametresBO>
    {

    }
}
