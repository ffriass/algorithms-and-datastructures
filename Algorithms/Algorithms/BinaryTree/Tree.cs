using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTree
{
    public class Tree
    {
        TreeNode root;
        int nodesCount;
        private List<int> nodesInOrder;
        public Tree()
        {
            root = null;
            nodesCount = 0;                      
        }

        public int NodesCount => nodesCount;
        public bool IsEmpty => root == null;

        public TreeNode Root => root;

        public List<int> NodesInOrder
        {
            get
            {
                nodesInOrder = new List<int>();
                GetValuesInOrder(root);
                return nodesInOrder;
            }
        }

        private void GetValuesInOrder(TreeNode node = null)
        {
            if (node != null)
            {                
                GetValuesInOrder(node.LeftChild);
                nodesInOrder.Add(node.Value);
                GetValuesInOrder(node.RightChild);
            }
        }
        
        public TreeNode InvertTree(TreeNode root)
        {
            if(root != null)
            {
                TreeNode right = root.RightChild;
                TreeNode left = root.LeftChild;
                root.RightChild = left;
                root.LeftChild = right;
                InvertTree(root.RightChild);
                InvertTree(root.LeftChild);
                return root;
            }
            return null;
        }


        public void Add(int value, string nodeName = "")
        {
            TreeNode newNode = new TreeNode(value, nodeName);

            if (root == null)
            {
                root = newNode;
                nodesCount++;
            }
            else
            {
                TreeNode auxNode = root;
                TreeNode parentNode;
                while (true)
                {
                    parentNode = auxNode;
                    if (value < parentNode.Value)
                    {
                        auxNode = auxNode.LeftChild;
                        if (auxNode == null)
                        {
                            parentNode.LeftChild = newNode;
                            nodesCount++;
                            return;
                        }
                    }
                    else
                    {
                        auxNode = auxNode.RightChild;
                        if (auxNode == null)
                        {
                            parentNode.RightChild = newNode;
                            nodesCount++;
                            return;
                        }
                    }
                }

            }

        }



    }
}
