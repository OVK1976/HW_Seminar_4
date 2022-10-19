/* Задача 29: Напишите программу, которая задаёт 
 * массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Программа задает массив из 8 элементов");
Console.WriteLine("заполняет его случайными числами в заданном диапазоне");
Console.WriteLine();

Console.Write("Введите начальное число диапазона: ");
int StartNum = int.Parse(Console.ReadLine());

Console.Write("Введите конечное число диапазона: ");
int EndtNum = int.Parse(Console.ReadLine());

Massiv(StartNum,EndtNum);

#region Function Massiv
void Massiv(int min, int max)
{
    int[] N = new int[8];
    Console.Write("Массив [");
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(min, max);
        Console.Write($"{N[i]}  ");
    }
    Console.Write("]");
}
#endregion