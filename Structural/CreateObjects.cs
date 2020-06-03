using System;

namespace Observer
{
    public class CreateObjects
    {
        public static void Run()
        {
           
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            
            Observer user1 = new Observer("John", RedMI);
            
            Observer user2 = new Observer("Doe", RedMI);
            
            Observer user3 = new Observer("Joanna", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.GetAvailability());
            Console.WriteLine();
            
            RedMI.SetAvailability("Available");
            Console.Read();
        }
    }
}