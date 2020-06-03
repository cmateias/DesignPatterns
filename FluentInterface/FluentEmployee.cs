using System;

namespace FluentInterface
{
    public class FluentEmployee
    {
        private readonly Employee employee = new Employee();

        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            return this;
        }

        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }

        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }

        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            return this;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Name :" + employee.FullName);
            Console.WriteLine("Address :" + employee.Address);
            Console.WriteLine("DateOfBirth :" + employee.DateOfBirth);
            Console.WriteLine("Department :" + employee.Department);
        }
    }
}