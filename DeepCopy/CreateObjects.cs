using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopy
{
    public class CreateObjects
    {
        public static void Run()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Test Name";
            emp1.Department = "IT";
            emp1.EmpAddress = new Address() { AddressValue = "Test Address" };
            Employee emp2 = emp1.GetClone();
            emp2.Name = "John DOe";
            emp2.EmpAddress.AddressValue = "UK Address";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.AddressValue + ", Dept: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.AddressValue + ", Dept: " + emp2.Department);
            Console.Read();
        }
    }
}
