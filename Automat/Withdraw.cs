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
    public partial class Withdraw : UserControl
    {
        public double money;
        public event EventHandler ButtonClick;
        public event EventHandler ButtonClickCancel;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            String moneyString = btnWithdraw.Text;
            try
            {
                money = Convert.ToDouble(moneyString);
                if (money < 0 && money > 10000 )
                {
                    if (money % 0.01 != 0) {

                        if (this.ButtonClick != null)
                            this.ButtonClick(this, e);
                    }
                }                    
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Withdraw FormatException", ex);
            }


            
        }

        private void BtnWithdraw10_Click(object sender, EventArgs e)
        {
            money = 10;
            
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void BtnWithdraw50_Click(object sender, EventArgs e)
        {
            money = 50;
        
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void BtnWithdraw100_Click(object sender, EventArgs e)
        {
            money = 100;
           
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void BtnWithdraw200_Click(object sender, EventArgs e)
        {
            money = 200;
            
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void BtnWithdraw500_Click(object sender, EventArgs e)
        {
            money = 500;
           
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
            btnCancel.Text = Properties.strings.cancel;
            btnCancel.Refresh();
            btnWithdraw.Text = Properties.strings.selected;
            btnWithdraw.Refresh();
            label1.Text = Properties.strings.pick;
            label1.Refresh();
            label2.Text = Properties.strings.notes;
            label2.Refresh();
        }

        public void refreshTB()
        {
            tbWithdraw.Text = "";
            tbWithdraw.Refresh();
        }
    }
}
