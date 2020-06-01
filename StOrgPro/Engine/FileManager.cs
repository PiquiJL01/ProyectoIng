using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Data.SqlClient;


namespace Engine
{
    public class FileManager
    {
        SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Integrated Security = True; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=False");

        public User Login(string name, string password)
        {
            User user;
            if (name == "admin")
            {
                user = new User(name, "admin", true, true, true, true, true);
                user.ValidatePassword(password);
            }
            else if (name == "super")
            {
                user = new User(name, "super", false, true, false, true, true);
                user.ValidatePassword("super");
            }
            else if (name == "manager")
            {
                user = new User(name, "manager", false, false, true, true, false);
                user.ValidatePassword("manager");
                user.PermitUserManagement = false;
                user.PermitStoragesManagement = true;
                user.PermitCatalogManagement = false;
                user.PermitInventoryManagement = true;
                user.PermitHistoryViewer = false;
            }
            else
            {
                throw new FailedLogin();
            }

            return user;
        }


    }
}
