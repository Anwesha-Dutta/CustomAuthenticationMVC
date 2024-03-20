using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthenticationinMVC.Models
{
    public class USERS
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}