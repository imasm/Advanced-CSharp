using System;
using System.Diagnostics;

namespace AdvancedCSharp
{
    public class LambdasSamples
    {
        private delegate void WriteMessageDelegate(string message);

        private void WriteToConsole(string message)
        {
            Console.WriteLine(message);
        }

        private void WriteToTrace(string message)
        {
            Trace.WriteLine(message);
        }

        public void RunAll()
        {
            DemoDelegate();
            DemoAnonymousMethod();
            DemoLamda();
            DemoPredicate();
            DemoAction();
            DemoFunc();
            DemoFunc2Parameters();
        }

        public void DemoDelegate()
        {
            ConsoleHelper.WriteCallerMethod();

            WriteMessageDelegate method = WriteToConsole;
            method("Message in console");

            WriteMessageDelegate method2 = WriteToTrace;
            method2("Message in Trace");
        }

        public static void DemoAnonymousMethod()
        {
            ConsoleHelper.WriteCallerMethod();
            WriteMessageDelegate method = delegate (string message) { Console.WriteLine(message); };
            method("Text");
        }
        
        public static void DemoLamda()
        {
            ConsoleHelper.WriteCallerMethod();
            WriteMessageDelegate method = (message) => { Console.WriteLine(message); };
            method("Text");
        }

        public static void DemoPredicate()
        {
            ConsoleHelper.WriteCallerMethod();
            Predicate<int> f = (x) => { return (x % 2 == 0); };

            const int num = 8;

            if (f(num))
                Console.WriteLine($"{num} IsEven");
            else
                Console.WriteLine($"{num} IsEven");
        }

        public static void DemoAction()
        {
            ConsoleHelper.WriteCallerMethod();
            Action<int> f = (x) =>
            {
                if (x % 2 == 0)
                    Console.WriteLine($"{x} IsEven");
                else
                    Console.WriteLine($"{x} IsOdd");
            };

            f(7);
        }

        public static void DemoFunc()
        {
            ConsoleHelper.WriteCallerMethod();
            Func<int,int, int> modul = (x,y) => { return x % y; };

            const int num = 8;

            if (modul(num, 2) == 0)
                Console.WriteLine($"{num} IsEven");
            else
                Console.WriteLine($"{num} IsEven");
        }

        public static void DemoFunc2Parameters()
        {
            ConsoleHelper.WriteCallerMethod();
            Func<int, int, int> modul = (x, y) => x % y;

            const int num = 8;

            if (modul(num, 2) == 0)
                Console.WriteLine($"{num} IsEven");
            else
                Console.WriteLine($"{num} IsEven");
        }


    }
}