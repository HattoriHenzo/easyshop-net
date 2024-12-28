using System;

namespace App.BusinessObject
{
	/// <summary>
	/// Classe de mappage sur la table Livraison
	/// </summary>
	public class LivraisonBO
	{
		/// <summary>
		/// Id de la livraison
		/// </summary>
		private int idLiv;
		
		public int IdLiv 
		{
			get { return idLiv; }
			set { idLiv = value; }
		}
		
		/// <summary>
		/// Numéro de facture de la livraison
		/// </summary>
		private string numFactLiv;
		
		public string NumFactLiv 
		{
			get { return numFactLiv; }
			set 
            {               
                numFactLiv = value; 
            }
		}
		
		/// <summary>
		/// Numéro du bordereau de livraison
		/// </summary>
		private string numBLLiv;
		
		public string NumBLLiv 
		{
			get { return numBLLiv; }
			set 
            {               
                numBLLiv = value; 
            }
		}
		
		/// <summary>
		/// Date de livraison
		/// </summary>
		private DateTime dateLiv;
		
		public DateTime DateLiv 
		{
			get { return dateLiv; }
			set { dateLiv = value; }
		}
		
		/// <summary>
		/// Heure de livraison
		/// </summary>
		private string heureLiv;

        public string HeureLiv 
		{
			get { return heureLiv; }
			set { heureLiv = value; }
		}
		
		/// <summary>
		/// Id de la commande
		/// </summary>
		private int idCom;
		
		public int IdCom {
			get { return idCom; }
			set { idCom = value; }
		}
		
		/// <summary>
		/// Vérifie si la livraison est valide
		/// </summary>
		private bool valideLiv;
		
		public bool ValideLiv 
		{
			get { return valideLiv; }
			set { valideLiv = value; }
		}
		
		/// <summary>
		/// Constructeur
		/// </summary>
		public LivraisonBO()
		{
		}
	}
	
	/// <summary>
	/// Liste des livraisons
	/// </summary>
	public class LivraisonBOListView : BusinessObjectListView<LivraisonBO>
	{
		
	}
}
