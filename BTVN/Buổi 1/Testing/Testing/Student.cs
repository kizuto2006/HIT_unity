using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Student
{
    private string name;
    private string clas;
    private float gpa;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Clas
    {
        get { return clas; }
        set { clas = value; }
    }
    public float GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }

    public Student(string Name, string Clas, float Gpa)
    {
        this.name = Name;
        this.clas = Clas;
        this.gpa = Gpa;
    }
    public void UpdateGPA(float Gpa)
    {
        if (Gpa >= 0 && Gpa <= 0)
        {
            this.gpa = Gpa;
        }
    }


    public override string ToString()
    {
        return $"Tên: {Name}, Lớp: {Clas} , GPA: {GPA}";
    }



}