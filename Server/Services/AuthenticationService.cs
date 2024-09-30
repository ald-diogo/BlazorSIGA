using System;

namespace BlazorSIGA.Server.Services
{
    public class AuthenticationService
    {
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            Console.WriteLine("Usuário deslogado com sucesso.");
        }
    }
}


