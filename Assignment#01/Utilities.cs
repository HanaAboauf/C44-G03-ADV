using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Utilities
    {
        public static void ReveseArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= arr.Length / 2)
                    break;
                T temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;

            }

        }

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }

        public static char FindFirstNonRepeatedCharacter(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (char c in input)
            {
                if (charCount[c] == 1)
                {
                    return c; 
                }
            }
            return '\0'; 
        }
    }
}
