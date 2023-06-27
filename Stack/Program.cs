// See https://aka.ms/new-console-template for more information
using Stack.Models;

Console.WriteLine("Hello, Stack!");

var easyStack = new EasyStack<int>();
easyStack.Push(1);
easyStack.Push(2);
easyStack.Push(3);

var item =  easyStack.Pop();
var item2 = easyStack.Peek();

Console.WriteLine(item);
Console.WriteLine(item2);

Console.ReadLine();