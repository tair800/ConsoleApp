using ConsoleApp.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain.Models
{
    public class Student: BaseEntity
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public byte Age { get; set; }
        public Group Group { get; set; }
    }
}
