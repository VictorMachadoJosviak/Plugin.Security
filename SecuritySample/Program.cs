using Plugin.Security.Core;
using System;

namespace SecuritySample
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordEncoder encoder = new PasswordEncoder();

            var user = "name@example.com";
            var pwd = "#brasil@01";
            var salt = encoder.DefaultSalt[36];
            
            var result = encoder.Encode(salt + user + pwd);

            Console.WriteLine(result);            
            Console.ReadKey();
        }
    }
}
