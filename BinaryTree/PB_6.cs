using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal static class PB_6
    {
        /// <summary>
        /// 863. All Nodes Distance K in Binary Tree : https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<int> DistanceK(Node root, Node target, int k)
        {
            if (root == null)
            {
                return null;
            }
                
            if (k == 0)
            {
                return new List<int>()
                {
                    target.value
                };
            }

            Dictionary<Node, Node?> parentTracker = new Dictionary<Node, Node?>();
            SetParents(root, parentTracker);
            List<int> nodesAtSaidDistance = new List<int>();

            Dictionary<Node, bool> visited = new Dictionary<Node, bool>();
            int distanceTravelled = 0;
            Queue<Node> neighborNodesQueue = new Queue<Node>();

            neighborNodesQueue.Enqueue(target);
            visited.Add(target, true);

            while(neighborNodesQueue.Count > 0)
            {
                int neighborsCount = neighborNodesQueue.Count;
                if(distanceTravelled == k)
                {
                    break;
                }
                distanceTravelled++;

                for (int i = 0; i < neighborsCount; i++)
                {
                    Node currentNode = neighborNodesQueue.Dequeue();

                    if(currentNode.left != null && !visited.ContainsKey(currentNode.left))
                    {
                        neighborNodesQueue.Enqueue(currentNode.left);
                        visited.Add(currentNode.left, true);
                    }

                    if (currentNode.right != null && !visited.ContainsKey(currentNode.right))
                    {
                        neighborNodesQueue.Enqueue(currentNode.right);
                        visited.Add(currentNode.right, true);
                    }

                    Node? parentOfCurrentNode = parentTracker[currentNode];
                    if (parentOfCurrentNode != null && !visited.ContainsKey(parentOfCurrentNode))
                    {
                        neighborNodesQueue.Enqueue(parentOfCurrentNode);
                        visited.Add(parentOfCurrentNode, true);
                    }
                }
            }

            while (neighborNodesQueue.Count > 0)
            {
                Node item = neighborNodesQueue.Dequeue();
                nodesAtSaidDistance.Add(item.value);
            }

            return nodesAtSaidDistance;
        }

        private static void SetParents(Node root, Dictionary<Node, Node?> parentTracker)
        {
            Queue<Node> levelNodesQueue = new Queue<Node>();
            levelNodesQueue.Enqueue(root);
            parentTracker.Add(root, null);

            while (levelNodesQueue.Count > 0)
            {
                int size = levelNodesQueue.Count;

                Node nodeToProcess = levelNodesQueue.Dequeue();

                if(nodeToProcess.left != null)
                {
                    levelNodesQueue.Enqueue(nodeToProcess.left);
                    parentTracker.Add(nodeToProcess.left, nodeToProcess);
                }

                if (nodeToProcess.right != null)
                {
                    levelNodesQueue.Enqueue(nodeToProcess.right);
                    parentTracker.Add(nodeToProcess.right, nodeToProcess);
                }
            }
        }
    }
}
