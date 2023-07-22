// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число A в целую степень B с помощью рекурсии.

// ==========================
int PowDigits(int numA, int numB)
{
    if (numB == 1) return numA;
    else return numA * PowDigits(numA, numB - 1);   
}

// ==========================
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int sumDig = PowDigits(A, B);
Console.WriteLine();
Console.Write($"{A} в степени {B} равен {sumDig}");
