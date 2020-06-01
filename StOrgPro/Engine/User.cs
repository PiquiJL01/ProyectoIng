using System;

namespace Engine
{
    public class User
    {
        public string UserName { get; set; }
        private string Password { get; set; }
        public bool PermitUserManagement { get; set; }
        public bool PermitCatalogManagement { get; set; }
        public bool PermitInventoryManagement { get; set; }
        public bool PermitStoragesManagement { get; set; }
        public bool PermitHistoryViewer { get; set; }

        public User(string userName, string password, bool permitUserManagement,
            bool permitCatalogManagement, bool permitInventoryManagement, 
            bool permitStoragesManagement, bool permitHistoryViewer)
        {
            UserName = userName;
            Password = password;
            PermitUserManagement = permitUserManagement;
            PermitCatalogManagement = permitCatalogManagement;
            PermitInventoryManagement = permitInventoryManagement;
            PermitStoragesManagement = permitStoragesManagement;
            PermitHistoryViewer = permitHistoryViewer; 
        }

        public void ValidatePassword(string PasswordToValidate)
        {
            if (!(Password == PasswordToValidate))
            {
                throw new FailedLogin();
            }
        }
    }
}
