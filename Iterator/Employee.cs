using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(string name, int id)
        {
            ID = id;
            Name = name;
        }
    }
}
