using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Shared1
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string Method1(string method1)
        {
            new Shared2();
            return method1;
        }
    }
}
