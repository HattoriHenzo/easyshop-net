using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using DataAccessLayerLib;
using DataAccessLayerLib.GestionBoutiqueDataSetTableAdapters;
using ToolsLib;

namespace BusinessLogicLayerLib
{
    [DataObject]
    public class MotifBLL
    {
        private MotifTableAdapter innerAdapter = null;

        private static MotifBLL instance = null;

        private MotifBLL()
        {
            innerAdapter = new MotifTableAdapter();
        }

        //Singleton
        public static MotifBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MotifBLL();
                }

                return instance;
            }
        }

        /// <summary>
        /// Fonction qui renvoie la liste des motifs
        /// </summary>
        /// <returns>Renvoie un objet de type MotifDataTable</returns>
        [DataObjectMethod(DataObjectMethodType.Select,true)]
        public GestionBoutiqueDataSet.MotifDataTable GetMotifs()
        {
            return innerAdapter.GetMotifs();
        }

        /// <summary>
        /// Fonction qui effectue l'insertion d'un motif
        /// </summary>
        /// <param name="newMotif">Nouveau motif à insérer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int Insert(string motif)
        {
            if (motif == null)
            {
                throw new ArgumentNullException("Veuillez saisir un motif valide !");
            }

            if (motif == "")
            {
                throw new AppException("Veuillez saisir un motif valide !");
            }

            foreach (GestionBoutiqueDataSet.MotifRow mr in innerAdapter.GetMotifs())
            {
                if (mr.Motif == motif.Trim())
                {
                    throw new AppException("Le motif saisi existe déjà ! Veuillez saisir un autre !");                    
                }
            }

            return innerAdapter.InsertMotif(motif.Trim());
            
        }

        /// <summary>
        /// Fonctioon qui effectue la mise à jour 
        /// </summary>
        /// <param name="id">Id du motif à modifier</param>
        /// <param name="motif">Libelle du Motif à modifier</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public int Update(int id, string motif)
        {
            if (motif == null)
            {
                throw new ArgumentNullException("Veuillez saisir un motif valide !");
            }

            if (motif == "")
            {
                throw new AppException("Veuillez saisir un motif valide !");
            }

            return innerAdapter.UpdateMotif(motif, id);
        }

        /// <summary>
        /// Fonction qui effectue la suppression d'un motif
        /// </summary>
        /// <param name="id">Id du motif à supprimer</param>
        /// <returns>Renvoie un entier</returns>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public int Delete(int id)
        {
            if (id == 0)
            {
                throw new AppException("Veuillez choisir un motif à supprimer !");
            }

            return innerAdapter.DeleteMotif(id);
        }

    }
}
