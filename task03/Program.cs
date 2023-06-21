// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] array = new int[8];

NewArray(array);
PrintArray(array);

void NewArray(int[] arr)
{
    Random rmd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rmd.Next(100);
    }
}

void PrintArray(int[] arrs)
{
    for (int i = 0; i < arrs.Length; i++)
    {
        Console.Write($"{arrs[i]} ");
    }
}