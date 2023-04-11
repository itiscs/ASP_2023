﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{Id} {Name} {Group} {Marks.Count}";
        }

    }
}
