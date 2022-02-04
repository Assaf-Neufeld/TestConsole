// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var list = new List<int>();
for (int i = 0; i < 100; i++)
{
    list.Add(i);
}

list = list.Where(i => i % 21 == 1).ToList();

foreach (var item in list)
{
    Console.WriteLine(item);
}

