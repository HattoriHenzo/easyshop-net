using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace App.Tools
{
    public class AppNumericTextBox : TextBox
    {
        string value;

        public string Value
        {
            get { return this.value; }
            set 
            { 
                this.value = value;

                this.Text = int.Parse(this.value).ToString("N");                
            }
        }

        public AppNumericTextBox()
        {            
            this.KeyPress += new KeyPressEventHandler(AppNumericTextBoxKeyPress);
            this.Leave += new EventHandler(AppNumericTextBoxLeave);
            this.Enter += new EventHandler(AppNumericTextBoxEnter);
            this.MouseClick += new MouseEventHandler(AppNumericTextBoxMouseClick);            

            //Initialisation du champ
            this.Text = "0";
            this.value = "0";
        }

        /// <summary>
        /// Evènement en saisie
        /// </summary>       
        public void AppNumericTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) != true) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AppNumericTextBoxMouseClick(object sender, MouseEventArgs e)
        {
            if (this.Text != string.Empty)
            {
                this.SelectAll();

                this.Text = this.value.ToString();
            }            
        }

        /// <summary>
        /// En quittant
        /// </summary>      
        public void AppNumericTextBoxLeave(object sender, EventArgs e)
        {
            if (this.Text == string.Empty)
            {
                this.Text = "0";
            }           

            this.value = this.Text;
                  
            int tmp = int.Parse(this.value.ToString());            
            //Affichage du format
            this.Text = String.Format("{0:0}", tmp.ToString("N"));            
        }

        /// <summary>
        /// En entrant
        /// </summary>        
        public void AppNumericTextBoxEnter(object sender, EventArgs e)
        {
            if (this.Text != string.Empty)
            {
                this.SelectAll();

                this.Text = this.value.ToString();
            }                     
        }        
    }
}
