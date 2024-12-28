using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

using BusinessObjectLib;
using ToolsLib;

namespace DataAccessLayerLib
{
    /// <summary>
    /// Classe de mappage sur la table User
    /// </summary>
    public class UserDAL
    {
        private static UserDAL instance = null;

        private UserDAL()
        {

        }

        //Singleton
        public static UserDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAL();
                }

                return instance;
            }
        }

        /// <summary>
        /// Fonction renvoie la liste des users
        /// </summary>
        /// <returns>Renvoie un  UserBOListView</returns>
        public UserBOListView GetUsersFromDB()
        {
            UserBOListView liste = new UserBOListView();

            using (OleDbCommand command = ConnectionDB.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM User";

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    UserBO u = new UserBO();

                    u.IdUser = (int)reader["IdUser"];
                    u.NomUser = reader["NomUser"].ToString();
                    u.PrenomUser = reader["PrenomUser"].ToString();
                    u.AgeUser = (int)reader["AgeUser"];
                    u.NumCarteUser = reader["NumCarteUser"].ToString();
                    u.DomicileUser = reader["DomicileUser"].ToString();
                    u.TelUser = reader["TelUser"].ToString();
                    u.CelUser = reader["CelUser"].ToString();
                    u.EmailUser = reader["EmailUser"].ToString();
                    u.LoginUser = reader["LoginUser"].ToString();
                    u.PasswordUser = reader["PasswordUser"].ToString();
                    u.ValideUser = (bool)reader["ValideUser"];

                    liste.Add(u);
                }
            }

            return liste;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="nomUser">Nom du User</param>
        /// <param name="prenomUser">Prenom du User</param>
        /// <param name="ageUser">Age du User</param>
        /// <param name="numCarteUser">Numéro de la carte d'identité</param>
        /// <param name="domicileUser">Domicile du User</param>
        /// <param name="telUser">Téléphone du User</param>
        /// <param name="celUser">Cellulaire du User</param>
        /// <param name="emailUser">Email du User</param>
        /// <param name="loginUser">Login du User</param>
        /// <param name="passwordUser">Password du User</param>
        /// <param name="valideUser">Indique si le User est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertUser(string nomUser, string prenomUser, int ageUser, string numCarteUser, string domicileUser, string telUser, string celUser, string emailUser, string loginUser, string passwordUser, bool valideUser)
        {
            int result = 0;

            using (OleDbCommand command = ConnectionDB.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO User(NomUser, PrenomUser, AgeUser, NumeroCarteUser, DomicileUser, TelephoneUser, CellulaireUser, EmailUser, LoginUser, PasswordUser, ValideUser) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                command.Parameters.Add("NomUser", OleDbType.VarChar, 50).Value = nomUser;
            }

            return result;
        }
    }
}
