using System;
using System.Data;
using System.Data.OleDb;
using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    /// <summary>
    /// Classe permettant de manipuler la table ArreteDeCaisse
    /// </summary>
    public class ArreteDeCaisseDAL : AbstractDataAccess
    {
        public ArreteDeCaisseDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des ArreteDeCaisse
        /// </summary>
        /// <returns>Renvoie un ArreteDeCaisseBOListView</returns>
        public ArreteDeCaisseBOListView GetArreteDeCaissesFromDB()
        {
            ArreteDeCaisseBOListView liste = new ArreteDeCaisseBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM ArreteDeCaisse";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ArreteDeCaisseBO a = new ArreteDeCaisseBO();

                            a.IdAC = (int)reader["IdAc"];
                            a.DateAC = (DateTime)reader["DateAC"];
                            a.HeureAC = reader["HeureAC"].ToString();
                            a.MontantEnCaisse = (int)reader["MontantEnCaisse"];
                            a.MontantBase = (int)reader["MontantBase"];
                            a.ConformeAC = bool.Parse(reader["ConformeAC"].ToString());
                            a.ObservationAC = reader["ObservationAC"].ToString();

                            liste.Add(a);
                        }
                    }

                    reader.Close();
                }
                
            }

            //Connection à la base de données
            AppConnection.Instance.Disconnect();

            return liste;
        }

        /// <summary>
        /// Fonction qui renvoie la liste des ArreteDeCaisse suivant une période donnée
        /// </summary>
        /// <returns>Renvoie un ArreteDeCaisseBOListView</returns>
        public ArreteDeCaisseBOListView GetArreteDeCaissesByPeriodFromDB(DateTime dateDu, DateTime dateAu)
        {
            ArreteDeCaisseBOListView liste = new ArreteDeCaisseBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM ArreteDeCaisse WHERE DateAC BETWEEN @DateDu AND @DateAu";

                command.Parameters.Add(CreateDbParameter(command, "@DateDu", dateDu));
                command.Parameters.Add(CreateDbParameter(command, "@DateAu", dateAu));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ArreteDeCaisseBO a = new ArreteDeCaisseBO();

                            a.IdAC = (int)reader["IdAc"];
                            a.DateAC = (DateTime)reader["DateAC"];
                            a.HeureAC = DateTime.Parse(reader["HeureAC"].ToString()).ToShortTimeString();
                            a.MontantEnCaisse = (int)reader["MontantEnCaisse"];
                            a.MontantBase = (int)reader["MontantBase"];
                            a.ConformeAC = bool.Parse(reader["ConformeAC"].ToString());
                            a.ObservationAC = reader["ObservationAC"].ToString();

                            liste.Add(a);
                        }
                    }

                    reader.Close();
                }

            }

            //Connection à la base de données
            AppConnection.Instance.Disconnect();

            return liste;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'un arrêté de caisse dans la base de données
        /// </summary>
        /// <param name="dateAC">Date de l'arrêté de caisse</param>
        /// <param name="heureAC">Heure de l'arrêté de caisse</param>
        /// <param name="montantEnCaisse">Montant compté de l'arrêté de caisse</param>
        /// <param name="montantBase">Montant contenu dans la base</param>
        /// <param name="conformeAC">Indique si l'arrêté de caisse est conforme ou pas</param>
        /// <param name="observationAC">Observation sur l'arrêté de caisse</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertArreteDeCaisse(DateTime dateAC, DateTime heureAC, int montantEnCaisse, int montantBase, bool conformeAC, string observationAC)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO ArreteDeCaisse(DateAC, HeureAC, MontantEnCaisse, MontantBase, ConformeAC, ObservationAC) " +
                    "VALUES(@DateAC, @HeureAC, @MontantEnCaisse, @MontantBase, @ConformeAC, @ObservationAC)";

                command.Parameters.Add(CreateDbParameter(command, "@DateAC", dateAC));
                command.Parameters.Add(CreateDbParameter(command, "@HeureAC", heureAC));
                command.Parameters.Add(CreateDbParameter(command, "@MontantEnCaisse", montantEnCaisse));
                command.Parameters.Add(CreateDbParameter(command, "@MontantBase", montantBase));
                command.Parameters.Add(CreateDbParameter(command, "@ConformeAC", conformeAC));
                command.Parameters.Add(CreateDbParameter(command, "@ObservationAC", observationAC));


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
        /// Fonction qui effectue la modification d'un arrêté de caisse
        /// </summary>
        /// <param name="idAC">Id de l'arrêté de caisse à modifier</param>
        /// <param name="dateAC">Date de l'arrêté de caisse</param>
        /// <param name="heureAC">Heure de l'arrêté de caisse</param>
        /// <param name="montantEnCaisse">Montant compté de l'arrêté de caisse</param>
        /// <param name="montantBase">Montant contenu dans la base</param>
        /// <param name="conformeAC">Indique si l'arrêté de caisse est conforme ou pas</param>
        /// <param name="observationAC">Observation sur l'arrêté de caisse</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateArreteDeCaisse(int idAC, DateTime dateAC, DateTime heureAC, int montantEnCaisse, int montantBase, bool conformeAC, string observationAC)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ArreteDeCaisse SET DateAC = @DateAC, HeureAC = @HeureAC, MontantEnCaisse = @MontantEnCaisse, MontantBase = @MontantBase, ConformeAC = @ConformeAC, ObservationAC = @ObservationAC WHERE (IdAC = @IdAC)";

    
                command.Parameters.Add(CreateDbParameter(command, "@DateAC", dateAC));
                command.Parameters.Add(CreateDbParameter(command, "@HeureAC", heureAC));
                command.Parameters.Add(CreateDbParameter(command, "@MontantEnCaisse", montantEnCaisse));
                command.Parameters.Add(CreateDbParameter(command, "@MontantBase", montantBase));
                command.Parameters.Add(CreateDbParameter(command, "@ConformeAC", conformeAC));
                command.Parameters.Add(CreateDbParameter(command, "@ObservationAC", observationAC));
                command.Parameters.Add(CreateDbParameter(command, "@IdAC", idAC));

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
        /// Fonction qui effectue la suppression d'un arrêté de caisse
        /// </summary>
        /// <param name="idAC">Id de l'arrêté de caisse à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteArreteDeCaisse(int idAC)
        {
            int result = 0;
            
            //Connection à la base de données
            AppConnection.Instance.Connect();
            
            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM ArreteDeCaisse WHERE IdAC = @IdAC";

                command.Parameters.Add(CreateDbParameter(command, "@IdAC", idAC));

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
