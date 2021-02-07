using System;
using System.Collections.Generic;
using System.Text;

namespace Mausbach_Project5
{
    class Conversions
    {
        public static double weightConversion(double pounds)
        {
            return pounds * 0.45359;
        }

        public static double heightConversion(double ft, double inch)
        {
            return (ft * 30.48) + (inch * 2.54);
        }

        public static double GetLBS()
        {
            Console.WriteLine("Enter the pounds: ");
            double pounds = double.Parse(Console.ReadLine());
            return pounds;
        }

        public static double GetFeet()
        {
            Console.WriteLine("Enter the feet: ");
            double ft = double.Parse(Console.ReadLine());
            return ft;
        }

        public static double GetInches()
        {
            Console.WriteLine("Enter the inches: ");
            double inch = double.Parse(Console.ReadLine());
            return inch;
        }
        public static void KiloPrint(double kilo, double pounds)
        {
            
            Console.WriteLine($"\n You entered {pounds} Pounds which equals {kilo:f} in Kilograms \n");
        }

        public static void CMPrint(double ft, double inch, double cm)
        {
            
            Console.WriteLine($"\n You entered {ft} Feet and {inch}  Inches which equals {cm:f} in Centimeters \n");
        }
    }
}
