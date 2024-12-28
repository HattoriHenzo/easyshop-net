//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.ComponentModel;

//using DataAccessLayerLib;
//using ToolsLib;


//namespace BusinessLogicLayerLib
//{   
//    [DataObject]
//    public class UserBLL
//    {
//        private UserTableAdapter innerAdapter = null;

//        private static UserBLL instance = null;

//        private UserBLL()
//        {
//            innerAdapter = new UserTableAdapter();
//        }

//        //Singleton
//        public static UserBLL Instance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new UserBLL();
//                }

//                return instance;
//            }
//        }

//        /// <summary>
//        /// Fonction qui renvoie la liste des utilisateurs
//        /// </summary>
//        /// <returns></returns>
//        [DataObjectMethod(DataObjectMethodType.Select, true)]
//        public GestionBoutiqueDataSet.UserDataTable GetUsers()
//        {
//            return innerAdapter.GetUsers();
//        }

//        /// <summary>
//        /// Renvoie la liste des utilisateurs en fonction de leur validité dans la base de données
//        /// </summary>
//        /// <param name="idUser"></param>
//        /// <returns></returns>
//        [DataObjectMethod(DataObjectMethodType.Select, true)]
//        public GestionBoutiqueDataSet.UserDataTable GetUsersValide(bool valide)
//        {
//            return innerAdapter.GetUsersValide(valide);
//        }

//        ///<summary>
//        /// Fonction qui créé un login pour un utilisateur nouvellement créé
//        ///</summary>
//        ///<param name ="nom"> Nom du nouvelle utilisateur </param>
//        ///<param name ="prenom"> Prénom du nouvelle utilisateur </param>
//        ///<remarks>
//        /// Pour un utilisateur ayant pour nom et prénom 'Jérémie Akakpo', son login sera 'jAkakpo' 
//        ///</remarks>
//        ///<exception cref="ArgumentNullException"> 
//        /// Une exception est levée lorsque le nom ou le prénom sont null 
//        ///</exception>
//        ///<exception cref="AppException"> 
//        /// Une exception est levée lorsque le nom ou le prénom sont vide  
//        ///</exception>
//        public string CreateNewLogin(string nom, string prenom)
//        {
//            if ((nom == null) || (prenom == null))
//            {
//                throw new ArgumentNullException("Impossible de procéder à la création du login car les valeurs saisies ne sont pas valides !");
//            }

//            if ((nom == "") || (prenom == ""))
//            {
//                throw new AppException("Impossible de procéder à la création du login car les valeurs saisies ne sont pas valides !");
//            }

//            //On récupère la première lettre du prénom
//            string fLetter = prenom.Substring(0, 1);

//            //On converti le nom en lettre minuscule
//            nom.ToLower();

//            //Le nom est reformaté ('EMILE' devient 'mile' pour avoir 'Emile')  
//            string newName = nom.Substring(0, 1).ToUpper() + nom.Substring(1, nom.Length - 1).ToLower();

//            return (fLetter.ToLower() + newName.ToLower());
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="login"></param>
//        /// <param name="password"></param>
//        /// <returns></returns>
//        [DataObjectMethod(DataObjectMethodType.Select, true)]
//        public GestionBoutiqueDataSet.UserDataTable GetLoginValid(string login, string password)
//        {
//            return innerAdapter.GetLoginValid(login, password);
//        }

//        /// <summary>
//        /// Fonction qui effectue la vérification du login
//        /// </summary>
//        /// <param name="login">Login</param>
//        /// <param name="password">Mot de passe</param>
//        /// <returns>Renvoie un booléen</returns>
//        public bool IsValidUser(string login, string password)
//        {
//            bool valid = false;

//            if (innerAdapter.GetLoginValid(login, password).Rows.Count != 0)
//            {
//                valid = true;
//            }

//            return valid;
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="nom"></param>
//        /// <param name="prenom"></param>
//        /// <param name="age"></param>
//        /// <param name="adresse"></param>
//        /// <param name="tel"></param>
//        /// <param name="cel"></param>
//        /// <param name="email"></param>
//        /// <param name="login"></param>
//        /// <param name="password"></param>        
//        /// <param name="valide"></param>
//        /// <returns></returns>
//        [DataObjectMethod(DataObjectMethodType.Insert, true)]
//        public int Insert(string nom, string prenom, int age, string adresse, string tel, string cel, string email, string login, string password, int typeuser, bool valide)
//        {          
//            if ((nom == null) || (nom == ""))
//            {
//                throw new AppException("Veuillez saisir un nom valide !");
//            }

