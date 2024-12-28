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
    public class DateInventaireDAL : AbstractDataAccess
    {

        public DateInventaireDAL()
        {

        }

        /// <summary>
        /// Fonction qui renvoie la liste de toutes les dates d'inventaires
        /// </summary>
        /// <returns>Renvoie un DateInventaireBOListView</returns>
        public DateInventaireBOListView GetDateInventairesFromDB()
        {
            DateInventaireBOListView liste = new DateInventaireBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdDateInv, ObservationInv, DateInv, HeureInv, ValideInv FROM DateInventaire";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateInventaireBO d = new DateInventaireBO();

                            d.IdDateInv = (int)reader["IdDateInv"];
                            d.ObservationInv = reader["ObservationInv"].ToString();
                            d.DateInv = (DateTime)reader["DateInv"];
                            d.HeureInv = DateTime.Parse(reader["HeureInv"].ToString()).ToShortTimeString();
                            d.ValideInv = bool.Parse(reader["ValideInv"].ToString());

                            liste.Add(d);
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
        /// Fonction qui renvoie la liste de toutes les dates d'inventaires
        /// </summary>
        /// <returns>Renvoie un DateInventaireBOListView</returns>
        public DateInventaireBOListView GetDateInventairesByDateFromDB(DateTime dateDu, DateTime dateAu)
        {
            DateInventaireBOListView liste = new DateInventaireBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdDateInv, ObservationInv, DateInv, HeureInv, ValideInv FROM DateInventaire WHERE DateInv BETWEEN @DateDu AND @DateAu";

                command.Parameters.Add(CreateDbParameter(command, "@DateDu", dateDu));
                command.Parameters.Add(CreateDbParameter(command, "@DateAu", dateAu));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DateInventaireBO d = new DateInventaireBO();

                            d.IdDateInv = (int)reader["IdDateInv"];
                            d.ObservationInv = reader["ObservationInv"].ToString();
                            d.DateInv = (DateTime)reader["DateInv"];
                            d.HeureInv = DateTime.Parse(reader["HeureInv"].ToString()).ToShortTimeString();
                            d.ValideInv = bool.Parse(reader["ValideInv"].ToString());

                            liste.Add(d);
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
        /// Fonction qui effectue l'insertion d'une date d'inventaire
        /// </summary>
        /// <param name="observationInv">Observation de l'inventaire</param>
        /// <param name="dateInv">Date de l'inventaire</param>
        /// <param name="heureInv">Heure de l'inventaire</param>       
        /// <returns>Renvoie un entier</returns>
        public int InsertDateInventaire(string observationInv, DateTime dateInv, DateTime heureInv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO DateInventaire (ObservationInv, DateInv, HeureInv) " +
                    "VALUES (@ObservationInv, @DateInv, @HeureInv)";

                command.Parameters.Add(CreateDbParameter(command, "@ObservationInv", observationInv));
                command.Parameters.Add(CreateDbParameter(command, "@DateInv", dateInv));
                command.Parameters.Add(CreateDbParameter(command, "@HeureInv", heureInv));

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
        /// Fonction qui effectue la modification d'une date d'inventaire
        /// </summary>
        /// <param name="idDateInv">Id de la date inventaire à modifier</param>
        /// <param name="observationInv">Observation de l'inventaire</param>
        /// <param name="dateInv">Date de l'inventaire</param>
        /// <param name="heureInv">Heure de l'inventaire</param>    
        /// <returns>Renvoie un entier</returns>
        public int UpdateDateInventaire(int idDateInv, string observationInv, DateTime dateInv, DateTime heureInv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE DateInventaire SET ObservationInv = @ObservationInv, DateInv = @DateInv, HeureInv = @HeureInv  WHERE (IdDateInv = @IdDateInv)";

                command.Parameters.Add(CreateDbParameter(command, "@ObservationInv", observationInv));
                command.Parameters.Add(CreateDbParameter(command, "@DateInv", dateInv));
                command.Parameters.Add(CreateDbParameter(command, "@HeureInv", heureInv));
                command.Parameters.Add(CreateDbParameter(command, "@IdDateInv", idDateInv));

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
        /// Fonction qui effectue la validation ou l'invalidation d'un inventaire 
        /// </summary>
        /// <param name="idDateInv">Id de l'inventaire à modifier</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateDateInventaireValide(int idDateInv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE DateInventaire SET ValideInv = true WHERE (IdDateInv = @IdDateInv)";
                
                command.Parameters.Add(CreateDbParameter(command, "@IdDateInv", idDateInv));

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
        /// Fonction qui effectue la suppression d'une date d'inventaire
        /// </summary>
        /// <param name="idDateInv">Id de l'inventaire à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteDateInventaire(int idDateInv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM DateInventaire WHERE IdDateInv = @IdDateInv";

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
