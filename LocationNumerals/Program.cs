using System;


namespace LocationNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Numerals number = new Numerals();
            String abbrev;
            // convert decimal value to Location Numeral
            int intValue = 9763;

            if (intValue > 33554432 || intValue < 0)
                Console.WriteLine("Change the whole number to a number between 1 and 33554432 (2^25) ");
            else if (intValue < 33554432)
            {
                abbrev = number.convertIntToLocationNumeral(intValue);
                Console.WriteLine("The Location Numeral of " + intValue + " is " + abbrev);
            }


            abbrev = "abbc";
            // convert Location numeral back to decimal value
            int convertedIntValue = number.convertLocationNumeralToInt(abbrev);
            
            Console.WriteLine("\nThe Location numeral of " + convertedIntValue + " is: " +abbrev );

            // Show how the Location numeral can be converted from extended to be abbreviated            
            String abbreviatedValue = number.convertLocationNumeralToAbbreviated("abbc");
           
            Console.WriteLine("\nThe abbreviated value of abbc is " + abbreviatedValue);
            
            Console.WriteLine("\n\nProgram done");

            // this prompt is here so that the console window won't close right away after running the program
            Console.WriteLine("\nPress the Enter key to close the console window");
            Console.Read();
        }
    }
}
