using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table Catégorie
    /// </summary>
    public class CategorieBO
    {
        /// <summary>
        /// Identifiant de la catégorie
        /// </summary>
        private int idCat;

        public int IdCat
        {
            get { return idCat; }
            set { idCat = value; }
        }

        /// <summary>
        /// Libelle de la catégorie
        /// </summary>
        private string libelleCat;

        public string LibelleCat
        {
            get { return libelleCat; }
            set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider une catégorie dont le libellé est vide !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider une catégorie dont le libellé dépasse 50 caractères !");
                }

                libelleCat = value; 
            }
        }
        
        /// <summary>
        /// Permet de savoir si la catégorie est valide ou pas
        /// </summary>
        private bool valideCat;

        public bool ValideCat
        {
            get { return valideCat; }
            set { valideCat = value; }
        }
        
        /// <summary>
        /// Renvoie le libellé de l'article
        /// </summary>
        /// <returns>Renvoie une chaîne de caractère</returns>
		public override string ToString()
		{
			return this.libelleCat;
		}

        /// <summary>
        /// Constructeur
        /// </summary>
        public CategorieBO()
        {
        }
    }

    /// <summary>
    /// Représente la liste des catégories
    /// </summary>
    public class CategorieBOListView : BusinessObjectListView<CategorieBO>
    {

    }
}
