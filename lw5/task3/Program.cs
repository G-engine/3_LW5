using task3;

MyDictionary<int, string> dict = new MyDictionary<int, string>(1, "text1");

dict.Add(2, "text2");
foreach (var k in dict)
    Console.WriteLine(k);