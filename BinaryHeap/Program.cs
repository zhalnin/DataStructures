// See https://aka.ms/new-console-template for more information
using BinaryHeap.Models;
using System.Diagnostics;
using System.Globalization;

Console.WriteLine("Hello, binary heap!");

#region Static test
//Heap<int> heap = new();
//heap.Add(20);
//heap.Add(11);
//heap.Add(17);
//heap.Add(7);
//heap.Add(4);
//heap.Add(13);
//heap.Add(15);
//heap.Add(14);
#endregion

var timer = new Stopwatch();
var startItems = new List<int>();
var rnd = new Random();
for (int i = 0; i < 10; i++)
{
    startItems.Add(rnd.Next(-1000,1000));
}
timer.Start();
Heap<int> heap = new(startItems);
timer.Stop();
Console.WriteLine($"The first initialization of 1000 elements {timer.Elapsed}");

timer.Restart();
//for (int i = 0; i < 10; i++)
//{
//    heap.Add(rnd.Next(-1000, 1000));
//}
//timer.Stop();
//Console.WriteLine($"The second adding of 1000 elements {timer.Elapsed}");

timer.Restart();
foreach (var item in heap)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Total of 2000 elements {timer.Elapsed}");
