using System;
using Shared;

namespace Framework_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = new Shared1();
            new Shared2();

            if (true)
            {
                MyClass.StaticMethod();
            }
        }
    }

    class MyClass
    {
        public static void StaticMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}