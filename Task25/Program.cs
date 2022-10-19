/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 * и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Возведение числа А в степень В");
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int b = int.Parse(Console.ReadLine());
while (b<1)
    {
        Console.WriteLine("Число B не натуральное. Введите число снова: ");
        b = int.Parse(Console.ReadLine());
    }
        Console.WriteLine($"Значение равно {DegreeNumber(a, b)}");

#region DegreeNumberFunction
int DegreeNumber(int Num,int Deg)
{
    int DNum = Num;

     for (int i = 1; i < Deg; i++)
    {
        DNum = DNum * Num;
    }
        return DNum;
}
#endregion