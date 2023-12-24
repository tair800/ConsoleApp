using AcademyApp.DataContext.Interfaces;
using ConsoleApp.Domain.Models;
using DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.DataContext.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
            DbContext.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student entity)
        {
            DbContext.Students.Remove(entity);
            return true;
        }

        public Student Get(Predicate<Student> filter)
        {
            return DbContext.Students.Find(filter); //filterin yerine s=>s.Id==1 etsek, id si 1 olani tapacag
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
           if(filter == null)
            {
                return DbContext.Students;
            }
            else
            {
                return DbContext.Students.FindAll(filter);
            }//return filter == null ? DbContext.Students : DbContext.Students.FindAll(filter);

        }

        public bool Update(Student entity)
        {
            try
            {
                var existStudent = Get(s => s.Id == entity.Id);
                existStudent = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
