using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            school.School schoolDB = new school.School(new MySql.Data.MySqlClient.MySqlConnection("Database=school;Data Source=localhost;User Id=root;Password="));
            var students = from student in schoolDB.Students select student;
            foreach (var student in students)
            {
                Console.WriteLine("Student {0}'s roll number is {1} and age is {2}", student.Name, student.RollNo, student.Age);
            }
            schoolDB.Students.InsertOnSubmit(new school.Student { Name = "Peru", RollNo = 54321, Age = 15 });
            schoolDB.SubmitChanges();
        }
    }
}
