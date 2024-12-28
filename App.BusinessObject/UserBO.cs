using System;
using ToolsLib;

namespace BusinessObjectLib
{
	/// <summary>
	/// Classe de mappage sur la classe User
	/// </summary>
	public class UserBO
	{
		/// <summary>
		/// Id du user
		/// </summary>
		private int idUser;
		
		public int IdUser 
		{
			get { return idUser; }
			set { idUser = value; }
		}
		
		/// <summary>
		/// Nom et prénom du user
		/// </summary>
		private string nomUser;
		
		public string NomUser 
		{
			get { return nomUser; }
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
				
				nomUser = value; 
			}
		}
		
		/// <summary>
		/// Nom et prénom du user
		/// </summary>
		private string prenomUser;
		
		public string PrenomUser 
		{
			get { return prenomUser; }
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
				
				prenomUser = value; 
			}
		}
		
		/// <summary>
		/// Age du user
		/// </summary>
		private short ageUser;
		
		public short AgeUser 
		{
			get { return ageUser; }
			set 
			{ 
				short tmp = value;
				
				if((tmp <= 0) || (tmp >= 120))
				{
					throw new AppValidationException("Impossible d'effectuer la validation ! Veuillez saisir un âge compris entre 0 et 120 ans !");
				}
				
				ageUser = value; 
			}
		}
		
		/// <summary>
		/// Numéro de carte d'identité de l'utilisateur
		/// </summary>
		private string numCarteUser;
		
		public string NumCarteUser 
		{
			get { return numCarteUser; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de carte d'identité n'est pas saisi !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de carte d'indentité dépasse 50 caractères !");
                }

                numCarteUser = value; 
            }
		}
		
		/// <summary>
		/// Domicile du user
		/// </summary>
		private string domicileUser;
		
		public string DomicileUser 
		{
			get { return domicileUser; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le domicile n'est pas saisi !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le domicile dépasse 50 caractères !");
                }

                domicileUser = value; 
            }
		}
		
		/// <summary>
		/// Téléphone du user
		/// </summary>
		private string telUser;
		
		public string TelUser 
		{
			get { return telUser; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de téléphone n'est pas saisi !");
                }

                if (tmp.Length > 20)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de téléphone dépasse 20 caractères !");
                }

                telUser = value; 
            }
		}
		
		/// <summary>
		/// Cellulaire du user
		/// </summary>
		private string celUser;
		
		public string CelUser 
		{
			get { return celUser; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de cellulaire n'est pas saisi !");
                }

                if (tmp.Length > 20)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de cellulaire dépasse 20 caractères !");
                }

                celUser = value; 
            }
		}
		
		/// <summary>
		/// Email du user
		/// </summary>
		private string emailUser;
		
		public string EmailUser 
		{
			get { return emailUser; }
			set 
            {
                string tmp = value;

                if (tmp == string.Empty)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont l'email n'est pas saisi !");
                }
                else
                {
                    if (AppEmailValidation.IsValidEmail(tmp) == true)
                    {
                        throw new AppValidationException("Impossible d'effectuer la validation ! Veuillez saisir un email au format valide (ex: esombugma@gmail.com) !");
                    }
                }

                if (tmp.Length > 20)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le numéro de cellulaire dépasse 20 caractères !");
                }

                emailUser = value; 
            }
		}
		
		/// <summary>
		/// Login du user
		/// </summary>
		private string loginUser;
		
		public string LoginUser 
		{
			get { return loginUser; }
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

                loginUser = value; 
            }
		}
		
		/// <summary>
		/// Password du user
		/// </summary>
		private string passwordUser;
		
		public string PasswordUser 
		{
			get { return passwordUser; }
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
 
 
                passwordUser = value; 
            }
		}
		
		/// <summary>
		/// Définit le type du user
		/// </summary>
		private int typeUser;
		
		public int TypeUser 
		{
			get { return typeUser; }
			set { typeUser = value; }
		}
		
		/// <summary>
		/// Définit si le user est toujours en activité
		/// </summary>
		private bool valideUser;
		
		public bool ValideUser 
		{
			get { return valideUser; }
			set { valideUser = value; }
		}
		
		/// <summary>
		/// Constructeur
		/// </summary>
		public UserBO()
		{
		}
	}
	
	/// <summary>
	/// Liste des Users
	/// </summary>
	public class UserBOListView : BusinessObjectListView<UserBO>
	{
		
	}
}
