using System;
using System.Data;

using App.Tools;
using System.Data.Common;
using App.BusinessObject;

namespace App.DataAccess
{
    /// <summary>
    /// Classe de mappage sur la table ArchiveVente
    /// </summary>
    public class ArchiveVenteDAL : AbstractDataAccess
    {

        public ArchiveVenteDAL()
        {

        }

        /// <summary>
        /// Fonction qui renvoie la liste des ventes en fonction d'une période donnée
        /// </summary>
        /// <param name="dateDu">Date début</param>
        /// <param name="dateAu">Date fin</param>
        /// <returns>Renvoie un ArchiveVenteBOListView</returns>
        public ArchiveVenteBOListView GetVentesByPeriodFromDB(DateTime dateDu, DateTime dateAu)
        {
            ArchiveVenteBOListView liste = new ArchiveVenteBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArch, DateVente, HeureVente, ArchiveVente.IdArt, LibelleArt, LibelleCat, PrixVente, PrixEnGros, QteEnGros, QteVente, IdUser, ArchiveVente.TypeVente, ArchiveVente.RemisePourcentage, ArchiveVente.RemiseMontant, ArchiveVente.PrixAchat " + 
                            "FROM Article, Categorie, ArchiveVente WHERE Article.IdArt = ArchiveVente.IdArt AND Article.IdCat = Categorie.IdCat AND ArchiveVente.DateVente BETWEEN @DateDu AND @DateAu";

                command.Parameters.Add(CreateDbParameter(command, "@DateDu", dateDu));
                command.Parameters.Add(CreateDbParameter(command, "@DateAu", dateAu));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            StatsVenteBO a = new StatsVenteBO();

                            a.IdArch = (int)reader["IdArch"];
                            a.DateVente = (DateTime)reader["DateVente"];
                            a.HeureVente = DateTime.Parse(reader["HeureVente"].ToString()).ToShortTimeString(); ;
                            a.IdArt = (int)reader["IdArt"];
                            a.LibelleArt = reader["LibelleArt"].ToString();
                            a.LibelleCat = reader["LibelleCat"].ToString();
                            a.PrixAchat = (int)reader["PrixAchat"];
                            a.PrixVente = (int)reader["PrixVente"];
                            a.PrixEnGros = (int)reader["PrixEnGros"];
                            a.QteEnGros = (int)reader["QteEnGros"];
                            a.TypeVente = reader["TypeVente"].ToString();
                            a.RemisePourcentage = (int)reader["RemisePourcentage"];
                            a.RemiseMontant = (int)reader["RemiseMontant"];
                            a.QteVente = (int)reader["QteVente"];
                            a.TotalVente = (a.PrixVente * a.QteVente) - ((((a.PrixVente * a.QteVente) * a.RemisePourcentage) / 100) + a.RemiseMontant);
                            a.IdUser = int.Parse(reader["IdUser"].ToString());

                            liste.Add(a);
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
        /// Fonction qui renvoie la liste des ventes en fonction d'une période donnée
        /// </summary>
        /// <param name="dateDu">Date début</param>
        /// <param name="dateAu">Date fin</param>
        /// <returns>Renvoie un ArchiveVenteBOListView</returns>
        public ArchiveVenteBOListView GetVentesByIdFromDB(string numeroVente)
        {
            ArchiveVenteBOListView liste = new ArchiveVenteBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArch, DateVente, HeureVente, ArchiveVente.IdArt, LibelleArt, LibelleCat, PrixVente, PrixEnGros, QteEnGros, QteVente, IdUser, ArchiveVente.TypeVente, ArchiveVente.RemisePourcentage, ArchiveVente.RemiseMontant, ArchiveVente.PrixAchat " +
                    "FROM Article, Categorie, ArchiveVente WHERE Article.IdArt = ArchiveVente.IdArt AND Article.IdCat = Categorie.IdCat AND NumeroVente = @NumeroVente";

                DbParameter numeroVenteParam = command.CreateParameter();
                numeroVenteParam.ParameterName = "@NumeroVente";
                numeroVenteParam.Value = numeroVente;

                command.Parameters.Add(CreateDbParameter(command, "@NumeroVente", numeroVente));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            StatsVenteBO a = new StatsVenteBO();

                            a.IdArch = (int)reader["IdArch"];
                            a.DateVente = (DateTime)reader["DateVente"];
                            a.HeureVente = DateTime.Parse(reader["HeureVente"].ToString()).ToShortTimeString(); ;
                            a.IdArt = (int)reader["IdArt"];
                            a.LibelleArt = reader["LibelleArt"].ToString();
                            a.LibelleCat = reader["LibelleCat"].ToString();
                            a.PrixAchat = (int)reader["PrixAchat"];
                            a.PrixVente = (int)reader["PrixVente"];
                            a.PrixEnGros = (int)reader["PrixEnGros"];
                            a.QteEnGros = (int)reader["QteEnGros"];
                            a.TypeVente = reader["TypeVente"].ToString();
                            a.RemisePourcentage = (int)reader["RemisePourcentage"];
                            a.RemiseMontant = (int)reader["RemiseMontant"];
                            a.QteVente = (int)reader["QteVente"];
                            a.TotalVente = (a.PrixVente * a.QteVente) - ((((a.PrixVente * a.QteVente) * a.RemisePourcentage)/100) + a.RemiseMontant);
                            a.IdUser = int.Parse(reader["IdUser"].ToString());

                            liste.Add(a);
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
        /// Fonction qui efefctue l'insertion dans la base de données
        /// </summary>
        /// <param name="dateVente">Date de la vente</param>
        /// <param name="heureVente">Heure de la vente</param>
        /// <param name="idArt">Id de l'article</param>
        /// <param name="prixVente">Prix de la vente</param>
        /// <param name="qteVente">Quantité vendue</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertArchiveVente(DateTime dateVente, string heureVente, int idArt, int prixAchat, int prixVente, int qteVente, string numeroVente, string typeVente, int remisePourcentage, int remiseMontant, int idUser)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO ArchiveVente (DateVente, HeureVente, IdArt, PrixAchat, PrixVente, QteVente, NumeroVente, TypeVente, RemisePourcentage, RemiseMontant, IdUser) " +
                    "VALUES (@DateVente, @HeureVente, @IdArt, @PrixAchat, @PrixVente, @QteVente, @NumeroVente, @TypeVente, @RemisePourcentage, @RemiseMontant, @IdUser)";

                command.Parameters.Add(CreateDbParameter(command, "@DateVente", dateVente));
                command.Parameters.Add(CreateDbParameter(command, "@HeureVente", heureVente));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixAchat", prixAchat));
                command.Parameters.Add(CreateDbParameter(command, "@PrixVente", prixVente));
                command.Parameters.Add(CreateDbParameter(command, "@QteVente", qteVente));
                command.Parameters.Add(CreateDbParameter(command, "@NumeroVente", numeroVente));
                command.Parameters.Add(CreateDbParameter(command, "@TypeVente", typeVente));
                command.Parameters.Add(CreateDbParameter(command, "@RemisePourcentage", remisePourcentage));
                command.Parameters.Add(CreateDbParameter(command, "@RemiseMontant", remiseMontant));
                command.Parameters.Add(CreateDbParameter(command, "@IdUser", idUser));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de l'insertion dans la base de données : " + dbEx.Message);
                }
            }

