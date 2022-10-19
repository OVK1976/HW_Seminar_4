/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример:
452-> 11
82-> 10
9012-> 12 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
SumNum(num);
#region Function
int SumNum(int Number)
{
    int sum = 0;
    
        while (Number > 0)
        {
            sum = sum + Number % 10;
            Number = Number / 10;
        }
        Console.WriteLine($"Сумма чисел равна {sum}");

    return sum;
}
#endregion