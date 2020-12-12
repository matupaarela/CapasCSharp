using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Common.Helpers
{
    public static class Helpers
    {
        public static void NumberOnly(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static string SHA1(string password)
        {
            SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
            byte[] textOriginal = Encoding.Default.GetBytes(password);
            byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
