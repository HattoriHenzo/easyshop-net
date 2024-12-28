using System;
using System.Data;

using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    /// <summary>
    /// Classe de mappage sur la table Entree/Sortie
    /// </summary>
    public class EntreeSortieDAL : AbstractDataAccess
    {

        public EntreeSortieDAL()
        {

        }


        /// <summary>
        /// Fonction qui renvoie la liste des Entrées/Sorties
        /// </summary>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        public EntreeSortieBOListView GetEntreeSortiesFromDB()
        {
            EntreeSortieBOListView liste = new EntreeSortieBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT IdES, QteES, DateES, HeureES, TypeES, MotifS, ObservationES, IdUser, IdArt, DatePeremption, DelaiAlerte FROM EntreeSortie";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            EntreeSortieBO es = new EntreeSortieBO
                            {
                                IdES = (int)reader["IdES"],
                                QteES = (int)reader["QteES"],
                                DateES = (DateTime)reader["DateES"],
                                HeureES = DateTime.Parse(reader["HeureES"].ToString()).ToShortTimeString(),
                                TypeES = reader["TypeES"].ToString(),
                                MotifS = reader["MotifS"].ToString(),
                                ObservationES = reader["ObservationES"].ToString(),
                                IdUser = (int)reader["IdUser"],
                                IdArt = (int)reader["IdArt"],
                                DatePeremption = (DateTime)reader["DatePeremption"],
                                DelaiAlerte = (int)reader["DelaiAlerte"]
                            };

                            liste.Add(es);
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
        /// Fonction qui renvoie la liste des Entrées/Sorties
        /// </summary>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        public EntreeSortieBOListView GetEntreeSortiesByArticleIdFromDB(int idArt, string typeES, string motifS)
        {
            EntreeSortieBOListView liste = new EntreeSortieBOListView();

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;

                if (typeES == "entree")
                {
                    command.CommandText = "SELECT IdES, QteES, DateES, HeureES, TypeES, MotifS, ObservationES, IdUser, IdArt, DatePeremption, DelaiAlerte  " +
                        "FROM EntreeSortie WHERE IdArt = @IdArt AND TypeES = @TypeES AND MotifS = @MotifS";
                }
                else
                {
                    command.CommandText = "SELECT IdES, QteES, DateES, HeureES, TypeES, MotifS, ObservationES, IdUser, IdArt, DatePeremption, DelaiAlerte  " +
                        "FROM EntreeSortie WHERE IdArt = @IdArt AND TypeES = @TypeES AND MotifS <> @MotifS";
                }

                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@TypeES", typeES));
                command.Parameters.Add(CreateDbParameter(command, "@MotifS", motifS));

                using (DbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            EntreeSortieBO es = new EntreeSortieBO
                            {
                                IdES = (int)reader["IdES"],
                                QteES = (int)reader["QteES"],
                                DateES = (DateTime)reader["DateES"],
                                HeureES = DateTime.Parse(reader["HeureES"].ToString()).ToShortTimeString(),
                                TypeES = reader["TypeES"].ToString(),
                                MotifS = reader["MotifS"].ToString(),
                                ObservationES = reader["ObservationES"].ToString(),
                                IdUser = (int)reader["IdUser"],
                                IdArt = (int)reader["IdArt"],
                                DatePeremption = (DateTime)reader["DatePeremption"],
                                DelaiAlerte = (int)reader["DelaiAlerte"]
                            };

                            liste.Add(es);
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
        /// Fonction qui renvoie le total vendu un jour donné
        /// </summary>
        /// <param name="date">Date du jour</param>
        /// <returns>Renvoie un entier</returns>
        public int GetTotalVenteByDayFromDB(DateTime date)
        {
            int total = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT SUM(PrixVenteArt * QteES) as TotalVente FROM EntreeSortie, Article " +
                    "WHERE EntreeSortie.IdArt = Article.IdArt AND MotifS = @MotifS AND DateES = @Date";

                command.Parameters.Add(CreateDbParameter(command, "@IdArt", Motifs.VENTE.ToString()));
                command.Parameters.Add(CreateDbParameter(command, "@DateES", date));

                if (command.ExecuteScalar().ToString() != "")
                {
                    total = int.Parse(command.ExecuteScalar().ToString());
                }
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return total;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion dans la base de données
        /// </summary>
        /// <param name="qteES">Quantité de l'article</param>
        /// <param name="dateES">Date à laquelle se fait l'Entrée/Sortie</param>
        /// <param name="heureES">Heure à laquelle se fait l'Entrée/Sortie</param>
        /// <param name="typeES">Type de l'Entrée/Sortie</param>
        /// <param name="motifS">Motif de la Sortie</param>
        /// <param name="observationES">Observation de l'Entrée/Sortie</param>
        /// <param name="idUser">Id de l'utilisateur</param>
        /// <param name="idArt">Id de l'article</param>        
        /// <returns>Renvoie un entier</returns>
        public int InsertEntreeSortie(int qteES, DateTime dateES, DateTime heureES, string typeES, string motifS, string observationES, int idUser, int idArt, DateTime datePeremption, int delaiAlerte)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO EntreeSortie (QteES, DateES, HeureES, TypeES, MotifS, ObservationES, IdUser, IdArt, DatePeremption, DelaiAlerte) " +
                    "VALUES (@QteES, @DateES, @HeureES, @TypeES, @MotifS, @ObservationES, @IdUser, @IdArt, @DatePeremption, @DelaiAlerte)";

                command.Parameters.Add(CreateDbParameter(command, "@QteES", qteES));
                command.Parameters.Add(CreateDbParameter(command, "@DateES", dateES));
                command.Parameters.Add(CreateDbParameter(command, "@HeureES", heureES));
                command.Parameters.Add(CreateDbParameter(command, "@TypeES", typeES));
                command.Parameters.Add(CreateDbParameter(command, "@MotifS", motifS));
                command.Parameters.Add(CreateDbParameter(command, "@ObservationES", observationES));
                command.Parameters.Add(CreateDbParameter(command, "@IdUser", idUser));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@DatePeremption", datePeremption));
                command.Parameters.Add(CreateDbParameter(command, "@DelaiAlerte", delaiAlerte));


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
        /// <param name="idES">Id de l'Entrée/Sortie à modifier</param>
        /// <param name="qteES">Quantité de l'article</param>
        /// <param name="dateES">Date à laquelle se fait l'Entrée/Sortie</param>
        /// <param name="heureES">Heure à laquelle se fait l'Entrée/Sortie</param>
        /// <param name="typeES">Type de l'Entrée/Sortie</param>
        /// <param name="motifS">Motif de la Sortie</param>
        /// <param name="observationES">Observation de l'Entrée/Sortie</param>
        /// <param name="idUser">Id de l'utilisateur</param>
        /// <param name="idArt">Id de l'article</param>        
        /// <returns>Renvoie un entier</returns>
        public int UpdateEntreeSortie(int idES, int qteES, DateTime dateES, DateTime heureES, string typeES, string motifS, string observationES, int idUser, int idArt, DateTime datePeremption, int delaiAlerte)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE EntreeSortie " +
                    "SET QteES = @QteES, DateES = @DateES, HeureES = @HeureES, TypeES = @TypeES, MotifS = @MotifS, ObservationES = @ObservationES, IdUser = @IdUser, IdArt = @IdArt, DatePeremption = @DatePeremption, DelaiAlerte = @DelaiAlerte " +
                    "WHERE (IdES = @IdES)";

                command.Parameters.Add(CreateDbParameter(command, "@QteES", qteES));
                command.Parameters.Add(CreateDbParameter(command, "@DateES", dateES));
                command.Parameters.Add(CreateDbParameter(command, "@HeureES", heureES));
                command.Parameters.Add(CreateDbParameter(command, "@TypeES", typeES));
                command.Parameters.Add(CreateDbParameter(command, "@MotifS", motifS));
                command.Parameters.Add(CreateDbParameter(command, "@ObservationES", observationES));
                command.Parameters.Add(CreateDbParameter(command, "@IdUser", idUser));
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@DatePeremption", datePeremption));
                command.Parameters.Add(CreateDbParameter(command, "@DelaiAlerte", delaiAlerte));
                command.Parameters.Add(CreateDbParameter(command, "@IdES", idES));

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
        /// <param name="idES">Id de l'Entrée/Sortie</param>
        /// <returns>Renvoie un entier</returns>
        public int DeleteEntreeSortie(int idES)
        {
            int result = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM EntreeSortie WHERE IdES = @IdES";

                command.Parameters.Add(CreateDbParameter(command, "@IdES", idES));

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






        /// <summary>
        /// Fonction qui renvoie la liste des Entrées/Sorties
        /// </summary>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        public DateTime GetDateAlerteByIdESFromDB(int idES)
        {
            DateTime dateAlerte;
            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT DatePeremption FROM EntreeSortie WHERE IdES = @IdES";
                command.Parameters.Add(CreateDbParameter(command, "@IdES", idES));
                dateAlerte = (DateTime)command.ExecuteScalar();
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return dateAlerte;
        }
        /// <summary>
        /// Fonction qui renvoie la liste des Entrées/Sorties
        /// </summary>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        public Boolean EstPerime(int idES, int idArt, DateTime dateES, DateTime dateEnCours)
        {
            Boolean alerte = false;
            DateTime dateAlerte;
            dateAlerte = GetDateAlerteByIdESFromDB(idES);

            if (dateEnCours >= dateAlerte)
            {
                int nombreUtilise = GetNombreUtiliseFromDB(idArt, dateES, dateEnCours);
                if (nombreUtilise > 0)
                {
                    alerte = true;
                }
            }

            return alerte;
        }
        /// <summary>
        /// Fonction qui renvoie la liste des Entrées/Sorties
        /// </summary>
        /// <returns>Renvoie un EntreeSortieBOListView</returns>
        public int GetNombreUtiliseFromDB(int idArt, DateTime dateES, DateTime DateEnCours)
        {

            int nombre_article_entree;
            int nombre_article_sortie;
            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT count(qteES) FROM EntreeSortie WHERE IdArt = @IdArt and DateES <= @DateES and TypeES = @TypeES";
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@DateES", dateES));
                command.Parameters.Add(CreateDbParameter(command, "@TypeES", Motifs.ENTREE.ToString()));

                nombre_article_entree = (int)command.ExecuteScalar();


                command.CommandText = "SELECT count(qteES) FROM EntreeSortie WHERE IdArt = @IdArt and DateES <= @DateES and TypeEs = @TypeEs";
                command.Parameters.Add(CreateDbParameter(command, "@IdArt", idArt));
                command.Parameters.Add(CreateDbParameter(command, "@DateES", dateES));
                command.Parameters.Add(CreateDbParameter(command, "@TypeEs", Motifs.SORTIE.ToString()));

                nombre_article_sortie = (int)command.ExecuteScalar();
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return nombre_article_entree - nombre_article_sortie;
        }




    }
}
