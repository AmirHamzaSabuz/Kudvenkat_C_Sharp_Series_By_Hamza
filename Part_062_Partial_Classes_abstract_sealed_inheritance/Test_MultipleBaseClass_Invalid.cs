using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_062_Partial_Classes_abstract_sealed_inheritance
{
    /*
     * // Can not have multiple base classes
     * internal class Test_MultipleBaseClass_Invalid : BaseClassOne_PartialClass, BaseClassTwo_PartialClass
     * // Compile Time Error
    */

    //internal class Test_MultipleBaseClass_Invalid : BaseClassTwo_PartialClass
    // Valid

    internal class Test_MultipleBaseClass_Invalid : BaseClassOne_PartialClass
    {
    }
}
