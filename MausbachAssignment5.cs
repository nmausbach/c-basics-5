using System;
/*
 * created by Nathan Mausbach
 */
namespace Mausbach_Project5
{
    class MausbachAssignment5
    {
        static void Main(string[] args)
        {
            double kg = 0, cm = 0, lbs = 0, feet = 0, inches = 0;

            MausbachHeading.getHeading("Assignment5");
            int menu = ConversionMenu.Menu(1);

            if (menu <= 13)
            {
                while (menu <= 13)
                {//start of while loop

                    Console.WriteLine("\n");
                    if (menu == 11)
                    {
                        feet = Conversions.GetFeet();
                        inches = Conversions.GetInches();
                        cm = Conversions.heightConversion(feet, inches);
                        Conversions.CMPrint(feet, inches, cm);
                    }
                    if (menu == 12)
                    {
                        lbs = Conversions.GetLBS();
                        kg = Conversions.weightConversion(lbs);
                        Conversions.KiloPrint(kg, lbs);
                    }

                    menu = ConversionMenu.Menu(2);

                    if (menu == 13)
                    {
                        MausbachHeading.getClosing();
                    }
                }
            }

            
            if ((menu >= 21) && (menu <= 23))
            {//do loop
                do
                {
                    Console.WriteLine("\n");
                    if (menu == 21)
                    {
                        feet = Conversions.GetFeet();
                        inches = Conversions.GetInches();
                        cm = Conversions.heightConversion(feet, inches);
                        Conversions.CMPrint(feet, inches, cm);
                    }
                    if (menu == 22)
                    {
                        lbs = Conversions.GetLBS();
                        kg = Conversions.weightConversion(lbs);
                        Conversions.KiloPrint(kg, lbs);
                    }

                    menu = ConversionMenu.Menu(2);

                    if (menu == 23)
                    {
                        MausbachHeading.getClosing();
                    }
                }
                while (menu <= 23);
            }

            
            if ((menu >= 31) && (menu <= 33))
            {//for loop
                for (menu = menu; menu <= 33; menu++)
                {
                    Console.WriteLine("\n");
                    if (menu == 31)
                    {
                        feet = Conversions.GetFeet();
                        inches = Conversions.GetInches();
                        cm = Conversions.heightConversion(feet, inches);
                        Conversions.CMPrint(feet, inches, cm);
                    }
                    if (menu == 32)
                    {
                        lbs = Conversions.GetLBS();
                        kg = Conversions.weightConversion(lbs);
                        Conversions.KiloPrint(kg, lbs);
                    }

                    menu = ConversionMenu.Menu(2);

                    if (menu == 33)
                    {
                        MausbachHeading.getClosing();
                    }
                }
            }
            Console.WriteLine("end of file");
        }
    }
}
