using ArrayTask;

MyArray array = new();
array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);
array.Add(5);
array.Print();
//array.Clear();
var tmp = array.Pop();
array.Print();
Console.WriteLine(tmp);
Console.WriteLine(array.Length);
