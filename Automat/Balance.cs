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
    public partial class Balance : UserControl
    {
        public event EventHandler ButtonClick;
        public Balance()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        public void refresh()
        {
            btnCancel.Text = Properties.strings.cancel;
            btnCancel.Refresh();
            label1.Text = Properties.strings.balance;
            label1.Refresh();

        }
    }
}
