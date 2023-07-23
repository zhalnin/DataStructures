// See https://aka.ms/new-console-template for more information
using Map.Models;

Console.WriteLine("Hello, Map!");

var easyMap = new EasyMap<int, string>
{
    new Item<int, string>(1, "One"),
    new Item<int, string>(2, "Two"),
    new Item<int, string>(3, "Three"),
    new Item<int, string>(4, "Four"),
    new Item<int, string>(5, "Five")
};
Console.WriteLine("-------");
foreach (var item in easyMap)
{
    Console.WriteLine(item);
}

Console.WriteLine(easyMap.Search(7) ?? "Not found");
Console.WriteLine(easyMap.Search(3) ?? "Not found");

easyMap.Remove(3);
easyMap.Remove(1);
Console.WriteLine("-------");
foreach (var item in easyMap)
{
    Console.WriteLine(item);
}

 
var dict = new Dict<int, string>
{
    new Item<int, string>(1, "One#1"),
    new Item<int, string>(1, "One#2"),
    new Item<int, string>(2, "Two"),
    new Item<int, string>(3, "Three"),
    new Item<int, string>(4, "Four"),
    new Item<int, string>(5, "Five"),
    new Item<int, string>(101, "Hundred")
};
Console.WriteLine("-------");
foreach (var item in dict)
{
    Console.WriteLine(item);
}

Console.WriteLine(dict.Search(7) ?? "Not found");
Console.WriteLine(dict.Search(3) ?? "Not found");
Console.WriteLine(dict.Search(101) ?? "Not found");

dict.Remove(3);
dict.Remove(1);
dict.Remove(101);

Console.WriteLine("-------");
foreach (var item in dict)
{
    Console.WriteLine(item);
}