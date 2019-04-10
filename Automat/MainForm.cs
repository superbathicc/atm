using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat
{
    public partial class Form1 : Form
    {
        private String loginPasswort;
        private String loginName;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void balance1_Load(object sender, EventArgs e)
        {
            withdraw1.Hide();
            transfer1.Hide();
            deposit1.Hide();
            konto1.Hide();
            balance1.Hide();
            login1.ButtonClick += new EventHandler(Login_ButtonClick);
            konto1.ButtonCancelClick += new EventHandler(KontoCancel_ButtonClick);
            konto1.ButtonBalanceClick += new EventHandler(KontoBalance_ButtonClick);
            konto1.ButtonDepositClick += new EventHandler(KontoDeposit_ButtonClick);
            konto1.ButtonWithDrawClick += new EventHandler(KontoWithDraw_ButtonClick);
            konto1.ButtonTransferClick += new EventHandler(KontoTransfer_ButtonClick);
            konto1.ButtonLanguageClick += new EventHandler(KontoLanguage_ButtonClick);
            balance1.ButtonClick += new EventHandler(KontoBalanceClose_ButtonClick);
            deposit1.ButtonClick += new EventHandler(KontoDepositClose_ButtonClick);
            deposit1.ButtonClickCancel += new EventHandler(KontoDepositCloseCancel_ButtonClick);
            withdraw1.ButtonClick += new EventHandler(KontoWithDrawClose_ButtonClick);
            withdraw1.ButtonClickCancel += new EventHandler(KontoWithDrawCloseCancel_ButtonClick);
            transfer1.ButtonCancelClick += new EventHandler(KontoTransferClose_ButtonClick);
            transfer1.ButtonTransferOKClick += new EventHandler(KontoTransferOK_ButtonClick);

        }

        protected void Login_ButtonClick(object sender, EventArgs e)
        {
            loginName = login1.tbLogin.Text;
            loginPasswort = login1.tbLoginPasswort.Text;
            if (!loginName.Equals("")&&!loginPasswort.Equals(""))
            {
                login1.Hide();
                konto1.Show();
                login1.lbLogin.Text = "";
                login1.refreshTB();
                login1.Refresh();
                Application.DoEvents();
            }
            else
            {
                login1.lbLogin.Text = "Leerer Anmeldename!";
            }
        }
        protected void KontoCancel_ButtonClick(object sender, EventArgs e)
        {

            konto1.Hide();
            login1.Show();
        }
        protected void KontoBalance_ButtonClick(object sender, EventArgs e)
        {

            konto1.Hide();
            balance1.Show();
            
        }
        protected void KontoBalanceClose_ButtonClick(object sender, EventArgs e)
        {
            balance1.Hide();
            konto1.Show();
        }
        protected void KontoDeposit_ButtonClick(object sender, EventArgs e)
        {
            konto1.Hide();
            deposit1.Show();
        }
        protected void KontoDepositClose_ButtonClick(object sender, EventArgs e)
        {
            double money;
            String deposit = deposit1.tbDeposit.Text;
            Regex regex = new Regex(@"^[0-9]{2,4}(,[0-9]{2})?$");
            Match match = Regex.Match(deposit, @"^[0-9]{1,4}(,[0-9]{2})?$");
            if (match.Success)
            {
                
                try
                {
                    money = Convert.ToDouble(match.Value);
                    deposit1.Hide();
                    konto1.Show();
                    deposit1.refreshTB();
                    deposit1.Refresh();
                    Application.DoEvents();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Withdraw FormatException", ex);
                }

            }
        }

        protected void KontoDepositCloseCancel_ButtonClick(object sender, EventArgs e)
        {
            deposit1.Hide();
            konto1.Show();
            deposit1.refreshTB();
            deposit1.Refresh();
            Application.DoEvents();
        }
        protected void KontoLanguage_ButtonClick(object sender, EventArgs e)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (currentCulture.ToString().Equals("de-DE")|| currentCulture.ToString().Equals("de"))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de");
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de");
            }
            CultureInfo currentCulture2 = Thread.CurrentThread.CurrentCulture;
            konto1.refresh();
            withdraw1.refresh();
            balance1.refresh();
            deposit1.refresh();
            transfer1.refresh();
            konto1.Refresh();
            withdraw1.Refresh();
            balance1.Refresh();
            deposit1.Refresh();
            transfer1.Refresh();
            Application.DoEvents();

        }

        protected void KontoWithDraw_ButtonClick(object sender, EventArgs e)
        {

            konto1.Hide();
            withdraw1.Show();  
            
        }
        protected void KontoWithDrawClose_ButtonClick(object sender, EventArgs e)
        {
            int eingabe = withdraw1.money;
           
            int s200 = eingabe / 200;
            eingabe = eingabe % 200;

            int s100 = eingabe / 100;
            eingabe = eingabe % 100;

            int s50 = eingabe / 50;
            eingabe = eingabe % 50;

            int s20 = eingabe / 20;
            eingabe = eingabe % 20;

            int s10 = eingabe / 10;
            eingabe = eingabe % 10;

            int s5 = eingabe / 5;


            withdraw1.Hide();
            konto1.Show();
            withdraw1.refreshTB();
            withdraw1.Refresh();
            Application.DoEvents();
        }
        protected void KontoWithDrawCloseCancel_ButtonClick(object sender, EventArgs e)
        {
            withdraw1.Hide();
            konto1.Show();
            withdraw1.refreshTB();
            withdraw1.Refresh();
            Application.DoEvents();
        }

        protected void KontoTransfer_ButtonClick(object sender, EventArgs e)
        {
            konto1.Hide();
            transfer1.Show();
        }

        protected void KontoTransferOK_ButtonClick(object sender, EventArgs e)
        {
            transfer1.Hide();
            konto1.Show();
            transfer1.refreshTB();
            transfer1.Refresh();
            Application.DoEvents();
        }
        protected void KontoTransferClose_ButtonClick(object sender, EventArgs e)
        {
            transfer1.Hide();
            konto1.Show();
            transfer1.refreshTB();
            transfer1.Refresh();
            Application.DoEvents();
        }
    }
}
