using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLandScape
{
    class User
    {
        public User(string name, string surname, string email, string password)
        {
            string u_name = name;
            string u_surname = surname;
            string u_email = email;
            string u_password = password;
            int u_access_level = 1;
        }

        public string generateHashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000000); // change number to variable
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            
            return savedPasswordHash;
        }

        public bool decodeHashPassword(string userHashedPassword, string user_password)
        {
            byte[] hashBytes = Convert.FromBase64String(userHashedPassword);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(user_password, salt, 10000000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    throw new UnauthorizedAccessException();
                    return false;
        }
        
        public void registerUser()
        {

        }

        public bool logInUser()
        {
            return true;
        }
    }
    internal class UserControlSystem
    {
        /*
        // Poczytać o dziedziczeniu, klasy muszą dziedziczyć elementy user'a
        // Zrobić bazę danych na userów
        public class Worker : User
        {
            
        }

        public class Manager : User
        {

        }

        public class Chef : User
        {

        }
        */
    }
}
