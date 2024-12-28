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
    public class DepenseDAL : AbstractDataAccess
    {

        public DepenseDAL()
        {

        }

        /// <summary>
        /// Fonction aui renvoi la liste des depenses suivant une periode
        /// </summary>        >        
        /// <returns>Renvoi une liste de Depenses</returns>
        public DepenseBOListView GetDepensesFromDB()
        {
            DepenseBOListView liste = new DepenseBOListView();
            // Connexion a la base de donnees
            AppConnection.Instance.Connect();
            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Id, DateDepense, Objet, Montant FROM Depense";             

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DepenseBO d = new DepenseBO
                            {
                                IdDep = (int)reader["Id"],
                                Date = (DateTime)reader["DateDepense"],
                                Objet = reader["Objet"].ToString(),
                                Montant = (int)reader["Montant"]
                            };

                            liste.Add(d);
                        }
                    }

                    reader.Close();
                }
            }

            AppConnection.Instance.Disconnect();

            return liste;
        }

        /// <summary>
        /// Fonction aui renvoi la liste des depenses suivant une periode
        /// </summary>
        /// <param name="dateDu">Date de debut</param>
        /// <param name="dateAu">Date de fin</param>
        /// <returns>Renvoi une liste de Depenses</returns>
        public DepenseBOListView GetDepensesByPeriodFromDB(DateTime dateDu, DateTime dateAu)
        {
            DepenseBOListView liste = new DepenseBOListView();
            // Connexion a la base de donnees
            AppConnection.Instance.Connect();
            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Id, DateDepense, Objet, Montant FROM Depense WHERE DateDepense BETWEEN @DateDu AND @DateAu";

                command.Parameters.Add(CreateDbParameter(command, "@DateDu", dateDu));
                command.Parameters.Add(CreateDbParameter(command, "@DateAu", dateAu));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            DepenseBO d = new DepenseBO
                            {
                                IdDep = (int)reader["Id"],
                                Date = (DateTime)reader["DateDepense"],
                                Objet = reader["Objet"].ToString(),
                                Montant = (int)reader["Montant"]
                            };

                            liste.Add(d);
                        }   
                    }

                    reader.Close();
                }
            }

            AppConnection.Instance.Disconnect();

            return liste;
        }

        /// <summary>
        /// Fonction qui insert une depense dans a base de donnees
        /// </summary>
        /// <param name="dateDepense">Date d'insertion</param>
        /// <param name="objet">Objet de la depense</param>
        /// <param name="montant">Montant de la depense</param>
        /// <returns>Renvoi un entier</returns>
        public int InsertDepense(DateTime dateDepense, String objet, int montant)
        {
            int result = 0;

            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Depense (DateDepense, Objet, Montant) " +
                    "VALUES (@DateDepense, @Objet, @Montant)";
                
                command.Parameters.Add(CreateDbParameter(command, "@DateDepense", dateDepense));
                command.Parameters.Add(CreateDbParameter(command, "@Objet", objet));
                command.Parameters.Add(CreateDbParameter(command, "@Montant", montant));

                result = command.ExecuteNonQuery();
            }

            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="depense"></param>
        /// <returns></returns>
        public int DeleteDepense(int id)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Depense WHERE Id = @Id";

                command.Parameters.Add(CreateDbParameter(command, "@Id", id));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la suppression dans la base de données : " + dbEx.Message);
                }
            }

            //Déconnection à la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }
    }
}
