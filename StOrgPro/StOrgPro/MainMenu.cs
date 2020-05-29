using Engine;
using StOrgPro.Users;
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
            setMenu();
        }

        private void setMenu()
        {
            if (!user.PermitUserManagement)
            {
                BtnUser.Text = "Gestion de Usuario";
            }

            if (!user.PermitStoragesManagement)
            {
                BtnStorage.Enabled = false;
            }

            if (!user.PermitCatalogManagement)
            {
                BtnCatalog.Enabled = false;
            }

            if (!user.PermitInventoryManagement)
            {
                BtnInventary.Enabled = false;
            }

            if (!user.PermitHistoryViewer)
            {
                BtnHiistory.Enabled = false;
            }
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (user.PermitUserManagement)
            {
                UsersMenu usersMenu = new UsersMenu();
                usersMenu.ShowDialog();
            }
            else
            {
                ManageMyUser manageMyUser = new ManageMyUser();
                manageMyUser.ShowDialog();
            }
            this.Show();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoragesMenu storagesMenu = new StoragesMenu();
            storagesMenu.ShowDialog();
            this.Show();
        }

        private void BtnCatalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogMenu catalogMenu = new CatalogMenu();
            catalogMenu.ShowDialog();
            this.Show();
        }

        private void BtnInventary_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryMenu inventoryMenu = new InventoryMenu();
            inventoryMenu.ShowDialog();
            this.Show();
        }
    }
}
