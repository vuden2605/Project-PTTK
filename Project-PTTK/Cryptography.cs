using System.Text;
using System.Security.Cryptography;

namespace Project_PTTK.Cryptography
{
    public class Cryptography
    {
        public Cryptography() { }
        public static string HashPassword(string password)
        {
            // Sử dụng SHA256 để băm mật khẩu
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Băm mật khẩu nhập vào và so sánh với mật khẩu đã băm
            string hashedInput = HashPassword(password);
            return hashedInput.Equals(hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
