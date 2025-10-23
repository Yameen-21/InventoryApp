using System.Security.Cryptography;
using System.Text;

namespace InventoryApp.Services
{
    public class SimpleAuthService
    {
        // Wrapper to satisfy callers looking for HashPassword
        public string HashPassword(string password) => ComputeSha256(password);

        public bool VerifyPassword(string input, string storedHash)
        {
            var inputHash = ComputeSha256(input);
            return inputHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        }

        public string ComputeSha256(string input)
        {
            // CA1850 suggests using HashData; this version is universally compatible
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
        }
    }
}
