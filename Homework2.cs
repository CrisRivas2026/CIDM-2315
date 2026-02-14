namespace Homework2;

class Program
{
    static void Main(string[] args)
    
    
    {
        
        //Q1

      Console.WriteLine("Input a letter grade (Capitalized Only): ");
    string user_grade = Console.ReadLine();
    
    if (user_grade == "A")
    {
    Console.WriteLine("Range is from 100 to 90");
    }
    if (user_grade == "B")
    {
    Console.WriteLine("Range is from 89 to 80");
    }
    if (user_grade == "C")
    {
    Console.WriteLine("Range is from 79 to 70");
    }
    if (user_grade == "D")
    {
    Console.WriteLine("Range is from 69 to 60");
    }
    if (user_grade == "F")
    {
    Console.WriteLine("Range is from 60 to 0");
    }   
    else
    {
    Console.WriteLine("Incorrect Format! Please input A, B, C, D, or F");
    }

    
        //Q2


    Console.WriteLine("Input your first number: ");
    int first_num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a second number, different from the first: ");
    int second_num = Convert.ToInt32(Console.ReadLine());    
    Console.WriteLine("Input your third number, different from the first and second: ");
    int third_num = Convert.ToInt32(Console.ReadLine());

    if (first_num < second_num)
        {
          if   (first_num < third_num)
            {
                Console.WriteLine("The lowest number is " + first_num);
            }
            else
            {
                Console.WriteLine("The lowest number is " + third_num);
            } 
        }
        else if (second_num < third_num)
        {
            Console.WriteLine("The lowest number is " + second_num);
        }
        else
        {
            Console.WriteLine("The lowest number is " + third_num);
        }
    }


   




}
