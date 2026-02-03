using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

class Student
{
    public int Id;
     public string Name ;
    public int Age;
}

class Program
{
    static List<Student> students=new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View all Students");
            Console.WriteLine("Search Student by ID");
            Console.WriteLine("4.Delete Student");      
            Console.WriteLine("5.Update Student");
            Console.WriteLine("6.Exit");
            Console.Write("Enter your choice: ");
            int choice=int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: ViewAllStudents(); break;
                case 3: SearchStudentById(); break;
                case 4: DeleteStudent(); break;
                case 5: UpdateStudent(); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

            }
    }

    static void AddStudent()
    {
        Student s=new Student();

        Console.Write("Enter Student ID: ");
        s.Id=int.Parse(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        s.Name=Console.ReadLine();  

        Console.Write("Enter Student Age: ");
        s.Age=int.Parse(Console.ReadLine());    

        students.Add(s);
        Console.WriteLine("Student added successfully");
    }

    static void ViewAllStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
        }
    }

    static void SearchStudentById()
    {
        Console.Write("Enter Student ID to search: ");
        int id=int.Parse(Console.ReadLine());

        var student=students.Find(s => s.Id == id);
        if (student != null)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        int id=int.Parse(Console.ReadLine());

        var student=students.Find(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student deleted successfully");
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }
    static void UpdateStudent()
    {
        Console.Write("Enter Student ID to update: ");
        int id=int.Parse(Console.ReadLine());

        var student=students.Find(s => s.Id == id);
        if (student != null)
        {
            Console.Write("Enter new Name: ");
            student.Name=Console.ReadLine();

            Console.Write("Enter new Age: ");
            student.Age=int.Parse(Console.ReadLine());

            Console.WriteLine("Student updated successfully");
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }

}