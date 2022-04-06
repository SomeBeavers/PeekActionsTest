using System;

namespace Core_Console
{
    public class PeekSameFile
    {
        private void Test()
        {
            Console.WriteLine("Test2");
            Test2();
            // comment
            new PeekDifferentFile().Name_Renamed = "";
            new PeekDifferentFile().Name_Renamed = "";
            new PeekDifferentFile().Name_Renamed = "";
        }

        private void Test2()
        {
            throw new System.NotImplementedException();
        }
    }
}