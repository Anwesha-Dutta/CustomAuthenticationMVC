using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomAuthenticationinMVC.Models;
using CustomAuthenticationinMVC.DAL;
using System.Web.Security;

namespace CustomAuthenticationinMVC.Models
{
    public class Repository
    {
        public USERS GetUserDetails(string UserName, string Password)
        {
            USERS user = new USERS();
            using (UserDBContext db = new UserDBContext())
            {
                user = db.USERS.FirstOrDefault(u => u.UserName.ToLower() == UserName.ToLower() && u.Password == Password);
            }
            return user;
        }

        internal USER GetUserDetails(object userName, object password)
        {
            throw new NotImplementedException();
        }
    }
}