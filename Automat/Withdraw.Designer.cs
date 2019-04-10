using System.Drawing;

namespace Automat
{
    partial class Withdraw
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbWithdraw = new Automat.NumberTextbox();
            this.btnWithdraw = new Automat.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw200 = new Automat.RoundedButton();
            this.btnWithdraw500 = new Automat.RoundedButton();
            this.btnWithdraw100 = new Automat.RoundedButton();
            this.btnWithdraw10 = new Automat.RoundedButton();
            this.btnWithdraw50 = new Automat.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Automat.RoundedButton();
            this.SuspendLayout();
            // 
            // tbWithdraw
            // 
            this.tbWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWithdraw.Location = new System.Drawing.Point(801, 581);
            this.tbWithdraw.Name = "tbWithdraw";
            this.tbWithdraw.ShortcutsEnabled = false;
            this.tbWithdraw.Size = new System.Drawing.Size(302, 44);
            this.tbWithdraw.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithdraw.Location = new System.Drawing.Point(801, 462);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(302, 85);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = Properties.strings.selected;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = Properties.strings.pick;
            // 
            // btnWithdraw200
            // 
            this.btnWithdraw200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnWithdraw200.FlatAppearance.BorderSize = 0;
            this.btnWithdraw200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw200.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw200.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithdraw200.Location = new System.Drawing.Point(801, 183);
            this.btnWithdraw200.Name = "btnWithdraw200";
            this.btnWithdraw200.Size = new System.Drawing.Size(302, 85);
            this.btnWithdraw200.TabIndex = 8;
            this.btnWithdraw200.Text = "200€";
            this.btnWithdraw200.UseVisualStyleBackColor = true;
            this.btnWithdraw200.Click += new System.EventHandler(this.BtnWithdraw200_Click);
            // 
            // btnWithdraw500
            // 
            this.btnWithdraw500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnWithdraw500.FlatAppearance.BorderSize = 0;
            this.btnWithdraw500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw500.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw500.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithdraw500.Location = new System.Drawing.Point(801, 320);
            this.btnWithdraw500.Name = "btnWithdraw500";
            this.btnWithdraw500.Size = new System.Drawing.Size(302, 85);
            this.btnWithdraw500.TabIndex = 7;
            this.btnWithdraw500.Text = "500€";
            this.btnWithdraw500.UseVisualStyleBackColor = true;
            this.btnWithdraw500.Click += new System.EventHandler(this.BtnWithdraw500_Click);
            // 
            // btnWithdraw100
            // 
            this.btnWithdraw100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnWithdraw100.FlatAppearance.BorderSize = 0;
            this.btnWithdraw100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw100.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw100.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithdraw100.Location = new System.Drawing.Point(159, 413);
            this.btnWithdraw100.Name = "btnWithdraw100";
            this.btnWithdraw100.Size = new System.Drawing.Size(302, 85);
            this.btnWithdraw100.TabIndex = 6;
            this.btnWithdraw100.Text = "100€";
            this.btnWithdraw100.UseVisualStyleBackColor = true;
            this.btnWithdraw100.Click += new System.EventHandler(this.BtnWithdraw100_Click);
            // 
            // btnWithdraw10
            // 
            this.btnWithdraw10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnWithdraw10.FlatAppearance.BorderSize = 0;
            this.btnWithdraw10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithdraw10.Location = new System.Drawing.Point(159, 183);
            this.btnWithdraw10.Name = "btnWithdraw10";
            this.btnWithdraw10.Size = new System.Drawing.Size(302, 85);
            this.btnWithdraw10.TabIndex = 5;
            this.btnWithdraw10.Text = "10€";
            this.btnWithdraw10.UseVisualStyleBackColor = true;
            this.btnWithdraw10.Click += new System.EventHandler(this.BtnWithdraw10_Click);
            // 
            // btnWithdraw50
            // 
            this.btnWithdraw50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnWithdraw50.FlatAppearance.BorderSize = 0;
            this.btnWithdraw50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw50.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw50.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWithdraw50.Location = new System.Drawing.Point(159, 293);
            this.btnWithdraw50.Name = "btnWithdraw50";
            this.btnWithdraw50.Size = new System.Drawing.Size(302, 85);
            this.btnWithdraw50.TabIndex = 4;
            this.btnWithdraw50.Text = "50€";
            this.btnWithdraw50.UseVisualStyleBackColor = true;
            this.btnWithdraw50.Click += new System.EventHandler(this.BtnWithdraw50_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = Properties.strings.notes;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(160)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(28, 629);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 72);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = Properties.strings.cancel;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWithdraw200);
            this.Controls.Add(this.btnWithdraw500);
            this.Controls.Add(this.btnWithdraw100);
            this.Controls.Add(this.btnWithdraw10);
            this.Controls.Add(this.btnWithdraw50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.tbWithdraw);
            this.Name = "Withdraw";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberTextbox tbWithdraw;
        private RoundedButton btnWithdraw;
        private System.Windows.Forms.Label label1;
        private RoundedButton btnWithdraw50;
        private RoundedButton btnWithdraw10;
        private RoundedButton btnWithdraw100;
        private RoundedButton btnWithdraw500;
        private RoundedButton btnWithdraw200;
        private System.Windows.Forms.Label label2;
        private RoundedButton btnCancel;
    }
}
