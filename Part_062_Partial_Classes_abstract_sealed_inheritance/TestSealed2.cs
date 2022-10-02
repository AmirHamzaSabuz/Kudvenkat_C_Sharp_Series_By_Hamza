using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_062_Partial_Classes_abstract_sealed_inheritance
{
    internal class TestSealed2 
    {
        

        public void TestSealed2_Method() 
        {
            PartialClass_Sealed partialClass_Sealed = new PartialClass_Sealed();
            partialClass_Sealed.FirstName = "Amir";
            partialClass_Sealed.LastName = "Hamza";

            string FullName2 = partialClass_Sealed.GetFullName();
            Console.WriteLine("From TestSealed2_Method  output " + FullName2);
        }


    }
}
