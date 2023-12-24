using AcademyApp.DataContext.Interfaces;
using ConsoleApp.Domain.Models;
using DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = ConsoleApp.Domain.Models.Group;

namespace AcademyApp.DataContext.Repository
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Create(Group entity)
        {
            try
            {
                DbContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group entity)
        {
            DbContext.Groups.Remove(entity);
            return true;
        }

        public Group Get(Predicate<Group> filter)
        {
            return DbContext.Groups.Find(filter);
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            if (filter == null)
            {
                return DbContext.Groups;
            }
            else
            {
                return DbContext.Groups.FindAll(filter);
            }

        }

        public bool Update(Group entity)
        {
            try
            {
                var existGroup = Get(g => g.Id == entity.Id);
                existGroup = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
