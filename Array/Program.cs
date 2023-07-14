using Collections;

MyArray<int> array = new();
array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);
array.Add(5);
foreach(var i in array)
{
    Console.WriteLine(i);
}
array[0] = 345;
Console.WriteLine(array[0]);
Console.WriteLine("-------------------");
MyStack<int> stack = new();
stack.Push(1);
stack.Push(2);
stack.Push(3);
var tmp = stack.Pop();
foreach(var i in stack)
{
    Console.WriteLine(i);
}
Console.WriteLine("------------------");
Console.WriteLine(tmp);
Console.WriteLine("----------------------");
Console.WriteLine(stack.Peek());
Console.WriteLine("-----------------------");
Console.WriteLine(stack.Contains(1));
Console.WriteLine(stack.Contains(8));
Console.WriteLine("-------------------");
stack.Clear();
Console.WriteLine(stack.Count);


