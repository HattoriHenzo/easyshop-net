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
    /// Classe de mappage sur la classe Fournisseur
    /// </summary>
    public class FournisseurDAL : AbstractDataAccess
    {

        public FournisseurDAL()
        {

        }

        /// <summary>
        /// Fonction qui renvoie la liste de tous les fournisseurs
        /// </summary>
        /// <returns>Renvoie un FournisseurBOListView</returns>
        public FournisseurBOListView GetFournisseursFromDB()
        {
            FournisseurBOListView liste = new FournisseurBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdFour, RaisonSocialeFour, AdresseFour, TelFour, CelFour, FaxFour, EmailFour, SiteInternetFour " +
                    "FROM Fournisseur";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FournisseurBO f = new FournisseurBO();

                            f.IdFour = (int)reader["IdFour"];
                            f.RaisonSocialeFour = reader["RaisonSocialeFour"].ToString();
                            f.AdresseFour = reader["AdresseFour"].ToString();
                            f.TelFour = reader["TelFour"].ToString();
                            f.CelFour = reader["CelFour"].ToString();
                            f.FaxFour = reader["FaxFour"].ToString();
                            f.EmailFour = reader["EmailFour"].ToString();
                            f.SiteInternetFour = reader["SiteInternetFour"].ToString();

                            liste.Add(f);
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
        /// Fonctio  qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="raisonSocialeFour">Raison sociale du fournisseur</param>
        /// <param name="adresseFour">Adresse du fournisseur</param>
        /// <param name="telFour">Téléphone du fournisseur</param>
        /// <param name="celFour">Cellulaire du fournisseur</param>
        /// <param name="faxFour">Fax du fournisseur</param>
        /// <param name="emailFour">Email du fournisseur</param>
        /// <param name="siteInternetFour">Site internet du fournisseur</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertFournisseur(string raisonSocialeFour, string adresseFour, string telFour, string celFour, string faxFour, string emailFour, string siteInternetFour)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Fournisseur (RaisonSocialeFour, AdresseFour, TelFour, CelFour, FaxFour, EmailFour, SiteInternetFour) " +
                    "VALUES (@RaisonSocialeFour, @AdresseFour, @TelFour, @CelFour, @FaxFour, @EmailFour, @SiteInternetFour)";

                command.Parameters.Add(CreateDbParameter(command, "@RaisonSocialeFour", raisonSocialeFour));
                command.Parameters.Add(CreateDbParameter(command, "@AdresseFour", adresseFour));
                command.Parameters.Add(CreateDbParameter(command, "@TelFour", telFour));
                command.Parameters.Add(CreateDbParameter(command, "@CelFour", celFour));
                command.Parameters.Add(CreateDbParameter(command, "@FaxFour", faxFour));
                command.Parameters.Add(CreateDbParameter(command, "@EmailFour", emailFour));
                command.Parameters.Add(CreateDbParameter(command, "@SiteInternetFour", siteInternetFour));

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
        /// Fonction qui effectue la modification dans la base de données
        /// </summary>
        /// <param name="idFour">Id du fournisseur</param>
        /// <param name="raisonSocialeFour">Raison sociale du fournisseur</param>
        /// <param name="adresseFour">Adresse du fournisseur</param>
        /// <param name="telFour">Téléphone du fournisseur</param>
        /// <param name="celFour">Cellulaire du fournisseur</param>
        /// <param name="faxFour">Fax du fournisseur</param>
        /// <param name="emailFour">Email du fournisseur</param>
        /// <param name="siteInternetFour">Site internet du fournisseur</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateFournisseur(int idFour, string raisonSocialeFour, string adresseFour, string telFour, string celFour, string faxFour, string emailFour, string siteInternetFour)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Fournisseur " +
                    "SET RaisonSocialeFour = @RaisonSocialeFour, AdresseFour = @AdresseFour, TelFour = @TelFour, CelFour = @CelFour, FaxFour = @FaxFour, EmailFour = @EmailFour, SiteInternetFour = @SiteInternetFour " +
                    "WHERE (IdFour = @IdFour)";

                command.Parameters.Add(CreateDbParameter(command, "@RaisonSocialeFour", raisonSocialeFour));
                command.Parameters.Add(CreateDbParameter(command, "@AdresseFour", adresseFour));
                command.Parameters.Add(CreateDbParameter(command, "@TelFour", telFour));
                command.Parameters.Add(CreateDbParameter(command, "@CelFour", celFour));
                command.Parameters.Add(CreateDbParameter(command, "@FaxFour", faxFour));
                command.Parameters.Add(CreateDbParameter(command, "@EmailFour", emailFour));
                command.Parameters.Add(CreateDbParameter(command, "@SiteInternetFour", siteInternetFour));
                command.Parameters.Add(CreateDbParameter(command, "@IdFour", idFour));

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
        /// <param name="idFour">Id du fournisseur</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteFournisseur(int idFour)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Fournisseur WHERE IdFour = @IdFour";

                command.Parameters.Add(CreateDbParameter(command, "@IdFour", idFour));

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
