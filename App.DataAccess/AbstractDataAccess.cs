using System;
using System.Data.Common;

namespace App.DataAccess
{
    public abstract class AbstractDataAccess
    {
        /// <summary>
        /// Fonction qui renvoie le dernier Id inséré
        /// </summary>
        /// <param name="tableName">Nom de la table</param>
        /// <param name="idName">Nom du champ Id</param>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxIdFromDB(string tableName, string idName)
        {
            int maxId = 0;

            //Connection à la base de données
            AppConnection.Instance.Connect();

            using (DbCommand command = AppConnection.Instance.GetConnection().CreateCommand())
            {
                //Mise en place des paramètres
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT MAX(" + idName + ") FROM " + tableName;

                maxId = (int)command.ExecuteScalar();
            }

            //Déconnection de la base de données
            AppConnection.Instance.Disconnect();

            return maxId;
        }

        public static DbParameter CreateDbParameter(DbCommand command, String parameterName, Object value)
        {
            DbParameter dbParameter = command.CreateParameter();
            dbParameter.ParameterName = parameterName;
            dbParameter.Value = value;
            return dbParameter;
        }

    }
}
