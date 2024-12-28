using System;
using App.Tools;

namespace App.BusinessObject
{
	/// <summary>
	/// Classe de mappage sur la classe Util
	/// </summary>
	public class UtilBO
	{
		/// <summary>
		/// Id du Util
		/// </summary>
		private int idUtil;
		
		public int IdUtil 
		{
			get { return idUtil; }
			set { idUtil = value; }
		}
		
		/// <summary>
		/// Nom et prénom du Util
		/// </summary>
		private string nomUtil;
		
		public string NomUtil 
		{
			get { return nomUtil; }
			set 
			{
				string tmp = value;
				
				if(tmp == string.Empty)
				{
					throw new AppValidationException("Impossible de valider un utilisateur dont le nom n'est pas saisi !");
				}
				
				if(tmp.Length > 50)
				{
					throw new AppValidationException("Impossible de valider un utilisateur dont le nom dépasse 50 caractères !");
				}
				
				nomUtil = value; 
			}
		}
		
		/// <summary>
		/// Nom et prénom du Util
		/// </summary>
		private string prenomUtil;
		
		public string PrenomUtil 
		{
			get { return prenomUtil; }
			set 
			{
				string tmp = value;
				
				if(tmp == string.Empty)
				{
					throw new AppValidationException("Impossible de valider un utilisateur dont le prénom n'est pas saisi !");
				}
				
				if(tmp.Length > 50)
				{
					throw new AppValidationException("Impossible de valider un utilisateur dont le prénom dépasse 50 caractères !");
				}
				
				prenomUtil = value; 
			}
		}
		
		/// <summary>
		/// Age du Util
		/// </summary>
		private short ageUtil;
		
		public short AgeUtil 
		{
			get { return ageUtil; }
			set 
			{ 								
				ageUtil = value; 
			}
		}
		
		/// <summary>
		/// Numéro de carte d'identité de l'utilisateur
		/// </summary>
		private string numCarteUtil;
		
		public string NumCarteUtil 
		{
			get { return numCarteUtil; }
			set 
            {                
                numCarteUtil = value; 
            }
		}
		
		/// <summary>
		/// Domicile du Util
		/// </summary>
		private string adresseUtil;

        public string AdresseUtil 
		{
            get { return adresseUtil; }
			set 
            {                
                adresseUtil = value; 
            }
		}
		
		/// <summary>
		/// Téléphone du Util
		/// </summary>
		private string telUtil;
		
		public string TelUtil 
		{
			get { return telUtil; }
			set 
            {               
                telUtil = value; 
            }
		}
		
		/// <summary>
		/// Cellulaire du Util
		/// </summary>
		private string celUtil;
		
		public string CelUtil 
		{
			get { return celUtil; }
			set 
            {                
                celUtil = value; 
            }
		}
		
		/// <summary>
		/// Email du Util
		/// </summary>
		private string emailUtil;
		
		public string EmailUtil 
		{
			get { return emailUtil; }

			set 
            {                                               
                emailUtil = value; 
            }
		}
		
		/// <summary>
		/// Login du Util
		/// </summary>
		private string loginUtil;
		
		public string LoginUtil 
		{
			get { return loginUtil; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le login n'est pas saisi !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le login dépasse 50 caractères !");
                }

                loginUtil = value; 
            }
		}
		
		/// <summary>
		/// Password du Util
		/// </summary>
		private string passwordUtil;
		
		public string PasswordUtil 
		{
			get { return passwordUtil; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe n'est pas saisi !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe dépasse 50 caractères !");
                }

                if (tmp.Length < 6)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe est inférieur à 6 caractères !");
                }
 
 
                passwordUtil = value; 
            }
		}
		
		/// <summary>
		/// Définit le type du Util
		/// </summary>
		private int typeUtil;
		
		public int TypeUtil 
		{
			get { return typeUtil; }
			set { typeUtil = value; }
		}
		
		/// <summary>
		/// Définit si le Util est toujours en activité
		/// </summary>
		private bool valideUtil;
		
		public bool ValideUtil 
		{
			get { return valideUtil; }
			set { valideUtil = value; }
		}
		
		/// <summary>
		/// Constructeur
		/// </summary>
		public UtilBO()
		{
		}
	}
	
	/// <summary>
	/// Liste des Utils
	/// </summary>
	public class UtilBOListView : BusinessObjectListView<UtilBO>
	{
		
	}
}
