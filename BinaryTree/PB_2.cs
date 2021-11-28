using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class PB_2
    {
        private static bool GetPath(Node? root, Stack<int> path, int searchVal)
        {
            if (root == null)
                return false;

            path.Push(root.value);

            if(root.value == searchVal)
            {
                return true;
            }

            if(GetPath(root.left, path, searchVal) || GetPath(root.right, path, searchVal))
            {
                return true;
            }

            path.Pop();
            return false;
        }

        public List<int> findNodePath(Node? root, int searchVal)
        {
            Stack<int> path = new Stack<int>();

            if(root == null)
            {
                return path.ToList();
            }

            GetPath(root, path, searchVal);

            var finalPath = path.ToList();
            finalPath.Reverse();
            return path.ToList();
        }
    }
}
