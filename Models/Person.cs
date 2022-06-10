using System;
using System.Collections.Generic;
using System.Text;

namespace DescendantsOf.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public Person[] Children { get; set; }
    }
}
