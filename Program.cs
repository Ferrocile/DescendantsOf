using System;
using System.Collections.Generic;
using DescendantsOf;
using DescendantsOf.Models;

namespace DescendantsOf
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var descendantChecker = new DescendantChecker();

            Person p = new Person();

            var numDescendants = descendantChecker.NumDescendantsOf(p);

            Console.WriteLine($"Number of descendants with the same name: {numDescendants}");
        }
    }
}
