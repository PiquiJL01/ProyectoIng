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

        public User(string userName, string password, bool permitUserManagement = false,
            bool permitCatalogManagement = false, bool permitInventoryManagement = false, bool permitStoragesManagement = false)
        {
            UserName = userName;
            Password = password;
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
