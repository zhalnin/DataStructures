// See https://aka.ms/new-console-template for more information
using Set.Models;

Console.WriteLine("Hello, Set!");

var easyset1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
var easyset2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
var easyset3 = new EasySet<int>(new int[] { 3,4,5 });

Console.Write("--- Union ---");
foreach (var i in easyset1.Union(easyset2))
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.Write("--- Intersection ---");
foreach (var i in easyset1.Intersection(easyset2))
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.Write("--- Difference A\\B ---");
foreach (var i in easyset1.Difference(easyset2))
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.Write("--- Difference B\\A ---");
foreach (var i in easyset2.Difference(easyset1))
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.Write("--- Subset A\\C ---");
Console.Write(easyset1.Subset(easyset3));
Console.WriteLine();

Console.Write("--- Subset C\\A ---");
Console.Write(easyset3.Subset(easyset1));
Console.WriteLine();

Console.Write("--- Subset B\\C ---");
Console.Write(easyset2.Subset(easyset3));
Console.WriteLine();

Console.Write("--- Subset C\\B ---");
Console.Write(easyset3.Subset(easyset2));
Console.WriteLine();

Console.Write("--- Symmetric Difference ---");
foreach (var i in easyset1.SymmetricDifference(easyset2))
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.ReadLine();