using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Queue
{
    public class QueueNode
    {
        public int value { get; set; }
        public QueueNode next { get; set; }

        public QueueNode(int value)
        {
            this.value  = value;
            this.next = null;
        }
    }
}
