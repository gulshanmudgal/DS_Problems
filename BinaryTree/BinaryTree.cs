using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        internal int value;
        internal Node? left;
        internal Node? right;

        public Node(int nodeValue)
        {
            value = nodeValue;
            left = null;
            right = null;
        }
    }

    public class BinaryTree
    {
        public Node CreateBinaryTree()
        {
            Node rootNode = new Node(0);

            Node leftSubTreeRoot = new Node(10);
            leftSubTreeRoot.left = new Node(20);
            leftSubTreeRoot.right = new Node(22);

            Node rightSubTreeRoot = new Node(11);
            rightSubTreeRoot.left = new Node(21);
            rightSubTreeRoot.right = new Node(23);

            rootNode.left = leftSubTreeRoot;
            rootNode.right = rightSubTreeRoot;

            return rootNode;
        }
    }
}
