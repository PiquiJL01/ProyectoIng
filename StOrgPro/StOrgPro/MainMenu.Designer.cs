namespace StOrgPro
{
    partial class MainMenu
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
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnStorage = new System.Windows.Forms.Button();
            this.BtnCatalog = new System.Windows.Forms.Button();
            this.BtnInventary = new System.Windows.Forms.Button();
            this.BtnHiistory = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(39, 12);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(400, 52);
            this.BtnUser.TabIndex = 0;
            this.BtnUser.Text = "Gestion de Usuarios";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnStorage
            // 
            this.BtnStorage.Location = new System.Drawing.Point(39, 70);
            this.BtnStorage.Name = "BtnStorage";
            this.BtnStorage.Size = new System.Drawing.Size(400, 53);
            this.BtnStorage.TabIndex = 1;
            this.BtnStorage.Text = "Gestionar Almacenes";
            this.BtnStorage.UseVisualStyleBackColor = true;
            this.BtnStorage.Click += new System.EventHandler(this.BtnStorage_Click);
            // 
            // BtnCatalog
            // 
            this.BtnCatalog.Location = new System.Drawing.Point(39, 129);
            this.BtnCatalog.Name = "BtnCatalog";
            this.BtnCatalog.Size = new System.Drawing.Size(400, 51);
            this.BtnCatalog.TabIndex = 2;
            this.BtnCatalog.Text = "Gestionar Catalogo";
            this.BtnCatalog.UseVisualStyleBackColor = true;
            this.BtnCatalog.Click += new System.EventHandler(this.BtnCatalog_Click);
            // 
            // BtnInventary
            // 
            this.BtnInventary.Location = new System.Drawing.Point(39, 186);
            this.BtnInventary.Name = "BtnInventary";
            this.BtnInventary.Size = new System.Drawing.Size(400, 49);
            this.BtnInventary.TabIndex = 3;
            this.BtnInventary.Text = "Gestion de Inventario";
            this.BtnInventary.UseVisualStyleBackColor = true;
            this.BtnInventary.Click += new System.EventHandler(this.BtnInventary_Click);
            // 
            // BtnHiistory
            // 
            this.BtnHiistory.Location = new System.Drawing.Point(39, 241);
            this.BtnHiistory.Name = "BtnHiistory";
            this.BtnHiistory.Size = new System.Drawing.Size(400, 54);
            this.BtnHiistory.TabIndex = 4;
            this.BtnHiistory.Text = "Ver Historial";
            this.BtnHiistory.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(39, 301);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(399, 55);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 370);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHiistory);
            this.Controls.Add(this.BtnInventary);
            this.Controls.Add(this.BtnCatalog);
            this.Controls.Add(this.BtnStorage);
            this.Controls.Add(this.BtnUser);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnStorage;
        private System.Windows.Forms.Button BtnCatalog;
        private System.Windows.Forms.Button BtnInventary;
        private System.Windows.Forms.Button BtnHiistory;
        private System.Windows.Forms.Button BtnExit;
    }
}