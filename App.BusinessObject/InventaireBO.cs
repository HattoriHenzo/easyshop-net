using System;

namespace App.BusinessObject
{
	/// <summary>
	/// Classe de mappage su la table Inventaire
	/// </summary>
	public class InventaireBO
	{
		/// <summary>
		/// Id de l'inventaire
		/// </summary>
		private int idInv;
		
		public int IdInv 
		{
			get { return idInv; }
			set { idInv = value; }
		}

        private string libelleArt;

        /// <summary>
        /// Libelle de l'article
        /// </summary>
        public string LibelleArt
        {
            get { return libelleArt; }
            set { libelleArt = value; }
        }

		/// <summary>
		/// Qté comptée physiquement
		/// </summary>
		private int qtePhysInv;
		
		public int QtePhysInv 
		{
			get { return qtePhysInv; }
			set { qtePhysInv = value; }
		}
		
		/// <summary>
		/// Qté comptée dans la base de données
		/// </summary>
		private int qteStockInv;
		
		public int QteStockInv 
		{
			get { return qteStockInv; }
			set { qteStockInv = value; }
		}
		

		/// <summary>
		/// Ecart de l'inventaire
		/// </summary>
		private int ecartInv;
		
		public int EcartInv 
		{
			get { return ecartInv; }
			set { ecartInv = value; }
		}
		
		/// <summary>
		/// Observation de l'inventaire
		/// </summary>
		private string observationInv;
		
		public string ObservationInv 
		{
			get { return observationInv; }
			set { observationInv = value; }
		}
		
		/// <summary>
		/// Id de la date d'inventaire
		/// </summary>
		private int idDateInv;
		
		public int IdDateInv 
		{
			get { return idDateInv; }
			set { idDateInv = value; }
		}
		
		/// <summary>
		/// Id de l'article
		/// </summary>
		private int idArt;
		
		public int IdArt 
		{
			get { return idArt; }
			set { idArt = value; }
		}
		
		/// <summary>
		/// Constructeur
		/// </summary>
		public InventaireBO()
		{
		}
	}
	
	/// <summary>
	/// Liste des inventaires
	/// </summary>
	public class InventaireBOListView : BusinessObjectListView<InventaireBO>
	{
		
	}
}
