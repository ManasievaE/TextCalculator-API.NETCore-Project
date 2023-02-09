using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskOne
{
    public class TextCalculator
    {
        public string Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return "0";
            }

            string[] numberStrings = numbers.Split(',');
            int[] numbersArray = new int[numberStrings.Length];
            List<int> negativeNumbers = new List<int>();

            for (int i = 0; i < numberStrings.Length; i++)
            {

                if (!int.TryParse(numberStrings[i], out numbersArray[i]))
                {
                    throw new InvalidOperationException("Input must contain only digits.");
                }

                if (numbersArray[i] < 0)
                {
                    negativeNumbers.Add(numbersArray[i]);
                }

                if (numberStrings[numberStrings.Length - 1].Length == 0)
                {
                    throw new InvalidOperationException("Missing number in last position.");
                }
            }

            if (negativeNumbers.Count > 0)
            {
                string negativeNumbersList = string.Join(", ", negativeNumbers);
                throw new InvalidOperationException("Negative numbers not allowed: " + negativeNumbersList);
            }

            int result = 0;
            foreach (int number in numbersArray)
            {
                result += number;
            }

            return result.ToString();
        }
    }
}
         



