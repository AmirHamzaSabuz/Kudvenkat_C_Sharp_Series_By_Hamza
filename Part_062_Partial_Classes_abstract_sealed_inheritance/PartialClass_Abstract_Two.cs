using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_062_Partial_Classes_abstract_sealed_inheritance
{
    internal partial class PartialClass_Abstract
    {
        public string GetFullName()
        {
            return _firstName + ", " + _lastName;
        }
    }
}
