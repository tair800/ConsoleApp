using ConsoleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Interfaces
{
    public interface IStudent
    {
        List<Student> GetAll();
        List<Student> GetAll(string name);// listdeki butun hemin adlari tapmaq uchun(bashga sheylere gorede tapa bilerik
        Student Get(int id);
        Student Delete(int id);
        Student Update(int id, Student student, string groupName);//birinci id sine gore tapirig studenti ve sonra teze melumatlari elave edirik
        Student Create(Student student, string gruopName);
    }
}
