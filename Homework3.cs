using System.Data;

namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string user_num = Console.ReadLine();
        double user_num_int = Convert.ToInt32(user_num);
        bool p = true;
    

        for (int i = 1; i <= user_num_int; i++)
        {
            double div = user_num_int%i;
            //Console.WriteLine("The remainder of {0} divided by {1} is equal to {2}", user_num_int, i, div);
            
            if ( i != 1 && i!=user_num_int)
            {
                if (div == 0)
                {
                    Console.WriteLine("{0} is non-prime", user_num_int);
                    p = false;
                    break;
                }
                else
                {
                    
                    continue;
                }

            }
            
        }

       if (p == true)
        {
            Console.WriteLine("{0} is prime", user_num_int);        
        }
        else
        {
            
        }
    
        
        Console.WriteLine("Input an integer");

        string n = Console.ReadLine();
        int N = Convert.ToInt32(n);

        for(int row = 0; row<N; row++)
        {
            for(int col = 0; col<N; col++)
                {
                    Console.Write('#');
                }
            Console.WriteLine("");
        }

        
        
        
      
    }
}
