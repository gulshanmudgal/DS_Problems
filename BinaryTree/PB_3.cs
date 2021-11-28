using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class PB_3
    {
        /// <summary>
        /// 236. Lowest Common Ancestor of a Binary Tree https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
        /// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public Node LowestCommonAncestor(Node? root, Node p, Node q)
        {
            if (root == null || p == root || q == root)
            {
                return root;
            }

            Node left = LowestCommonAncestor(root.left, p, q);
            Node right = LowestCommonAncestor(root.right, p, q);

            if (left == null)
            {
                return right;
            }
            else if (right == null)
            {
                return left;
            }
            else
            {
                return root;
            }
        }
    }
}
