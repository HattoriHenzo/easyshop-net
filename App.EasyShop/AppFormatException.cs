using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBoutique
{
    /// <summary>
    /// Classe définissant les exceptions gérées lors des mauvaises converstions
    /// </summary>
    public class AppFormatException : FormatException
    {
        /// <summary>
        /// Constructeur sans paramètres
        /// </summary>
        public AppFormatException() :  base()
        {
        }

        /// <summary>
        /// Contructeur qui prend en paramètre le message à envoyé
        /// </summary>
        /// <param name="msg">Message renvoyé lorsque l'exception est levée</param>
        public AppFormatException(string msg) : base(msg)
        {

        }

        /// <summary>
        /// Constructeur qui prend deux paramètres
        /// </summary>
        /// <param name="msg">Message renvoyé</param>
        /// <param name="innerEx">Exception interne</param>
        public AppFormatException(string msg, FormatException innerEx) : base(msg, innerEx)
        {
        }
    }
}
