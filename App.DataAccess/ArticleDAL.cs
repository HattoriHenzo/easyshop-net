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
    /// Classe de mappage sur la table Article
    /// </summary>
    public class ArticleDAL : AbstractDataAccess
    {        

        public ArticleDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des Articles
        /// </summary>
        /// <param name="libelleArt">Libellé de l'article</param>
        /// <returns>Renvoie un ArticleBOListView</returns>
        public ArticleBOListView GetArticlesFromDB(string libelleArt)
        {
            ArticleBOListView liste = new ArticleBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArt, LibelleArt, Categorie.LibelleCat, Categorie.IdCat, PrixAchatArt, PrixVenteArt, PrixEnGros, PrixEnDemiGros, QteEngros, CoutSortie, SeuilArt, QteStockArt, IdUser, DateEnreg, CodeValidite " +
                    "FROM (Article INNER JOIN Categorie ON Article.IdCat = Categorie.IdCat) WHERE (LibelleArt LIKE @LibelleArt) ORDER BY LibelleArt";

                DbParameter libelleArtParam = command.CreateParameter();
                libelleArtParam.ParameterName = "@LibelleArt";
                libelleArtParam.Value = libelleArt + "%";
                command.Parameters.Add(libelleArtParam);

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ArticleBO a = new ArticleBO();

                            a.IdArt = (int)reader["IdArt"];
                            a.LibelleArt = reader["LibelleArt"].ToString();                            
                            a.PrixAchatArt = (int)reader["PrixAchatArt"];
                            a.PrixVenteArt = (int)reader["PrixVenteArt"];
                            a.PrixEnGros = (int)reader["PrixEnGros"];
                            a.PrixEnDemiGros = (int)reader["PrixEnDemiGros"];
                            a.QteEnGros = (int)reader["QteEnGros"];
                            a.CoutSortie = 0;
                            a.SeuilArt = int.Parse(reader["SeuilArt"].ToString());
                            a.QteStockArt = (int)reader["QteStockArt"];
                            a.Categorie.IdCat = (int)reader["IdCat"];
                            a.Categorie.LibelleCat = reader["LibelleCat"].ToString();
                            a.QteStockArt = (int)reader["QteStockArt"];
                            a.IdUser = (int)reader["IdUser"];
                            a.DateEnreg = (DateTime)reader["DateEnreg"];
                            a.CodeValidite = (int)reader["CodeValidite"];
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
        /// Liste des Articles ayant un prix de vente défini
        /// </summary>
        /// <returns>Renvoie un ArticleBOListView</returns>
        public ArticleBOListView GetArticlesWithPriceFromDB(string libelleArt)
        {
            ArticleBOListView liste = new ArticleBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArt, LibelleArt, Categorie.LibelleCat, Categorie.IdCat, PrixAchatArt, PrixVenteArt, PrixEnDemiGros, PrixEnGros, QteEnGros, CoutSortie, SeuilArt, QteStockArt, IdUser, DateEnreg, CodeValidite " +
                    "FROM (Article INNER JOIN Categorie ON Article.IdCat = Categorie.IdCat) WHERE (LibelleArt LIKE @LibelleArt) ORDER BY LibelleArt";

                command.Parameters.Add(CreateDbParameter(command, "@LibelleArt", libelleArt + "%"));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ArticleBO a = new ArticleBO();

                            a.IdArt = (int)reader["IdArt"];
                            a.LibelleArt = reader["LibelleArt"].ToString();
                            a.PrixAchatArt = (int)reader["PrixAchatArt"];
                            a.PrixVenteArt = (int)reader["PrixVenteArt"];
                            a.PrixEnGros = (int)reader["PrixEnGros"];
                            a.PrixEnDemiGros = (int)reader["PrixEnDemiGros"];
                            a.QteEnGros = (int)reader["QteEnGros"];
                            a.CoutSortie = 0;
                            a.SeuilArt = int.Parse(reader["SeuilArt"].ToString());
                            a.QteStockArt = (int)reader["QteStockArt"];
                            a.Categorie.IdCat = (int)reader["IdCat"];
                            a.Categorie.LibelleCat = reader["LibelleCat"].ToString();
                            a.IdUser = (int)reader["IdUser"];
                            a.DateEnreg = (DateTime)reader["DateEnreg"];
                            a.CodeValidite = (int)reader["CodeValidite"];

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
        /// Fonction qui renvoie un article par rapport à son Id
        /// </summary>
        /// <param name="idArt">Id de l'article</param>
        /// <returns>Renvoie un entier</returns>
        public ArticleBO GetArticleByIdFromDB(int idArt)
        {
            ArticleBO article = new ArticleBO();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArt, LibelleArt, Categorie.LibelleCat, Categorie.IdCat, PrixAchatArt, PrixVenteArt, PrixEnDemigros, PrixEnGros, QteEnGros, CoutSortie, SeuilArt, QteStockArt, IdUser, DateEnreg, CodeValidite " +
                    "FROM   (Article INNER JOIN Categorie ON Article.IdCat = Categorie.IdCat) WHERE (IdArt = @IdArt)  ORDER BY LibelleArt";

                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();                                               

                        article.IdArt = (int)reader["IdArt"];
                        article.LibelleArt = reader["LibelleArt"].ToString();
                        article.PrixAchatArt = (int)reader["PrixAchatArt"];
                        article.PrixVenteArt = (int)reader["PrixVenteArt"];
                        article.PrixEnGros = (int)reader["PrixEnGros"];
                        article.PrixEnDemiGros = (int)reader["PrixEnDemiGros"];
                        article.QteEnGros = (int)reader["QteEnGros"];
                        article.CoutSortie = 0;
                        article.SeuilArt = int.Parse(reader["SeuilArt"].ToString());
                        article.QteStockArt = (int)reader["QteStockArt"];
                        article.Categorie.IdCat = (int)reader["IdCat"];
                        article.Categorie.LibelleCat = reader["LibelleCat"].ToString();
                        article.IdUser = (int)reader["IdUser"];
                        article.DateEnreg = (DateTime)reader["DateEnreg"];
                        article.CodeValidite = (int)reader["CodeValidite"];
                    }

                    reader.Close();
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return article;
        }

        /// <summary>
        /// Fonction qui renvoie la liste des articles en fonction de leur catégorie
        /// </summary>
        /// <param name="idCat">Id de la catégorie à laquelle appartient les articles</param>
        /// <returns>Renvoie un ArticleBOListView</returns>
        public ArticleBOListView GetArticlesByCategorieIdFromDB(int idCat)
        {
            ArticleBOListView liste = new ArticleBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArt, LibelleArt, Categorie.LibelleCat, PrixAchatArt, PrixVenteArt, PrixEnGros, PrixEnDemiGros, QteEnGros, CoutSortie, SeuilArt, QteStockArt, IdUser, DateEnreg, CodeValidite " +
                    "FROM   (Article INNER JOIN Categorie ON Article.IdCat = Categorie.IdCat) WHERE (Article.IdCat = @IdCat) ORDER BY LibelleArt";

                DbParameter idCatParam = command.CreateParameter();
                idCatParam.ParameterName = "@IdCat";
                idCatParam.Value = idCat;
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idCat));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ArticleBO a = new ArticleBO();

                            a.IdArt = (int)reader["IdArt"];
                            a.LibelleArt = reader["LibelleArt"].ToString();                            
                            a.PrixAchatArt = (int)reader["PrixAchatArt"];
                            a.PrixVenteArt = (int)reader["PrixVenteArt"];
                            a.PrixEnGros = (int)reader["PrixEnGros"];
                            a.PrixEnDemiGros = (int)reader["PrixEnDemiGros"];
                            a.QteEnGros = (int)reader["QteEnGros"];
                            a.CoutSortie = 0;
                            a.SeuilArt = int.Parse(reader["SeuilArt"].ToString());
                            a.QteStockArt = (int)reader["QteStockArt"];
                            a.Categorie.LibelleCat = reader["LibelleCat"].ToString();
                            a.IdUser = (int)reader["IdUser"];
                            a.DateEnreg = (DateTime)reader["DateEnreg"];
                            a.CodeValidite = (int)reader["CodeValidite"];

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
        /// Fonction qui effectue l'insertion d'un article dans la base de données
        /// </summary>
        /// <param name="libelleArt">Libellé de l'article</param>
        /// <param name="prixAchatArt">Prix d'achat de l'article</param>
        /// <param name="prixVenteArt">Prix de vente de l'article</param>
        /// <param name="coutSortie">Cout de sortie de l'article</param>
        /// <param name="seuilArt">Seuil de l'article</param>
        /// <param name="qteStockArt">Qté de l'article</param>
        /// <param name="idCat">Id de la catégorie de l'article</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertArticle(string libelleArt, int prixAchatArt, int prixVenteArt, int prixEnGros, int prixEnDemiGros, int qteEnGros, int coutSortie, int seuilArt, int qteStockArt, int idUser, DateTime dateEnreg, int codeValidite, int idCat)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Article (LibelleArt, PrixAchatArt, PrixVenteArt, PrixEnGros, PrixEnDemiGros, QteEnGros, CoutSortie, SeuilArt, QteStockArt, IdUser, DateEnreg, CodeValidite, IdCat) " +
                    "VALUES (@LibelleArt, @PrixAchatArt, @PrixVenteArt, @PrixEnGros, @PrixEnDemiGros, @QteEnGros, @CoutSortie, @SeuilArt, @QteStockArt, @IdUser, @DateEnreg, @CodeValidite, @IdCat)";

                command.Parameters.Add(CreateDbParameter(command, "@LibelleArt", libelleArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixAchatArt", prixAchatArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixVenteArt", prixVenteArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixEnGros", prixEnGros));
                command.Parameters.Add(CreateDbParameter(command, "@PrixEnDemiGros", prixEnDemiGros));
                command.Parameters.Add(CreateDbParameter(command, "@QteEnGros", qteEnGros));
                command.Parameters.Add(CreateDbParameter(command, "@CoutSortie", coutSortie));
                command.Parameters.Add(CreateDbParameter(command, "@SeuilArt", seuilArt));
                command.Parameters.Add(CreateDbParameter(command, "@QteStockArt", qteStockArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdUser", idUser));
                command.Parameters.Add(CreateDbParameter(command, "@DateEnreg", dateEnreg));
                command.Parameters.Add(CreateDbParameter(command, "@CodeValidite", codeValidite));
                command.Parameters.Add(CreateDbParameter(command, "@IdCat", idCat));

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
        /// Fonction qui effectue la modification dans la base de données
        /// </summary>
        /// <param name="idArt">Id de l'article</param>
        /// <param name="libelleArt">Libellé de l'article</param>
        /// <param name="prixAchatArt">Prix d'achat de l'article</param>
        /// <param name="prixVenteArt">Prix de vente de l'article</param>
        /// <param name="coutSortie">Cout de sortie de l'article</param>
        /// <param name="seuilArt">Seuil de l'article</param>
        /// <param name="qteStockArt">Qté de l'article</param>
        /// <param name="idCat">Id de la catégorie de l'article</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateArticle(int idArt, string libelleArt, int prixAchatArt, int prixVenteArt, int prixEnGros, int prixEnDemiGros, int qteEnGros,  int coutSortie, int seuilArt, int qteStockArt, int idUser, DateTime dateEnreg, int codeValidite, int idCat)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Article " +
                    "SET LibelleArt = @LibelleArt, PrixAchatArt = @PrixAchatArt, PrixVenteArt = @PrixVenteArt, PrixEnGros = @PrixEnGros, PrixEnDemiGros = @PrixEnDemiGros, QteEnGros = @QteEnGros, CoutSortie = @CoutSortie, SeuilArt = @SeuilArt, QteStockArt = @QteStockArt, IdUser = @IdUser, DateEnreg= @DateEnreg, CodeValidite = @CodeValidite , IdCat = @IdCat " +
                    "WHERE (IdArt = @IdArt)";

                command.Parameters.Add(CreateDbParameter(command, "@LibelleArt", libelleArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixAchatArt", prixAchatArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixVenteArt", prixVenteArt));
                command.Parameters.Add(CreateDbParameter(command, "@PrixEnGros", prixEnGros));
                command.Parameters.Add(CreateDbParameter(command, "@PrixEnDemiGros", prixEnDemiGros));
                command.Parameters.Add(CreateDbParameter(command, "@QteEnGros", qteEnGros));
                command.Parameters.Add(CreateDbParameter(command, "@CoutSortie", coutSortie));
                command.Parameters.Add(CreateDbParameter(command, "@SeuilArt", seuilArt));
                command.Parameters.Add(CreateDbParameter(command, "@QteStockArt", qteStockArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdUser", idUser));
                command.Parameters.Add(CreateDbParameter(command, "@DateEnreg", dateEnreg));
                command.Parameters.Add(CreateDbParameter(command, "@CodeValidite", codeValidite));
                command.Parameters.Add(CreateDbParameter(command, "@IdCat", idCat));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));

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
        /// Fonction qui effectue la modiifcation de la quantité
        /// </summary>
        /// <param name="qteStockArt">Quantité en stock</param>
        /// <param name="idArt">Id de l'article dont on modifie la quantité</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateQuantiteArticle(int qteStockArt, int idArt)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Article " +
                    "SET QteStockArt = QteStockArt + @QteStockArt " +
                    "WHERE (IdArt = @IdArt)";

                command.Parameters.Add(CreateDbParameter(command, "@QteStockArt", qteStockArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la mise à jour de la quantité : " + dbEx.Message);
                }
            }

            //Déconnection à la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui effectue la suppression d'un article
        /// </summary>
        /// <param name="idArt"></param>
        /// <returns></returns>
        public int DeleteArticle(int idArt)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Article WHERE IdArt = @IdArt";

                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la mise à jour de la quantité : " + dbEx.Message);
                }
            }

            //Déconnection à la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

    }    
}