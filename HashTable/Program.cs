// See https://aka.ms/new-console-template for more information
using HashTable.Models;

Console.WriteLine("Hello, HashTable!");

EasyHashTable<int> easyHashTable = new(100);
easyHashTable.Add(5);
easyHashTable.Add(18);
easyHashTable.Add(777);

Console.WriteLine(easyHashTable.Search(6));
Console.WriteLine(easyHashTable.Search(18));

BetterHashTable<int, string> betterHashTable = new(100);
betterHashTable.Add(5,"Hello");
betterHashTable.Add(18,"World");
betterHashTable.Add(777,"Bro");

Console.WriteLine(betterHashTable.Search(6, "Peter"));
Console.WriteLine(betterHashTable.Search(18, "World"));

HashTable<Person> hashTable = new(100);
var person = new Person() { Name = "Bob", Age = 41, Gender = 0 };
hashTable.Add(new Person() { Name = "Alex", Age = 20, Gender = 0 });
hashTable.Add(new Person() { Name = "Marina", Age = 15, Gender = 1 });
hashTable.Add(new Person() { Name = "Lera", Age = 34, Gender = 1 });
hashTable.Add(person);

Console.WriteLine(hashTable.Search(new Person() { Name = "Marina", Age = 15, Gender = 1 }));
Console.WriteLine(hashTable.Search(person));