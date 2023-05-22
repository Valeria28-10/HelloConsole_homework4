// Задача 27: Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sumch(int ch)
{
    int sum = 0;
    while (ch > 0)
    {
        int b = ch % 10;
        sum = sum + b;
        ch /= 10;
    }
    return sum;
}
Console.Write("Введите число для определения суммы цифр в числе: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"-> {Sumch(a)}");

