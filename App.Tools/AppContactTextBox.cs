using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace App.Tools
{
    public class AppContactTextBox : TextBox
    {
        public AppContactTextBox()
        {
            this.KeyPress += new KeyPressEventHandler(AppContactTextBox_KeyPress);
            this.TextAlign = HorizontalAlignment.Right;
        }

        public void AppContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) != true) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}
