// See https://aka.ms/new-console-template for more information
using BinaryTree.Models;

Console.WriteLine("Hello, BinaryTree!");

var tree = new Tree<int>();
tree.Add(5);
tree.Add(3);
tree.Add(7);
tree.Add(1);
tree.Add(2);
tree.Add(8);
tree.Add(6);
tree.Add(9);

foreach (var item in tree.PrefOrder())
{
    Console.WriteLine($"Tree item: {item}");
}
Console.WriteLine("------");
foreach (var item in tree.PostOrder())
{
    Console.WriteLine($"Tree item: {item}");
}
Console.WriteLine("------");
foreach (var item in tree.InOrder())
{
    Console.WriteLine($"Tree item: {item}");
}

