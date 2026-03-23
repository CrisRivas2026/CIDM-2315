using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
            Customer C1 = new Customer();
            C1.SetCusID(110);
            C1.cus_name = "Alice";
            C1.cus_age = 28;

            C1.PrintCusInfo();
             
            Customer C2 = new Customer();
            C2.SetCusID(111);
            C2.cus_name = "Bob";
            C2.cus_age = 30;

            C2.PrintCusInfo();

            C1.ChangeID(220);
            C1.PrintCusInfo();

            C2.ChangeID(221);
            C2.PrintCusInfo();

    
         
            if (C1.cus_age > C2.cus_age)
            {   
            Console.WriteLine("{0} is older",C1.cus_name);
            }
            else
            {
            Console.WriteLine("{0} is older",C2.cus_name);
            }
        

    }
}

class Customer
{
    private int cus_id;
    
    public void SetCusID(int new_id)
    {
        cus_id = new_id;
    }


    public string cus_name;

    public int cus_age;
    
    public void PrintCusInfo()
    {
        Console.WriteLine("Customer: {0}, name: {1}, age: {2}", cus_id, cus_name, cus_age);
    }

    public void ChangeID(int New_ID)
    {
        cus_id = New_ID;
    }

    
}