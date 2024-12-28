using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

using App.BusinessObject;
using App.DataAccess;
using App.Tools;

namespace App.BusinessLogic
{
    [DataObject]
    public class UtilBLL
    {
        private UtilDAL dataAccess;

        public UtilBLL()
        {
            this.dataAccess = new UtilDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public UtilBOListView GetUsers()
        {
            return this.dataAccess.GetUtilsFromDB();
        }

        /// <summary>
        /// Renvoie la liste des utilisateurs en fonction de leur validité dans la base de données
        /// </summary>
        /// <param name="valide">Indique la validité de l'utilisateur</param>
        /// <returns></returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public UtilBOListView GetUsersValide(bool valide)
        {
            return this.dataAccess.GetUtilsValideFromDB(valide);
        }

        ///<summary>
        /// Fonction qui créé un login pour un utilisateur nouvellement créé
        ///</summary>
        ///<param name ="nom"> Nom du nouvelle utilisateur </param>
        ///<param name ="prenom"> Prénom du nouvelle utilisateur </param>
        ///<remarks>
        /// Pour un utilisateur ayant pour nom et prénom 'Jérémie Akakpo', son login sera 'jAkakpo' 
        ///</remarks>
        ///<exception cref="ArgumentNullException"> 
        /// Une exception est levée lorsque le nom ou le prénom sont null 
        ///</exception>
        ///<exception cref="AppException"> 
        /// Une exception est levée lorsque le nom ou le prénom sont vide  
        ///</exception>
        public string CreateNewLogin(string nom, string prenom)
        {            
            if ((nom == "") || (prenom == ""))
            {
                throw new AppException("Impossible de procéder à la création du login car les valeurs saisies ne sont pas valides !");
            }

            //On récupère la première lettre du prénom
            string fLetter = prenom.Substring(0, 1);

            //On converti le nom en lettre minuscule
            nom.ToLower();

            //Le nom est reformaté ('EMILE' devient 'mile' pour avoir 'Emile')  
            string newName = nom.Substring(0, 1).ToUpper() + nom.Substring(1, nom.Length - 1).ToLower();

            return (fLetter.ToLower() + newName.ToLower());
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Utilisateur";
            string idName = "IdUtil";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'un utilisateur
        /// </summary>
        /// <param name="u">Utilisateur à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(UtilBO u)
        {            
            //On vérifie si le login existe déjà
            foreach(UtilBO ut in this.dataAccess.GetUtilsFromDB())
            {
                if (ut.LoginUtil == u.LoginUtil)
                {
                    throw new AppException("Le login choisi existe déjà dans la base de données !");
                }
            }

            return this.dataAccess.InsertUtil(u.NomUtil, u.PrenomUtil, u.AgeUtil, u.NumCarteUtil, u.AdresseUtil, u.TelUtil, u.CelUtil, u.EmailUtil, u.LoginUtil, u.PasswordUtil, u.TypeUtil, u.ValideUtil);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'un utilisateur
        /// </summary>
        /// <param name="u">Utilisateur à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(UtilBO u)
        {
            //On vérifie si le login existe déjà
            foreach (UtilBO ut in this.dataAccess.GetUtilsFromDB())
            {
                if (ut.LoginUtil == u.LoginUtil)
                {
                    if (ut.IdUtil != u.IdUtil)
                    {
                        throw new AppException("Le login choisi existe déjà dans la base de données !");
                    }                    
                }
            }

            return this.dataAccess.UpdateUtil(u.IdUtil, u.NomUtil, u.PrenomUtil, u.AgeUtil, u.NumCarteUtil, u.AdresseUtil, u.TelUtil, u.CelUtil, u.EmailUtil, u.LoginUtil, u.PasswordUtil, u.TypeUtil, u.ValideUtil);
        }

        /// <summary>
        /// Fonction qui effectue la suppression
        /// </summary>
        /// <param name="iduser">Id de l'utilisateur à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(bool valide, int idUtil)
        {
            return this.dataAccess.DeleteUtil(valide, idUtil);
        }

    }
}
