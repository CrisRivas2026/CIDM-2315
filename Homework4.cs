using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
using System.Text;
using System.Transactions;
using Microsoft.VisualBasic;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Input two values");
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();

        int N1 = Convert.ToInt32(n1);
        int N2 = Convert.ToInt32(n2);

        Main(N1, N2);

        

        Console.WriteLine("Input an integer");
        string n = Console.ReadLine(); 
        int N = Convert.ToInt32(n);
        Console.WriteLine("Left or Right?");
        string shape = Console.ReadLine();

        LeftRight(N, shape);




    }

    static void Main(int N1, int N2)
    {
        
        if (N1 > N2)
        {
            Console.WriteLine("{0} is the larger number", N1);
        }

        else
        {
            Console.WriteLine("{0} is the larger number", N2);
        }
    }

    static void LeftRight(int N, string shape)
    {
        if (shape == "Left")
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (row >= col)
                    Console.Write('*');
                }
               Console.WriteLine(""); 
            }

            Console.WriteLine("N is {0}; shape is {1}", N, shape);
        }

        else if (shape == "Right")
        {
            for (int row = 1; row <= N; row++)
            {
                for (int col = 1; col <= N - row; col++)
                {
                    
                    Console.Write(" ");
                }
                
                
                for (int star = 1; star <= N; star++)
                {
                    if (star <= row)
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                


            }

            Console.WriteLine("N is {0}; shape is {1}", N, shape);
        }

        else
        {
            Console.WriteLine("Please enter a valid shape");
        }
    }
}
