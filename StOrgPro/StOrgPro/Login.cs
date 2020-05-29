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
            User user = new User(UserText.Text, PasswordText.Text, UserType.LoginProfile);

            try
            {
                login(ref user);
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
            Menu menu = new Menu(user);
            menu.ShowDialog();
            this.Close();
        }

        private void login(ref User user) //test login for different user types
        {
            if (user.UserName == "admin")
            {
                user.ValidatePassword("admin");
                user.Type = UserType.Owner;
            }
            else if (user.UserName == "manager")
            {
                user.ValidatePassword("manager");
                user.Type = UserType.Supervisor;
            }
            else if (user.UserName == "user")
            {
                user.ValidatePassword("user");
                user.Type = UserType.Manager;
            }
            else
            {
                throw new FailedLogin();
            }
        }
    }
}
