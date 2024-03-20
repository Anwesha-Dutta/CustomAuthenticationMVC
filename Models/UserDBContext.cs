using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthenticationinMVC.Models
{
    internal class UserDBContext : IDisposable
    {
        public IQueryable<USERS> USERS { get; set; } // Change the type to IQueryable<USER> assuming USER is your user entity class

        // Add a constructor to initialize USERS property
        public UserDBContext()
        {
            // Initialize USERS with some data or query from database
            USERS = GetUsers(); // You need to implement GetUsers method to return user data from the database
        }

        private IQueryable<USERS> GetUsers()
        {
            throw new NotImplementedException();
        }

        // Dispose method to release resources if needed
        public void Dispose()
        {
            // Dispose any resources here if needed
        }
    }
}
