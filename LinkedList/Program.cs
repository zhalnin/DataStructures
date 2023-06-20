// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Linked list!");


var list = new LinkedList.Models.LinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

list.Delete(3);
list.AppendHead(13);


foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine();



list.InsertAfter(4, 8);
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

Console.ReadLine();