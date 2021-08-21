
using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration programs");
                   
            Registration user = new Registration();
            Console.Write("Enter your valid passward : ");
            string passward = Console.ReadLine();
            user.Check(passward);            
        }
    }
}
