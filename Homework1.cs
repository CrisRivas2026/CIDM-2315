using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        
        
        double X , Y, Z;
        
        X = 2.5;
        Y = 3.3;
        Z = 4*X*X + 3*Y;
        
        Console.WriteLine("X is equal to {0} and Y is equal to {1}.", X , Y);
        Console.WriteLine("The value of Z is {0}.", Z);
    }
}
