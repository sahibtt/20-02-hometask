using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.Write("Username'i daxil edin: ");
            u.UserName = Console.ReadLine();
            Console.Write("Password'u daxil edin: ");
            u.Password = Console.ReadLine();
        }
    }
}
