// See https://aka.ms/new-console-template for more information
using BinaryTree;

Console.WriteLine("Hello, World!");

var treeRoot = new BinaryTree.Node(3);
treeRoot.left = new BinaryTree.Node(5);
treeRoot.left.left = new BinaryTree.Node(6);
treeRoot.left.right = new BinaryTree.Node(2);
treeRoot.left.right.left = new BinaryTree.Node(7);
treeRoot.left.right.right = new BinaryTree.Node(4);

treeRoot.right = new BinaryTree.Node(1);
treeRoot.right.left = new BinaryTree.Node(0);
treeRoot.right.right = new BinaryTree.Node(8);

PB_6.DistanceK(treeRoot, treeRoot.left, 2);

var treeRoot2 = new BinaryTree.Node(1);
treeRoot2.left = new BinaryTree.Node(2);
treeRoot2.left.left = new BinaryTree.Node(4);
treeRoot2.left.right = new BinaryTree.Node(5);

treeRoot2.right = new BinaryTree.Node(3);
treeRoot2.right.left = new BinaryTree.Node(6);
int count = PB_8.CountNodes(treeRoot2);
Console.WriteLine(count);

var root = PB_9.BuildTree(new int[] {3, 9, 20, 15, 7}, new int[] { 9, 3, 15, 20, 7 });

var root2 = PB_11.Deserialize("1 2 3 # # 4 5");