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
		/// Nom et pr�nom du user
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
					throw new AppValidationException("Impossible de valider un utilisateur dont le nom d�passe 50 caract�res !");
				}
				
				nomUser = value; 
			}
		}
		
		/// <summary>
		/// Nom et pr�nom du user
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
					throw new AppValidationException("Impossible de valider un utilisateur dont le pr�nom n'est pas saisi !");
				}
				
				if(tmp.Length > 50)
				{
					throw new AppValidationException("Impossible de valider un utilisateur dont le pr�nom d�passe 50 caract�res !");
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
					throw new AppValidationException("Impossible d'effectuer la validation ! Veuillez saisir un �ge compris entre 0 et 120 ans !");
				}
				
				ageUser = value; 
			}
		}
		
		/// <summary>
		/// Num�ro de carte d'identit� de l'utilisateur
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de carte d'identit� n'est pas saisi !");
                }

                if (tmp.Length > 50)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de carte d'indentit� d�passe 50 caract�res !");
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le domicile d�passe 50 caract�res !");
                }

                domicileUser = value; 
            }
		}
		
		/// <summary>
		/// T�l�phone du user
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de t�l�phone n'est pas saisi !");
                }

                if (tmp.Length > 20)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de t�l�phone d�passe 20 caract�res !");
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de cellulaire n'est pas saisi !");
                }

                if (tmp.Length > 20)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de cellulaire d�passe 20 caract�res !");
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le num�ro de cellulaire d�passe 20 caract�res !");
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le login d�passe 50 caract�res !");
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
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe d�passe 50 caract�res !");
                }

                if (tmp.Length < 6)
                {
                    throw new AppValidationException("Impossible de valider un utilisateur dont le mot de passe est inf�rieur � 6 caract�res !");
                }
 
 
                passwordUser = value; 
            }
		}
		
		/// <summary>
		/// D�finit le type du user
		/// </summary>
		private int typeUser;
		
		public int TypeUser 
		{
			get { return typeUser; }
			set { typeUser = value; }
		}
		
		/// <summary>
		/// D�finit si le user est toujours en activit�
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
