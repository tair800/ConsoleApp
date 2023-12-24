using AcademyApp.Business.Interfaces.Services;
using AcademyApp.Helpers;
using ConsoleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Collector
{
    public class StudentController
    {
        private readonly StudentService _studentService;
        public StudentController()
        {
            _studentService = new ();
        }
        public void CreateStudent()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Enter Group Number");
            string groupNumber = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Enter Student Name");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Enter Student Surname");
            string surname = Console.ReadLine();
            Student newStudent = new();
            newStudent.Name = name;
            newStudent.Surname = surname;
            StudentService studentService = new();
            if (_studentService.Create(newStudent, groupNumber) == null)
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Something went wrong");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Green, "Student created");
            }
        }
        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Student List :");
            var students = _studentService.GetAll();   
            foreach ( var student in _studentService.GetAll())
            {
                if(students.Count > 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.Yellow, $"Id : {student.Id} Name : {student.Name} ");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"Empty list  ");
                }
            }
        }

    }
       
}
