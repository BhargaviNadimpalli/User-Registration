using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class Registration
    {
        public void Check(string phNumber)
        {
            string pattern = @"^[1 - 9]{2}\s[1 - 9][0 - 9]{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(phNumber))
            {
                Console.WriteLine("{0} is Valid ", phNumber);
            }
            else
            {
                Console.WriteLine("{0} is Invalid", phNumber);
            }
        }
    }
}
