namespace serwis_komputerowy
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHasło = new System.Windows.Forms.TextBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHasło = new System.Windows.Forms.Label();
            this.buttonPassReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 35);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxHasło
            // 
            this.textBoxHasło.Location = new System.Drawing.Point(15, 74);
            this.textBoxHasło.Name = "textBoxHasło";
            this.textBoxHasło.Size = new System.Drawing.Size(100, 20);
            this.textBoxHasło.TabIndex = 1;
            this.textBoxHasło.UseSystemPasswordChar = true;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Location = new System.Drawing.Point(63, 110);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(75, 23);
            this.buttonZaloguj.TabIndex = 2;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 19);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // labelHasło
            // 
            this.labelHasło.AutoSize = true;
            this.labelHasło.Location = new System.Drawing.Point(12, 58);
            this.labelHasło.Name = "labelHasło";
            this.labelHasło.Size = new System.Drawing.Size(36, 13);
            this.labelHasło.TabIndex = 4;
            this.labelHasło.Text = "Hasło";
            // 
            // buttonPassReset
            // 
            this.buttonPassReset.Location = new System.Drawing.Point(63, 140);
            this.buttonPassReset.Name = "buttonPassReset";
            this.buttonPassReset.Size = new System.Drawing.Size(75, 23);
            this.buttonPassReset.TabIndex = 5;
            this.buttonPassReset.Text = "Reset hasła";
            this.buttonPassReset.UseVisualStyleBackColor = true;
            this.buttonPassReset.Click += new System.EventHandler(this.buttonPassReset_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 198);
            this.Controls.Add(this.buttonPassReset);
            this.Controls.Add(this.labelHasło);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.textBoxHasło);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "loginForm";
            this.Text = "REP-AIR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHasło;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHasło;
        private System.Windows.Forms.Button buttonPassReset;
    }
}