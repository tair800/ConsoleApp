using ConsoleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Interfaces
{
    public interface IGroup
    {
        List<Group> GetAll();
        List<Group> GetAll(int size);
        Group Get(int id);
        Group Get(string name);
        Group Delete(int id);
        Group Create(Group group);
        Group Update(int id, Group group);
        

    }
}
