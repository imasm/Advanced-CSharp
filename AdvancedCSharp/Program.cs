using System;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LambdasSamples lambdaSamples = new LambdasSamples();
            lambdaSamples.RunAll();

            LinqSamples linqSamples = new LinqSamples();
            linqSamples.RunAll();

            ExtensionSample();
            Console.ReadLine();
        }

        static void ExtensionSample()
        {
            ConsoleHelper.WriteCallerMethod();

            string text = "Hola";

            try
            {
                string result = text.Substring(1, 10);
            }
            catch (Exception ex)
            {
                // Error: System.ArgumentOutOfRangeException
                Console.WriteLine("Substring Error: " + ex.Message);
            }

            string result2 = text.SafeSubstring(1, 10);
            // result2 => ola
        }
    }
}
