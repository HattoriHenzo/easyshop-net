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
    [DataObject]
    public class CategorieBLL
    {        
        private CategorieDAL dataAccess;

        public CategorieBLL()
        {
            this.dataAccess = new CategorieDAL();
        }

        /// <summary>
        /// Fonction qui renvoie la liste des catégories
        /// </summary>
        /// <returns>Renvoie un objet de type CategorieBOListView</returns>
        [DataObjectMethod(DataObjectMethodType.Select,true)]
        public CategorieBOListView GetCategories()
        {
            return this.dataAccess.GetCategoriesFromDB();
        }

        /// <summary>
        /// Renvoie le dernier Id inséré dans la base de données
        /// </summary>
        /// <returns>Renvoie un entier</returns>
        public int GetMaxId()
        {
            string tableName = "Categorie";
            string idName = "IdCat";

            return this.dataAccess.GetMaxIdFromDB(tableName, idName);
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'une nouvelle catégorie
        /// </summary>
        /// <param name="newCategorie">Représente la catégorie à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Select,true)]
        public int Insert(CategorieBO c)
        {                       
            foreach (CategorieBO cat in this.dataAccess.GetCategoriesFromDB())
            {
                if (cat.LibelleCat.Trim() == c.LibelleCat.Trim())
                {
                    throw new AppException("La catégorie saisie existe déjà ! Veuillez saisir une autre catégorie !");
                }
            }

            return this.dataAccess.InsertCategorie(c.LibelleCat, c.ValideCat);
        }

        /// <summary>
        /// Fonction qui effectue la modification d'une marque
        /// </summary>
        /// <param name="oldCategorie">Catégorie à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update,true)]
        public int Update(CategorieBO c)
        {
            foreach (CategorieBO cat in this.dataAccess.GetCategoriesFromDB())
            {
                if (cat.LibelleCat.Trim() == c.LibelleCat.Trim())
                {
                    if (cat.IdCat != c.IdCat)
                    {
                        throw new AppException("La catégorie saisie existe déjà ! Veuillez saisir une autre catégorie !");
                    }                    
                }
            }

            return this.dataAccess.UpdateCategorie(c.IdCat, c.LibelleCat, c.ValideCat);
        }

        /// <summary>
        /// Fonction qui fait une suppression logique de la catégorie
        /// </summary>
        /// <param name="oldCategorie">Catégorie à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int UpdateValide(CategorieBO c)
        {
            return this.dataAccess.UpdateCategorieValide(c.ValideCat, c.IdCat);
        }       
    }
}
