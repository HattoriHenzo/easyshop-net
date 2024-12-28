using System.Data;
using System.Data.OleDb;

using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    /// <summary>
    /// Classe de mappage sur la table ArticleLivre
    /// </summary>
    public class ArticleLivreDAL : AbstractDataAccess
    {

        public ArticleLivreDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste de tous les articles livrés
        /// </summary>
        /// <returns>Renvoie un ArticleLivreBOListView</returns>
        public ArticleLivreBOListView GetArticleLivresByLivraisonIdFromDB(int idLiv)
        {
            ArticleLivreBOListView liste = new ArticleLivreBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdArtLiv, Article.LibelleArt, QteArtLiv, ArticleLivre.IdArt, IdLiv, PrixLiv  " +
                    "FROM ArticleLivre, Article WHERE Article.IdArt = ArticleLivre.IdArt AND IdLiv = @IdLiv";

                command.Parameters.Add(CreateDbParameter(command, "@IdLiv", idLiv));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ArticleLivreBO a = new ArticleLivreBO();

                            a.IdArtLiv = (int)reader["IdArtLiv"];
                            a.LibelleArt = reader["LibelleArt"].ToString();
                            a.QteArtLiv = (int)reader["QteArtLiv"];
                            a.PrixLiv = (int)reader["PrixLiv"];
                            a.IdArt = (int)reader["IdArt"];
                            a.IdLiv = (int)reader["IdLiv"];

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
        /// Fonction qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="idArtLiv">Id de ArticleLivre inséré</param>
        /// <param name="qteArtLiv">Qté de l'article</param>
        /// <param name="prixLiv">Prix de la livraison</param>
        /// <param name="idArt">Id de l'article</param>
        /// <param name="idLiv">Id de la livraison</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertArticleLivre(int qteArtLiv, int prixLiv, int idArt, int idLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO ArticleLivre (QteArtLiv, PrixLiv, IdArt, IdLiv) " +
                    "VALUES (@QteArtLiv, @PrixLiv, @IdArt, @IdLiv)";

                command.Parameters.Add(CreateDbParameter(command, "@QteArtLiv", qteArtLiv));
                command.Parameters.Add(CreateDbParameter(command, "@PrixLiv", prixLiv));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdLiv", idLiv));

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
        /// <param name="idArtLiv">Id de ArticleLivre</param>
        /// <param name="qteArtLiv">Qté de l'article livré</param>
        /// <param name="prixLiv">Prix de l'article livré</param>
        /// <param name="idArt">Id de l'article livré</param>
        /// <param name="idLiv">Id de la livraison</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateArticleLivre(int idArtLiv, int qteArtLiv, int prixLiv, int idArt, int idLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ArticleLivre " +
                    "SET QteArtLiv = @QteArtLiv, PrixLiv = @PrixLiv, IdArt = @IdArt, IdLiv = @IdLiv " +
                    "WHERE IdArtLiv = @IdArtLiv";

                command.Parameters.Add(CreateDbParameter(command, "@QteArtLiv", qteArtLiv));
                command.Parameters.Add(CreateDbParameter(command, "@PrixLiv", prixLiv));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@IdLiv", idLiv));
                command.Parameters.Add(CreateDbParameter(command, "@IdArtLiv", idArtLiv));

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
        /// Fonction qui modifie la quantité livrée
        /// </summary>
        /// <param name="a">Article livré</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateQuantiteArticleLivre(int qteArtLiv, int idArtLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ArticleLivre " +
                    "SET QteArtLiv = QteArtLiv + @QteArtLiv " +
                    "WHERE IdArtLiv = @IdArtLiv";

                command.Parameters.Add(CreateDbParameter(command, "@IdArtLiv", idArtLiv));
                command.Parameters.Add(CreateDbParameter(command, "@QteArtLiv", qteArtLiv));

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
        /// <param name="idArtLiv"></param>
        /// <returns></returns>
        public int DeleteArticleLivre(int idArtLiv)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM ArticleLivre WHERE IdArtLiv = @IdArtLiv";

                command.Parameters.Add(CreateDbParameter(command, "@IdArtLiv", idArtLiv));

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
