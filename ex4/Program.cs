using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username;
            Console.WriteLine("Enter the user name : ");
            username = Console.ReadLine();
            if(username.Length >=6 ) {
                Console.WriteLine("Welcome " + username);
            }
            else
            {
                Console.WriteLine("Invalid user name");
            }
            Console.ReadKey();

        }
    }
}
