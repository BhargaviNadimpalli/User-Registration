
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration programs");
            
            Registration user = new Registration();
            Console.Write("Enter your phone number : ");
            string number = Console.ReadLine();
            user.Check(number);
        }
    }
}
