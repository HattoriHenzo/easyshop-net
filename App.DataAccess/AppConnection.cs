using System;

using System.Data;
using System.Data.OleDb;

using App.Tools;
using System.Data.Common;
using System.Configuration;
using DataAccess.Enums;

namespace App.DataAccess
{
    public class AppConnection
    {
        private readonly DbProviderFactory providerFactory = null;
        private readonly DbConnection innerConnection = null;

        private static AppConnection instance = null;

        private AppConnection()
        {
            string dataSourceProvider = ConfigurationManager.ConnectionStrings[Connections.MysqlConnection].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings[Connections.MysqlConnection].ConnectionString;

            providerFactory = DbProviderFactories.GetFactory(dataSourceProvider);
            innerConnection = providerFactory.CreateConnection();
            innerConnection.ConnectionString = connectionString;
        }

        /// <summary>
        /// Renvoie un singleton
        /// </summary>
        /// <returns>Renvoie un objet de type ConnectionDB</returns>
        public static AppConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppConnection();
                }

                return instance;
            }
        }

        /// <summary>
        /// Fonction qui se connecte à la base de données
        /// </summary>
        public void Connect()
        {
            try
            {               
                innerConnection.Open();
            }
            catch (DbException dbEx)
            {
                AppMessage.Error("Une erreur est survenue lors de la connection à la base de données : " + dbEx.Message);
            }
        }

        /// <summary>
        /// Fonction qui renvoie la connection
        /// </summary>
        /// <returns>Renvoie un objet de type OleDbConnection</returns>
        public DbConnection GetConnection()
        {
            return innerConnection;
        }

        /// <summary>
        /// Fonction qui effectue la déconnection à la base de données
        /// </summary>
        public void Disconnect()
        {
            if (innerConnection.State == ConnectionState.Open)
            {
                innerConnection.Close();
            }
        }
    }
}
