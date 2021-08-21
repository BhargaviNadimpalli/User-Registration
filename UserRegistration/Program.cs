
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration programs");
            
            Registration user = new Registration();
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            user.Check(firstName);
        }
    }
}
