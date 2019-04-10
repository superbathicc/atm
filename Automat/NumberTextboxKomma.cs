using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Automat
{
  public class NumberTextboxKomma : System.Windows.Forms.TextBox
    {
        //Constructor
        public NumberTextboxKomma()
        {
            //Aufruf von Context Menü unterbinden.
            this.ShortcutsEnabled = false;

            //KeyPress Ereignis anmelden
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumTextBox_KeyPress);
        }

        void NumTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //String newText = this.Text + e.KeyChar.ToString();
            //  Regex regex = new Regex(@"^[0-9]{1,4}(,[0-9]{2})?$");
            //Match match = Regex.Match(newText, @"^[0-9]{1,4}(,[0-9]{2})?$");
            //if (match.Success) {
            // if (regex.IsMatch(newText))
            //{
            //   Console.WriteLine(newText);

            //  }
            //Prüfung, ob eine Zahl oder BackSpace ausgelöst wurde
            if (",1234567890\b".IndexOf(e.KeyChar.ToString()) < 0)
            {

                e.Handled = true;
            }
        }
        
    }
}
