using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.ComponentModel;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{

    public class CommanderBLL
    {
        private CommanderDAL dataAccess;

        public CommanderBLL()
        {
            this.dataAccess = new CommanderDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des commandes
        /// </summary>
        /// <returns>Renvoie un objet de type CommanderDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public CommanderBOListView GetCommander()
        {
            return this.dataAccess.GetCommanderFromDB();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des commandes
        /// </summary>
        /// <returns>Renvoie un objet de type CommanderDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public CommanderBOListView GetCommanderByCommandeId(int idCom)
        {
            return this.dataAccess.GetCommanderByCommandeIdFromDB(idCom);
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Commander";
            string idName = "IdComder";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Vérifie si l'article existe déja pour la commande en question
        /// </summary>
        /// <param name="idart">Id de l'article</param>
        /// <param name="idcom">Id de la commande</param>
        /// <returns>Renvoie un booléen</returns>
        private bool ArticleExist(int idart, int idcom)
        {
            bool exist = false;

            var listeArt = from art in this.GetCommanderByCommandeId(idcom)
                           where art.IdCom == idcom
                           select art;

            foreach (var v in listeArt)
            {
                if (v.IdArt == idart)
                {
                    exist = true;
                }
            }

            return exist;
        }

        /// <summary>
        /// Fonction qui effectue l'insertion dans la relation commander
        /// </summary>
        /// <param name="c">Commande à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(CommanderBO c)
        {
            if (this.ArticleExist(c.IdArt, c.IdCom) == true)
            {
                throw new AppException("L'article sélectionné existe déjà dans la commande ! Veuillez choisir un autre article !");
            }

            return this.dataAccess.InsertCommander(c.QteCom, c.PrixCom, c.IdArt, c.IdCom, c.IdFour);
        }

        /// <summary>
        /// Fonction qui effectue la modification
        /// </summary>
        /// <param name="c">Commande à modifier</param>
        /// <returns>Renvoie le nombre de lignes </returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(CommanderBO c)
        {           
            return this.dataAccess.UpdateCommander(c.IdComder, c.QteCom, c.PrixCom, c.IdArt, c.IdCom, c.IdFour);
        }

        /// <summary>
        /// Fonction qui effectue la suppression
        /// </summary>
        /// <param name="c">Commande à modifier</param>
        /// <returns>Renvoie le nombre de lignes affectées par la requête</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(CommanderBO c)
        {
            return this.dataAccess.DeleteCommander(c.IdComder);
        }
    }
}
