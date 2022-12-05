///Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 1

int A = Number("Введите число A: ");
int B = Number("Введите число B: "); ;
GetNumber(A, B);

int GetNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
    return result;
}
int Number(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}