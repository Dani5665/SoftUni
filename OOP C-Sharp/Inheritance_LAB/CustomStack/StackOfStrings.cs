using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddRange(IEnumerable<string> stack)
        {
            foreach (var item in stack)
            {
                this.Push(item);
            }
        }
    }
}
