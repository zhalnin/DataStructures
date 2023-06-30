// See https://aka.ms/new-console-template for more information
using RoundLinkedList.Models;

Console.WriteLine("Hello, World!");

var duplexList = new DuplexLinkedList<int>();
duplexList.Add(1);
duplexList.Add(2);
duplexList.Add(3);
duplexList.Add(4);
duplexList.Add(5);

foreach(var duplex in duplexList)
{
    Console.WriteLine(duplex);
}
Console.WriteLine("----------------");
duplexList.Delete(2);

foreach (var duplex in duplexList)
{
    Console.WriteLine(duplex);
}
Console.WriteLine("----------------");
var reverse = duplexList.Reverse();

foreach (var duplex in reverse)
{
    Console.WriteLine(duplex);
}
Console.WriteLine("----------------");