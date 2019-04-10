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
    public partial class Transfer : UserControl
    {
        public event EventHandler ButtonCancelClick;
        public event EventHandler ButtonTransferOKClick;
        public Transfer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.ButtonCancelClick != null)
                this.ButtonCancelClick(this, e);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (this.ButtonTransferOKClick != null)
                this.ButtonTransferOKClick(this, e);
        }

        public void refresh()
        {
            label1.Text = Properties.strings.benefic;
            label2.Text = Properties.strings.accountNumber;
            label3.Text = Properties.strings.amount;
            label4.Text = Properties.strings.purpose;
            label5.Text = Properties.strings.transfer;
            btnOK.Text = Properties.strings.confirm;
            btnCancel.Text = Properties.strings.cancel;
            label1.Refresh();
            label2.Refresh();
            label3.Refresh();
            label4.Refresh();
            label5.Refresh();
            btnCancel.Refresh();
            btnOK.Refresh();
        }

        public void refreshTB()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            tbBetrag.Text = "";
            tbName.Text = "";
            tbName1.Text = "";
            tbNummer.Text = "";
            textBox1.Refresh();
            textBox2.Refresh();
            textBox3.Refresh();
            tbBetrag.Refresh();
            tbNummer.Refresh();
            tbName.Refresh();
            tbName1.Refresh();
        }
    }
}
