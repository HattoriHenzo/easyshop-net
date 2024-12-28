using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    /// <summary>
    /// Classe de mappage sur la table User
    /// </summary>
    public class UtilDAL : AbstractDataAccess
    {

        public UtilDAL()
        {

        }

        /// <summary>
        /// Fonction renvoie la liste des users
        /// </summary>
        /// <returns>Renvoie un  UserBOListView</returns>
        public UtilBOListView GetUtilsFromDB()
        {
            UtilBOListView liste = new UtilBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Utilisateur ORDER BY NomUtil";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UtilBO u = new UtilBO();

                            u.IdUtil = (int)reader["IdUtil"];
                            u.NomUtil = reader["NomUtil"].ToString();
                            u.PrenomUtil = reader["PrenomUtil"].ToString();
                            u.AgeUtil = (short)reader["AgeUtil"];
                            u.NumCarteUtil = reader["NumCarteUtil"].ToString();
                            u.AdresseUtil = reader["AdresseUtil"].ToString();
                            u.TelUtil = reader["TelUtil"].ToString();
                            u.CelUtil = reader["CelUtil"].ToString();
                            u.EmailUtil = reader["EmailUtil"].ToString();
                            u.LoginUtil = reader["LoginUtil"].ToString();
                            u.PasswordUtil = reader["PasswordUtil"].ToString();
                            u.TypeUtil = int.Parse(reader["TypeUtil"].ToString());
                            u.ValideUtil = (bool)reader["ValideUtil"];

                            liste.Add(u);
                        }
                    }

                    reader.Close();
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return liste;
        }

        /// <summary>
        /// Fonction renvoie la liste des users
        /// </summary>
        /// <returns>Renvoie un  UserBOListView</returns>
        public UtilBOListView GetUtilsValideFromDB(bool valide)
        {
            UtilBOListView liste = new UtilBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Utilisateur WHERE ValideUtil = @ValideUtil ORDER BY NomUtil";

                command.Parameters.Add(CreateDbParameter(command, "@ValideUtil", valide));

               using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UtilBO u = new UtilBO();

                            u.IdUtil = (int)reader["IdUtil"];
                            u.NomUtil = reader["NomUtil"].ToString();
                            u.PrenomUtil = reader["PrenomUtil"].ToString();
                            u.AgeUtil = (short)reader["AgeUtil"];
                            u.NumCarteUtil = reader["NumCarteUtil"].ToString();
                            u.AdresseUtil = reader["AdresseUtil"].ToString();
                            u.TelUtil = reader["TelUtil"].ToString();
                            u.CelUtil = reader["CelUtil"].ToString();
                            u.EmailUtil = reader["EmailUtil"].ToString();
                            u.LoginUtil = reader["LoginUtil"].ToString();
                            u.PasswordUtil = reader["PasswordUtil"].ToString();
                            u.TypeUtil = int.Parse(reader["TypeUtil"].ToString());
                            u.ValideUtil = (bool)reader["ValideUtil"];

                            liste.Add(u);
                        }
                    }

                    reader.Close();
                }            
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return liste;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion dans la base de donnÃ©es
        /// </summary>
        /// <param name="nomUtil">Nom du Util</param>
        /// <param name="prenomUtil">Prenom du Util</param>
        /// <param name="ageUtil">Age du Util</param>
        /// <param name="numCarteUtil">Numéro de la carte d'identité</param>
        /// <param name="domicileUtil">Domicile du Util</param>
        /// <param name="telUtil">Téléphone du Util</param>
        /// <param name="celUtil">Cellulaire du Util</param>
        /// <param name="emailUtil">Email du Util</param>
        /// <param name="loginUtil">Login du Util</param>
        /// <param name="passwordUtil">Password du Util</param>
        /// <param name="valideUtil">Indique si le Util est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertUtil(string nomUtil, string prenomUtil, int ageUtil, string numCarteUtil, string adresseUtil, string telUtil, string celUtil, string emailUtil, string loginUtil, string passwordUtil, int typeUtil, bool valideUtil)
        {
            int result = 0;

             //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Utilisateur (NomUtil, PrenomUtil, AgeUtil, NumCarteUtil, AdresseUtil, TelUtil, CelUtil, EmailUtil, LoginUtil, PasswordUtil, TypeUtil, ValideUtil) " +
                    "VALUES (@NomUtil, @PrenomUtil, @AgeUtil, @NumCarteUtil, @AdresseUtil, @TelUtil, @CelUtil, @EmailUtil, @LoginUtil, @PasswordUtil, @TypeUtil, @ValideUtil)";

                command.Parameters.Add(CreateDbParameter(command, "@NomUtil", nomUtil));
                command.Parameters.Add(CreateDbParameter(command, "@PrenomUtil", prenomUtil));
                command.Parameters.Add(CreateDbParameter(command, "@AgeUtil", ageUtil));
                command.Parameters.Add(CreateDbParameter(command, "@NumCarteUtil", numCarteUtil));
                command.Parameters.Add(CreateDbParameter(command, "@AdresseUtil", adresseUtil));
                command.Parameters.Add(CreateDbParameter(command, "@TelUtil", telUtil));
                command.Parameters.Add(CreateDbParameter(command, "@CelUtil", celUtil));
                command.Parameters.Add(CreateDbParameter(command, "@EmailUtil", emailUtil));
                command.Parameters.Add(CreateDbParameter(command, "@LoginUtil", loginUtil));
                command.Parameters.Add(CreateDbParameter(command, "@PasswordUtil", passwordUtil));
                command.Parameters.Add(CreateDbParameter(command, "@TypeUtil", typeUtil));
                command.Parameters.Add(CreateDbParameter(command, "@ValideUtil", valideUtil));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de l'insertion : " + dbEx.Message);                    
                }
            }

             //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui effectue la modification dans la base de donnÃ©es
        /// </summary>
        /// <param name="idUtil">Id du Util</param>
        /// <param name="nomUtil">Nom du Util</param>
        /// <param name="prenomUtil">Prenom du Util</param>
        /// <param name="ageUtil">Age du Util</param>
        /// <param name="numCarteUtil">NumÃ©ro de la carte d'identitÃ©</param>
        /// <param name="domicileUtil">Domicile du Util</param>
        /// <param name="telUtil">TÃ©lÃ©phone du Util</param>
        /// <param name="celUtil">Cellulaire du Util</param>
        /// <param name="emailUtil">Email du Util</param>
        /// <param name="loginUtil">Login du Util</param>
        /// <param name="passwordUtil">Password du Util</param>
        /// <param name="valideUtil">Indique si le Util est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateUtil(int idUtil, string nomUtil, string prenomUtil, int ageUtil, string numCarteUtil, string adresseUtil, string telUtil, string celUtil, string emailUtil, string loginUtil, string passwordUtil, int typeUtil, bool valideUtil)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Utilisateur " +
                    "SET NomUtil = @NomUtil, PrenomUtil = @PrenomUtil, AgeUtil = @AgeUtil, NumCarteUtil = @NumCarteUtil, AdresseUtil = @AdresseUtil, TelUtil = @TelUtil, CelUtil = @CelUtil, EmailUtil = @EmailUtil, LoginUtil = @LoginUtil, PasswordUtil = @PasswordUtil, TypeUtil = @TypeUtil, ValideUtil = @ValideUtil " +
                    "WHERE IdUtil = @IdUtil";

                command.Parameters.Add(CreateDbParameter(command, "@NomUtil", nomUtil));
                command.Parameters.Add(CreateDbParameter(command, "@PrenomUtil", prenomUtil));
                command.Parameters.Add(CreateDbParameter(command, "@AgeUtil", ageUtil));
                command.Parameters.Add(CreateDbParameter(command, "@NumCarteUtil", numCarteUtil));
                command.Parameters.Add(CreateDbParameter(command, "@AdresseUtil", adresseUtil));
                command.Parameters.Add(CreateDbParameter(command, "@TelUtil", telUtil));
                command.Parameters.Add(CreateDbParameter(command, "@CelUtil", celUtil));
                command.Parameters.Add(CreateDbParameter(command, "@EmailUtil", emailUtil));
                command.Parameters.Add(CreateDbParameter(command, "@LoginUtil", loginUtil));
                command.Parameters.Add(CreateDbParameter(command, "@PasswordUtil", passwordUtil));
                command.Parameters.Add(CreateDbParameter(command, "@TypeUtil", typeUtil));
                command.Parameters.Add(CreateDbParameter(command, "@ValideUtil", valideUtil));
                command.Parameters.Add(CreateDbParameter(command, "@IdUtil", idUtil));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la modification : " + dbEx.Message);
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui effectue la suppression dans la base de données
        /// </summary>
        /// <param name="idUser">Id du user à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteUtil(bool valide, int idUtil)
        {
            int result = 0;

             //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Utilisateur SET ValideUtil = @ValideUtil  WHERE IdUtil = @IdUtil";

                command.Parameters.Add(CreateDbParameter(command, "@ValideUtil", valide));
                command.Parameters.Add(CreateDbParameter(command, "@IdUtil", idUtil));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la suppression : " + dbEx.Message);
                }
            }

             //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }
    }
}
