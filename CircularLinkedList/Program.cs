// See https://aka.ms/new-console-template for more information
using CircularLinkedList.Models;

Console.WriteLine("Hello, World!");

var circularList = new CircularLinkedList<int>
{
    1,
    2,
    3,
    4,
    5
};

foreach (var circular in circularList)
{
    Console.WriteLine(circular);
}
Console.WriteLine("-------------");

circularList.Delete(3);
foreach (var circular in circularList)
{
    Console.WriteLine(circular);
}