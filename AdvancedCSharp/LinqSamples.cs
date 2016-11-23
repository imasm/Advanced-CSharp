using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedCSharp
{
    public class LinqSamples
    {
        public void RunAll()
        {
            BasicLinq();
            FluentLinq();
            MoreLinq();
        }

        public void BasicLinq()
        {
            ConsoleHelper.WriteCallerMethod();

            string[] noms = {"Tom", "Dick", "Harry"};

            IEnumerable<string> query = noms .Where(x => x.Length < 5);

            foreach (string nom in query)
                Console.WriteLine(nom);

            // Tom
            // Dick
        }


        public void FluentLinq()
        {
            ConsoleHelper.WriteCallerMethod();

            string[] noms = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            IEnumerable<string> query = noms
                .Where(x => x.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach (string nom in query)
                Console.WriteLine(nom);

            // JAY
            // MARY
            // HARRY
        }

        public void MoreLinq()
        {
            ConsoleHelper.WriteCallerMethod();

            int[] numbers = { 10, 9, 8, 7, 6 };

            IEnumerable<int> firstThree = numbers.Take(3); // { 10, 9, 8 }
            IEnumerable<int> lastTwo = numbers.Skip(3); // { 7, 6 }
            IEnumerable<int> reversed = numbers.Reverse(); // { 6, 7, 8, 9, 10 }
            
            int firstNumber = numbers.First(); // 10
            int lastNumber = numbers.Last(); // 6
            int secondNumber = numbers.ElementAt(1); // 9
            int secondLowest = numbers.OrderBy(n => n).Skip(1).First(); // 7

            int count = numbers.Count(); // 5;
            int min = numbers.Min(); // 6;
            int sum = numbers.Sum(); // 40

            bool hasTheNumberNine = numbers.Contains(9); // true
            bool hasMoreThanZeroElements = numbers.Any(); // true
            bool hasAnOddElement = numbers.Any(n => n % 2 != 0); // true

            int[] seq1 = { 1, 2, 3 };
            int[] seq2 = { 3, 4, 5 };
            IEnumerable<int> concat = seq1.Concat(seq2); // { 1, 2, 3, 3, 4, 5 }
            IEnumerable<int> union = seq1.Union(seq2); // { 1, 2, 3, 4, 5 }
        }

        
    }

}
