// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

PrintArray(Matrix());
Console.WriteLine(Matrix());

int[] Matrix()
{
   int[] matri = new int[8];
   for (int i = 1; i <= 7; i++)
   {
    matri[i] = new Random().Next(0, 101);
   } 
   return matri;
}
void PrintArray(int[] matri)
{
    Console.WriteLine($"Массив: {String.Join(',',matri)} -> [{String.Join(',',matri)}]");
}
