using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    public class StockDateDAL : AbstractDataAccess
    {

        public StockDateDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des Stock a date
        /// </summary>
        /// <param name="dateDu">Date debut</param>
        /// <param name="dateAu">Date fin</param>
        /// <param name="article">Article</param>
        /// <returns>Renvoie une liste de StockDateBOListView</returns>
        public StockDateBOListView GetStockDateByPeriodFromDB(DateTime dateDu, DateTime dateAu, string libelleArt)
        {
            StockDateBOListView liste = new StockDateBOListView();

            //Connexion a la base de donnees
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place de parametres
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT IdArt, DateStock, LibelleArt, Categorie.LibelleCat, Categorie.IdCat, PrixAchatArt, PrixVenteArt, PrixEnGros, PrixEnDemiGros, QteEngros, CoutSortie, SeuilArt, QteStockArt " +
                    "FROM (StockDate INNER JOIN Categorie ON StockDate.IdCat = Categorie.IdCat) " +
                    "WHERE (LibelleArt LIKE @LibelleArt) AND (DateStock BETWEEN @DateDu AND @DateAu) ORDER BY LibelleArt";

                command.Parameters.Add(CreateDbParameter(command, "@LibelleArt", libelleArt));
                command.Parameters.Add(CreateDbParameter(command, "@DateDu", dateDu));
                command.Parameters.Add(CreateDbParameter(command, "@DateAu", dateAu));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            StockDateBO sd = new StockDateBO();

                            sd.IdArt = (int)reader["IdArt"];
                            sd.DateStock = (DateTime)reader["DateStock"];
                            sd.LibelleArt = reader["LibelleArt"].ToString();
                            sd.PrixAchatArt = (int)reader["PrixAchatArt"];
                            sd.PrixVenteArt = (int)reader["PrixVenteArt"];
                            sd.PrixEnGros = (int)reader["PrixEnGros"];
                            sd.PrixEnDemiGros = (int)reader["PrixEnDemiGros"];
                            sd.QteEnGros = (int)reader["QteEnGros"];
                            sd.CoutSortie = 0;
                            sd.SeuilArt = int.Parse(reader["SeuilArt"].ToString());
                            sd.QteStockArt = (int)reader["QteStockArt"];
                            sd.Categorie.IdCat = (int)reader["IdCat"];
                            sd.Categorie.LibelleCat = reader["LibelleCat"].ToString();

                            liste.Add(sd);
                        }
                    }
                    reader.Close();
                }
            }
            //Deconnexion de la base de donnees
            AppConnection.Instance.Disconnect();
            return liste;
        }

        /// <summary>
        /// Fonction qui insert les stocks a une date donnee
        /// </summary>        
        /// <returns>Renvoie un entier</returns>
        public int InsertStockDate()
        {
            int result = 0;

            //Connection a la base de donnees
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO StockDate SELECT Article.* FROM Article";

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch(DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de l'insertion : " + dbEx.Message);
                }
            }

            //Deconnection de la base de donnees
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui supprime le stock a une date donnee
        /// </summary>
        /// <param name="dateStock">Date parametre</param>
        /// <returns>Renvoie une entier</returns>
        public int DeleteStockDate(DateTime dateStock)
        {
            int result = 0;

            //Connection a la base de donnees
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM StockDate WHERE DateStock = @DateStock";

                command.Parameters.Add(CreateDbParameter(command, "@DateStock", dateStock));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la suppression : " + dbEx.Message);
                }
            }

            //Deconnection de la base de donnees
            AppConnection.Instance.Disconnect();

            return result;
        }
    }
}
