using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal static class PB_11
    {
        /// <summary>
        /// 297. Serialize and Deserialize Binary Tree : https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
        /// Encodes a tree to a single string.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string Serialize(Node root)
        {
            if(root == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            Queue<Node?> levelNodesQueue = new Queue<Node?> ();

            levelNodesQueue.Enqueue(root);

            while(levelNodesQueue.Count > 0)
            {
                var node = levelNodesQueue.Dequeue();

                if(node == null)
                {
                    sb.Append("#");
                    continue;
                }

                sb.Append(node.value + " ");
                levelNodesQueue.Enqueue(node.left);
                levelNodesQueue.Enqueue(node.right);
            }

            return sb.ToString();
        }

        /// <summary>
        /// 297. Serialize and Deserialize Binary Tree : https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
        /// Decodes your encoded data to tree.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Node Deserialize(string data)
        {
            if(data == "")
            {
                return null;
            }

            string[] values = data.Split(" ");
            Queue<Node> nodeQueue = new Queue<Node>();
            int rootValue;
            Int32.TryParse(values[0], out rootValue);
            Node root = new Node(rootValue);
            nodeQueue.Enqueue(root);

            for (int i = 1; i < values.Length; i++)
            {
                var parent = nodeQueue.Dequeue();

                if(!values[i].Equals("#"))
                {
                    int leftVal;
                    Int32.TryParse(values[i], out leftVal);
                    parent.left = new Node(leftVal);

                    nodeQueue.Enqueue(parent.left);
                }

                i++;
                if (!values[i].Equals("#"))
                {
                    int rightVal;
                    Int32.TryParse(values[i], out rightVal);
                    parent.right = new Node(rightVal);

                    nodeQueue.Enqueue(parent.right);
                }

            }

            return root;
        }
    }
}
