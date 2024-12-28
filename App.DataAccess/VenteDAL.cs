using System;

using App.BusinessObject;
using App.Tools;
using System.Data.Common;

namespace App.DataAccess
{
    public class VenteDAL : AbstractDataAccess
    {

        public VenteDAL()
        {
        }

        /// <summary>
        /// Fonction qui renvoie la liste des ventes suivant une periode
        /// </summary>
        /// <param name="dateDu">Date debut</param>
        /// <param name="dateAu">Date fin</param>
        /// <returns>Renvoi la liste des ventes</returns>
        public VenteBOListView GetVentesByPeriodFromDB(DateTime dateDu, DateTime dateAu)
        {
            VenteBOListView liste = new VenteBOListView();

            //Connection a la base de donnee
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM Vente WHERE DateVente BETWEEN @DateDu AND @DateAu";

                command.Parameters.Add(CreateDbParameter(command, "@DateDu", dateDu));
                command.Parameters.Add(CreateDbParameter(command, "@DateAu", dateAu));

                using (DbDataReader reader = command.ExecuteReader())
                {                    
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            VenteBO v = new VenteBO
                            {
                                Id = (int)reader["Id"],
                                NumeroVente = reader["NumeroVente"].ToString(),
                                DateVente = (DateTime)reader["DateVente"]
                            };

                            liste.Add(v);
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
        /// Fonction qui insere une vente
        /// </summary>
        /// <param name="numeroVente"></param>
        /// <param name="dateVente"></param>
        /// <returns></returns>
        public int InsertVente(string numeroVente, DateTime dateVente)
        {
            int result = 0;

            //Connexion a la base de donnees
            AppConnection.Instance.Connect();

            using(DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des parametres
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO Vente(NumeroVente, DateVente) " +
                    "VALUES(@NumeroVente, @DateVente)";

                command.Parameters.Add(CreateDbParameter(command, "@NumeroVente", numeroVente));
                command.Parameters.Add(CreateDbParameter(command, "@DateVente", dateVente));

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

    }
}
