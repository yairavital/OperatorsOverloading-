﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person()
        {

        }
        public Person(int id,string name)
        {Id = id;
            Name = name;

        }
    }
}
