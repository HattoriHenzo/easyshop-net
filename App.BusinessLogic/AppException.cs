using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Tools
{
    /// <summary>
    /// Classe définissant les exceptions de l'application 
    /// </summary>
    public class AppException : Exception
    {
        ///<summary>
        /// Constructeur sans paramètres
        ///</summary>
        public AppException()
            : base()
        { }

        ///<summary>
        /// Constructeur avec paramètre
        ///</summary>
        ///<param name = "msg"> 
        /// Message renvoyé lorsqu'une exception est levée
        ///</param>
        public AppException(string msg)
            : base(msg)
        { }

        ///<summary>
        /// Constructeur avec paramètre
        ///</summary>
        ///<param name = "msg">
        /// Message renvoyélorsqu'une exception est levée
        ///</param>
        ///<param name = "innerEx">
        /// Exception se trouvant à la base
        ///</param>
        public AppException(string msg, Exception innerEx)
            : base(msg, innerEx)
        { }

    }
}
