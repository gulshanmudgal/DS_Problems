using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class PB_7
    {
        /// <summary>
        /// Burn a Tree https://www.interviewbit.com/problems/burn-a-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="fromNode"></param>
        /// <returns></returns>
        public int GetTimeTakenToBurnTree(Node root, Node fromNode)
        {
            if(root == null)
            {
                return 0;
            }

            int totalTimeTaken = 0;
            Dictionary<Node, Node?> nodeParentDictionary = new Dictionary<Node, Node?>();
            SetParents(root, nodeParentDictionary);

            Dictionary<Node, bool> visitedNodes = new Dictionary<Node, bool>();
            Queue<Node> neighborNodesQueue = new Queue<Node>();

            neighborNodesQueue.Enqueue(root);
            visitedNodes.Add(root, true);

            while(neighborNodesQueue.Count > 0)
            {
                int totalNeighbors = neighborNodesQueue.Count;

                for(int i = 0; i < totalNeighbors; i++)
                {
                    Node node = neighborNodesQueue.Dequeue();
                    bool burnt = false;

                    if(node.left != null && !visitedNodes.ContainsKey(node.left))
                    {
                        burnt = true;
                        visitedNodes.Add(node.left, true);
                        neighborNodesQueue.Enqueue(node.left);
                    }

                    if (node.right != null && !visitedNodes.ContainsKey(node.right))
                    {
                        burnt = true;
                        visitedNodes.Add(node.right, true);
                        neighborNodesQueue.Enqueue(node.right);
                    }

                    Node? parentNode = nodeParentDictionary[node];

                    if(parentNode != null && !visitedNodes.ContainsKey(parentNode))
                    {
                        burnt = true;
                        visitedNodes.Add(parentNode, true);
                        neighborNodesQueue.Enqueue(parentNode);
                    }

                    if(burnt)
                    {
                        totalTimeTaken++;
                    }
                }
            }

            return totalTimeTaken;
        }

        public void SetParents(Node root, Dictionary<Node, Node?> nodeParentDictionary)
        {
            if(root == null)
            {
                return;
            }

            Queue<Node> levelNodeQueue = new Queue<Node>();
            levelNodeQueue.Enqueue(root);
            nodeParentDictionary.Add(root, null);

            while(levelNodeQueue.Count > 0)
            {
                int nodeCount = levelNodeQueue.Count;

                for (int i = 0; i < levelNodeQueue.Count; i++)
                {
                    Node nodeToProcess = levelNodeQueue.Dequeue();

                    if(nodeToProcess.left != null)
                    {
                        levelNodeQueue.Enqueue(nodeToProcess.left);
                        nodeParentDictionary.Add(nodeToProcess.left, nodeToProcess);
                    }

                    if (nodeToProcess.right != null)
                    {
                        levelNodeQueue.Enqueue(nodeToProcess.right);
                        nodeParentDictionary.Add(nodeToProcess.right, nodeToProcess);
                    }
                }
            }
        }
    }
}
