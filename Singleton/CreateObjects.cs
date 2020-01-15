using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CreateObjects
    {
        public static void Run()
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
            );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
