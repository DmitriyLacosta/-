// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет


//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Программа соответсивия квадрата чисел");
Console.WriteLine("Введите первое число: ");
int input A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int input B = int.Parse(Console.ReadLine()!);
if(inputA == inputB*inputB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


