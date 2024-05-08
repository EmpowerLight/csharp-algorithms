using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BinaryTree
{
    public class BinaryTreeOperation
    {
        TreeNode root;

        public BinaryTreeOperation()
        {
            this.root = null;
        }

        public void insert(int value)
        {
            TreeNode newNode = new TreeNode(value);

            if (root == null) {
                root = newNode;
                return;
            }
        }
    }
}
