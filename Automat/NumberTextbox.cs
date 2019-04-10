using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class NumberTextbox : System.Windows.Forms.TextBox
    {
        //Constructor
        public NumberTextbox()
        {
            //Aufruf von Context Menü unterbinden.
            this.ShortcutsEnabled = false;

            //KeyPress Ereignis anmelden
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumTextBox_KeyPress);
        }

        void NumTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
            
            //Prüfung, ob eine Zahl oder BackSpace ausgelöst wurde
            if ("1234567890\b".IndexOf(e.KeyChar.ToString()) < 0)
            {
                //Bei Abweichung Ereignis verwerfen
                e.Handled = true;
            }
        }
    }
}
