using System.Windows.Forms;

namespace App.Tools
{
    ///<summary>
    /// Fontion d'affichage des messages
    /// </summary>
    public class AppMessage
    {
        public static void Error(string msg)
        {
            MessageBox.Show(msg, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warning(string msg)
        {
            MessageBox.Show(msg, "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Success(string msg)
        {
            MessageBox.Show(msg, "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static DialogResult Question(string msg)
        {
            return MessageBox.Show(msg, "Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
