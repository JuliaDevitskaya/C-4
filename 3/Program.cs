// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;
Clear();

int[] Array=new int [8];
FillArr(Array);
WriteLine($"[{String.Join(",",Array)}]");

void FillArr (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=new Random().Next(0,20);
    }
}
