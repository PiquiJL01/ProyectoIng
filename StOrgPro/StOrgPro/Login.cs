using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace StOrgPro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void HidePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = HidePassword.Checked ? '\0' : '*';
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            User user;

            try
            {
                FileManager fileManager = new FileManager();
                user = fileManager.Login(UserText.Text, PasswordText.Text);
            }
            catch (Exception error)
            {
                user = null;
                this.Hide();
                Error failedLogin = new Error(error);
                failedLogin.ShowDialog();
                UserText.Text = "";
                PasswordText.Text = "";
                this.Show();
                return;
            }

            this.Hide();
            MainMenu menu = new MainMenu(user);
            menu.ShowDialog();
            this.Close();
        }
    }
}
