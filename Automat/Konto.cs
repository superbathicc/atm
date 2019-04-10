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
    public partial class Konto : UserControl
    {
        public event EventHandler ButtonCancelClick;
        public event EventHandler ButtonBalanceClick;
        public event EventHandler ButtonDepositClick;
        public event EventHandler ButtonWithDrawClick;
        public event EventHandler ButtonTransferClick;
        public event EventHandler ButtonLanguageClick;
        public Konto()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ButtonCancelClick != null)
                this.ButtonCancelClick(this, e);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (this.ButtonBalanceClick != null)
                this.ButtonBalanceClick(this, e);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (this.ButtonDepositClick != null)
                this.ButtonDepositClick(this, e);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (this.ButtonWithDrawClick != null)
                this.ButtonWithDrawClick(this, e);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (this.ButtonTransferClick != null)
                this.ButtonTransferClick(this, e);
        }

        private void BtnLanguage_Click(object sender, EventArgs e)
        {
            if (this.ButtonLanguageClick != null)
                this.ButtonLanguageClick(this, e);
        }

        public void refresh()
        {
            btnBalance.Text = Properties.strings.balance;
            btnDeposit.Text = Properties.strings.deposit;
            btnTransfer.Text = Properties.strings.transfer;
            btnWithdraw.Text = Properties.strings.withdraw;
            btnCancel.Text = Properties.strings.cancel;
            btnDeposit.Refresh();
            btnBalance.Refresh();
            btnCancel.Refresh();
            btnTransfer.Refresh();
            btnWithdraw.Refresh();
        }


    }
}
