using System;
using System.Security.Cryptography;

public static class PasswordHelper
{
    public static void CreatePasswordHash(string password,
        out string hash,
        out string salt)
    {
        using (var pbkdf2 = new Rfc2898DeriveBytes(password, 16, 10000))
        {
            salt = Convert.ToBase64String(pbkdf2.Salt);
            hash = Convert.ToBase64String(pbkdf2.GetBytes(20));
        }
    }

    public static bool VerifyPassword(string password,
        string storedHash,
        string storedSalt)
    {
        byte[] saltBytes = Convert.FromBase64String(storedSalt);

        using (var pbkdf2 =
            new Rfc2898DeriveBytes(password, saltBytes, 10000))
        {
            string newHash =
                Convert.ToBase64String(pbkdf2.GetBytes(20));

            return newHash == storedHash;
        }
    }
}
