using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ProjectLandScape
{
    public class User
    {
        public string Name, Surname, Password, EMail;
        public int ACC_lvl;
        public User(string name, string surname, string email, string password, int acc_lvl)
        {
            Name = name;
            Surname = surname;
            EMail = email;
            Password = password;
            ACC_lvl = acc_lvl;
            
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
            var cs = "Host=localhost;Username=postgres;Password=malek";
            var con = new NpgsqlConnection(cs);
            
            con.Open();
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            //cmd.CommandText = @"";
            //cmd.ExecuteNonQuery();

            string user_password = generateHashPassword(Password);

            cmd.CommandText = @"INSERT INTO users (surname, name, email, password) VALUES (@Surname, @Name, @EMail, @user_password)"; // error: column surname does not exist???
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool logInUser()
        {
            var cs = "Host=localhost;Username=postgres;Password=malek";
            var con = new NpgsqlConnection(cs);

            con.Open();
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            //Read data from database where email == email given by user
            cmd.CommandText = @"";
            cmd.ExecuteNonQuery();
            con.Close();

            //Decode user password
            //string user_password = decodeHashPassword();

            //If password entered by user == password saved in db, return true and read all user data from db, else: return false

            return true;
        }

        public void database_creator()
        {
            /*
             * FUnction responsible only for creating test user database -> in main project will be replaced by Python Flask or Django user auth API
             */
            var cs = "Host=localhost;Username=postgres;Password=malek";
            var con = new NpgsqlConnection(cs);

            /*var m_createdb_cmd = new NpgsqlCommand(@"IF DATABASE userdb NOT FOUND
                                                        CREATE DATABASE userdb WITH OWNER = postgres ENCODING = 'UTF8' CONNECTION LIMIT = -1; 
                                                     END IF;", con);
            //var m_createdb_cmd = new NpgsqlCommand(@"CREATE DATABASE userdb", con);
            con.Open();
            m_createdb_cmd.ExecuteNonQuery();
            con.Close();*/

            con.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            //cmd.CommandText = @"CREATE TABLE users(userid SERIAL PRIMARY KEY, surname VARCHAR(255), name VARCHAR(255), email VARCHAR(255), password VARCHAR(255))";
            //cmd.ExecuteNonQuery();
            //con.Close();

            //cmd.CommandText = @"CREATE TABLE companies(companyid SERIAL PRIMARY KEY, companyname VARCHAR(255), companykey VARCHAR(255))";
            //cmd.ExecuteNonQuery();
            //con.Close();

            //cmd.CommandText = @"CREATE TABLE permissions(userid INT NOT NULL, companyid INT, permissionlvl INT, data VARCHAR(255), CONSTRAINT users FOREIGN KEY (userid) REFERENCES users(userid))";
            //cmd.ExecuteNonQuery();
            //con.Close();

        }
    }
    
}
