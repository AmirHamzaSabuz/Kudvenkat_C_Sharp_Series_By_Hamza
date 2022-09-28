using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_050_AssemblyOne
{
    public class AssemblyOneClass2
    {
        public void Test()
        {
            AssemblyOneClass1 instance = new AssemblyOneClass1();
            // Can access inetrnal member ID, AssemblyOneClassII and AssemblyOneClassI
            // are present in the same assembly           
            Console.WriteLine(instance.ID);
            Console.WriteLine(instance.Name);
        }
    }
}
