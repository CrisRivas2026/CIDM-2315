using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {


        //Q1
        Console.WriteLine("Input two numbers you want to compare");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        int A = Convert.ToInt32(a);
        int B = Convert.ToInt32(b);

        Console.WriteLine("You input {0}, {1}",A, B);
        
        Compare(A,B);
        


        //Q2
        Console.WriteLine("Input four numbers you want to compare");
        string c = Console.ReadLine();
        string d = Console.ReadLine();
        string e = Console.ReadLine();
        string f = Console.ReadLine();

        int C = Convert.ToInt16(c);
        int D = Convert.ToInt16(d);
        int E = Convert.ToInt16(e);
        int F = Convert.ToInt16(f);
        
        Console.WriteLine("You input {0}, {1}, {2}, and {3}",C, D, E, F);
       
        int max1 = Compare1(C,D);
        int max2 = Compare1(E,F);

        int max = Compare1(max1,max2); 

        Console.WriteLine("The largest number is {0}", max);      
       
       

       //Q3
       CreateAccount(); 

        

        



    

        
    }

    static void Compare(int A, int B)
    {
        if (A > B)
        {
            Console.WriteLine("The largest number is {0}", A);
        }

        else
        {
            Console.WriteLine("The largest number is {0}", B);
        }
    }

    static int Compare1(int C, int D)
    {
        if (C > D)
        {
            return C;
            Console.WriteLine("The largest number is {0}", C);
        }

        else
        {
            return D;
            Console.WriteLine("The largest number is {0}", D);
        }
    }

    static bool CheckAge(int birth_year)
    {
        int current_year = 2026;
        int age = current_year - birth_year;

        if(age >= 18)
        {
            return true;
        }
        else
        {
           return false;  
        }

    
    
    }
    
    static void CreateAccount()
    {
        Console.WriteLine("Input your username");
        string username = Console.ReadLine();

        Console.WriteLine("Input your password");
        string password = Console.ReadLine();
        
        Console.WriteLine("Input your password again");
        string password2 = Console.ReadLine();   

        Console.WriteLine("What year were you born in?");
        string by = Console.ReadLine();
        int birth_year = Convert.ToInt32(by);
        
        
        bool checkAge = CheckAge(birth_year);

        if(checkAge == true)
        {
            if(password == password2)
            {
                Console.WriteLine("Account is created successfully");
            }

            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        
        if(checkAge == false)
        {
            Console.WriteLine("Could not create account");
        }
            
    

    }
    
}
