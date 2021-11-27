using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class PB_1
    {
        /// <summary>
        /// 101. Symmetric Tree: https://leetcode.com/problems/symmetric-tree/
        /// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsSymmetric(Node root)
        {
            return root == null || IsChildSymmetric(root.left, root.right);
        }

        private static bool IsChildSymmetric(Node? left, Node? right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }

            if (left.value != right.value)
            {
                return false;
            }

            return IsChildSymmetric(left.left, right.right) && IsChildSymmetric(left.right, right.left);
        }
    }
}
