using System;

// Class Numerals
namespace LocationNumerals
{
    class Numerals
    {
 
        // Method to convert a number between 2^0 and 2^25 to a Location Numeral
        public String convertIntToLocationNumeral(int intNumber)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyz";

            int nextPosition;
            int workingNumber = intNumber;
            String returnValue = "";

            
            // Start searching for the closest match to our decimal number in descending order
            while (workingNumber > 0)
            {
                // once we find the decimal number that is one lower than the decimal conversion of 2^x,
                // we will find the number we can use to start the conversion with.

                // Converting numbers from 2^0 to 2^25 to Location Numerals

                nextPosition = (int)(Math.Log(workingNumber) / Math.Log(2));
                workingNumber -= (int)Math.Truncate(Math.Pow(2, nextPosition));
                returnValue = alphabet[nextPosition] + returnValue;

            }
            
            return returnValue;
           
        }

        public int convertLocationNumeralToInt(String locationNumeral)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyz";
     
            int i = 0; // used to loop through the index of location numeral string
            int power; // used to find the index in the alphabet array
            int sum = 0; // used to add all the powers of the 2 
            int baseValue = 2; // the base number of 2

            // loop through the characters in the location numeral
            while (i < locationNumeral.Length)
            {
                // find the index of the location numeral in the alphabet string
                // using the power x where 2^x
                power = alphabet.IndexOf(locationNumeral[i]);

                // add this 2^x to a running total which will be used 
                // to hold the converted decimal number
                sum += (int) Math.Pow(baseValue, power);
                i++;
            }

            return sum;
        }

        public String convertLocationNumeralToAbbreviated(String locationNumber)
        {
            // call the method that converts a Location Numeral to an integer
            int intValue = convertLocationNumeralToInt(locationNumber);

            // then use the converted integer to convert to an abbreviated Location Number
            String locationNumeralAbbrev = convertIntToLocationNumeral(intValue); 

            return locationNumeralAbbrev;
        }

    }
}
