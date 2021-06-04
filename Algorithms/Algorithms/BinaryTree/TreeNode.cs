using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class TreeNode
    {
        int value;
        string name;
        TreeNode rightChild, leftChild;

        public TreeNode(int value, string name = "")
        {
            this.value = value;
            this.name = name;
            rightChild = null;
            leftChild = null;
        }

        public TreeNode RightChild { get => rightChild; set => rightChild = value; }
        public TreeNode LeftChild { get => leftChild; set => leftChild = value; }
        public int Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
