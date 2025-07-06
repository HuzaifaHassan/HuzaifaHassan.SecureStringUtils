using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuzaifaHassan.SecureStringUtils.MaskingExtensions
{
    public static class MaskingExtensions
    {
        public static string MaskCreditCard(this string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 4)
                return input;

            var masked = new string('*', input.Length - 4) + input[^4..];
            return masked;
        }

        public static string MaskEmail(this string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
                return email;

            var parts = email.Split('@');
            if (parts[0].Length <= 2)
                return "***@" + parts[1];

            return parts[0][0] + "***" + parts[0][^1] + "@" + parts[1];
        }
    }
}
