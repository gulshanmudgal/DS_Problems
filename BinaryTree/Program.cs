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