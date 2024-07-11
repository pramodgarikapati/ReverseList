// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
reverseList(list);

static void reverseList(List<int> list)
{
    for (int i = list.Count-1; i >= 0; i--)
        Console.WriteLine(list[i]);
    Console.ReadLine();
}

