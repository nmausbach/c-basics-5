using System;
using System.Collections.Generic;
using System.Text;

namespace Mausbach_Project5
{
    class ConversionMenu
    {

       
        public static int Menu(int num)
        {
            int choice = 0;
            int option;

            {
                Console.WriteLine("Option 1. Use a while loop: ");
                Console.WriteLine("Option 2. Use a do-while loop: ");
                Console.WriteLine("Option 3. Use a for loop: ");
                Console.WriteLine("Enter your choice. ");
                option = int.Parse(Console.ReadLine());
                //options for while loop
                if (option == 1)
                {
                    Console.WriteLine("\nYou have entered the While Loop\n\tConversions Menu");
                    Console.WriteLine("Option 1. Convert feet and inches to centimeters: ");
                    Console.WriteLine("Option 2. Convert pounds to kilograms: ");
                    if (num == 2)
                        Console.WriteLine("Option 3. Exit: ");
                    Console.WriteLine("Enter your choice. ");
                    choice = int.Parse(Console.ReadLine());
                    choice = choice + 10;

                    return choice;
                }
                if (option == 2)
                {
                    Console.WriteLine("\nYou have entered the Do-While Loop\n\tConversions Menu");
                    Console.WriteLine("Option 1. Convert feet and inches to centimeters: ");
                    Console.WriteLine("Option 2. Convert pounds to kilograms: ");
                    if (num == 2)
                        Console.WriteLine("Option 3. Exit: ");
                    Console.WriteLine("Enter your choice. ");
                    choice = int.Parse(Console.ReadLine());
                    choice = choice + 10;

                    return choice;
                }
                if (option == 3)
                {
                    Console.WriteLine("\nYou have entered the For Loop\n\tConversions Menu");
                    Console.WriteLine("Option 1. Convert feet and inches to centimeters: ");
                    Console.WriteLine("Option 2. Convert pounds to kilograms: ");
                    if (num == 2)
                        Console.WriteLine("Option 3. Exit: ");
                    Console.WriteLine("Enter your choice. ");
                    choice = int.Parse(Console.ReadLine());
                    choice = choice + 10;

                    return choice;
                }
                return choice;
            }
        }
    }
}
