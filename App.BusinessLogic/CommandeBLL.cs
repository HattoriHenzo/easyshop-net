using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    /// <summary>
    /// Classe qui implémente les règles de gestion de la table Commande
    /// </summary>
    [DataObject]
    public class CommandeBLL
    {        
        private CommandeDAL dataAccess;

        public CommandeBLL()
        {
            this.dataAccess = new CommandeDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste de toutes les commandes
        /// </summary>
        /// <returns>Renvoie un objet de type CommandeDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public CommandeBOListView GetCommandes()
        {
            return this.dataAccess.GetCommandesFromDB();
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Commande";
            string idName = "IdCom";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui renvoie le cout total de la commande
        /// </summary>
        /// <param name="liste">Liste des articles commandés</param>
        /// <returns>Renvoie un entier</returns>
        public int GetTotalCommande(CommanderBOListView liste)
        {
            int total = 0;

            foreach (CommanderBO c in liste)
            {
                total += c.Total;
            }

            return total;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'une commande 
        /// </summary>
        /// <param name="c">Commande à insérer</param>
        /// <returns>Renvoie le nombre de lignes affectées par la requête</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(CommandeBO c)
        {
            return this.dataAccess.InsertCommande(c.NumCom, c.NumComText, c.DateCom, DateTime.Parse(c.HeureCom), c.DescCom, c.AnnulerCom);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'une commande
        /// </summary>
        /// <param name="c">Commande à modifier</param>
        /// <returns>Renvoie le nombre de lignes affectées par la requête</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(CommandeBO c)
        {
            return this.dataAccess.UpdateCommande(c.IdCom, c.NumCom, c.NumComText, c.DateCom, DateTime.Parse(c.HeureCom), c.DescCom, c.AnnulerCom);
        }

        /// <summary>
        /// Fonction qui permet d'annuler une commande
        /// </summary>
        /// <param name="c">Commande à annuler</param>
        /// <returns>Renvoie un entier</returns>
        public int UpdateAnnuler(CommandeBO c)
        {
            return this.dataAccess.UpdateCommandeAnnuler(c.IdCom, true);
        }
    }
}