//            if((prenom == null) || (prenom == ""))
//            {
//                throw new AppException("Veuillez saisir un prénom valide !");
//            }

//            if (age <= 0)
//            {
//                throw new AppException("Veuillez saisir un age valide !");
//            }

//            if ((adresse == null) || (adresse == ""))
//            {
//                throw new AppException("Veuillez saisir une adresse valide !");
//            }           

//            if ((email == null) || (email == ""))
//            {
//                throw new AppException("Veuillez saisir un e-mail valide !");
//            }

//            if ((login == null) || (login == ""))
//            {
//                throw new AppException("Veuillez saisir un login valide !");
//            }

//            //On vérifie si le login existe déjà
//            foreach(GestionBoutiqueDataSet.UserRow ur in innerAdapter.GetUsers())
//            {
//                if (ur.Login == login)
//                {
//                    throw new AppException("Le login choisi existe déjà dans la base de données !");
//                }
//            }

//            if ((password == null) || (password == ""))
//            {
//                throw new AppException("Vous ne pouvez pas choisir un mot de passe vide !");
//            }

//            if (password.Length < 6)
//            {
//                throw new AppException("Vous devez saisir un mot de passe dont la longueur est supérieure ou égale à 6 !");
//            }            

//            return innerAdapter.InsertUser(nom, prenom, age, adresse, tel, cel, email, login, password, typeuser, valide);
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="id"></param>
//        /// <param name="nom"></param>
//        /// <param name="prenom"></param>
//        /// <param name="age"></param>
//        /// <param name="adresse"></param>
//        /// <param name="tel"></param>
//        /// <param name="cel"></param>
//        /// <param name="email"></param>
//        /// <param name="login"></param>
//        /// <param name="password"></param>        
//        /// <param name="valide"></param>
//        /// <returns></returns>
//        [DataObjectMethod(DataObjectMethodType.Update, true)]
//        public int Update(int iduser, string nom, string prenom, int age, string adresse, string tel, string cel, string email, string login, string password, int typeuser, bool valide)
//        {
//            if (iduser == 0)
//            {
//                throw new AppException("Veuillez choisir un utilisateur à modifier !");
//            }

//            if ((nom == null) || (nom == ""))
//            {
//                throw new AppException("Veuillez saisir un nom valide !");
//            }

//            if ((prenom == null) || (prenom == ""))
//            {
//                throw new AppException("Veuillez saisir un prénom valide !");
//            }

//            if (age <= 0)
//            {
//                throw new AppException("Veuillez saisir un age valide !");
//            }

//            if ((adresse == null) || (adresse == ""))
//            {
//                throw new AppException("Veuillez saisir une adresse valide !");
//            }            

//            if ((email == null) || (email == ""))
//            {
//                throw new AppException("Veuillez saisir un e-mail valide !");
//            }

//            if ((login == null) || (login == ""))
//            {
//                throw new AppException("Veuillez saisir un login valide !");
//            }

//            //On vérifie si le login existe déjà
//            if (int.Parse(innerAdapter.GetUsers().Compute("Count(Login)", "Login = '" + login + "'").ToString()) > 1)
//            {
//                throw new AppException("Le login choisi existe déjà dans la base de données !");
//            }

//            if ((password == null) || (password == ""))
//            {
//                throw new AppException("Vous ne pouvez pas choisir un mot de passe vide !");
//            }

//            if (password.Length < 6)
//            {
//                throw new AppException("Vous devez saisir un mot de passe dont la longueur est supérieure ou égale à 6 !");
//            }
            
//            return innerAdapter.UpdateUser(nom, prenom, age, adresse, tel, cel, email, login, password, typeuser, valide, iduser);            
//        }
       
//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="iduser"></param>
//        /// <returns></returns>
//        [DataObjectMethod(DataObjectMethodType.Delete, true)]
//        public int Delete(bool valide, int iduser)
//        {
//            if (iduser == 0)
//            {
//                throw new AppException("Veuillez choisir un utilisateur à supprimer !");
//            }

//            return innerAdapter.UpdateUserValidity(false, iduser);
//        }

//    }
//}
