// Напишите программу, которая на вход принимает два
// числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 2

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    System.Console.WriteLine("Меньшее число: " + a +", большее число: " + b);
else System.Console.WriteLine($"Меньшее число: {a}, большее число: {b}");