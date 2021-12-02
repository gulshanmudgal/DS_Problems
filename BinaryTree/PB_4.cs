using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class PB_4
    {
        /// <summary>
        /// 662. Maximum Width of Binary Tree https://leetcode.com/problems/maximum-width-of-binary-tree/
        /// Given the root of a binary tree, return the maximum width of the given tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int WidthOfBinaryTree(Node root)
        {
            if(root == null)
            {
                return 0;
            }

            int treeWidth = 0;

            Queue<(Node node, int index)> nodeQueue = new Queue<(Node node, int index)>();

            nodeQueue.Enqueue((root, 0));

            while(nodeQueue.Count > 0)
            {
                int levelSize = nodeQueue.Count;
                int minIndex = nodeQueue.Peek().index;
                int first = 0;
                int last = 0;

                for(int i = 0; i < levelSize; i++)
                {
                    int curr_id = nodeQueue.Peek().index - minIndex;
                    Node nodeToProcess = nodeQueue.Dequeue().node;
                    
                    if(i == 0)
                    {
                        first = curr_id;
                    }

                    if(i == levelSize - 1)
                    {
                        last = curr_id;
                    }


                    if(nodeToProcess.left != null)
                    {
                        nodeQueue.Enqueue((nodeToProcess.left, (curr_id * 2) + 1));
                    }

                    if (nodeToProcess.right != null)
                    {
                        nodeQueue.Enqueue((nodeToProcess.right, (curr_id * 2) + 2));
                    }
                }

                treeWidth = Math.Max(treeWidth, (last - first + 1));
            }

            return treeWidth;
        }
    }
}
