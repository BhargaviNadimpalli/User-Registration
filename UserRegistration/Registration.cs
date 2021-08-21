using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class Registration
    {
        public void Check(string passward)
        {
            string pattern = @"^[a-zA-Z0-9]{8}[a-zA-Z0-9]*";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(passward))
            {
                Console.WriteLine("{0} is Valid ", passward);
            }
            else
            {
                Console.WriteLine("{0} is Invalid", passward);
            }
        }
    }
}
