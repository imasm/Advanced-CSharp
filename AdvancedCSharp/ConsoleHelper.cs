using System;
using System.Runtime.CompilerServices;

namespace AdvancedCSharp
{
    public class ConsoleHelper
    {
        public static void WriteCallerMethod([CallerMemberName] string callerMemberName = null)
        {
            Console.WriteLine();
            Console.WriteLine(callerMemberName ?? "[Unknown caller member]");
        }
    }
}