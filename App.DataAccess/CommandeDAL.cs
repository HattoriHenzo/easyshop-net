using System;
using System.Data;
using System.Data.OleDb;

using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    /// <summary>
    /// Classe de mappage sur la table Commande
    /// </summary>
    public class CommandeDAL : AbstractDataAccess
    {

        public CommandeDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des commandes
        /// </summary>
        /// <returns>Renvoie un CommandeBOListView</returns>
        public CommandeBOListView GetCommandesFromDB()
        {
            CommandeBOListView liste = new CommandeBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdCom, NumCom, NumComText, DateCom, HeureCom, DescCom, AnnulerCom FROM Commande";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CommandeBO c = new CommandeBO();

                            c.IdCom = (int)reader["IdCom"];
                            c.NumCom = (int)reader["NumCom"];
                            c.NumComText = reader["NumComText"].ToString();
                            c.DateCom = (DateTime)reader["DateCom"];
                            c.HeureCom = DateTime.Parse(reader["HeureCom"].ToString()).ToShortTimeString();
                            c.DescCom = reader["DescCom"].ToString();
                            c.AnnulerCom = (bool)reader["AnnulerCom"];

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
        /// Fonction qui effectue l'insertion d'une commande dans la base de données
        /// </summary>
        /// <param name="numCom">Numéro de la commande</param>
        /// <param name="numComtext">Numéro de la commande sous forme de text</param>
        /// <param name="dateCom">Date de la commande</param>
        /// <param name="heureCom">Heure de la commande</param>
        /// <param name="descCom">Descritpion de la commande</param>
        /// <param name="annulerCom">Indique si une commande est annulée ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertCommande(int numCom, string numComText, DateTime dateCom, DateTime heureCom, string descCom, bool annulerCom)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Commande (NumCom, NumComText, DateCom, HeureCom, DescCom) " +
                    "VALUES (@NumCom, @NumComText, @DateCom, @HeureCom, @DescCom)";

                command.Parameters.Add(CreateDbParameter(command, "@NumCom", numCom));
                command.Parameters.Add(CreateDbParameter(command, "@NumComText", numComText));
                command.Parameters.Add(CreateDbParameter(command, "@DateCom", dateCom));
                command.Parameters.Add(CreateDbParameter(command, "@HeureCom", heureCom));
                command.Parameters.Add(CreateDbParameter(command, "@DescCom", descCom));

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
        /// <param name="idCom">Id de la commande à modifier</param>
        /// <param name="numCom">Numéro de la commande</param>
        /// <param name="numComtext">Numéro de la commande sous forme de text</param>
        /// <param name="dateCom">Date de la commande</param>
        /// <param name="heureCom">Heure de la commande</param>
        /// <param name="descCom">Descritpion de la commande</param>
        /// <param name="annulerCom">Indique si une commande est annulée ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateCommande(int idCom, int numCom, string numComText, DateTime dateCom, DateTime heureCom, string descCom, bool annulerCom)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Commande " +
                    "SET NumCom = @NumCom, NumComText = @NumComText, DateCom = @DateCom, HeureCom = @HeureCom, DescCom = @DescCom, AnnulerCom = @AnnulerCom " +
                    "WHERE IdCom = @IdCom";

                command.Parameters.Add(CreateDbParameter(command, "@NumCom", numCom));
                command.Parameters.Add(CreateDbParameter(command, "@NumComText", numComText));
                command.Parameters.Add(CreateDbParameter(command, "@DateCom", dateCom));
                command.Parameters.Add(CreateDbParameter(command, "@HeureCom", heureCom));
                command.Parameters.Add(CreateDbParameter(command, "@DescCom", descCom));
                command.Parameters.Add(CreateDbParameter(command, "@AnnulerCom", annulerCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));

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
        /// Fonction qui effectue la modification dans la base de données
        /// </summary>
        /// <param name="annulerCom">Indique si la commande est annulée ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateCommandeAnnuler(int idCom, bool annulerCom)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des patamètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Commande SET AnnulerCom = @AnnulerCom WHERE (IdCom = @IdCom)";

                command.Parameters.Add(CreateDbParameter(command, "@AnnulerCom", annulerCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));

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
        /// Fonction qui effectue la suppression d'une commande
        /// </summary>
        /// <param name="idCom">Id de la commande à supprimer</param>
        /// <returns>Renvoie unn entier</returns>
        public int DeleteCommande(int idCom)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Commande WHERE IdCom = @IdCom";

                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la supression : " + dbEx.Message);                    
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }
    }    

}
