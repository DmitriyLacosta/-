// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Программа вычисления квадрата числа");
Console.WriteLine("Введите число");
//1. Ввод числа
int input = int.Parse(Console.ReadLine()!);

//2. Вычисление квадрата числа
int result = input * input;
//3. Вывод результата на консоль
Console.WriteLine("Квадрат числа: " + result);
