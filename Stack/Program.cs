// See https://aka.ms/new-console-template for more information
using Stack.Models;

Console.WriteLine("Hello, Stack!");

try
{
    var easyStack = new EasyStack<int>();
    easyStack.Push(1);
    easyStack.Push(2);
    easyStack.Push(3);

    var item = easyStack.Pop();
    var item2 = easyStack.Peek();

    Console.WriteLine(item);
    Console.WriteLine(item2);


    var linkedStack = new LinkedStack<int>();
    linkedStack.Push(10);
    linkedStack.Push(20);
    linkedStack.Push(30);
    linkedStack.Push(40);

    var item5 = linkedStack.Peek();
    Console.WriteLine(item5);

    var item3 = linkedStack.Pop();
    Console.WriteLine(item3);

    var item4 = linkedStack.Peek();
    Console.WriteLine(item4);


    var arrayStack = new ArrayStack<int>(5);
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Push(100);
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Push(200);
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Push(300);
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Push(400);
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Push(500);
    Console.WriteLine($"The current length: {arrayStack.Count}");
    //arrayStack.Push(600);

    Console.WriteLine($"ArrayStack count: {arrayStack.MaxCount}");

    var item7 = arrayStack.Peek();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    var item6 = arrayStack.Pop();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    var item8 = arrayStack.Peek();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Pop();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Pop();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Pop();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    arrayStack.Pop();
    Console.WriteLine($"The current length: {arrayStack.Count}");
    //arrayStack.Pop();

    Console.WriteLine(item7);
    Console.WriteLine(item6);
    Console.WriteLine(item8);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    Console.ReadLine();
}