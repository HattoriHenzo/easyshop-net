using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe de mappage sur la table EntreeSortie
    /// </summary>
    public class EntreeSortieBO
    {
        /// <summary>
        /// Id de l'Entrée/Sortie
        /// </summary>
        private int idES;

        public int IdES
        {
            get { return idES; }
            set { idES = value; }
        }

        /// <summary>
        /// Qte effectuée lors de l'ES
        /// </summary>
        private int qteES;

        public int QteES
        {
            get { return qteES; }
            set { qteES = value; }
        }

        /// <summary>
        /// Date à laquelle l'entrée/sortie s'est effectuée
        /// </summary>
        private DateTime dateES;

        public DateTime DateES
        {
            get { return dateES; }
            set { dateES = value; }
        }
        
        /// <summary>
        /// Heure à laquelle l'entrée/sortie s'est effectuée
        /// </summary>
        private string heureES;

        public string HeureES
        {
            get { return heureES; }
            set { heureES = value; }
        }

        /// <summary>
        /// Type de l'entrée sortie
        /// </summary>
        private string typeES;

        public string TypeES
        {
            get { return typeES; }
            set { typeES = value; }
        }

        /// <summary>
        /// Motif de la sortie
        /// </summary>
        private string motifS;

        public string MotifS
        {
            get { return motifS; }
            set { motifS = value; }
        }
        
        /// <summary>
        /// Observation faite
        /// </summary>
        private string observationES;
        
		public string ObservationES 
		{
			get { return observationES; }
			set { observationES = value; }
		}
		
		/// <summary>
		/// Id de l'utilisateur 
		/// </summary>
		private int idUser;
		
		public int IdUser 
		{
			get { return idUser; }
			set { idUser = value; }
		}
		
		/// <summary>
		/// Id de l'aticle dont on fait l'ES
		/// </summary>
		private int idArt;
		
		public int IdArt {
			get { return idArt; }
			set { idArt = value; }
		}
        /// <summary>
        /// Date à laquelle l'entrée sera perimé
        /// </summary>
        private DateTime datePeremption;

        public DateTime DatePeremption
        {
            get { return datePeremption; }
            set { datePeremption = value; }
        }

        /// <summary>
        /// Delai d'alerte 
        /// </summary>
        private int delaiAlerte;

        public int DelaiAlerte
        {
            get { return delaiAlerte; }
            set { delaiAlerte = value; }
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        public EntreeSortieBO()
		{
			
		}
    }


    /// <summary>
    /// Liste des entrées sortiess
    /// </summary>
    public class EntreeSortieBOListView : BusinessObjectListView<EntreeSortieBO>
    {
    	
    }
}
