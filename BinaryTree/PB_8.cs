using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal static class PB_8
    {
        /// <summary>
        /// 222. Count Complete Tree Nodes https://leetcode.com/problems/count-complete-tree-nodes/
        /// Given the root of a complete binary tree, return the number of the nodes in the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int CountNodes(Node? root)
        {
            if(root == null)
            {
                return 0;
            }

            int leftHeight = GetLeftHeight(root);
            int rightHeight = GetRightHeight(root);

            if(leftHeight == rightHeight)
            {
                return (int)Math.Pow(2, leftHeight) - 1;
            }

            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }

        private static int GetLeftHeight(Node root)
        {
            if(root == null)
            {
                return 0;
            }
            int height = 1;

            while(root.left != null)
            {
                height++;
                root = root.left;
            }

            return height;
        }

        private static int GetRightHeight(Node root)
        {
            if(root == null)
            {
                return 0;
            }

            int height = 1;

            while (root.right != null)
            {
                height++;
                root = root.right;
            }

            return height;
        }
    }
}
