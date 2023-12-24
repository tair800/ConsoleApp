﻿using ConsoleApp.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Domain.Models
{
    public class Group: BaseEntity
    {
        public string Name { get; set; }
        public int MaxSize { get; set; }
    }
}
