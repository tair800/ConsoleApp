using AcademyApp.DataContext.Repository;
using ConsoleApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Interfaces.Services
{
    public class StudentService : IStudent
    {
        private readonly StudentRepository _studentRepository;
        private readonly GroupRepository _groupRepository;
        private static int Count = 1;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
            _groupRepository = new GroupRepository();
        }
        public Student Create(Student student, string groupName)
        {
            var existGroup = _groupRepository.Get(g => g.Name.Equals(groupName ,StringComparison.OrdinalIgnoreCase));
            //stringComparison.OrdinalIgnoreCase regemlerin boyuk ya kichik olmasina fikir vermir
            if (existGroup == null) return null;
            student.Id = Count;
            student.Group = existGroup;
            bool result=_studentRepository.Create(student);
            if (!result) return null;
            Count++;
            return student;

        }
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public List<Student> GetAll(string name)
        {
            return _studentRepository.GetAll(s => s.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

       

       

        public Student Update(int id, Student student, string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
