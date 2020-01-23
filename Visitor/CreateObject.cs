using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class CreateObject
    {
        public static void Run()
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }
}
