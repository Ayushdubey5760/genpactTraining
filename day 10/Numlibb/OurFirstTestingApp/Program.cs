using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace OurFirstTestingApp
{
    public class UserLogin
    {
        public static string Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "PLease enter username and password first";
            }
            else
            {
                if((username == "sam1256") && (password == "321@Ayu")) {
                    return "Login Success";
                }
                else { return "Login Failed, Invalid Credential"; }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
