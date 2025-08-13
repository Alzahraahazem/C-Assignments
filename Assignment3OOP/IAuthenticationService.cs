using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser();

        bool AuthorizeUser();
    }
}
