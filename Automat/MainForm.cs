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
using System.Timers;
using System.Windows.Forms;
using FunBankLib;

namespace Automat
{
    public partial class Form1 : Form
    {
        private String loginPasswort;
        private String loginName;
        private int zustand;
        private double balance;
        static string baseUrl = Properties.Settings.Default.baseUrl;
        protected FunBankLib.Models.ATM atm;
        AccountClient accountClient;
        FunBankLib.Models.Account account;


        System.Timers.Timer timer;


        public Form1(FunBankLib.Models.ATM atm)
        {
            this.atm = atm;
            InitializeComponent();
        }

        private void balance1_Load(object sender, EventArgs e)
        {
            zustand = 0;
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
            timer = new System.Timers.Timer();
        }

        protected void Login_ButtonClick(object sender, EventArgs e)
        {
            loginName = login1.tbLogin.Text;
            loginPasswort = login1.tbLoginPasswort.Text;          

            new Task(async () =>
        {
            accountClient = new AccountClient(baseUrl);
            account = await accountClient.Login(loginName, loginPasswort);

            if (account != null)
            {
                balance = account.Balance;
                balance = balance / 100;
                if (!loginName.Equals("") && !loginPasswort.Equals(""))

                {
                    InvokeIfRequired(() =>
                    {
                        startTimer();
                        zustand = 1;
                        login1.Hide();
                        konto1.Show(); 
                        login1.lbLogin.Text = "";
                        login1.refreshTB();
                        login1.Refresh();
                        Application.DoEvents();
                    });
                }
                else
                {
                    login1.lbLogin.Text = "Leerer Anmeldename!";
                }
            }
        }).Start();

        }
        protected void KontoCancel_ButtonClick(object sender, EventArgs e)
        {
            timer.Stop();
            zustand = 0;
            konto1.Hide();
            login1.Show();
        }
        protected void KontoBalance_ButtonClick(object sender, EventArgs e)
        {
            balance1.lbBalance.Text = Convert.ToString(balance);
            restartTimer();
            zustand = 2;
            konto1.Hide();
            balance1.Show();
        }
        protected void KontoBalanceClose_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            zustand = 1;
            balance1.Hide();
            konto1.Show();
        }
        protected void KontoDeposit_ButtonClick(object sender, EventArgs e)
        {
            
            restartTimer();
            zustand = 3;
            konto1.Hide();
            deposit1.Show();
        }
        protected void KontoDepositClose_ButtonClick(object sender, EventArgs e)
        {
         

            restartTimer();
            double money;
            String deposit = deposit1.tbDeposit.Text;
            Regex regex = new Regex(@"^[0-9]{2,4}(,[0-9]{2})?$");
            Match match = Regex.Match(deposit, @"^[0-9]{1,4}(,[0-9]{2})?$");
            if (match.Success)
            {

                try
                {

                    money = Convert.ToDouble(match.Value);
                    int moneyAccount = Convert.ToInt32(money * 100);

                    int s200 = moneyAccount / 20000;
                    moneyAccount = moneyAccount % 20000;

                    int s100 = moneyAccount / 10000;
                    moneyAccount = moneyAccount % 10000;

                    int s50 = moneyAccount / 5000;
                    moneyAccount = moneyAccount % 5000;

                    int s20 = moneyAccount / 2000;
                    moneyAccount = moneyAccount % 2000;

                    int s10 = moneyAccount / 1000;
                    moneyAccount = moneyAccount % 1000;

                    int s5 = moneyAccount / 500;
                    moneyAccount = moneyAccount % 500;

                    int s2 = moneyAccount / 200;
                    moneyAccount = moneyAccount % 200;

                    int s1 = moneyAccount / 100;
                    moneyAccount = moneyAccount % 100;

                    int s050 = moneyAccount / 50;
                    moneyAccount = moneyAccount % 50;

                    int s020 = moneyAccount / 20;
                    moneyAccount = moneyAccount % 20;

                    int s010 = moneyAccount / 10;
                    moneyAccount = moneyAccount % 10;

                    int s05 = moneyAccount / 5;
                    moneyAccount = moneyAccount % 5;

                    int s02 = moneyAccount / 2;
                    moneyAccount = moneyAccount % 2;

                    int s01 = moneyAccount / 1;
                    moneyAccount = moneyAccount % 1;

                    new Task(async () =>
                    {
                    
                            account = await accountClient.Deposit(account, atm, new FunBankLib.Models.ATMInventory()
                            {
                                FiftyEuro = s50,
                                FifyCents = s050,
                                FiveEuro = s5,
                                OneCent = s01,
                                OneEuro = s1,
                                OneHundredEuro = s100,
                                TenCents = s010,
                                TwoCents = s02,
                                FiveCents = s05,
                                TenEuro = s10,
                                TwentyEuro = s20,
                                TwentyCents = s020,
                                TwoEuro = s2,
                                TwoHundredEuro = s200
                            });

                            if (account != null)
                            {
                                InvokeIfRequired(() =>
                                {
                                    balance = account.Balance;
                                    balance = balance / 100;
                                    zustand = 1;
                                    deposit1.Hide();
                                    konto1.Show();
                                    deposit1.refreshTB();
                                    deposit1.Refresh();
                                    Application.DoEvents();
                                });
                            }
                        
                    }).Start();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Withdraw FormatException", ex);
                }

            }
                
            
        }

