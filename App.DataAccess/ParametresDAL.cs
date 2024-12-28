using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

using App.BusinessObject;
using System.Data.Common;

namespace App.DataAccess
{
    public class ParametresDAL : AbstractDataAccess
    {

        public ParametresDAL()
        {
        }

        public ParametresBOListView GetParamatresFromDB()
        {
            ParametresBOListView list = new ParametresBOListView();

            //Connexion a la base de donnee
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * From Parametres";

                using(DbDataReader reader = command.ExecuteReader())
                {
                    ParametresBO p = new ParametresBO();

                    p.Id = (int)reader["Id"];
                    p.RaisonSociale = reader["RaisonSociale"].ToString();
                    p.Adresse = reader["Adresse"].ToString();
                    p.BoitePostale = reader["BoitePostale"].ToString();
                    p.Telephone = reader["Telephone"].ToString();
                    p.Mobile = reader["Mobile"].ToString();
                    p.Email = reader["Email"].ToString();
                    p.MessageBienvenue = reader["MessageBienvenue"].ToString();
                    p.MessageAuRevoir = reader["MessageAuRevoir"].ToString();

                    list.Add(p);
                }
            }

            AppConnection.Instance.Disconnect();
            //Deconnexion de la base de donnee
            return list;
        }

        /// <summary>
        /// Fonction qui insert un parametre dans la base de donnees
        /// </summary>
        /// <param name="raisonSociale">Raison sociale</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="boitePostale">Boite Postale</param>
        /// <param name="telephone">Telephone</param>
        /// <param name="mobile">Mobile</param>
        /// <param name="email">Email</param>
        /// <param name="messageBienvenue">Message de bienvenue</param>
        /// <param name="messageAuRevoir">Message d'au revoir</param>
        /// <returns>Renvoi un entier</returns>
        public int InsertParamatres(String raisonSociale, String adresse, String boitePostale, String telephone, String mobile, String email, String messageBienvenue, String messageAuRevoir)
        {
            int result = 0;
            //Connexion a la base
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = CommandType.Text;
                command.CommandText = "Insert Into Parametres(RaisonSociale, Adresse, BoitePostale, Telephone, Mobile, Email, MessageBienvenue, MessageAuRevoir) " 
                                     + "Values(?, ?, ?, ?, ?, ?, ?, ?)";
            }

            //Deconnexion de la base de donnees
            AppConnection.Instance.Disconnect();

            return result;
        }
    }
}
