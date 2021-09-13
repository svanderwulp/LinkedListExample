﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
