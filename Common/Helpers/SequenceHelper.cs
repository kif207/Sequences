using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class SequenceHelper
    {
        /// <summary>
        /// Returns a numeric sequences of All numbers up to and including the number passed
        /// </summary>
        /// <param name="number">Integer value to generate the Numeric Sequence</param>        
        /// <remarks>
        /// Boundry Conditions:
        ///     Returns a blank numeric sequences if passed number is smaller than 0
        /// </remarks>
        public static List<int> AllNumbers(int number)
        {
            number = (number < 0 ? 0 : ++number);
            return Enumerable.Range(0, number).ToList();
        }

        /// <summary>
        /// Returns a numeric sequences of All odd numbers up to and including the number passed
        /// </summary>
        /// <param name="number">Integer value to generate the Numeric Sequence</param>        
        /// <remarks>
        /// Boundry Conditions:
        ///      Returns a blank numeric sequences if passed number is smaller than 0
        /// </remarks>
        public static List<int> AllOddNumbers(int number)
        {
            number = (number < 0 ? 0 : ++number);
            return Enumerable.Range(0, number).Where(num => num % 2 != 0).ToList();          
        }

        /// <summary>
        /// Returns a numeric sequences of All even numbers up to and including the number passed
        /// </summary>
        /// <param name="number">Integer value to generate the Numeric Sequence</param>        
        /// <remarks>
        /// Boundry Conditions:
        ///      Returns a blank numeric sequences if passed number is smaller than 0 
        /// </remarks>
        public static List<int> AllEvenNumbers(int number)
        {
            number = (number < 0 ? 0 : ++number);
            return Enumerable.Range(0, number).Where(num => num % 2 == 0).ToList();
        }

        /// <summary>
        /// Returns a numeric sequences of All numbers up to and including the number passed, except when
        ///     A number is a multiple of 3 output C, and when
        ///     A number is a multiple of 5 output E, and when,
        ///     A number is a multiple of both 3 and 5 output Z
        /// </summary>
        /// <param name="number">Integer value to generate the Numeric Sequence</param>        
        /// <remarks>
        /// Boundry Conditions:
        ///      Returns a blank numeric sequences if passed number is smaller than 0 
        /// </remarks>
        public static List<string> CEZSequence(int number)
        {
            number = (number < 0 ? 0 : ++number);
            return Enumerable.Range(0, number).Select(n => replaceCZE(n)).ToList();
        }

        /// <summary>
        /// Returns
        ///     C if passed vaue is a multiple of 3 
        ///     E if passed vaue is a multiple of 5
        ///     Z if passed vaue is a is a multiple of both 3 and 5
        ///     Value converted to string back if none of above is true
        static string replaceCZE(int value)
        {
            if (value == 0) return "0";
            else if (value % 15 == 0) return "Z";
            else if (value % 3 == 0) return "C";
            else if (value % 5 == 0) return "E";
            else return value.ToString();
        }

        /// <summary>
        /// Returns a numeric sequences of All fibonacci number up to and including the number passed
        /// </summary>
        /// <param name="number">Integer value to generate the Numeric Sequence</param>        
        /// <remarks>
        /// Boundry Conditions:
        ///      Returns a blank numeric sequences if passed number is smaller than 0 
        /// </remarks>
        public static List<int> FibonacciNumbers(int number)
        {
            List<int> returnList = new List<int>();
            if (number < 0) return returnList;

            int prev = -1;
            int next = 1;
            int sum = -1;

            while (sum <= number)
            {
                sum = prev + next;
                prev = next;
                next = sum;
                if (sum <= number) returnList.Add(sum);
            }

            return returnList;
        }
    }
}
