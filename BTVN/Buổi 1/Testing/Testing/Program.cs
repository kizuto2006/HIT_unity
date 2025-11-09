using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        StudentManager studentManager = new StudentManager();
        studentManager.AddStudent(new Student("Vương Tuấn Hưng", "TTMT01", 3.6f));
        studentManager.AddStudent(new Student("Vương  Hưng", "TTMT01", 3.4f));
        studentManager.AddStudent(new Student(" Hưng", "TTMT01", 4.2f));
        studentManager.AddStudent(new Student(" Tuấn Hưng", "TTMT01", 1.6f));
        studentManager.students[2].UpdateGPA(2.6f);
        studentManager.ShowAllStudent();
        Console.WriteLine("Sinh viên có GPA cao nhất là: ");
        Console.WriteLine(studentManager.FindTopStudent());
    }
}