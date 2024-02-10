

LinkedList<int> numberList = new LinkedList<int>(10);

Node<int> node = new();
Node<int> node2 = new(4);


// node.Value = 10;


numberList.Push(11);
numberList.Push(12);

// Console.WriteLine(numberList.Length);
// Console.WriteLine(numberList.Tail);

// numberList.Push(90);

// Console.WriteLine(numberList.Tail);
// Console.WriteLine(numberList.Length);
// // Console.WriteLine(numberList.Pop());
// // Console.WriteLine(numberList.Pop());
// Console.WriteLine(numberList.Tail);
// Console.WriteLine(numberList.Length);


// numberList.UnShift(89);
// numberList.Shift();
// numberList.RemoveAt(1);
numberList.InsertAt(1, 98);

Console.WriteLine(numberList.GetAt(2));


