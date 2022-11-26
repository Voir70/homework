/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

//можно так:
Console.WriteLine("Введите  трехзначное число: ");
int number = Int32.Parse(Console.ReadLine());
if (number > 1000 && number < 100)
{
    Console.WriteLine("wrong number");

}    
int number2 = number / 10 % 10;  
Console.WriteLine(number2);

//или так:
Console.Clear();
System.Console.WriteLine();
int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

System.Console.WriteLine();

// но мне кажется лучше вот так:
Console.WriteLine("Введите  трехзначное число: ");
int number = Int32.Parse(Console.ReadLine());

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

System.Console.WriteLine();