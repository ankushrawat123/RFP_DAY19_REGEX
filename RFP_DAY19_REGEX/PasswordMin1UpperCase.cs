using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_DAY19_REGEX
{
    internal class PasswordMin1UpperCase
    {
        public String Regex_Pwd_1UpperCase = "^[A-z]+[A-Z a-z 0-9 $#@!&*?|]{7,}$";
        public bool PwdUpperCase(string PwdUpperCase)
        {
            return Regex.IsMatch(PwdUpperCase, Regex_Pwd_1UpperCase);
        }
    }
}
