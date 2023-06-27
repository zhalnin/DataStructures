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
    //linkedStack.Push(1);
    //linkedStack.Push(2);
    //linkedStack.Push(3);
    //linkedStack.Push(4);

    //var item5 = linkedStack.Peek();
    //Console.WriteLine(item5);

    var item3 = linkedStack.Pop();
    Console.WriteLine(item3);

    //var item4 = linkedStack.Peek();
    //Console.WriteLine(item4);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.ReadLine();