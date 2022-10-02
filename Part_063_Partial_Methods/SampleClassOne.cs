using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_063_Partial_Methods
{
    internal partial class SampleClass
    {
        // Declaration of the partial method.
        partial void SampleMethod1(); // No implementation

        // Declaration of the partial method.
        partial void SampleMethod2(); // implementation is in SampleClassTwo.cs file

        // A public method calling the partial method
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            SampleMethod1(); // this method is ignored because it has no implementation.
            SampleMethod2();
            SampleMethod4();
            SampleMethod5();
            SampleMethod8();
            SampleMethod9();
            Console.WriteLine("SampleMethod11() with private partial int - " + SampleMethod11());
        }

        /*
         * // No defining declaration found
         * partial void SampleMethod3()  // Error
         * {
         *      Console.WriteLine("SampleMethod2() invoked");
         * }
         */


        // If we want to write access modifier
        // Must write both declatration and implementation
        private partial void SampleMethod4(); 
        private partial void SampleMethod4() 
        {
            Console.WriteLine("SampleMethod4() with private partial");
        }

        public partial void SampleMethod5();
        public partial void SampleMethod5()
        {
            Console.WriteLine("SampleMethod5() with public partial");
        }

        /*
         * virtual partial void SampleMethod6(); // Error
         * // Must have accessibility modifiers
         * // because it has a "virtual", "override", "sealed", "new" or "extern" modifier
         */

        /*
         * public virtual partial void SampleMethod7(); // Error
         * // Must have an implementation Part because it has accessibility modifiers
         */

        public virtual partial void SampleMethod8();
        public virtual partial void SampleMethod8() 
        {
            Console.WriteLine("SampleMethod8() with public virtual partial");
        }

        partial void SampleMethod9();
        partial void SampleMethod9()
        {
            Console.WriteLine("SampleMethod9() invoked");
        }

        /*
         * // A Partial method may not have multiple implementing declarations
         * partial void SampleMethod9() // Error
         * {
         *      Console.WriteLine("SampleMethod2() invoked");
         * }
         */

        /*
         * // Must have accessibility modifiers because it has a non void return type
         * partial int SampleMethod10(); // Error
         * partial int SampleMethod10() // Error
         * {
         *      return 0;
         * }
        */

        private partial int SampleMethod11();
        private partial int SampleMethod11()
        {
            return 0;
        }
    }

    internal class SampleClass2 
    {
        /*
        // A partial method must be declared within a partial type
        // the class is not partial
        partial void SampleMethod12(); // Error
        partial void SampleMetho12() // Error
        {
            Console.WriteLine("SampleMethod9() invoked");
        }
        */
    }
}
