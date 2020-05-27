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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HidePassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = HidePassword.Checked ? '\0' : '*';
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //login();
            }
            catch (FailedLogin)
            {
                // new FailedLoginWindow();
                return;
            }

            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
