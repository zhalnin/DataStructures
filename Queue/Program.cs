// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
