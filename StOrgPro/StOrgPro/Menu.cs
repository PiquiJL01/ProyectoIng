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
    public partial class Menu : Form
    {
        private User user;

        public Menu(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
        }

        private void Menu_Load(object sender, System.EventHandler e)
        {
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
    }
}
