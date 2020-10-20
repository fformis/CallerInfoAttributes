using System;
using System.Runtime.CompilerServices;

namespace CallerInfoAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Log1("chamando log1");
        }

        static void Log1(string message, [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = ""){
            Console.WriteLine($"{message} - {filePath} - {memberName} - {lineNumber}");
            Log2("chamando log2");
        }

        static void Log2(string message,  [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = ""){
            Console.WriteLine($"{message} - {filePath} - {memberName} - {lineNumber}");
        }
    }
}

