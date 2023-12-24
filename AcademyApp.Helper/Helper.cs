using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Helpers
{
    public class Helper
    {
        public static void ChangeTextColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menus
        {
            CreateStudent=1,
            GetAllStudent,
            GetAllStudentByName,
            GetStudentById,
            DeleteStudent,
            UpdateStudent ,
            ExitMenu
        }
    
    }
}
