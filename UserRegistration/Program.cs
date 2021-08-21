
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration programs");
            
            Registration user = new Registration();
            Console.Write("Enter your mail id : ");
            string mailId = Console.ReadLine();
            user.Check(mailId);
        }
    }
}
