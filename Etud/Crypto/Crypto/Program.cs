using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            // generate a 128-bit salt using a secure PRNG
            byte[] salt = Encoding.UTF8.GetBytes("turkcellgelecegiyazanlar");
           
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");
            Console.ReadLine();
        }
    }
}
