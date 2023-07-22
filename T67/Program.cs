// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число A в целую степень B с помощью рекурсии.

// ==========================
int SumDigits(int num)
{
    if (num < 10) return num;
    else return num % 10 + SumDigits(num / 10);   
}

// ==========================
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDig = SumDigits(number);
Console.WriteLine();
Console.Write($"Сумма цифр числа {number} равна {sumDig}");
