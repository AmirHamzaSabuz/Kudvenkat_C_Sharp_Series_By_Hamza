using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_063_Partial_Methods
{
    internal partial class SampleClass
    {
        partial void SampleMethod2()
        {
            Console.WriteLine("SampleMethod2() invoked");
        }
    }
}
