using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralsConverterWFA
{
    class NumberToRoman
    {
        // Converts an integer value into Roman numerals
        public string numRoman(int number)
        {
            /*The number being converted must be within the previously specified range. 
             * If a value outside of the range were provided, the resulting string would be incorrect, 
             * so a validation rule is incorporated that throws an argument exception. 
             * Add the following validation code within the method.
             */
            if (number < 1 || number > 1000000)
                throw new ArgumentException("Value must be in the range 1 ~ 1,000,000.");

            /*The algorithm will work by comparing a series of values to the number being converted. 
             * Each item in the series represents a specific Roman numeral letter or a 
             * letter pair representing a subtraction.
              
             
             * The key numerals will be m (1000000), d (500000), c (100000), l (50000), x (10000). v (5000),
             * M (1000), CM (900), D (500), CD (400), C (100), XC (90), L (50), XL (40), X (10), IX (9), V (5), IV (4) and I (1). 
             * To hold these values and link the integer to the numeral, we will create two arrays. 
             * This could also be achieved with a collection such as a SortedList.
             */

            // Set up key numerals and numeral pairs using an array
            int[] values = new int[] { 1000000, 500000, 100000, 50000, 10000, 5000, 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[]
                { "m", "d", "c", "l", "x", "v", "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            /*The resultant string will be built up in stages using a StringBuilder object as 
             * this is efficient for the recursive appending that will occur.
             */
            // Initialise the string builder
            StringBuilder result = new StringBuilder();

            /*Now that all of the data has been initialised, the process of appending letters and pairs
             * to the StringBuilder must be developed. This simple process loops through all of the items 
             * in the integer array, starting with the largest value. If the number found in the array 
             * is as large or larger than the number being converted then the corresponding letter or 
             * pair or letters from the numerals array is appended to the StringBuilder.

             * Each time the StringBuilder is updated, the number being converted is decreased 
             * by the appended letter or pair's value. This stops numerals from being incorrectly 
             * appended and ensures that the loop does not become infinite. The iterative process 
             * continues until all of the values in the integer array have been processed and the 
             * number being converted has therefore been reduced to zero.
             */

            // Loop through each of the values to diminish the number
            for (int i = 0; i < 19; i++)
            {
                // If the number being converted is less than the test value, append
                // the corresponding numeral or numeral pair to the resultant string
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }

            //All that remains now is to convert the StringBuilder value into a string so that it can be returned to the calling routine.
            
            // Done
            return result.ToString();

        }

    }
}
