using System;
using System.Collections.Generic;
using DescendantsOf.Models;
using System.Text;

namespace DescendantsOf
{
    public class DescendantChecker
    {
        public int NumDescendantsOf(Person p)
        {
            int nameCounter = 0;
            var nameToCheck = "Steve";

        Stack<Person> descendants = new Stack<Person>();

        //add to stack 
        descendants.Push(p);

            //loop through stack
            while (descendants.Count !=0)
            {
                Person descendant = descendants.Pop();

                if (descendant != null)
                {

                    if (descendant.Children != null)
                    {
                        //Steve Check + increment counter on successful match
                        nameCounter += p.FirstName == nameToCheck ? 1 : 0;

                        //loop through and add children to the stack
                        for (var i = descendant.Children.Length - 1; i >= 0; i--)
                        {
                            descendants.Push(descendant.Children[i]);
                        }
                    }
                }
            }
            //subtract one for root node
            return nameCounter;
        }
    }
}
