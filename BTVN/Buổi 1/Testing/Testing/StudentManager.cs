using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 internal class StudentManager
{
    public List<Student> students = new List<Student>();
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void ShowAllStudent()
    {
        for(int i = 0; i < students.Count; i++)
        {
            Console.WriteLine(students[i].ToString());
        }
    }

    public Student FindTopStudent()
    {
        float best = 0f;
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].GPA > best)
            {
                best = students[i].GPA;
            }
            
        }
        for (int j = 0; j < students.Count; j++)
        {
            if (students[j].GPA == best)
            {
                return students[j];
            }
        }
        return students[0];
    }
}