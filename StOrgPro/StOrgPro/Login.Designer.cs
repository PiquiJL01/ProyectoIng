namespace StOrgPro
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalirBtn = new System.Windows.Forms.Button();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.HidePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SalirBtn.Location = new System.Drawing.Point(147, 147);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(80, 25);
            this.SalirBtn.TabIndex = 0;
            this.SalirBtn.Text = "Exit";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserText
            // 
            this.UserText.AcceptsTab = true;
            this.UserText.Location = new System.Drawing.Point(91, 27);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(137, 20);
            this.UserText.TabIndex = 2;
            this.UserText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(91, 62);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(137, 20);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(26, 29);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(43, 13);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "Usuario";
            this.UserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(147, 113);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(80, 25);
            this.AceptarBtn.TabIndex = 5;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(25, 62);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // HidePassword
            // 
            this.HidePassword.AutoSize = true;
            this.HidePassword.Location = new System.Drawing.Point(91, 91);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(110, 17);
            this.HidePassword.TabIndex = 7;
            this.HidePassword.Text = "Mostrar Password";
            this.HidePassword.UseVisualStyleBackColor = true;
            this.HidePassword.CheckedChanged += new System.EventHandler(this.HidePassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SalirBtn;
            this.ClientSize = new System.Drawing.Size(241, 202);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.SalirBtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox HidePassword;
    }
}

