// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//// 2, 4 -> 16

using static System.Console;
Clear();

Write("Введите число A: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(ReadLine());
int pow = GetPow(A, B);
WriteLine($"При возведении числа {A} в степень {B} получаем {pow}");

int GetPow(int number1, int number2)
{
        int result = number1;
    for (int i = 1; i < number2; i++)
    {
        result= result*number1;
    }
    return result;
}