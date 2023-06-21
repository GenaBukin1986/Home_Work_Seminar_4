// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Erection(number1, number2);

Console.WriteLine($"Число {number1} в степени {number2} равно {result}");

int Erection(int num1, int num2)
{
    int total = 1;
    for (int i = 0; i < num2; i++)
    {
        total *= num1;
    }
    return total;
}