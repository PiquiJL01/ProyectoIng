using System;

namespace Engine
{
    public class User
    {
        public string UserName { get; set; }
        private string Password { get; set; }
        public UserType Type { get; set; }

        public User(string userName, string password, UserType type)
        {
            UserName = userName;
            Password = password;
            Type = type;
        }

        public bool ValidatePassword(string PasswordToValidate)
        {
            if (Password == PasswordToValidate)
            {
                return true;
            }

            throw new FailedLogin();
        }
    }

    public enum UserType
    {
        Owner,
        Supervisor,
        Manager
    }
}
