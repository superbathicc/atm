using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunBankLib;

namespace Automat
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string baseUrl = Properties.Settings.Default.baseUrl;
            string id = Properties.Settings.Default.id;
            string pw = Properties.Settings.Default.pw;

            var mre = new ManualResetEvent(false);

            new Task(async () =>
            {
                ATMClient atmClient = new ATMClient(baseUrl);
                var atm = await atmClient.Login(id, pw);

                if(atm != null)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    var f1 = new Form1(atm);
                    Application.Run(f1);
                    f1.FormClosed += new FormClosedEventHandler((sender, e) =>
                    {
                        mre.Set();
                    });
                }
            }).Start();

            mre.WaitOne();

        }
    }
}
