using ConsoleApp.Domain.Models;

namespace DataContext
{
    public static class DbContext
    {
        public static List<Student> Students { get; set; }
        public static List<Group> Groups { get; set; }
        static DbContext()
        {
            Students = new List<Student>();
            Groups = new List<Group> ();
        }
    }
}
 