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
    /// Classe de mappage sur la table Commander
    /// </summary>
    public class CommanderDAL : AbstractDataAccess
    {

        public CommanderDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des Commandes
        /// </summary>
        /// <returns>Renvoie un CommanderBOListView</returns>
        public CommanderBOListView GetCommanderFromDB()
        {
            CommanderBOListView liste = new CommanderBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdComder, Article.LibelleArt, Fournisseur.RaisonSocialeFour, QteCom, PrixCom, Commander.IdArt, IdCom, Commander.IdFour FROM Commander, Article, Fournisseur WHERE Commander.IdArt = Article.IdArt AND Commander.IdFour = Fournisseur.IdFour";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CommanderBO c = new CommanderBO();

                            c.IdComder = (int)reader["IdComder"];
                            c.LibelleArt = reader["LibelleArt"].ToString();
                            c.RaisonSocialeFour = reader["RaisonSocialeFour"].ToString();
                            c.QteCom = (int)reader["QteCom"];
                            c.PrixCom = (int)reader["PrixCom"];
                            c.Total = (c.QteCom * c.PrixCom);
                            c.IdArt = (int)reader["IdArt"];
                            c.IdCom = (int)reader["IdCom"];
                            c.IdFour = (int)reader["IdFour"];

                            liste.Add(c);
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
        /// Fonction qui renvoie la liste des Commandes en fonction de l'id de la commande
        /// </summary>
        /// <returns>Renvoie un CommanderBOListView</returns>
        public CommanderBOListView GetCommanderByCommandeIdFromDB(int idCom)
        {
            CommanderBOListView liste = new CommanderBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdComder, Article.LibelleArt, Fournisseur.RaisonSocialeFour, QteCom, PrixCom, Commander.IdArt, IdCom, Commander.IdFour " +
                    "FROM Commander, Article, Fournisseur WHERE Commander.IdArt = Article.IdArt AND Commander.IdFour = Fournisseur.IdFour AND Commander.IdCom = @IdCom";

                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CommanderBO c = new CommanderBO();

                            c.IdComder = (int)reader["IdComder"];
                            c.LibelleArt = reader["LibelleArt"].ToString();
                            c.RaisonSocialeFour = reader["RaisonSocialeFour"].ToString();
                            c.QteCom = (int)reader["QteCom"];
                            c.PrixCom = (int)reader["PrixCom"];
                            c.Total = (c.QteCom * c.PrixCom);
                            c.IdArt = (int)reader["IdArt"];
                            c.IdCom = (int)reader["IdCom"];
                            c.IdFour = (int)reader["IdFour"];

                            liste.Add(c);
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
        /// Fonction qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="qteCom">Qté de la commande</param>
        /// <param name="prixCom">Prix de la commande</param>
        /// <param name="idArt">Id de l'article commandé</param>
        /// <param name="idCom">Id de la commande</param>
        /// <param name="idFour">Id du fournisseur</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertCommander(int qteCom, int prixCom, int idArt, int idCom, int idFour)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Commander (QteCom, PrixCom, IdArt, IdCom, IdFour) " +
                    "VALUES (@QteCom, @PrixCom, @IdArt, @IdCom, @IdFour)";

                command.Parameters.Add(CreateDbParameter(command, "@QteCom", qteCom));
                command.Parameters.Add(CreateDbParameter(command, "@PrixCom", prixCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdFour", idFour));

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
        /// Fonction qui effectue la modification
        /// </summary>
        /// <param name="idComder">Id de la commande</param>
        /// <param name="qteCom">Qté commandée</param>
        /// <param name="prixCom">Prix de la commande</param>
        /// <param name="idArt">Id de l'article</param>
        /// <param name="idCom">Id de la commande associée</param>
        /// <param name="idFour">Id du fournisseur</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateCommander(int idComder, int qteCom, int prixCom, int idArt, int idCom, int idFour)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Commander " +
                    "SET QteCom = @QteCom, PrixCom = @PrixCom, IdArt = @IdArt, IdCom = @IdCom, IdFour = @IdFour " +
                    "WHERE (IdComder = @IdComder)";

                command.Parameters.Add(CreateDbParameter(command, "@QteCom", qteCom));
                command.Parameters.Add(CreateDbParameter(command, "@PrixCom", prixCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdFour", idFour));
                command.Parameters.Add(CreateDbParameter(command, "@IdComder", idComder));

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
        /// Fonction qui effectue la suppression
        /// </summary>
        /// <param name="idComder">Id de la commande</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteCommander(int idComder)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Commander WHERE IdComder = @IdComder";

                command.Parameters.Add(CreateDbParameter(command, "@IdComder", idComder));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la suppresion : " + dbEx.Message);                    
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }
    }
}
