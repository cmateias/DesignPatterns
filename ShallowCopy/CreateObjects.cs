using System;

namespace ShallowCopy
{
    public class CreateObjects
    {
        public static void Run()
        {
            Employee emp1 = new Employee();
            emp1.Name = "John";
            emp1.Department = "IT";
            emp1.EmpAddress = new Address() { AddressValue = "Test Address" };
            
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Doe";
            emp2.EmpAddress.AddressValue = "Uk Address";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.AddressValue + ", Dept: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.AddressValue + ", Dept: " + emp2.Department);
            Console.Read();
        }
    }
}