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
    public partial class Deposit : UserControl
    {
        public event EventHandler ButtonClick;
        public event EventHandler ButtonClickCancel;
        public Deposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickCancel != null)
                this.ButtonClickCancel(this, e);

        }

        public void refresh()
        {
            label1.Text = Properties.strings.pick;
            label1.Refresh();
            btnDeposit.Text = Properties.strings.selected;
            btnCancel.Text = Properties.strings.cancel;
            btnCancel.Refresh();
            btnDeposit.Refresh();
        }

        public void refreshTB()
        {
            tbDeposit.Text = "";
            tbDeposit.Refresh();
        }
    }
}
