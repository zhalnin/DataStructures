// See https://aka.ms/new-console-template for more information
using Queue.Models;

Console.WriteLine("Hello, World!");

//var queue = new Queue<int>();
//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);
//queue.Enqueue(5);

//Console.WriteLine(queue.Dequeue());
//Console.WriteLine(queue.Peek());
//Console.WriteLine(queue.Dequeue());

var arrayQueue = new ArrayQueue<int>(5);
arrayQueue.Enqueue(1);
arrayQueue.Enqueue(2);
arrayQueue.Enqueue(3);
arrayQueue.Enqueue(4);
arrayQueue.Enqueue(5);

Console.WriteLine(arrayQueue.Dequeue());
Console.WriteLine(arrayQueue.Peek());
Console.WriteLine(arrayQueue.Dequeue());
