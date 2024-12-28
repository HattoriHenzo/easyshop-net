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
    /// Classe de mappage sur la table Livraison
    /// </summary>
    public class LivraisonDAL : AbstractDataAccess
    {

        public LivraisonDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des livraisons
        /// </summary>
        /// <returns>Renvoie un LivraisonBOListView</returns>
        public LivraisonBOListView GetLivraisonsByCommandeIdFromDB(int idCom)
        {
            LivraisonBOListView liste = new LivraisonBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Livraison WHERE IdCom = @IdCom";

                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LivraisonBO l = new LivraisonBO();

                            l.IdLiv = (int)reader["IdLiv"];
                            l.NumFactLiv = reader["NumFactLiv"].ToString();
                            l.NumBLLiv = reader["NumBLLiv"].ToString();
                            l.DateLiv = (DateTime)reader["DateLiv"];
                            l.HeureLiv = DateTime.Parse(reader["HeureLiv"].ToString()).ToShortTimeString();
                            l.IdCom = int.Parse(reader["IdCom"].ToString());
                            l.ValideLiv = (bool)reader["ValideLiv"];

                            liste.Add(l);
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
        /// <param name="numFactLiv">Numéro de la facture</param>
        /// <param name="numBLLiv">Numéro du Bordereau de livraison</param>
        /// <param name="dateLiv">Date de la livraison</param>
        /// <param name="heureLiv">Heure de la livraison</param>
        /// <param name="idCom">Id de la commande</param>
        /// <param name="valideLiv">Indique si la commande est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertLivraison(string numFactLiv, string numBLLiv, DateTime dateLiv, DateTime heureLiv, int idCom, bool valideLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Livraison (NumFactLiv, NumBLLiv, DateLiv, HeureLiv, IdCom) " +
                    "VALUES (@NumFactLiv, @NumBLLiv, @DateLiv, @HeureLiv, @IdCom)";

                command.Parameters.Add(CreateDbParameter(command, "@NumFactLiv", numFactLiv));
                command.Parameters.Add(CreateDbParameter(command, "@NumBLLiv", numBLLiv));
                command.Parameters.Add(CreateDbParameter(command, "@DateLiv", dateLiv));
                command.Parameters.Add(CreateDbParameter(command, "@HeureLiv", heureLiv));
                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));

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
        /// Fonction qui effectue la modification d'une livraison
        /// </summary>
        /// <param name="idLiv">Id de la livraison</param>
        /// <param name="numFactLiv">Numéro de la facture</param>
        /// <param name="numBLLiv">Numéro du Bordereau de livraison</param>
        /// <param name="dateLiv">Date de la livraison</param>
        /// <param name="heureLiv">Heure de la livraison</param>
        /// <param name="idCom">Id de la commande</param>
        /// <param name="valideLiv">Indique si la commande est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateLivraison(int idLiv, string numFactLiv, string numBLLiv, DateTime dateLiv, DateTime heureLiv, int idCom, bool valideLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Livraison " +
                    "SET NumFactLiv = @NumFactLiv, NumBLLiv = @NumBLLiv, DateLiv = @DateLiv, HeureLiv = @HeureLiv, IdCom = @IdCom " +
                    "WHERE (IdLiv = @IdLiv)";

                command.Parameters.Add(CreateDbParameter(command, "@NumFactLiv", numFactLiv));
                command.Parameters.Add(CreateDbParameter(command, "@NumBLLiv", numBLLiv));
                command.Parameters.Add(CreateDbParameter(command, "@DateLiv", dateLiv));
                command.Parameters.Add(CreateDbParameter(command, "@HeureLiv", heureLiv));
                command.Parameters.Add(CreateDbParameter(command, "@IdCom", idCom));
                command.Parameters.Add(CreateDbParameter(command, "@IdLiv", idLiv));

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
        /// Fonction qui effectue la modification du champ ValideLiv
        /// </summary>
        /// <param name="valideLiv">Indique si la livraison est valide ou pas</param>
        /// <param name="idLiv">Id de la livraison</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateLivraisonValide(int idLiv, bool valideLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Livraison SET ValideLiv = @ValideLiv WHERE (IdLiv = @IdLiv)";

                command.Parameters.Add(CreateDbParameter(command, "@ValideLiv", valideLiv));
                command.Parameters.Add(CreateDbParameter(command, "@IdLiv", idLiv));

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
        /// <param name="idLiv">Id de la livraison</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteLivraison(int idLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Livraison WHERE (IdLiv = @IdLiv)";

                command.Parameters.Add(CreateDbParameter(command, "@IdLiv", idLiv));

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
