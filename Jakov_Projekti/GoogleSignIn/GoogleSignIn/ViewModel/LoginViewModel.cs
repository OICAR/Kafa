using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleSignIn.ViewModel
{
    public class LoginViewModel
    {



        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogin { get; set; }


    }
}
