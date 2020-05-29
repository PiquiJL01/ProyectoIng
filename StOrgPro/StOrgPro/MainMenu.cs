using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StOrgPro
{
    public partial class MainMenu : Form
    {
        private User user;

        public MainMenu(User CurrentUser)
        {
            InitializeComponent();
            user = CurrentUser;
            if (user.Type == UserType.Owner)
            {

            }
            else if (user.Type == UserType.Supervisor)
            {

            }
            else if (user.Type == UserType.Manager)
            {

            }
            else throw new WrongUserType();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersMenu menu = new UsersMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
