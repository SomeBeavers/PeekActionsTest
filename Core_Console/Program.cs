using System;
using Shared;

namespace Core_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shared1 = new Shared1();
            var s = shared1.Method1(null);
            Console.WriteLine("Hello World!");
        }
    }
}
