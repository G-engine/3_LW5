using task2;

MyList<int> list = new MyList<int>(14, 0, 55);

list.Add(50);
list.AddRange(0, 0, 4);

foreach (var i in list)
    Console.Write($"{i} ");

Console.WriteLine();
for(int i = 0; i < list.Length; ++i)
    Console.Write($"{list[i]} ");   