            //Déconnection à la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui effectue la modification
        /// </summary>
        /// <param name="idArch">Id de la ligne archivée</param>
        /// <param name="dateVente">Date de la vente</param>
        /// <param name="heureVente">Heure de la vente</param>
        /// <param name="idArt">Id de l'article</param>
        /// <param name="prixVente">Prix de la vente</param>
        /// <param name="qteVente">Quantité vendue</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateArchiveVente(int idArch, DateTime dateVente, string heureVente, int idArt, int prixAchat, int prixVente, int qteVente, string typeVente, int remisePourcentage, int remiseMontant)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ArchiveVente " +
                    "SET DateVente = @DateVente, HeureVente = @HeureVente, IdArt = @IdArt, PrixAchat = @PrixAchat, PrixVente = @PrixVente, QteVente = @QteVente, TypeVente = @TypeVente, RemisePourcentage = @RemisePourcentage, RemiseMontant = @RemiseMontant " +
                    "WHERE IdArch = @IdArch";

                command.Parameters.Add(CreateDbParameter(command, "@DateVente", dateVente));
                command.Parameters.Add(CreateDbParameter(command, "@HeureVente", heureVente));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixAchat", prixAchat));
                command.Parameters.Add(CreateDbParameter(command, "@PrixVente", prixVente));
                command.Parameters.Add(CreateDbParameter(command, "@QteVente", qteVente));
                command.Parameters.Add(CreateDbParameter(command, "@TypeVente", typeVente));
                command.Parameters.Add(CreateDbParameter(command, "@RemisePourcentage", remisePourcentage));
                command.Parameters.Add(CreateDbParameter(command, "@RemiseMontant", remiseMontant));
                command.Parameters.Add(CreateDbParameter(command, "@IdArch", idArch));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la modification dans la base de données : " + dbEx.Message);
                }
            }

            //Déconnection à la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui effectue la suppression dans la base de données
        /// </summary>
        /// <param name="idArch">Id de l'archive</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteArchiveVente(int idArch)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM ArchiveVente WHERE IdArch = @IdArch";

                command.Parameters.Add(CreateDbParameter(command, "@IdArch", idArch));

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
