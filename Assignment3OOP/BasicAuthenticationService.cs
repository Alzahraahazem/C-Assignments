using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP
{

    internal class BasicAuthenticationService: IAuthenticationService
    {
       
        public string username {  get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public BasicAuthenticationService(string u, string p, string r) {
             username = u;
            password = p;
            role = r;
        }
        public bool AuthenticateUser() {
            return username == "admin" && password == "1234";
         
        }

        public bool AuthorizeUser() {
            return username == "admin" && role == "Administrator";
        }
    }
}
