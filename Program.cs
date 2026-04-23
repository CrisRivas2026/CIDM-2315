using System.ComponentModel;
using System.Dynamic;

namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---CIDM2315 Final Project: Cristian Rivas---");
        Console.WriteLine("---Welcome to Buff Hotel---");
        
        CheckAccount();



    }

    static void CheckAccount()
    {
        Console.WriteLine("-->Please input username: ");
        string username = Console.ReadLine();
        Console.WriteLine("-->Please input password: ");
        string password = Console.ReadLine();

        if (username == "alice")
        {
            if (password == "alice123")
            {
                Console.WriteLine("-->Login Successfully");
            }
            else
            {
                Console.WriteLine("Wrong Username/Password");
            }
            
        }
        
        else
        {
            Console.WriteLine("Wrong Username/Password");
        }
    

    }
}
