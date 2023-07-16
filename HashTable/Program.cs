// See https://aka.ms/new-console-template for more information
using HashTable.Models;

Console.WriteLine("Hello, HashTable!");

EasyHashTable<int> easyHashTable = new(100);
easyHashTable.Add(5);
easyHashTable.Add(18);
easyHashTable.Add(777);

Console.WriteLine(easyHashTable.Search(6));
Console.WriteLine(easyHashTable.Search(18));