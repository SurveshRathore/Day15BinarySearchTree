// See https://aka.ms/new-console-template for more information
using Day15BinarySearchTree;

Console.WriteLine("----------UC1 Binary search tree");

UC1BST<int> bst = new(56);
bst.Insert(30);
bst.Insert(70);
bst.Display();

Console.WriteLine("\n----------UC2 Binary search tree");
UC2BST<int> bst1 = new(56);
bst1.Insert(30);
bst1.Insert(70);
bst1.Insert(22);
bst1.Insert(40);
bst1.Insert(60);
bst1.Insert(95);
bst1.Insert(11);
bst1.Insert(65);
bst1.Insert(3);
bst1.Insert(16);
bst1.Insert(63);
bst1.Insert(67);

bst1.Display();

Console.WriteLine("\n----------UC3 Search 63 in the Binary search tree");
UC3Search<int> search = new(56);
search.Insert(30);
search.Insert(70);
search.Insert(22);
search.Insert(40);
search.Insert(60);
search.Insert(95);
search.Insert(11);
search.Insert(65);
search.Insert(3);
search.Insert(16);
search.Insert(63);
search.Insert(67);
search.Display();
search.IfExists(63, search);
