// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int num1 = int.TryParse; // проверка на целочисленные значения

// string str = Console.ReadLine(); - строка 
// int n = Convert.ToInt32(str);

int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");

// bool res = num == 5 && num < 10; // true - false
// if (res)
// {

// }