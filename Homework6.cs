using System.Net.Mail;

namespace Homework6;

class StudentUML
{

    public string studentName;

    public string classEnroll;

    public double studentGrade {set; get;}  

    public void PrintStudentInfo()
    {

        Console.WriteLine("Student {0} is enrolled in {1}, and has a grade of {2}", studentName, classEnroll, studentGrade);

    }
}


class ProfessorUML
{

    public string profName;

    public string classTeach;

     
    public double salary {set;get;}
        

    public void PrintProfInfo()
    {

        Console.WriteLine("Professor {0} teaches {1}, and the salary is {2}", profName, classTeach, salary);

    }
}


class Program
{
    static void Main(string[] args)
    {
        ProfessorUML p1 = new ProfessorUML();
        p1.profName = "Alice";
        p1.classTeach = "Jave";
        p1.salary = 9000;
        p1.PrintProfInfo();
        

        ProfessorUML p2 = new ProfessorUML();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.salary = 8000;
        p2.PrintProfInfo();

        StudentUML s1 = new StudentUML();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.studentGrade = 90;
        s1.PrintStudentInfo();

        StudentUML s2 = new StudentUML();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.studentGrade = 80;
        s2.PrintStudentInfo();

        double salarydiff = p1.salary - p2.salary;
        Console.WriteLine("The salary different between {0} and {1} is {2}",p1.profName,p2.profName,salarydiff);

        double totalgrade = s1.studentGrade + s2.studentGrade;
        Console.WriteLine("The total grade of {0} and {1} is {2}",s1.studentName,s2.studentName, totalgrade);

    }
}
