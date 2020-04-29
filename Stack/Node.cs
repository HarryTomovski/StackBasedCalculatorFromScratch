using System;
using System.Collections.Generic;

namespace Stack
{
   public class Node
    {
        public double Data { get; set; }
        public Node Next { get; set; }

      
        public Node(double d)
        {
            Data = d;
            Next = null;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}