using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat
{
    
    public partial class Login : UserControl
    {
        public event EventHandler ButtonClick;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public void refreshTB()
        {
            tbLogin.Text = "";
            tbLoginPasswort.Text = "";
            tbLogin.Refresh();
            tbLoginPasswort.Refresh();
        }
    }
}
