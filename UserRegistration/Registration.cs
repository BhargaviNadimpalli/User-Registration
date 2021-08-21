using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class Registration
    {
        public void Check(string mail)
        {
            string pattern = @"^[a - z]{ 3} ([\# \+ _\.]*[a-zA-Z0-9])*@[a-zA-z]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("{0} is Valid ", mail);
            }
            else
            {
                Console.WriteLine("{0} is Invalid", mail);
            }
        }
    }
}
