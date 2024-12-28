using System.Data;
using System.Data.Common;
using System.Data.OleDb;

using App.BusinessObject;
using App.Tools;

namespace App.DataAccess
{
    /// <summary>
    /// Classe permettant de manipuler les données relatives à la table Catégorie
    /// </summary>
    public class CategorieDAL : AbstractDataAccess
    {
        

        public CategorieDAL()
        {

        }

        /// <summary>
        /// Fonction qui renvoie la liste de toutes les catégories
        /// </summary>
        /// <returns>Renvoie un CategorieBOListView</returns>
        public CategorieBOListView GetCategoriesFromDB()
        {
            CategorieBOListView liste = new CategorieBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * From Categorie Order By LibelleCat";

                using(DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CategorieBO c = new CategorieBO();

                            c.IdCat = (int)reader["IdCat"];
                            c.LibelleCat = reader["LibelleCat"].ToString();
                            c.ValideCat = (bool)reader["ValideCat"];

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
        /// Fonction qui effectue l'insertion dans la base de donnée
        /// </summary>
        /// <param name="libelleCat">Libellé de la catégorie</param>
        /// <param name="valideCat">Indique si la catégorie est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int InsertCategorie(string libelleCat, bool valideCat)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "Insert Into Categorie (LibelleCat, ValideCat) Values(@LibelleCat, @ValideCat)";

                command.Parameters.Add(CreateDbParameter(command, "@LibelleCat", libelleCat));
                command.Parameters.Add(CreateDbParameter(command, "@ValideCat", valideCat));

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
        /// <param name="idCat">Id de la catégorie</param>
        /// <param name="libelleCat">Libellé de la catégorie</param>
        /// <param name="valideCat">Indique si la catégorie est valide ou pas</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateCategorie(int idCat, string libelleCat, bool valideCat)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Categorie " +
                    "SET LibelleCat = @LibelleCat, ValideCat = @ValideCat " +
                    "WHERE (IdCat = @IdCat)";

                command.Parameters.Add(CreateDbParameter(command, "@LibelleCat", libelleCat));
                command.Parameters.Add(CreateDbParameter(command, "@ValideCat", valideCat));
                command.Parameters.Add(CreateDbParameter(command, "@IdCat", idCat));

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la mise à jour : " + dbEx.Message);
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }

        /// <summary>
        /// Fonction qui actualise le statut d'une catégorie (valide ou non valide)
        /// </summary>
        /// <param name="valideCat">Indique si l'article est valide ou pas</param>
        /// <param name="idCat">Id de la catégorie</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateCategorieValide(bool valideCat, int idCat)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Categorie " +
                    "SET ValideCat = @ValideCat WHERE (IdCat = @IdCat)";

                command.Parameters.Add(CreateDbParameter(command, "@ValideCat", valideCat));
                command.Parameters.Add(CreateDbParameter(command, "@IdCat", idCat));


                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (DbException dbEx)
                {
                    AppMessage.Error("Une erreur s'est produite lors de la mise à jour : " + dbEx.Message);
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return result;
        }        
    }
}
