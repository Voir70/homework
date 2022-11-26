/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();

if (number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {number} является цифра {number / 100 % 10}");
else System.Console.WriteLine($"У числа {number} нет третьей цифры");

System.Console.WriteLine();
