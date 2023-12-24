using AcademyApp.Business.Interfaces.Services;
using AcademyApp.Collector;
using AcademyApp.Helpers;
using ConsoleApp.Domain.Models;
using static AcademyApp.Helpers.Helper;

Helper.ChangeTextColor(ConsoleColor.Green, "Academy App");
Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter number :" +
    "1. CreateStudent" +
    "2. GetAllStudent " +
    "3. GetAllStudentByName" +
    "4. GetStudentById " +
    "5. Delete Student" +
    "6. Update Student" +
    "0. ExitMenu");
StudentController studentController = new();
EnterMenu: string menu=Console.ReadLine();
bool result=int.TryParse(menu, out int intMenu);
while (true)
{
    if (result && intMenu > 0 && intMenu < 7)
    {
        switch (intMenu)
        {
            case (int)Menus.CreateStudent:
               studentController.CreateStudent();
                break;
                case (int)Menus.GetAllStudent:
                studentController.GetAll();
                break;
            case (int)Menus.GetAllStudentByName:
                break;
            case (int)Menus.GetStudentById:
                break;

        }

    }
    else if (intMenu == 0)
    {
        Helper.ChangeTextColor(ConsoleColor.Cyan, "Bye");
        break;
    }
    else
    {
        Helper.ChangeTextColor(ConsoleColor.Red, "Enter valid number ");
        goto EnterMenu;
    }
}