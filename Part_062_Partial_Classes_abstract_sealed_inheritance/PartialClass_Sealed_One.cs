using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_062_Partial_Classes_abstract_sealed_inheritance
{
    internal sealed partial class PartialClass_Sealed
    {
        private string? _firstName;
        private string? _lastName;

        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
