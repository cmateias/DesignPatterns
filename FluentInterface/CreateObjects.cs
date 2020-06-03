using System;

namespace FluentInterface
{
    public class CreateObjects
    {
        public static void Run()
        {
            var obj = new FluentEmployee();
            obj.NameOfTheEmployee("Test Name")
                .Born("10/10/1982")
                .WorkingOn("IT")
                .StaysAt("City");

            obj.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}