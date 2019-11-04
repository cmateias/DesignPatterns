﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public static class CreateObjects
    {
        public static void Run()
        {
            //Creating Leaf Objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            //Creating composite objects
            Composite motherBoard = new Composite("Motherboard");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            //Creating tree structure
            //Adding CPU and RAM in Mother board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            //Adding mother board and hard disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            //Adding mouse and keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            //Adding cabinet and peripherals in computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            //To display the Price of Computer
            computer.DisplayPrice();
            Console.WriteLine();

            //To display the Price of Keyboard
            keyboard.DisplayPrice();
            Console.WriteLine();

            //To display the Price of Cabinet
            cabinet.DisplayPrice();
            Console.Read();
        }
    }
}