        protected void KontoDepositCloseCancel_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            zustand = 1;
            deposit1.Hide();
            konto1.Show();
            deposit1.refreshTB();
            deposit1.Refresh();
            Application.DoEvents();
        }
        protected void KontoLanguage_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (currentCulture.ToString().Equals("de-DE") || currentCulture.ToString().Equals("de"))
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
            restartTimer();
            zustand = 4;
            konto1.Hide();
            withdraw1.Show();

        }
        protected void KontoWithDrawClose_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            double eingabe = withdraw1.money;
            long eingabeLong = (long)eingabe*100;

            new Task(async () =>
            {

                var inv = await accountClient.Withdraw(account,atm,eingabeLong);               
                 
                if (inv != null)
                {
                    InvokeIfRequired(() =>
                    {
                        zustand = 1;
                        withdraw1.Hide();
                        konto1.Show();
                        withdraw1.refreshTB();
                        withdraw1.Refresh();
                        Application.DoEvents();
                    });
                }

            }).Start();
        }
    protected void KontoWithDrawCloseCancel_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            zustand = 1;
            withdraw1.Hide();
            konto1.Show();
            withdraw1.refreshTB();
            withdraw1.Refresh();
            Application.DoEvents();
        }

        protected void KontoTransfer_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            zustand = 5;
            konto1.Hide();
            transfer1.Show();
        }

        protected void KontoTransferOK_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            String beneficiary = transfer1.tbName.Text;
            String number = transfer1.tbNummer.Text;
            String moneyString = transfer1.tbBetrag.Text;

            try
            {
                double money = Convert.ToDouble(moneyString);
                if (money > 0.01)
                {
                    zustand = 1;
                    money = money * 100;
                    transfer1.Hide();
                    konto1.Show();
                    transfer1.refreshTB();
                    transfer1.Refresh();
                    Application.DoEvents();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Withdraw FormatException", ex);
            }


        }
        protected void KontoTransferClose_ButtonClick(object sender, EventArgs e)
        {
            restartTimer();
            zustand = 1;
            transfer1.Hide();
            konto1.Show();
            transfer1.refreshTB();
            transfer1.Refresh();
            Application.DoEvents();
        }

        protected void startTimer()
        {

            timer.Interval = 60000;  //60 seconds in milliseconds
            timer.Elapsed += OnTimedEvent;
            timer.Start();
        }

        protected void InvokeIfRequired(Action a)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() =>
                {
                    a.Invoke();
                }));
            }
            else
            {
                a.Invoke();
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            InvokeIfRequired(() =>
            {
                switch (zustand)
                {
                    case 0:
                        timer.Stop();
                        break;
                    case 1:
                        login1.Show();
                        konto1.Hide();
                        zustand = 0;
                        break;
                    case 2:
                        balance1.Hide();
                        login1.Show();
                        zustand = 0;
                        break;
                    case 3:
                        deposit1.Hide();
                        login1.Show();
                        deposit1.refreshTB();
                        deposit1.Refresh();
                        Application.DoEvents();
                        zustand = 0;
                        break;
                    case 4:
                        withdraw1.Hide();
                        login1.Show();
                        withdraw1.refreshTB();
                        withdraw1.Refresh();
                        Application.DoEvents();
                        zustand = 0;
                        break;
                    case 5:
                        transfer1.Hide();
                        login1.Show();
                        transfer1.refreshTB();
                        transfer1.Refresh();
                        Application.DoEvents();
                        zustand = 0;
                        break;
                }
            });
        }
        private void restartTimer()
        {

            timer.Stop();
            timer.Start();
        }
    }
}
