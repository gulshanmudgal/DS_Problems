using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal static class PB_9
    {
        /// <summary>
        /// 105. Construct Binary Tree from Preorder and Inorder Traversal : https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
        /// Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree,
        /// construct and return the binary tree.
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        public static Node BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> inorderDictionary = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; i++)
            {
                inorderDictionary.Add(inorder[i], i);
            }

            Node root = CreateTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1, inorderDictionary);

            return root;
        }

        private static Node CreateTree(int[] preOrder, int preStart, int preEnd, int[] inOrder, int inStart, int inEnd, Dictionary<int, int> inOrderDictionary)
        {
            if (preStart > preEnd || inStart > inEnd)
            {
                return null;
            }

            Node root = new Node(preOrder[preStart]);

            int inRootIndex = inOrderDictionary[root.value];
            int nodesOnLeft = inRootIndex - inStart;

            root.left = CreateTree(preOrder, (preStart + 1), (preStart + nodesOnLeft), inOrder, (inRootIndex - nodesOnLeft), (inRootIndex - 1), inOrderDictionary);
            root.right = CreateTree(preOrder, preStart + nodesOnLeft + 1, preEnd, inOrder, inRootIndex + 1, inEnd, inOrderDictionary);

            return root;
        }
    }
}
