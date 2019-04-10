namespace Automat
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.withdraw1 = new Automat.Withdraw();
            this.transfer1 = new Automat.Transfer();
            this.login1 = new Automat.Login();
            this.konto1 = new Automat.Konto();
            this.deposit1 = new Automat.Deposit();
            this.balance1 = new Automat.Balance();
            this.SuspendLayout();
            // 
            // withdraw1
            // 
            this.withdraw1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.withdraw1.Location = new System.Drawing.Point(0, 0);
            this.withdraw1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.withdraw1.Name = "withdraw1";
            this.withdraw1.Size = new System.Drawing.Size(1280, 720);
            this.withdraw1.TabIndex = 0;
            // 
            // transfer1
            // 
            this.transfer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transfer1.Location = new System.Drawing.Point(0, 0);
            this.transfer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transfer1.Name = "transfer1";
            this.transfer1.Size = new System.Drawing.Size(1280, 720);
            this.transfer1.TabIndex = 1;
            // 
            // login1
            // 
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1280, 720);
            this.login1.TabIndex = 2;
            // 
            // konto1
            // 
            this.konto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.konto1.Location = new System.Drawing.Point(0, 0);
            this.konto1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.konto1.Name = "konto1";
            this.konto1.Size = new System.Drawing.Size(1280, 720);
            this.konto1.TabIndex = 3;
            // 
            // deposit1
            // 
            this.deposit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deposit1.Location = new System.Drawing.Point(0, 0);
            this.deposit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deposit1.Name = "deposit1";
            this.deposit1.Size = new System.Drawing.Size(1280, 720);
            this.deposit1.TabIndex = 4;
            // 
            // balance1
            // 
            this.balance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balance1.Location = new System.Drawing.Point(0, 0);
            this.balance1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balance1.Name = "balance1";
            this.balance1.Size = new System.Drawing.Size(1280, 720);
            this.balance1.TabIndex = 5;
            this.balance1.Load += new System.EventHandler(this.balance1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.balance1);
            this.Controls.Add(this.deposit1);
            this.Controls.Add(this.konto1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.transfer1);
            this.Controls.Add(this.withdraw1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Withdraw withdraw1;
        private Transfer transfer1;
        private Login login1;
        private Konto konto1;
        private Deposit deposit1;
        private Balance balance1;
    }
}

