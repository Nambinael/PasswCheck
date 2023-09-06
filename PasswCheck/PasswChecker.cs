using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswCheck
{
    public class PasswChecker
    {
        public int PasswordCheck(string password)
        {
            int result = 0;
            string NumPattern = @"\d";
            Regex rg = new Regex(NumPattern);
            string LowerCPattern = @"[a-z]";
            Regex rg1 = new Regex(LowerCPattern);
            string UpperCPattern = @"[A-Z]";
            Regex rg2 = new Regex(UpperCPattern);
            string SpecialCPattern = @"\W";
            Regex rg3 = new Regex(SpecialCPattern);

            string secret = password;
            
            if (secret.Length >= 7)
            {
                result += 1;
            }
            if (rg.IsMatch(secret))
            {
                result += 1;
            }
            if (rg1.IsMatch(secret))
            {
                result += 1;
            }
            if (rg2.IsMatch(secret))
            {
                result += 1;
            }
            if (rg3.IsMatch(secret))
            {
                result += 1;
            }
            return result;
        }
    }
}
