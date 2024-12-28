using System;

namespace App.BusinessObject
{
	/// <summary>
	/// Classe de mappage sur la table fournisseur
	/// </summary>
	public class FournisseurBO
	{
		/// <summary>
		/// Id du fournisseur
		/// </summary>
		private int idFour;
		
		public int IdFour 
		{
			get { return idFour; }
			set { idFour = value; }
		}
		
		/// <summary>
		/// Raison sociale du fournisseur
		/// </summary>
		private string raisonSocialeFour;
		
		public string RaisonSocialeFour 
		{
			get { return raisonSocialeFour; }
			set 
			{   
				string tmp = value;
				
				if(tmp == string.Empty)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont la raison sociale n'est pas renseign�e !");
				}
				
				if(tmp.Length > 250)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont la raison sociale est sup�rieure � 250 caract�res !");
				}
				
				raisonSocialeFour = value; 
			}
		}
		
		/// <summary>
		/// Adresse du fournisseur
		/// </summary>
		private string adresseFour;
		
		public string AdresseFour 
		{
			get { return adresseFour; }
			set 
			{ 
				string tmp = value;
				
				if(tmp.Length > 250)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont l'adresse est sup�rieure � 250 caract�res !");
				}
				
				adresseFour = value; 
			}
		}
		
		/// <summary>
		/// Num�ro de t�l�phone du fournisseur
		/// </summary>
		private string telFour;
		
		public string TelFour 
		{
			get { return telFour; }
			set 
			{
				string tmp = value;
				
				if(tmp.Length > 20)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont le num�ro de t�l�phone est sup�rieur � 20 caract�res !");
				}
				
				telFour = value; 
			}
		}
		
		/// <summary>
		/// Nuim�ro de cellulaire du fournisseur
		/// </summary>
		private string celFour;
		
		public string CelFour 
		{
			get { return celFour; }
			set 
			{
				string tmp = value;
				
				if(tmp.Length > 20)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont le num�ro de cellulaire est sup�rieur � 20 caract�res !");
				}								
				
				celFour = value; 
			}
		}
		
		/// <summary>
		/// Num�ro de fax du fournisseur
		/// </summary>
		private string faxFour;
		
		public string FaxFour 
		{
			get { return faxFour; }
			set 
			{
				string tmp = value;
				
				if(tmp.Length > 20)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont le num�ro de fax est sup�rieur � 20 caract�res !");
				}								
				
				faxFour = value; 
			}
		}
		
		/// <summary>
		/// Email du fournisseur
		/// </summary>
		private string emailFour;
		
		public string EmailFour 
		{
			get { return emailFour; }
			set 
			{
				string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont l'email n'est pas saisi !");
                }
                else
                {
                    if (App.Tools.AppEmailValidation.IsValidEmail(tmp) == false)
                    {
                        throw new AppValidationException("Impossible d'effectuer la validation ! Veuillez saisir un email au format valide (ex: emilejeans@servermail.com) !");
                    }
                }
                
				emailFour = value; 
			}
		}
		
		/// <summary>
		/// Site internet du fournisseur
		/// </summary>
		private string siteInternetFour;
		
		public string SiteInternetFour 
		{
			get { return siteInternetFour; }
			set 
			{ 
				string tmp = value;
				
				if(tmp.Length > 50)
				{
					throw new AppValidationException("Impossible de valider un fournisseur dont le site web est sup�rieur � 50 caract�res !");
				}	
				
				siteInternetFour = value; 
			}
		}
		
		/// <summary>
		/// Constructeur
		/// </summary>
		public FournisseurBO()
		{
			
		}
	}
	
	/// <summary>
	/// Liste des fournisseurs
	/// </summary>
	public class FournisseurBOListView : BusinessObjectListView<FournisseurBO>
	{
		
	}
}
