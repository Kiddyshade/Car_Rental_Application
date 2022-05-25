using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public static class Utils
    {
        public static bool FormisOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            var IsOpen = OpenForms.Any(q => q.Name == name);
            return IsOpen;
        }

        public static string hashed_password(string password)
        {
            SHA256 sha = SHA256.Create(); // Algorithm for encryption.
                                          //convert input string into byte array and the compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //create a new stringbuilder to collect the above bytes and create a string
            StringBuilder sBuilder = new StringBuilder();

            //Loop through  each byte of the hashed data and format each one as hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            //Return the Encrypted password hashed_password()
            return sBuilder.ToString();//convert the Byte array to string and return to function itself
            
        }



        public static string DefaultHashed_password()
        {
            SHA256 sha = SHA256.Create(); // Algorithm for encryption.
                                          //convert input string into byte array and the compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("password@123"));

            //create a new stringbuilder to collect the above bytes and create a string
            StringBuilder sBuilder = new StringBuilder();

            //Loop through  each byte of the hashed data and format each one as hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            //Return the Encrypted password hashed_password()
            return sBuilder.ToString();//convert the Byte array to string and return to function itself

        }
    }
}
