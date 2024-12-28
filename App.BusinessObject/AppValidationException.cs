using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BusinessObject
{
    /// <summary>
    /// Classe définissant les exceptions des business objects
    /// </summary>
    public class AppValidationException : Exception
    {
        ///<summary>
        /// Constructeur sans paramètres
        ///</summary>
        public AppValidationException()
            : base()
        { }

        ///<summary>
        /// Constructeur avec paramètre
        ///</summary>
        ///<param name = "msg"> 
        /// Message renvoyé lorsqu'une exception est levée
        ///</param>
        public AppValidationException(string msg)
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
        public AppValidationException(string msg, Exception innerEx)
            : base(msg, innerEx)
        { }

    }

}
