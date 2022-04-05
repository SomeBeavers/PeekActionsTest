using System;

namespace Multi
{
    public class Multi2: Attribute
    {
        public bool Test(bool b)
        {
            if (b)
            {
                Console.WriteLine();
            }
            else
            {
            }

            return b;
        }

        private bool TestMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}