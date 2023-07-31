// See https://aka.ms/new-console-template for more information
using Trie.Models;

Console.WriteLine("Hello, Trie!");

var trie = new Trie<int>();
trie.Add("privet", 50);
trie.Add("mir", 100);
trie.Add("priz", 200);
trie.Add("mirnyi", 50);
trie.Add("podarok", 100);
trie.Add("project", 200);
trie.Add("praporschik", 100);
trie.Add("pravyi", 200);
trie.Add("god", 50);
trie.Add("geroy", 100);
trie.Add("krasota", 300);
trie.Add("golub", 200);
trie.Add("prokrastinacyia", 1000);


trie.Remove("pravyi");
trie.Remove("mir");

Search(trie, "privet");
Search(trie, "mir");
Search(trie, "oblako");
Search(trie, "mirnyi");
Search(trie, "prokrastinacyia");
Search(trie, "god");



void Search(Trie<int> trie, string word)
{
    if (trie.TrySearch(word, out int value))
    {
        Console.WriteLine($"TrySearch: word: {word} with value: {value}");
    }
    else
    {
        Console.WriteLine($"Not found: {word}");
    }
}


var s = string.Empty;