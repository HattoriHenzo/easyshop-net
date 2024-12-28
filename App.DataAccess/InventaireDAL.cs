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
    /// Classe de mappage sur la table Inventaire
    /// </summary>
    public class InventaireDAL : AbstractDataAccess
    {

        public InventaireDAL()
        {

        }

        /// <summary>
        /// Fonction qui renvoie la liste des Inventaires
        /// </summary>
        /// <returns>Renvoie un InventaireBOListView</returns>
        public InventaireBOListView GetInventairesByDateIdFromDB(int idDateInv)
        {
            InventaireBOListView liste = new InventaireBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdInv, LibelleArt, QtePhysInv, QteStockInv, EcartInv, ObservationInv, IdDateInv, Inventaire.IdArt FROM Inventaire, Article " +
                    "WHERE Inventaire.IdArt = Article.IdArt AND (IdDateInv = @IdDateInv)";

                command.Parameters.Add(CreateDbParameter(command, "@IdDateInv", idDateInv));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            InventaireBO i = new InventaireBO();

                            i.IdInv = (int)reader["IdInv"];
                            i.LibelleArt = reader["LibelleArt"].ToString();
                            i.QtePhysInv = int.Parse(reader["QtePhysInv"].ToString());
                            i.QteStockInv = int.Parse(reader["QteStockInv"].ToString());
                            i.EcartInv = i.QtePhysInv - i.QteStockInv;
                            i.ObservationInv = reader["ObservationInv"].ToString();
                            i.IdDateInv = int.Parse(reader["IdDateInv"].ToString());
                            i.IdArt = int.Parse(reader["IdArt"].ToString());

                            liste.Add(i);
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
        /// <param name="qtePhysInv">Quantité physique inventoriée</param>
        /// <param name="qteStockInv">Quantité stock inventoriée</param>
        /// <param name="ecartInv">Ecart entre les deux quantités</param>
        /// <param name="observationInv">Observation de l'inventaire</param>
        /// <param name="idDateInv">Id de la date d'inventaire</param>
        /// <param name="idArt">Id de l'article</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertInventaire(int qtePhysInv, int qteStockInv, int ecartInv, string observationInv, int idDateInv, int idArt)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Inventaire (QtePhysInv, QteStockInv, EcartInv, ObservationInv, IdDateInv, IdArt) " +
                    "VALUES (@QtePhysInv, @QteStockInv, @EcartInv, @ObservationInv, @IdDateInv, @IdArt)";

                command.Parameters.Add(CreateDbParameter(command, "@QtePhysInv", qtePhysInv));
                command.Parameters.Add(CreateDbParameter(command, "@QteStockInv", qteStockInv));
                command.Parameters.Add(CreateDbParameter(command, "@EcartInv", ecartInv));
                command.Parameters.Add(CreateDbParameter(command, "@ObservationInv", observationInv));
                command.Parameters.Add(CreateDbParameter(command, "@IdDateInv", idDateInv));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));

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
        /// <param name="idInv">Id de l'inventaire</param>
        /// <param name="qtePhysInv">Quantité physique inventoriée</param>
        /// <param name="qteStockInv">Quantité stock inventoriée</param>
        /// <param name="ecartInv">Ecart entre les deux quantités</param>
        /// <param name="observationInv">Observation de l'inventaire</param>
        /// <param name="idDateInv">Id de la date d'inventaire</param>
        /// <param name="idArt">Id de l'article</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateInventaire(int idInv, int qtePhysInv, int qteStockInv, int ecartInv, string observationInv, int idDateInv, int idArt)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Inventaire " +
                    "SET QtePhysInv = @QtePhysInv, QteStockInv = @QteStockInv, EcartInv = @EcartInv, ObservationInv = @ObservationInv, IdDateInv = @IdDateInv, IdArt = @IdArt " +
                    "WHERE (IdInv =  @IdInv)";

                command.Parameters.Add(CreateDbParameter(command, "@QtePhysInv", qtePhysInv));
                command.Parameters.Add(CreateDbParameter(command, "@QteStockInv", qteStockInv));
                command.Parameters.Add(CreateDbParameter(command, "@EcartInv", ecartInv));
                command.Parameters.Add(CreateDbParameter(command, "@ObservationInv", observationInv));
                command.Parameters.Add(CreateDbParameter(command, "@IdDateInv", idDateInv));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdInv", idInv));

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
        /// Fonction qui effectue la modification de la quantité physique
        /// </summary>
        /// <param name="idInv">Id à modifier</param>
        /// <param name="qtePhys">Nouvelle quantité physique</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateInventaireQtePhysique(int idInv, int qtePhys)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Inventaire SET QtePhysInv = @QtePhysInv WHERE (IdInv =  @IdInv)";

                command.Parameters.Add(CreateDbParameter(command, "@QtePhysInv", qtePhys));
                command.Parameters.Add(CreateDbParameter(command, "@IdInv", idInv));

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
        /// <param name="idInv">Id de l'inventaire</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteInventaire(int idInv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Inventaire WHERE (IdInv = @IdInv)";

                command.Parameters.Add(CreateDbParameter(command, "@IdInv", idInv));

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

        /// <summary>
        /// Fonction qui effectue la suppression dans la base 
        /// de données en fonction de la date d'inventaire
        /// </summary>
        /// <param name="idInv">Id de l'inventaire</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteInventaireByDateId(int idDateInv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Inventaire WHERE (IdDateInv = @IdDateInv)";

                command.Parameters.Add(CreateDbParameter(command, "@IdDateInv", idDateInv));

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
