using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_062_Partial_Classes_abstract_sealed_inheritance
{
    internal class TestAbstract2 : PartialClass_Abstract
    {
        public string? Address { get; set; }

        public void TestAbstract2_Method() 
        {
            TestAbstract2 testAbstract2 = new TestAbstract2();
            testAbstract2.FirstName = "Amir";
            testAbstract2.LastName = "Hamza";
            testAbstract2.Address = "Dhaka";

            Console.WriteLine("From TestAbstract2_Method, testAbstract2 object " + testAbstract2.GetFullName() + ", " + testAbstract2.Address);            
            

            PartialClass_Abstract partialClass_Abstract = new TestAbstract2();
            partialClass_Abstract.FirstName = "Sidratul";
            partialClass_Abstract.LastName = "Muntaha";

            /* 
             * partialClass_Abstract.Address = "Khulna";
             * // Invaid
            */

            Console.WriteLine("From TestAbstract2_Method,  partialClass_Abstract which is PartialClass_Abstract type object of TestAbstract2 class " + partialClass_Abstract.GetFullName());
        }
 
    }
}
