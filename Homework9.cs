using System.Diagnostics.Contracts;
using System.Net.Mail;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        foreach(Student stu in Student.student_list)
        {
            stu.PrintInfo();
        }
        
        Dictionary<string, double> Gradebook = new Dictionary<string, double>();
        Gradebook.Add("Alice", 4.0);
        Gradebook.Add("Bob", 3.6);
        Gradebook.Add("Cathy", 2.5);
        Gradebook.Add("David", 1.8);

        if (Gradebook.ContainsKey("Tom"))
        {
            Console.WriteLine("Tom is in the gradebook");
        }
        else 
        {
            Console.WriteLine("Tom is not in the gradebook! Tom has been added! ");
            Gradebook.Add("Tom", 3.3);
        }

         List<double> valueList = Gradebook.Values.ToList();
        
         double GradeTotals = valueList.Sum();

         int NumberofGrades = valueList.Count();
        
         double GradeAvg = GradeTotals/NumberofGrades;
         Console.WriteLine("The average grade is {0}", GradeAvg);

       

    
    }


class Student
    {
        private int studentID;
        public int stuID
        {
            get {return studentID;}
            set {studentID = value;}
        }

        

        private string studentName;
        public string stuName  
        {
            get {return studentName;}
            set {studentName = value;}
        }
        public void PrintInfo()
        {
            Console.WriteLine("Student ID: {0} ; Student Name: {1}", studentID, studentName);
        }
        
        public static List<Student> student_list = new List<Student>();
    
        public Student(int StudentID, string StudentName)
        {
            stuID = StudentID;
            stuName = StudentName;
            student_list.Add(this);
        }
    
    }

}
