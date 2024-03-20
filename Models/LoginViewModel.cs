using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthenticationinMVC.Models
{
    public class LoginViewModel
    {
        internal object Password;

        public object UserName { get; internal set; }
        public bool RememberMe { get; internal set; }
    }
}