using ArrayC;

var array = new ArrayC<int>();

array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);
array.Add(5);
array.Add(6);
array.Add(7);
array.Add(8);
array.Add(9);

Console.WriteLine("Инициализация массива :");
array.Print();

array.Delete(2);

Console.WriteLine("Массив после удаления индекса 2:");
array.Print();

int first = array.FindFirst(x => x % 2 == 0);
Console.WriteLine($"Первое чётное число: {first}");

array.Swap(0, 3);

Console.WriteLine("Массив после замены индексов 0 и 3:");
array.Print();

Console.ReadKey();