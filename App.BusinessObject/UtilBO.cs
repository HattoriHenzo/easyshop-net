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
		/// Nom et pr�nom du Util
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
					throw new AppValidationException("Impossible de valider un utilisateur dont le nom d�passe 50 caract�res !");
				}
				
				nomUtil = value; 
			}
		}
		
		/// <summary>
		/// Nom et pr�nom du Util
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
					throw new AppValidationException("Impossible de valider un utilisateur dont le pr�nom n'est pas saisi !");
				}
				
				if(tmp.Length > 50)
				{
					throw new AppValidationException("Impossible de valider un utilisateur dont le pr�nom d�passe 50 caract�res !");
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
		/// Num�ro de carte d'identit� de l'utilisateur
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
		/// T�l�phone du Util
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le login d�passe 50 caract�res !");
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe d�passe 50 caract�res !");
                }

                if (tmp.Length < 6)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe est inf�rieur � 6 caract�res !");
                }
 
 
                passwordUtil = value; 
            }
		}
		
		/// <summary>
		/// D�finit le type du Util
		/// </summary>
		private int typeUtil;
		
		public int TypeUtil 
		{
			get { return typeUtil; }
			set { typeUtil = value; }
		}
		
		/// <summary>
		/// D�finit si le Util est toujours en activit�
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
