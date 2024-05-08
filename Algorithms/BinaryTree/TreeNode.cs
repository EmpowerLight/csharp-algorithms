using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinaryTree
{
    public class TreeNode
    {
        public int value { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
